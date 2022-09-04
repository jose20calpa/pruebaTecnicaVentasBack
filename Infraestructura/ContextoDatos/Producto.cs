using System;
using System.Collections.Generic;

namespace Infraestructura.ContextoDatos
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string DescProducto { get; set; } = null!;
        public decimal ValorUnitario { get; set; }
    }
}
