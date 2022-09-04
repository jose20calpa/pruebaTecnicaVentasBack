using Core.Contratos;
using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Servicios
{
    public class VentaServicio : IVentaServicio
    {
        private readonly IVentaRepository _repositoryVenta;
        public VentaServicio(IVentaRepository repository)
        {
            _repositoryVenta = repository;
        }
        public Respuesta RegistrarVenta(VentaE ven)
        {
            var idVenta = _repositoryVenta.RegistrarTotalVenta(ven.Totalventa);
            if (idVenta > 0)
            {
                var creado = _repositoryVenta.RegistrarVentaProductos(ven, idVenta);
                if (creado == 1)
                {
                    return new Respuesta
                    {
                        Mensaje = "Venta Registra Satisfactoriamente",
                        Objeto = creado,
                        ok = true
                    };
                }
            }

            return new Respuesta
            {
                Mensaje = "Error al registrar la venta",
                Objeto = 0,
                ok = false
            };
        }
    }
}
