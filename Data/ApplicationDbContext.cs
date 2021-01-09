using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetLover.Models;

namespace PetLover.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PetLover.Models.Contacto> Contactos { get; set; }
        public object Productos { get; internal set; }
        public DbSet<PetLover.Models.Producto> Producto { get; set; }

        //public DbSet<PetLover.Models.LikeServices> LikeServices{ get; internal set;}

        //public object Services { get; internal set; }
    }
}
