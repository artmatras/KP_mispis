using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerAssembly
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            UpdateOrderDataGrid();
        }

        private void UpdateOrderDataGrid()
        {
            ordersDataGridView.DataSource = null;
            ordersDataGridView.DataSource = DataStorage.Orders;
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            var newOrder = new Order
            {
                Id = DataStorage.Orders.Any() ? DataStorage.Orders.Max(o => o.Id) + 1 : 1,
                OrderNumber = orderNumberTextBox.Text,
                Amount = decimal.Parse(amountTextBox.Text),
                ComputerType = computerTypeTextBox.Text,
                DueDate = dueDatePicker.Value,
                ClientId = int.Parse(clientIdTextBox.Text)
            };
            DataStorage.Orders.Add(newOrder);
            UpdateOrderDataGrid();
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = (int)ordersDataGridView.SelectedRows[0].Cells[0].Value;
                var order = DataStorage.Orders.First(o => o.Id == selectedId);
                order.OrderNumber = orderNumberTextBox.Text;
                order.Amount = decimal.Parse(amountTextBox.Text);
                order.ComputerType = computerTypeTextBox.Text;
                order.DueDate = dueDatePicker.Value;
                order.ClientId = int.Parse(clientIdTextBox.Text);
                UpdateOrderDataGrid();
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = (int)ordersDataGridView.SelectedRows[0].Cells[0].Value;
                var order = DataStorage.Orders.First(o => o.Id == selectedId);
                DataStorage.Orders.Remove(order);
                UpdateOrderDataGrid();
            }
        }
    }
}
