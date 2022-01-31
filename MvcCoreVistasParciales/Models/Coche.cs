using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Models
{
    public class Coche
    {
        public int IdCoche { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; } 
        public int VelocidadMaxima { get; set; }
    }
}
