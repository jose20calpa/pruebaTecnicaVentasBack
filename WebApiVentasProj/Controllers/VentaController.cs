using Core.Contratos;
using Core.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiVentasProj.Models;

namespace WebApiVentasProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly IVentaServicio _ventaServicio;

        public VentaController(IVentaServicio ventaServicio)
        {
            _ventaServicio = ventaServicio;
        }


        [HttpPost]
        public IActionResult CrearVenta([FromBody] Venta venta)
        {
            try
            {
                var ventaE = new VentaE();
                ventaE.IdCliente= venta.IdCliente;
                ventaE.Totalventa= venta.Totalventa;
                ventaE.Productos = venta.Productos;
                

                Respuesta respuesta = _ventaServicio.RegistrarVenta(ventaE);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
