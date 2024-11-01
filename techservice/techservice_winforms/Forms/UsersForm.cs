using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using techservice_winforms.Controls;
using techservice_winforms.Services.Interfaces;

namespace techservice_winforms.Forms
{
	public partial class UsersForm : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IDbWorker _dbworker;

		public UsersForm(IDbWorker dbWorker, IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_dbworker = dbWorker;
			_serviceProvider = serviceProvider;
		}

		// Load
		private void UsersForm_Load(object sender, EventArgs e)
		{
			// dgvUsers.DataSource = _dbworker.Users;
			// labelCount.Text = dgvUsers.ColumnCount.ToString();

			// Custom FlyLaoutPanel with scroll
			int totalContentHeight = 0;
			foreach (Control control in flpUsers.Controls)
			{
				totalContentHeight += control.Height + flpUsers.Margin.Vertical;
			}
			flpUsers.AutoScrollMinSize = new Size(0, totalContentHeight);

			flpUsers.AutoScroll = true;
			flpUsers.WrapContents = false;
			flpUsers.FlowDirection = FlowDirection.TopDown;

			// Docking
			flpUsers.Dock = DockStyle.Fill;
			flpActionPanel.Dock = DockStyle.Top;

			// Empty panel for spacing
			Panel spacer = new Panel
			{
				Height = 20, // space height
				Width = flpUsers.Width / 2, // dividing for avoiding horizontal scrollbar
				BackColor = Color.Transparent // transparency
			};
			flpUsers.Controls.Add(spacer);

			foreach (var user in _dbworker.Users)
			{
				flpUsers.Controls.Add(new UserViewControl(_dbworker, user));
			}
			flpUsers.PerformLayout();
		}

		// Save changes
		private void btnSave_Click(object sender, EventArgs e)
		{
			_dbworker.Save();
		}

		// Add user
		private void btnAdd_Click(object sender, EventArgs e)
		{
			var dialog = _serviceProvider.GetRequiredService<AddUserForm>();
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK)
			{
				MessageBox.Show("Пользователь был успешно добавлен.");
			}
			else if (dialog.DialogResult == DialogResult.Cancel || dialog.DialogResult == DialogResult.Abort)
			{
				MessageBox.Show("Создание пользователя отменено.");
			}
		}
	}
}
