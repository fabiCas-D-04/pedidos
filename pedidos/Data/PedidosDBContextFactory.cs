using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace pedidos.Data
{
    public class PedidosDBContextFactory : IDesignTimeDbContextFactory<PedidosDBContext>
    {
        public PedidosDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PedidosDBContext>();

            
            optionsBuilder.UseSqlServer("Server=FABICAS\\FABICAS;Database=PedidosWeb;Trusted_Connection=True;TrustServerCertificate=True;");

            return new PedidosDBContext(optionsBuilder.Options);
        }
    }
}
