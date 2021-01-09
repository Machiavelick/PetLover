using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetLover.Data;
using PetLover.Models;

namespace PetLover.Controllers.Rest
{
    [ApiController]
    [Route("api/contactos")]
    public class APIContactosController: ControllerBase
    {
         private readonly ILogger<APIContactosController> _logger;
       private readonly ApplicationDbContext _context;

       public APIContactosController(ILogger<APIContactosController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]    

        public IEnumerable<Contacto>  ListContactos()
        {
            var listContactos=_context.Contactos.ToList();
            return listContactos.ToArray();
        }           
       
    }
}