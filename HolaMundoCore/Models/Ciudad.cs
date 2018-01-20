using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundoCore.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Ciudad()
        {
            Nombre = string.Empty;
        }
        public Ciudad(string nombre)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        }
    }
}
