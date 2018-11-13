using Microsoft.EntityFrameworkCore;
using SRVFlorerias.Models;

namespace SRVFlorerias.Context
{
    public class SRVFloreriasContext : DbContext
    {
        public SRVFloreriasContext(DbContextOptions<SRVFloreriasContext> dco)
            : base(dco)
        { }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
    }
}