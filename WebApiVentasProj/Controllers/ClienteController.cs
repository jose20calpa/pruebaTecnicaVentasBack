using Core.Contratos;
using Core.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiVentasProj.Models;

namespace WebApiVentasProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServicio _clienteServicio;

        public ClienteController(IClienteServicio clienteServicio)
        {
            _clienteServicio = clienteServicio;
        }


        [HttpPost]
        public IActionResult CrearCliente([FromBody] Cliente  cliente)
        {
            try
            {
                var clienteE = new ClienteE();
                clienteE.Nombre = cliente.Nombre;
                clienteE.Cedula = cliente.Cedula;  
                clienteE.Apellido = cliente.Apellido;

                Respuesta respuesta = _clienteServicio.CrearCliente(clienteE);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult ConsultarClientes()
        {
            try
            {
                Respuesta respuesta = _clienteServicio.ObtenerClientes();
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
