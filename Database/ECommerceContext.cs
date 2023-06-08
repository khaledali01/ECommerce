using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Database
{
    public class ECommerceContext : DbContext
    {
        public IConfiguration Configuration { get; }
        protected ECommerceContext(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection string

            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
        }

    }
}