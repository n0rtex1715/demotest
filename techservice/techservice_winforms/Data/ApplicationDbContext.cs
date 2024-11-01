using Microsoft.EntityFrameworkCore;
using techservice_winforms.Data.Models;

namespace techservice_winforms.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
			// Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		// Tables
		public DbSet<Client> Clients { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Equipment> Equipments { get; set; }
		public DbSet<SparePart> SparePart { get; set; }
		public DbSet<RepairRequest> RepairRequests { get; set; }
		public DbSet<SparePartRequest> SparePartRequests { get; set; }
		public DbSet<RepairReport> RepairReports { get; set; }
		public DbSet<User> Users { get; set; }

		// Initial data
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Users
			List<User> users = [
				new() { Id = 1, Name = "Admin", Password = "Admin", isEmployee = true, isAdmin = true },
				new() { Id = 2, Name = "client@example.com", Password = "clientpassword", isEmployee = false, isAdmin = false },
				new() { Id = 3, Name = "employee@example.com", Password = "employeepassword", isEmployee = true, isAdmin = false },
				new() { Id = 4, Name = "arseniy21101980@rambler.ru", Password = "arseniy21101980", isEmployee = false, isAdmin = true },
				new() { Id = 5, Name = "rukoleevpe@mer.ci.nsu.ru", Password = "rukoleevpe1234", isEmployee = true, isAdmin = true },
				new() { Id = 6, Name = "yakov1971@ya.ru", Password = "yakov1971", isEmployee = true, isAdmin = false },
			];
			modelBuilder.Entity<User>().HasData(users);

			// Clients
			List<Client> clients = [
				new() { Id = 1, Name = "Харитонова Юлиана Данииловна", ContactInfo = "+7(965)342-94-38 yuliana1987@mail.ru" },
				new() { Id = 2, Name = "Абоимов Виктор Александрович", ContactInfo = "+7(993)474-87-94 viktor.aboimov@mail.ru" },
				new() { Id = 3, Name = "Менде Юлиан Максимович", ContactInfo = "+7(939)617-13-94 yulian27041960@hotmail.com" },
				new() { Id = 4, Name = "Ненашев Николай Алексеевич", ContactInfo = "+7(909)664-56-34 nikolay12@hotmail.com" },
				new() { Id = 5, Name = "Кондратьева Пелагея Ильиновна", ContactInfo = "+7(981)692-59-32 pelageya1968@outlook.com" },
				new() { Id = 6, Name = "Шевцов Феликс Феликсович", ContactInfo = "+7(934)141-77-85 feliks1995@gmail.com" },
			];
			modelBuilder.Entity<Client>().HasData(clients);

			// Employee
			List<Employee> employees = [
				new() { Id = 1, Name = "Руколеев Петр Евгеньевич", Role="Администратор", ContactInfo = "+7(999)999-99-99 rukoleevpe@mer.ci.nsu.ru" },
				new() { Id = 2, Name = "Капшуков Арсений Максимоич", Role="Менеджер", ContactInfo = "+7(978)169-61-99 arseniy21101980@rambler.ru" },
				new() { Id = 3, Name = "Шаврин Яков Валентинович", Role= "Механик", ContactInfo = "+7(982)342-44-34 yakov1971@ya.ru" },
				new() { Id = 4, Name = "Аспидова Вероника Витальевна", Role="Логист", ContactInfo = "+7(934)141-77-85 veronika1969@yandex.ru" },
			];
			modelBuilder.Entity<Employee>().HasData(employees);
		}
	}
}
