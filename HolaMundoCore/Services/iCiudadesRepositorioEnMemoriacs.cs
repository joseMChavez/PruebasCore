using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolaMundoCore.Models;
namespace HolaMundoCore.Services
{
    public interface iCiudadesRepositorioEnMemoriacs
    {
        List<Ciudad> GetList();
    }
}
