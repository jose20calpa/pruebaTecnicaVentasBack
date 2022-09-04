using Core.Entidades;

namespace WebApiVentasProj.Models
{
    public class Venta
    {
        public List<ProductoVenta> Productos { get; set; }
        public int IdCliente { get; set; }
        public decimal Totalventa { get; set; }
    }
}
