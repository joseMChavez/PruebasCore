using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolaMundoCore.Models;
namespace HolaMundoCore.Services
{
    public class CiudadesRepositoriosEnMemoria
    {
        public List<Ciudad> GetList()
        {
            List<Ciudad> ciudades = new List<Ciudad>() {
                new Ciudad("San Francisco"),
                new Ciudad("Santo Domingo"),
                new Ciudad("Santiago"),
                new Ciudad("La Vega")
            };
            return ciudades;
        }
    }
}
