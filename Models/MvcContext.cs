using Microsoft.EntityFrameworkCore;
using SRVFlorerias.Models;

namespace SRVFlorerias.Models
{
    public class MvcContext : DbContext
    {
        public MvcContext (DbContextOptions<MvcContext> options)
            : base(options)
        {
        }

         public DbSet<SRVFlorerias.Models.Empleado> Empleado { get; set; }
        public DbSet<SRVFlorerias.Models.Pedido> Pedido { get; set; }
        public DbSet<SRVFlorerias.Models.Contactos> Contactos { get; set; }
        
    }
}
