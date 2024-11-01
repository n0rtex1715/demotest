using Microsoft.Extensions.DependencyInjection;
using techservice_winforms.Services.Interfaces;
using techservice_winforms.Data.Models;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace techservice_winforms.Forms
{
    public partial class ClientsForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IDbWorker _dbworker;
        private List<Client> _clientsList = null!;
        private BindingSource _bindingSource = new BindingSource();

        public ClientsForm(IDbWorker dbworker, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _dbworker = dbworker;
            _serviceProvider = serviceProvider;
        }

        // Load
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            _clientsList = _dbworker.Clients.ToList();
            _bindingSource.DataSource = new BindingList<Client>(_clientsList);

            var sortedList = _dbworker.Clients.OrderBy(item => item.Id).ToList();
            dgvClients.DataSource = sortedList;
            // Set quantity
            labelColumnCount.Text = "Кол-во:" + dgvClients.ColumnCount.ToString();

            foreach (DataGridViewColumn column in dgvClients.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        // Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            _dbworker.Save();
        }

        // Add
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var dialog = _serviceProvider.GetRequiredService<AddClientForm>();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Клиент был успешно добавлен.");
            }
            else if (dialog.DialogResult == DialogResult.Cancel || dialog.DialogResult == DialogResult.Abort)
            {
                MessageBox.Show("Создание клиента отменено.");
            }
        }

        // Id
        private void rbSortId_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSortId.Checked)
            {
				var sortedList = _dbworker.Clients.OrderBy(item => item.Id).ToList();
				dgvClients.DataSource = sortedList;
			}
        }

        // Name        
        private void rbSortName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSortName.Checked)
            {
                var sortedList = _dbworker.Clients.OrderBy(item => item.Name).ToList();
                dgvClients.DataSource = sortedList;
            }
        }
    }
}
