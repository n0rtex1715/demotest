using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using test.Data;
using test.Forms;
using test.Services;
using test.Services.Interfaces;

namespace test
{
	internal static class Program
	{
		private static IServiceProvider _serviceProvider = null!;
		private static string connString = @"Server=.;Database=test_demo;Trusted_Connection=True;TrustServerCertificate=True";

		[STAThread]
		static void Main()
		{
			var services = new ServiceCollection();

			// Forms
			services.AddTransient<MainForm>();
			services.AddTransient<DialogForm>();
			// DbWorker
			services.AddScoped<IDbWorker, DbWorker>();
			// AppDbContext
			services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connString));

			_serviceProvider = services.BuildServiceProvider();

			ApplicationConfiguration.Initialize();
			Application.Run(_serviceProvider.GetRequiredService<MainForm>());
		}
	}
}