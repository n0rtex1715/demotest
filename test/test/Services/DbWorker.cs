using test.Data;
using test.Data.Models;
using test.Services.Interfaces;

namespace test.Services
{
	public class DbWorker : IDbWorker
	{
		private readonly AppDbContext _context;

		public DbWorker(AppDbContext context)
		{
			_context = context;
		}

		// Tables 
		public IEnumerable<User> Users => _context.Users.ToList();

		// Methods

		public void Save() => _context.SaveChanges();

		public User? Auth(string login, string password)
		{
			var user = _context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
			return user;
		}
	}
}
