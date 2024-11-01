using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using techservice_winforms.Data;
using techservice_winforms.Services.Interfaces;
using techservice_winforms.Services.Implementations;
using techservice_winforms.Forms;

namespace techservice_winforms
{
	internal static class Program
	{
		private static IServiceProvider _serviceProvider = null!;
		private static string connString = "Server=.;Database=techservice;Trusted_Connection=True;TrustServerCertificate=True";

		[STAThread]
		static void Main()
		{
			// Services
			var services = new ServiceCollection();
			// Forms
			services.AddTransient<MainForm>();
			services.AddTransient<ClientsForm>();
			services.AddTransient<AddClientForm>();
			services.AddTransient<RegisterForm>();
			services.AddTransient<UsersForm>();
			services.AddTransient<AddUserForm>();
			// DbWorker
			services.AddScoped<IDbWorker, DbWorker>();
			// AppDbContext
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(connString));
				// options.UseSqlite($"Data source=./techservice.db"));
			// Builder
			_serviceProvider = services.BuildServiceProvider();

			ApplicationConfiguration.Initialize();
			Application.Run(_serviceProvider.GetRequiredService<MainForm>());
		}
	}
}