using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using techservice_winforms.Data;
using techservice_winforms.Services.Implementations;

[TestClass]
public class DbWorkerTests
{
	private DbWorker _dbWorker;
	private ApplicationDbContext _context;

	[TestInitialize]
	public void TestInitialize()
	{
		var options = new DbContextOptionsBuilder<ApplicationDbContext>()
			.UseInMemoryDatabase("TestDatabase")
			.Options;

		_context = new ApplicationDbContext(options);
		Assert.IsNotNull(_context, "Failed to initialize ApplicationDbContext.");

		_dbWorker = new DbWorker(_context);
		Assert.IsNotNull(_dbWorker, "Failed to initialize DbWorker.");
	}

	[TestCleanup]
	public void TestCleanup()
	{
		if (_context != null)
		{
			_context.Database.EnsureDeleted();
			_context.Dispose();
			_context = null;
		}
	}

	[TestMethod]
	public void AddClient_ShouldAddClientToDatabase()
	{
		// Arrange
		int initialCount = _context.Clients.Count();

		// Act
		_dbWorker.AddClient("Test Client", "Contact Info");
		_dbWorker.Save();
		_context.Clients.Load(); // Manually load data to avoid NullReferenceException

		// Assert
		int newCount = _context.Clients.Count();
		Assert.AreEqual(initialCount + 1, newCount, "Client count did not increase as expected.");

		var client = _context.Clients.OrderBy(c => c.Id).LastOrDefault();
		Assert.IsNotNull(client, "Client not found after saving.");
		Assert.AreEqual("Test Client", client.Name, "Client name mismatch.");
	}

	[TestMethod]
	public void Save_ShouldSaveChangesToDatabase()
	{
		// Arrange
		_dbWorker.AddClient("Test Client", "Contact Info");

		// Act
		_dbWorker.Save();
		_context.Clients.Load(); // Manually load data to avoid NullReferenceException

		// Assert
		int newCount = _context.Clients.Count();
		MessageBox.Show($"{newCount}");

		var client = _context.Clients.LastOrDefault();
		Assert.IsNotNull(client, "Client not found after saving.");
		Assert.AreEqual("Test Client", client.Name, "Client name mismatch.");
	}
}
