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
         private readonly ILogger<APIProductoController> _logger;
       private readonly ApplicationDbContext _context;

       public APIContactosController(ILogger<APIProductoController> logger,
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
        /*    
        public IEnumerable<Producto> ListProductos()
        {
             var listProductos=_context.Productos.OrderBy(s => s.ID).ToList();   
             return listProductos.ToArray();
        }*/
        
        /*
        [HttpGet("{id}")]
        public Producto GetProduct(int? id)
        {
            var producto =  _context.Productos.Find(id);
            return producto;
        }

        [HttpPost]
        public Producto CreateProduct(Producto producto){
            _context.Add(producto);
            _context.SaveChanges();
            return producto;
        }*/
    }
}