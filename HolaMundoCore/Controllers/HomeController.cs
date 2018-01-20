using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HolaMundoCore.Models;
using HolaMundoCore.Services;
namespace HolaMundoCore.Controllers
{
    public class HomeController : Controller
    {
        public iCiudadesRepositorioEnMemoriacs Repos { get; }

        public HomeController(iCiudadesRepositorioEnMemoriacs repositorioEnMemoria)
        {
            Repos = repositorioEnMemoria;
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Esta es una App de Prueba OK.";
            var ciudad = Repos.GetList();
            return View(ciudad);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Prueba Por Jose Chavez.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
