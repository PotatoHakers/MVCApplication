using Microsoft.EntityFrameworkCore;
using Model;

namespace MVCApplication
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Car> Cars { get; set; }

        public DbSet<Owner> Owner { get; set; }
    }
}
