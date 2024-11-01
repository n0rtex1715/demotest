using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using techservice_winforms.Services.Interfaces;

namespace techservice_winforms.Forms
{
	public partial class AddClientForm : Form
	{
		private readonly IDbWorker _dbworker;
		private string _clientName = string.Empty;
		private string _clientContactInfo = string.Empty;
		public AddClientForm(IDbWorker dbworker)
		{
			InitializeComponent();
			_dbworker = dbworker;
		}

		// Confirm add
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if (_clientContactInfo.Length == 0 || _clientName.Length == 0)
			{
				MessageBox.Show("Все поля должны быть заполненны.");
				return;
			}
			else if (_clientName.Length < 3)
			{
				MessageBox.Show("Длина ФИО должна быть не менее 3 (В сокращённом варианте).");
				return;
			}
			else
			{
				_dbworker.AddClient(_clientName, _clientContactInfo);
				this.DialogResult = DialogResult.OK;
			}
		}

		// Cancel add
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		// Update values on edit
		private void tbClientContactInfo_TextChanged(object sender, EventArgs e)
		{
			if (tbClientContactInfo != null)
			{
				_clientContactInfo = tbClientContactInfo.Text.ToString();
			}
		}

		private void tbClientName_TextChanged(object sender, EventArgs e)
		{
			if (tbClientName != null)
			{
				_clientName = tbClientName.Text.ToString();
			}
		}
	}
}
