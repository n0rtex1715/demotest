using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Data.Models.DTO;
using test.Services.Interfaces;

namespace test.Forms
{
	public partial class DialogForm : Form
	{
		private readonly IDbWorker _worker;
		public LoginModel authData { get; set; }

		public DialogForm(IDbWorker worker)
		{
			InitializeComponent();
			_worker = worker;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbPassword.Text)) { return; }

			authData = new LoginModel()
			{
				Login = tbLogin.Text,
				Password = tbPassword.Text,
			};

			this.DialogResult = DialogResult.OK;
		}

		// OrderBy(item => item.Id)
		// Where(item => item.Name.Contains(""))
	}
}
