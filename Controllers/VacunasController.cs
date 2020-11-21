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
    public class VacunasController : Controller
    {
        private readonly ILogger<VacunasController> _logger;

        public VacunasController(ILogger<VacunasController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Vacunas()
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