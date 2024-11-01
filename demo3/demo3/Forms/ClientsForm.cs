using demo3.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.DirectoryServices;

namespace demo3.Forms
{
	public partial class ClientsForm : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IDbWorker _worker;
		private List<Client> _clients = null!;
		private List<Client> _filteredClients = null!;
		public ClientsForm(IDbWorker worker, IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_worker = worker;
			_serviceProvider = serviceProvider;
		}

		// Load data to dgv
		private void ClientsForm_Load(object sender, EventArgs e)
		{
			_clients = _worker.Clients.ToList();
			_filteredClients = _clients;
			dgvClients.DataSource = _filteredClients;
		}

		// Perform partial search
		public void SearchClients()
		{
			var searchTerm = textBoxSearchBar.Text;
			if (string.IsNullOrWhiteSpace(searchTerm))
			{
				_filteredClients = _clients;
			}
			else
			{
				_filteredClients = _clients.Where(item =>
					item.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
					item.Login.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
					item.Password.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
					item.Address.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
					item.ClientID.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
				).ToList();
			}
			
			SortClients();
		}

		// Sort clients in dgv
		public void SortClients()
		{
			if (rbId.Checked)
			{
				dgvClients.DataSource = _filteredClients.OrderBy(item => item.ClientID).ToList();
			}

			else if (rbName.Checked)
			{
				dgvClients.DataSource = _filteredClients.OrderBy(item => item.Name).ToList();
			}

			else if (rbPhone.Checked)
			{
				dgvClients.DataSource = _filteredClients.OrderBy(item => item.Phone).ToList();
			}
			else
			{
				dgvClients.DataSource = _filteredClients;
			}
		}

		// Sort radio buttons
		private void rbId_CheckedChanged(object sender, EventArgs e)
		{
			SortClients();
		}

		private void rbName_CheckedChanged(object sender, EventArgs e)
		{
			SortClients();
		}

		private void rbPhone_CheckedChanged(object sender, EventArgs e)
		{
			SortClients();
		}

		// Search bar
		private void textBoxSearchBar_TextChanged(object sender, EventArgs e)
		{
			SearchClients();
		}
	}
}
