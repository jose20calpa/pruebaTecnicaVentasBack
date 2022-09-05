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
    public class ClienteRepository : IClienteRepository
    {
        public int CrearCliente(ClienteE clienteE)
        {
            try
            {
                using (DbVentaContext context = new DbVentaContext())
                {
                    var cliente = new Cliente();
                    cliente.Cedula = clienteE.Cedula;
                    cliente.Nombre = clienteE.Nombre;
                    cliente.Apellido = clienteE.Apellido;
                    context.Clientes.Add(cliente);
                    context.SaveChanges();
                    return 1;

                }
            }
            catch
            {
                return 0;
            }
        }

        public List<ClienteE> ObtenerClientes()
        {
            List<ClienteE> clientes = new List<ClienteE>();
            try
            {
                using (DbVentaContext context = new DbVentaContext())
                {
                    var listaCLientes = context.Clientes.ToList();
                    foreach (var cliente in listaCLientes)
                    {
                        clientes.Add(new ClienteE
                        {
                            Apellido = cliente.Apellido,
                            Cedula = cliente.Cedula,
                            Nombre = cliente.Nombre,
                            Id = cliente.IdCliente
                        });
                    }
                    return clientes;
                }
            }
            catch
            {
                return clientes;
            }
        }

        public ClienteE ConsultarCliente(string cedula)
        {
            try
            {
                using (DbVentaContext context = new DbVentaContext())
                {
                    var cliente = context.Clientes.Where(x => x.Cedula == cedula).FirstOrDefault();

                    return new ClienteE
                    {
                        Id = cliente.IdCliente,
                        Nombre = cliente.Nombre,
                        Apellido = cliente.Apellido,
                        Cedula = cliente.Cedula
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
