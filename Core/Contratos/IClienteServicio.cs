using Core.Entidades;

namespace Core.Contratos
{
    public interface IClienteServicio
    {
        Respuesta CrearCliente(ClienteE cliente);
        Respuesta ObtenerClientes();
    }
}