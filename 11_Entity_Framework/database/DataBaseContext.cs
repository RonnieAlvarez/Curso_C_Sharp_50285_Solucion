using _11_Entity_Framework.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Entity_Framework.database
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer(@"server=localhost;Database=Coderhouse;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer(@"server=localhost;Database=Coderhouse;Trusted_Connection=True;");
        }
        // en la consola se debe ejecutar : Add-Migration "nombre1"
        //luego en la misma consola ejecutamos : Update-Database
    }
}
