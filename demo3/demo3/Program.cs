using demo3.Data;
using demo3.Forms;
using demo3.Services;
using demo3.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace demo3
{
	internal static class Program
	{
		private static IServiceProvider _serviceProvider;
		private static string connString = @"Server=.;Database=demo3;Trusted_Connection=True;TrustServerCertificate=True";

		[STAThread]
		static void Main()
		{
			// Services
			var services = new ServiceCollection();
			// Forms
			services.AddTransient<MainForm> ();
			services.AddTransient<ClientsForm> ();
			services.AddTransient<LoginForm> ();
			// DbWorker
			services.AddScoped<IDbWorker, DbWorker>();
			// ApplicationDbContext
			services.AddDbContext<ApplicationDbContext> (options => options.UseSqlServer(connString));

			// Build service provider
			_serviceProvider = services.BuildServiceProvider();

			ApplicationConfiguration.Initialize();
			Application.Run(_serviceProvider.GetRequiredService<MainForm>());
		}
	}
}