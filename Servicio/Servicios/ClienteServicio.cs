using Core.Contratos;
using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Servicios
{
    public class ClienteServicio : IClienteServicio
    {
        private readonly IClienteRepository _repository;
        public ClienteServicio(IClienteRepository repository)
        {
            _repository = repository;
        }
        public Respuesta CrearCliente(ClienteE cliente)
        {
            var creado = _repository.CrearCliente(cliente);
            if (creado == 1)
            {
                return new Respuesta
                {
                    Mensaje = "Creado Exitosamente",
                    Objeto = creado,
                    ok = true
                };
            }
            return new Respuesta
            {
                Mensaje = "Error al crear el Cliente",
                Objeto = 0,
                ok = false
            };
        }
        public Respuesta ObtenerClientes()
        {
            var clientes = _repository.ObtenerClientes();
            if (clientes.Count > 0)
            {
                return new Respuesta
                {
                    Mensaje = "Ok",
                    Objeto = clientes,
                    ok = true
                };
            }
            return new Respuesta
            {
                Mensaje = "No se han encontrado clientes",
                Objeto = null,
                ok = false
            };
        }

        public Respuesta ConsultarCliente(string cedula)
        {
            var cliente = _repository.ConsultarCliente(cedula);
            if (cliente is null)
            {
                
                return new Respuesta
                {
                    Mensaje = "No se han encontrado clientes",
                    Objeto = null,
                    ok = false
                };
            }
            return new Respuesta
            {
                Mensaje = "Ok",
                Objeto = cliente,
                ok = true
            };
        }
    }
}
