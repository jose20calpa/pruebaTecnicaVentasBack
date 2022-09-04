using Core.Entidades;

namespace Core.Contratos
{
    public interface IProductoServicio
    {
        Respuesta CrearProducto(ProductoE producto);
        Respuesta ObtenerProductos();
    }
}