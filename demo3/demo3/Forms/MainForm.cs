using demo3.Forms;
using demo3.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace demo3
{
	public partial class MainForm : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IDbWorker _worker;
		public MainForm(IDbWorker worker, IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_worker = worker;
			_serviceProvider = serviceProvider;
		}

		// Test connection
		private void buttonTestConnection_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show(_worker.Clients.Count().ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Authenticate
		private void buttonLogin_Click(object sender, EventArgs e)
		{
			var dialog = _serviceProvider.GetRequiredService<LoginForm>();
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK)
			{
				var _authData = dialog.AuthData;
				labelCurrentUser.Text = _authData.Login;
				MessageBox.Show($"Добро пожаловать, {_authData.Login}");
			}
			else if (dialog.DialogResult == DialogResult.Cancel)
			{
				return;
			}
			else { MessageBox.Show("Произошла ошибка при входе. Проверьте корректность данных."); }
		}

		private void buttonClients_Click(object sender, EventArgs e)
		{
			var dialog = _serviceProvider.GetRequiredService<ClientsForm>();
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK )
			{
				//
			}
		}
	}
}
