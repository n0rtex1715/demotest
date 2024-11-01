using techservice_winforms.Data.Models;

namespace techservice_winforms.Services.Interfaces
{
	public interface IDbWorker
	{
		// Tables
		public IEnumerable<Client> Clients { get; }
		public IEnumerable<Employee> Employees { get; }
		public IEnumerable<Equipment> Equipments { get; }
		public IEnumerable<SparePart> SparePart { get; }
		public IEnumerable<RepairRequest> RepairRequests { get; }
		public IEnumerable<SparePartRequest> SparePartRequests { get; }
		public IEnumerable<RepairReport> RepairReports { get; }
		public IEnumerable<User> Users { get; }

		// Methods
		public void AddClient(string clientName, string clientContactInfo);
		public User? Authenticate(string username, string password);
		public void Register(string username, string password);
		public bool IsLoginTaken(string username);

		// Save changes
		public void Save() => Console.WriteLine("Data saved to db.");
	}
}
