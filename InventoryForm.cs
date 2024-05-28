using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerAssembly
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            UpdateInventoryDataGrid();
        }

        private void UpdateInventoryDataGrid()
        {
            componentsDataGridView.DataSource = null;
            componentsDataGridView.DataSource = DataStorage.Inventory;
        }

        private void addComponentButton_Click(object sender, EventArgs e)
        {
            var newComponent = new InventoryItem
            {
                Id = DataStorage.Inventory.Any() ? DataStorage.Inventory.Max(i => i.Id) + 1 : 1,
                ComponentName = componentNameTextBox.Text,
                Quantity = int.Parse(quantityTextBox.Text)
            };
            DataStorage.Inventory.Add(newComponent);
            UpdateInventoryDataGrid();
        }

        private void editComponentButton_Click(object sender, EventArgs e)
        {
            if (componentsDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = (int)componentsDataGridView.SelectedRows[0].Cells[0].Value;
                var component = DataStorage.Inventory.First(i => i.Id == selectedId);
                component.ComponentName = componentNameTextBox.Text;
                component.Quantity = int.Parse(quantityTextBox.Text);
                UpdateInventoryDataGrid();
            }
        }

        private void deleteComponentButton_Click(object sender, EventArgs e)
        {
            if (componentsDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = (int)componentsDataGridView.SelectedRows[0].Cells[0].Value;
                var component = DataStorage.Inventory.First(i => i.Id == selectedId);
                DataStorage.Inventory.Remove(component);
                UpdateInventoryDataGrid();
            }
        }
    }
}
