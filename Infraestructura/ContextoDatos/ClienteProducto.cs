using System;
using System.Collections.Generic;

namespace Infraestructura.ContextoDatos
{
    public partial class ClienteProducto
    {
        public int IdClienteProducto { get; set; }
        public int IdProducto { get; set; }
        public int IdCliente { get; set; }
        public int Cantidad { get; set; }
        public int IdVenta { get; set; }
    }
}
