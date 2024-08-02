using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SCADBContext : DbContext
    {
        public SCADBContext(DbContextOptions<SCADBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<IPSales> IPSales { get; set; }

    }
}

