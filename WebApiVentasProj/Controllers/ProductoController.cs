using Core.Contratos;
using Core.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiVentasProj.Models;

namespace WebApiVentasProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoServicio _productoService;

        public ProductoController(IProductoServicio productoServicio)
        {
            _productoService = productoServicio;
        }


        [HttpPost]
        public IActionResult CrearCliente([FromBody] Producto producto)
        {
            try
            {
                var productoE = new ProductoE();
                productoE.Nombre = producto.Nombre;
                productoE.Valor = producto.Valor;

                Respuesta respuesta = _productoService.CrearProducto(productoE);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult ConsultarProductos()
        {
            try
            {
                Respuesta respuesta = _productoService.ObtenerProductos();
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
