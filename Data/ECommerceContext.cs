using ECommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Database
{
	public class ECommerceContext : DbContext
	{
		public ECommerceContext()
		{
		}

		public IConfiguration _configuration { get; }
		public ECommerceContext(IConfiguration configuration)
		{
			this._configuration = configuration;
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

			optionsBuilder
				.UseSqlServer(_configuration
					.GetConnectionString("connectionStr"));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
				.HasData(
				  new Product()
				  {
					  ProductID = 1,
					  Name = "Pulse Oximeter",
					  Description = "Accurately measures your oxygen saturation levels and pulse rate.",
					  Price = 29,
					  Quantity = 1,
					  Category = "Diagnostic Equipment",
					  ImageURL = "wwwroot/Images/pulse_oximeter.jpg"

				  }
				 );

		}



	}
}