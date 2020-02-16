using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealerASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace DealerASP.Controllers
{
    public class VerController : Controller
    {
        public IActionResult Ver(DatosCarro datosCarro, Carro carro)
        {
            return View(datosCarro);
        }
    }
}