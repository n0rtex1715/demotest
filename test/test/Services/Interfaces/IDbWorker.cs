using test.Data.Models;

namespace test.Services.Interfaces
{
	public interface IDbWorker
	{
		// Tables
		public IEnumerable<User> Users { get; }

		// Methods
		public void Save() => Console.WriteLine("Data saved to db.");

		public User? Auth(string login, string password);
	}
}
