using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerAssembly
{
    public partial class SuppliesForm : Form
    {
        public SuppliesForm()
        {
            InitializeComponent();
            UpdateSupplyDataGrid();
        }

        private void UpdateSupplyDataGrid()
        {
            suppliesDataGridView.DataSource = null;
            suppliesDataGridView.DataSource = DataStorage.Supplies;
        }

        private void createSupplyButton_Click(object sender, EventArgs e)
        {
            var newSupply = new Supply
            {
                Id = DataStorage.Supplies.Any() ? DataStorage.Supplies.Max(s => s.Id) + 1 : 1,
                Supplier = supplierTextBox.Text,
                ComponentName = componentTextBox.Text,
                Quantity = int.Parse(quantityTextBox.Text),
                SupplyDate = supplyDatePicker.Value
            };
            DataStorage.Supplies.Add(newSupply);
            UpdateSupplyDataGrid();
        }
    }
}
