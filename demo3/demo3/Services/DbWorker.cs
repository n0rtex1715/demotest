using demo3.Data;
using demo3.Data.Models;
using demo3.Services.Interfaces;

namespace demo3.Services
{
	public class DbWorker : IDbWorker
	{
		private readonly ApplicationDbContext _context;
		public DbWorker(ApplicationDbContext context)
		{
			_context = context;
		}

		// Tables
		public IEnumerable<Client> Clients => _context.Clients.ToList();
		public IEnumerable<Product> Products => _context.Products.ToList();
		public IEnumerable<Order> Orders => _context.Orders.ToList();
		public IEnumerable<OrderDetail> OrderDetails => _context.OrderDetails.ToList();
		public IEnumerable<FavoriteProduct> FavoriteProducts => _context.FavoriteProducts.ToList();

		// -- Methods --

		// Saving changes
		public void Save() => _context.SaveChanges();

		// Client : Authenticate
		public Client? ClientAuth(string login, string password)
		{
			var client = _context.Clients.FirstOrDefault(c => c.Login == login && c.Password == password);
			return client;
		}
	}
}
