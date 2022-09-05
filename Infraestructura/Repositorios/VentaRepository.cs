using Core.Contratos;
using Core.Entidades;
using Infraestructura.ContextoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositorios
{
    public class VentaRepository : IVentaRepository
    {
        public int RegistrarVentaProductos(VentaE venta, int idVenta)
        {
            try
            {
                using (DbVentaContext context = new DbVentaContext())
                {
                    foreach (var prouctoV in venta.Productos)
                    {
                        var clienteProducto = new ClienteProducto();
                        clienteProducto.IdVenta = idVenta;
                        clienteProducto.IdCliente = venta.IdCliente;
                        clienteProducto.Cantidad = prouctoV.Cantidad;
                        clienteProducto.IdProducto = prouctoV.IdProducto;
                        context.ClienteProductos.Add(clienteProducto);
                    }
                    context.SaveChanges();
                    return 1;

                }
            }
            catch
            {
                return 0;
            }

        }

        public int RegistrarTotalVenta(decimal totalVenta)
        {
            try
            {
                using (DbVentaContext context = new DbVentaContext())
                {
                    context.Venta.Add(new Venta
                    {
                        Total = totalVenta,
                    });
                    context.SaveChanges();
                    var idVenta = context.Venta.OrderBy(x => x.IdVenta).LastOrDefault().IdVenta;
                    return idVenta;
                }
            }
            catch
            {
                return 0;
            }
        }

        
    }
}
