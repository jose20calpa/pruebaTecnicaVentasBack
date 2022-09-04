using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class VentaE
    {
        public int Id { get; set; } 
        public List<ProductoVenta> Productos { get; set; }
        public int IdCliente { get; set; }
        public decimal Totalventa { get; set; }   
    }
}
