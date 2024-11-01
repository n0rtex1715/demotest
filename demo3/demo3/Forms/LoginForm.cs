using demo3.Data.Models.DTO;
using demo3.Services.Interfaces;

namespace demo3.Forms
{
	public partial class LoginForm : Form
	{
		private string _login = ""; private string _password = "";
		public Auth AuthData { get; set; }
		private readonly IDbWorker _worker;
		private bool passwordHiden = true;

		public LoginForm(IDbWorker worker)
		{
			InitializeComponent();
			_worker = worker;
		}

		// Abort authentication
		private void buttonCancelAuth_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		// Confirm authemtication
		private void buttonAuth_Click(object sender, EventArgs e)
		{
			var user = _worker.ClientAuth(_login, _password);
			if (user != null)
			{
				AuthData = new Auth
				{
					Login = _login,
					Password = _password
				};
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				this.DialogResult = DialogResult.Abort;
			}

		}

		// Update local data
		private void textBoxLogin_TextChanged(object sender, EventArgs e)
		{
			if (textBoxLogin.Text != null)
			{
				_login = textBoxLogin.Text;
			}
		}

		private void textBoxPassword_TextChanged(object sender, EventArgs e)
		{
			if (textBoxPassword.Text != null)
			{
				_password = textBoxPassword.Text;
			}
		}

		// Hide password button
		private void buttonHidePassword_Click(object sender, EventArgs e)
		{
			if (passwordHiden)
			{
				textBoxPassword.PasswordChar = '\0';
				passwordHiden = !passwordHiden;
			}
			else
			{
				textBoxPassword.PasswordChar = '*';
				passwordHiden = !passwordHiden;
			}
		}
	}
}
