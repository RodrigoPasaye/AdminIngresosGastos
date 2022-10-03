using Microsoft.EntityFrameworkCore;

namespace AdminIngresosGastos.Data {
    public class AplicationDbContext : DbContext {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }
    }
}
