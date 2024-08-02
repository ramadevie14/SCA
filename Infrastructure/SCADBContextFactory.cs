

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure
{

    public class SCADBContextFactory : IDesignTimeDbContextFactory<SCADBContext>
    {
        public SCADBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SCADBContext>();

            // Use the same configuration as in your appsettings.json
            optionsBuilder.UseSqlServer("Server=localhost;Database=SalesCommission;User Id=sa;Password=MyStrongPass123;");

            return new SCADBContext(optionsBuilder.Options);
        }
    }

}
