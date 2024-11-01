using Microsoft.Extensions.DependencyInjection;
using techservice_winforms.Forms;
using techservice_winforms.Services.Interfaces;

namespace techservice_winforms
{
	public partial class MainForm : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IDbWorker _dbworker;
		public MainForm(IServiceProvider serviceProvider, IDbWorker dbWorker)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_dbworker = dbWorker;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// pass
		}

		// Open ClientsFrom
		private void btnClients_Click(object sender, EventArgs e)
		{
			var dialog = _serviceProvider.GetRequiredService<ClientsForm>();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				// OK
			}
		}

		// Login
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string _login = tbLogin.Text; string _password = tbPassword.Text;
			var user = _dbworker.Authenticate(_login, _password);

			if (user != null)
			{
				MessageBox.Show($"Добро пожаловать, {user.Name}.");
				if (user.isAdmin)
				{
					btnUsers.Visible = true;
					btnClients.Visible = true;
					btnEmployees.Visible = true;
				}
				if (user.isEmployee)
				{
					btnEquipment.Visible = true;
					btnRequests.Visible = true;
					btnSpareParts.Visible = true;
				}
				// if client
				if (!user.isAdmin && !user.isEmployee)
				{
					btnNewRequest.Visible = true;
				}

				// Profile
				labelUsername.Text = user.Name;
				btnLogout.Visible = true;

				// Hide auth interface
				labelLoginTitle.Visible = false;
				labelLogin.Visible = false; labelPassword.Visible = false;
				tbLogin.Visible = false; tbPassword.Visible = false;
				btnLogin.Visible = false; btnRegister.Visible = false;
				

				labelButtonPanel.Visible = true;

				return;
			}

			MessageBox.Show("Такого пользователя не существует.");
		}

		// Open RegisterForm
		private void btnRegister_Click(object sender, EventArgs e)
		{
			var dialog = _serviceProvider.GetRequiredService<RegisterForm>();
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK)
			{
				MessageBox.Show("Вы были успешно зарегистрированы в системе.");
			}
			else if (dialog.DialogResult == DialogResult.Cancel || dialog.DialogResult == DialogResult.Abort)
			{
				MessageBox.Show("Регистрация отменена.");
			}
		}

		// Open UsersForm
		private void btnUsers_Click(object sender, EventArgs e)
		{
			var dialog = _serviceProvider.GetRequiredService<UsersForm>();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				// OK
			}
		}

		// Logout
		private void btnLogout_Click(object sender, EventArgs e)
		{
			// Show auth interface
			tbLogin.Visible = true; tbPassword.Visible = true;
			labelLogin.Visible = true; labelPassword.Visible = true;
			labelLoginTitle.Visible = true; labelButtonPanel.Visible = false;
			btnLogin.Visible = true; btnRegister.Visible = true;

			// Hide buttons

			// admin
			btnUsers.Visible = false;
			btnClients.Visible = false;
			btnEmployees.Visible = false;
			// employee
			btnEquipment.Visible = false;
			btnRequests.Visible = false;
			btnSpareParts.Visible = false;
			// client
			btnNewRequest.Visible = false;

			// Profile
			labelUsername.Text = "Войдите или зарегистрируйтесь";
			btnLogout.Visible = false;
		}
	}
}
