using System;
using System.Collections.Generic;

namespace Infraestructura.ContextoDatos
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Cedula { get; set; } = null!;
    }
}
