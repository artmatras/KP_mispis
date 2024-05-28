using System.Windows.Forms;

namespace ComputerAssembly
{
    partial class SuppliesForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView suppliesDataGridView;
        private Button createSupplyButton;
        private TextBox supplierTextBox;
        private TextBox componentTextBox;
        private TextBox quantityTextBox;
        private DateTimePicker supplyDatePicker;
        private Label supplierLabel;
        private Label componentLabel;
        private Label quantityLabel;
        private Label supplyDateLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.suppliesDataGridView = new System.Windows.Forms.DataGridView();
            this.createSupplyButton = new System.Windows.Forms.Button();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.componentTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.supplyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.componentLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.supplyDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesDataGridView)).BeginInit();
            this.SuspendLayout();

            // 
            // suppliesDataGridView
            // 
            this.suppliesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.suppliesDataGridView.Name = "suppliesDataGridView";
            this.suppliesDataGridView.Size = new System.Drawing.Size(400, 300);
            this.suppliesDataGridView.TabIndex = 0;

            // 
            // createSupplyButton
            // 
            this.createSupplyButton.Location = new System.Drawing.Point(420, 230);
            this.createSupplyButton.Name = "createSupplyButton";
            this.createSupplyButton.Size = new System.Drawing.Size(100, 30);
            this.createSupplyButton.TabIndex = 1;
            this.createSupplyButton.Text = "Создать";
            this.createSupplyButton.UseVisualStyleBackColor = true;
            this.createSupplyButton.Click += new System.EventHandler(this.createSupplyButton_Click);

            // 
            // supplierTextBox
            // 
            this.supplierTextBox.Location = new System.Drawing.Point(420, 30);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(150, 20);
            this.supplierTextBox.TabIndex = 2;

            // 
            // componentTextBox
            // 
            this.componentTextBox.Location = new System.Drawing.Point(420, 70);
            this.componentTextBox.Name = "componentTextBox";
            this.componentTextBox.Size = new System.Drawing.Size(150, 20);
            this.componentTextBox.TabIndex = 3;

            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(420, 110);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(150, 20);
            this.quantityTextBox.TabIndex = 4;

            // 
            // supplyDatePicker
            // 
            this.supplyDatePicker.Location = new System.Drawing.Point(420, 150);
            this.supplyDatePicker.Name = "supplyDatePicker";
            this.supplyDatePicker.Size = new System.Drawing.Size(150, 20);
            this.supplyDatePicker.TabIndex = 5;

            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(420, 10);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(76, 13);
            this.supplierLabel.TabIndex = 6;
            this.supplierLabel.Text = "Поставщик";

            // 
            // componentLabel
            // 
            this.componentLabel.AutoSize = true;
            this.componentLabel.Location = new System.Drawing.Point(420, 50);
            this.componentLabel.Name = "componentLabel";
            this.componentLabel.Size = new System.Drawing.Size(96, 13);
            this.componentLabel.TabIndex = 7;
            this.componentLabel.Text = "Название комп.";

            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(420, 90);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(66, 13);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Количество";

            // 
            // supplyDateLabel
            // 
            this.supplyDateLabel.AutoSize = true;
            this.supplyDateLabel.Location = new System.Drawing.Point(420, 130);
            this.supplyDateLabel.Name = "supplyDateLabel";
            this.supplyDateLabel.Size = new System.Drawing.Size(91, 13);
            this.supplyDateLabel.TabIndex = 9;
            this.supplyDateLabel.Text = "Дата поставки";

            // 
            // SuppliesForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.supplyDateLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.componentLabel);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.supplyDatePicker);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.componentTextBox);
            this.Controls.Add(this.supplierTextBox);
            this.Controls.Add(this.createSupplyButton);
            this.Controls.Add(this.suppliesDataGridView);
            this.Name = "SuppliesForm";
            this.Text = "Поставки";
            ((System.ComponentModel.ISupportInitialize)(this.suppliesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
