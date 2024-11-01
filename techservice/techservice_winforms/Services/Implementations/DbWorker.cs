using Microsoft.EntityFrameworkCore;
using techservice_winforms.Data;
using techservice_winforms.Data.Models;
using techservice_winforms.Services.Interfaces;

namespace techservice_winforms.Services.Implementations
{
	public class DbWorker : IDbWorker
	{
		// Load database context
		private readonly ApplicationDbContext _context;
		public DbWorker(ApplicationDbContext context)
		{
			_context = context;
		}

		// Tables
		public IEnumerable<Client> Clients => _context.Clients.ToList();
		public IEnumerable<Employee> Employees => _context.Employees.ToList();
		public IEnumerable<Equipment> Equipments => _context.Equipments.ToList();
		public IEnumerable<SparePart> SparePart => _context.SparePart.ToList();
		public IEnumerable<RepairRequest> RepairRequests => _context.RepairRequests.ToList();
		public IEnumerable<SparePartRequest> SparePartRequests => _context.SparePartRequests.ToList();
		public IEnumerable<RepairReport> RepairReports => _context.RepairReports.ToList();
		public IEnumerable<User> Users => _context.Users.ToList();

		// Save changes
		public void Save() => _context.SaveChanges();

		// -- Clients

		// Add
		public void AddClient(string name, string contact_info)
		{
			_context.Clients.Add(new()
			{
				Name = name, ContactInfo = contact_info
			});
			Save();
		}

		// -- Users

		// Authenticate
		public User? Authenticate(string username, string password)
		{
			var user = _context.Users.FirstOrDefault(u => u.Name == username && u.Password == password);
			return user;
		}

		// Register
		public void Register(string username, string password)
		{
			_context.Users.Add(new()
			{
				Name = username,
				Password = password,
				isAdmin = false, isEmployee = false
			});
			Save();
		}

		// Is login already taken
		public bool IsLoginTaken(string username)
		{
			return _context.Users.Where(u => u.Name == username).Any();
		}
	}
}
