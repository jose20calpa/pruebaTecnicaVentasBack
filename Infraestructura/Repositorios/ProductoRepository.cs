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
    public class ProductoRepository : IProductoRepository
    {

        public int CrearProducto(ProductoE productoE)
        {
            try
            {
                using (DbVentaContext context = new DbVentaContext())
                {
                    var producto = new Producto();
                    producto.DescProducto = productoE.Nombre;
                    producto.ValorUnitario = productoE.Valor;
                    context.Productos.Add(producto);
                    context.SaveChanges();
                    return 1;

                }
            }
            catch
            {
                return 0;
            }
        }

        public List<ProductoE> ObtenerProductos()
        {
            List<ProductoE> productos = new List<ProductoE>();
            try
            {
                using (DbVentaContext context = new DbVentaContext())
                {
                    var listaProductos = context.Productos.ToList();
                    foreach (var producto in listaProductos)
                    {
                        productos.Add(new ProductoE
                        {
                            Id = producto.IdProducto,
                            Nombre = producto.DescProducto,
                            Valor = producto.ValorUnitario
                        });
                    }
                    return productos;
                }
            }
            catch
            {
                return productos;
            }
        }
        public ProductoE ConsultarProducto(int idProd)
        {
            try
            {
                using (DbVentaContext context = new DbVentaContext())
                {
                    var producto = context.Productos.Where(x =>x.IdProducto == idProd).FirstOrDefault();
                    
                    return new ProductoE
                    {
                        Id = producto.IdProducto,
                        Nombre = producto.DescProducto,
                        Valor = producto.ValorUnitario
                    };
                }
            }
            catch
            {
                return null;
            }

        } 
    }
}
