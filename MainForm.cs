using System;
using System.Windows.Forms;

namespace ComputerAssembly
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void clientsMenuItem_Click(object sender, EventArgs e)
        {
            var clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
        }

        private void ordersMenuItem_Click(object sender, EventArgs e)
        {
            var ordersForm = new OrdersForm();
            ordersForm.ShowDialog();
        }

        private void inventoryMenuItem_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryForm();
            inventoryForm.ShowDialog();
        }

        private void suppliesMenuItem_Click(object sender, EventArgs e)
        {
            var suppliesForm = new SuppliesForm();
            suppliesForm.ShowDialog();
        }
    }
}

