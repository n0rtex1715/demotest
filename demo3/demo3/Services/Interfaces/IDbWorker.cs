using demo3.Data.Models;

namespace demo3.Services.Interfaces
{
	public interface IDbWorker
	{
		// Таблицы
		public IEnumerable<Client> Clients { get; }
		public IEnumerable<Product> Products { get; }
		public IEnumerable<Order> Orders { get; }
		public IEnumerable<OrderDetail> OrderDetails { get; }
		public IEnumerable<FavoriteProduct> FavoriteProducts { get; }

		// -- Методы --

		// Сохранение изменений
		public void Save() => Console.WriteLine("Данные успешно сохранены в базе данных.");

		// Client : Auth
		public Client? ClientAuth(string login, string password);
	}
}
