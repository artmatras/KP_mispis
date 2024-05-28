using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerAssembly
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            UpdateClientDataGrid();
        }

        private void UpdateClientDataGrid()
        {
            clientsDataGridView.DataSource = null;
            clientsDataGridView.DataSource = DataStorage.Clients;
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            var newClient = new Client
            {
                Id = DataStorage.Clients.Any() ? DataStorage.Clients.Max(c => c.Id) + 1 : 1,
                FullName = fullNameTextBox.Text,
                ContactInfo = contactInfoTextBox.Text,
                Address = addressTextBox.Text
            };
            DataStorage.Clients.Add(newClient);
            UpdateClientDataGrid();
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = (int)clientsDataGridView.SelectedRows[0].Cells[0].Value;
                var client = DataStorage.Clients.First(c => c.Id == selectedId);
                client.FullName = fullNameTextBox.Text;
                client.ContactInfo = contactInfoTextBox.Text;
                client.Address = addressTextBox.Text;
                UpdateClientDataGrid();
            }
        }

        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = (int)clientsDataGridView.SelectedRows[0].Cells[0].Value;
                var client = DataStorage.Clients.First(c => c.Id == selectedId);
                DataStorage.Clients.Remove(client);
                UpdateClientDataGrid();
            }
        }
    }
}
