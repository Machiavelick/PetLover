using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetLover.Models;

namespace PetLover.Controllers
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

        public IActionResult Servicios()
        {
            return View();
        }
         public IActionResult Peluqueria()
        {
            return View();
        }
        public IActionResult Acupuntura()
        {
            return View();
        }
        public IActionResult Cardiologia()
        {
            return View();
        }
        public IActionResult Cirugia()
        {
            return View();
        }
        public IActionResult Dermatologia()
        {
            return View();
        }
        public IActionResult Odontologia()
        {
            return View();
        }
        public IActionResult Resonancias()
        {
            return View();
        }
        public IActionResult Spa()
        {
            return View();
        }
        public IActionResult Vacunas()
        {
            return View();
        }
        public IActionResult Farmacia()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
