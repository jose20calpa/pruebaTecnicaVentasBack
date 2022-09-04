using Core.Entidades;

namespace Core.Contratos
{
    public interface IProductoRepository
    {
        int CrearProducto(ProductoE productoE);
        List<ProductoE> ObtenerProductos();
    }
}