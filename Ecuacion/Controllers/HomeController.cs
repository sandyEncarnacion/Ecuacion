using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ecuacion.Models;

namespace Ecuacion.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
       public IActionResult Ecuacion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ecuacion(int numero1, int numero2, int numero3)
        {
            var resultado1 = -numero2 + ((Math.Sqrt(((numero2 * numero2) - (4 * numero1 * numero3)))));
            var resultado2 = -numero2 - ((Math.Sqrt(((numero2 * numero2) - (4 * numero1 * numero3)))));

            ViewBag.resultado1 = resultado1;
            ViewBag.resultado2 = resultado2;
            ViewBag.Dividendo = numero1*2;

            return View("Resultado");
        }

    }

}
