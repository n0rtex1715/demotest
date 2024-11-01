using Microsoft.Extensions.DependencyInjection;
using test.Forms;
using test.Services.Interfaces;

namespace test
{
	public partial class MainForm : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IDbWorker _worker;

		public MainForm(IServiceProvider serviceProvider, IDbWorker worker)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_worker = worker;
		}

		private void buttonTest_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"{_worker.Users.Count()}");
		}

		private void buttonDialog_Click(object sender, EventArgs e)
		{
			var dialog = _serviceProvider.GetRequiredService<DialogForm>();
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK)
			{
				var _authData = dialog.authData;
				MessageBox.Show($"L: {_authData.Login}\nP: {_authData.Password}");
			}
		}
	}
}
