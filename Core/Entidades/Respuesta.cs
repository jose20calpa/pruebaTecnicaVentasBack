using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class Respuesta
    {
        public string Mensaje { get; set; } 
        public bool ok { get; set; }    
        public object Objeto { get; set; }  
    }
}
