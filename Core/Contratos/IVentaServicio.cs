using Core.Entidades;

namespace Core.Contratos
{
    public interface IVentaServicio
    {
        Respuesta RegistrarVenta(VentaE ven);
    }
}