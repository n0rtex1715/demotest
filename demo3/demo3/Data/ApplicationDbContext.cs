using Microsoft.EntityFrameworkCore;
using demo3.Data.Models;

namespace demo3.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			// Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		public DbSet<Animal> Animals { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
	}
}
