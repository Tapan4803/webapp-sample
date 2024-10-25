using Microsoft.EntityFrameworkCore;
using webapp_sample.Models;
namespace webapp_sample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } // Add this line
        
    }
}
