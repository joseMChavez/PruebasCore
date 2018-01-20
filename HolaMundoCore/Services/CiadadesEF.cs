using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolaMundoCore.Models;
using HolaMundoCore.Data;

namespace HolaMundoCore.Services
{
    public class CiadadesEF : iCiudadesRepositorioEnMemoriacs
    {
        public ApplicationDbContext DbContext { get; }
        public CiadadesEF(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public List<Ciudad> GetList() => DbContext.Ciudades.ToList();
    }
}
