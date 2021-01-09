
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetLover.Models;
using PetLover.Data;

namespace PetLover.Controllers.Rest
{
    [ApiController]
    [Route("api/productos")]
    public class APIProductosController: ControllerBase
    {
        /*
        private readonly ILogger<APIProductosController> _logger;
       private readonly ApplicationDbContext _context;

       public APIProductosController(ILogger<APIProductosController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
         public IEnumerable<Producto> ListProductos()
        {
             var listProductos=_context.Productos.OrderBy(s => s.ID).ToList();   
             return listProductos.ToArray();
        }
                
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