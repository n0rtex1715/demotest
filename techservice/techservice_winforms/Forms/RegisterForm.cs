using techservice_winforms.Services.Interfaces;

namespace techservice_winforms.Forms
{
	public partial class RegisterForm : Form
	{
		private readonly IDbWorker _dbworker;

		public RegisterForm(IDbWorker dbWorker)
		{
			InitializeComponent();
			_dbworker = dbWorker;
		}

		// Register
		private void btnRegister_Click(object sender, EventArgs e)
		{
			var _login = tbLogin.Text; var _password = tbPassword.Text; var _repeatPassword = tbPasswordRepeat.Text;

			if (_login.Length == 0 || _password.Length == 0 || _repeatPassword.Length == 0)
			{
				MessageBox.Show("Проверьте заполненность данных."); return;
			}

			if (_dbworker.IsLoginTaken(_login))
			{
				MessageBox.Show("Такой пользователь уже существует."); return;
			}
			if (_login.Length < 5 || _login.Length > 25)
			{
				MessageBox.Show("Длина логина должна быть не менее 5 и не более 25 символов."); return;
			}

			if (_password != _repeatPassword)
			{
				MessageBox.Show("Пароли не совпадают."); return;
			}
			if (_password.Length < 8 || _password.Length > 50)
			{
				MessageBox.Show("Длина пароля должна быть не менее 8 и не более 50 символов."); return;
			}

			_dbworker.Register(_login, _password);
			this.DialogResult = DialogResult.OK;
		}
	}
}
