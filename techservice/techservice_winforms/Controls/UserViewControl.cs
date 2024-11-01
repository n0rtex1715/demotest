using techservice_winforms.Data.Models;
using techservice_winforms.Services.Interfaces;

namespace techservice_winforms.Controls
{
	public partial class UserViewControl : UserControl
	{
		private readonly IDbWorker _dbworker;
		private readonly User _user;

		public UserViewControl(IDbWorker dbWorker, User user)
		{
			InitializeComponent();
			_dbworker = dbWorker;
			_user = user;
			
			tboxId.DataBindings.Add(new Binding("Text", _user, "Id"));
			tboxLogin.DataBindings.Add(new Binding("Text", _user, "Name"));
			tboxPassword.DataBindings.Add(new Binding("Text", _user, "Password"));
			cboxIsEmployee.DataBindings.Add(new Binding("Checked", _user, "isEmployee"));
			cboxIsAdmin.DataBindings.Add(new Binding("Checked", _user, "isAdmin"));
		}
	}
}
