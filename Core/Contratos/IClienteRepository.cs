using Core.Entidades;

namespace Core.Contratos
{
    public interface IClienteRepository
    {
        int CrearCliente(ClienteE clienteE);
        List<ClienteE> ObtenerClientes();
        ClienteE ConsultarCliente(string cedula);
    }
}