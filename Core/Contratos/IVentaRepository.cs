using Core.Entidades;

namespace Core.Contratos
{
    public interface IVentaRepository
    {
        int RegistrarTotalVenta(decimal totalVenta);
        int RegistrarVentaProductos(VentaE venta, int idVenta);
    }
}