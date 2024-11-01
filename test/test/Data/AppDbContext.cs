using Microsoft.EntityFrameworkCore;
using test.Data.Models;

namespace test.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
			Database.EnsureCreated();
		}

		// Tables
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			List<User> users = [
				new() { UserId = 1, Login = "Login", Password = "Password" }
			];

			modelBuilder.Entity<User>().HasData(users);
		}
	}
}
