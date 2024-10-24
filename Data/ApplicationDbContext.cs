using Microsoft.EntityFrameworkCore;

namespace WEBAPP_SAMPLE.Data  // Corrected namespace
{
    public class ApplicationDbContext : DbContext
    {
        // Corrected constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSets for your models
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
