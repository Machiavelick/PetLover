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
    public class RegistroController : Controller
    {
        private readonly ILogger<RegistroController> _logger;

        public RegistroController(ILogger<RegistroController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Registro()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Registro(Registro registro)
        {
            if (ModelState.IsValid) 
            {
                // TODO: Hacer algo con los parámetros del objecto contacto
                return RedirectToAction("RegistroConfirmacion");
            }
            
            return View(registro);
        }
         public IActionResult RegistroConfirmacion()
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