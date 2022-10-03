using AdminIngresosGastos.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminIngresosGastos.Data {
    public class AplicationDbContext : DbContext {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
