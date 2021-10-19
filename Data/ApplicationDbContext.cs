using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Practica03.Data
{
    public class ApplicationDbContext:DbContext
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Practica03.Models.Solicitud> DataSolicitudes { get; set; }

        public DbSet<Practica03.Models.Categoria> DataCategorias { get; set; }
    }
}