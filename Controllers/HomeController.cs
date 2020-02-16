using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DealerASP.Models;

namespace DealerASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        } 

        public IActionResult Carros(DatosCarro datosCarro, Carro carro)
        {
            var ID = datosCarro.Carros.Count > 0 ? datosCarro.Carros.Max(x => x.Id) + 1 : 0;
            carro.Id = ID;

            datosCarro.Carros.Add(carro);
            return View(datosCarro);
        }
    }
}
