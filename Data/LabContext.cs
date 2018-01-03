using Microsoft.EntityFrameworkCore;
using Lab.Models;

namespace Lab.Data
{
    public class CotizacionesContext : DbContext
    {
        public CotizacionesContext(DbContextOptions<CotizacionesContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SQLITE COMO BACKEND
            optionsBuilder.UseSqlite("Data Source=lab.db");
        }

        public DbSet<Persona> Personas { get; set; }
        
    }
}