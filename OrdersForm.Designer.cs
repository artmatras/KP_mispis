namespace ComputerAssembly
{
    partial class OrdersForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.editOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.orderNumberTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.computerTypeTextBox = new System.Windows.Forms.TextBox();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.computerTypeLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();

            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(400, 300);
            this.ordersDataGridView.TabIndex = 0;

            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(420, 230);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(100, 30);
            this.addOrderButton.TabIndex = 1;
            this.addOrderButton.Text = "Добавить";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);

            // 
            // editOrderButton
            // 
            this.editOrderButton.Location = new System.Drawing.Point(420, 270);
            this.editOrderButton.Name = "editOrderButton";
            this.editOrderButton.Size = new System.Drawing.Size(100, 30);
            this.editOrderButton.TabIndex = 2;
            this.editOrderButton.Text = "Редактировать";
            this.editOrderButton.UseVisualStyleBackColor = true;
            this.editOrderButton.Click += new System.EventHandler(this.editOrderButton_Click);

            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(420, 310);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(100, 30);
            this.deleteOrderButton.TabIndex = 3;
            this.deleteOrderButton.Text = "Удалить";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);

            // 
            // orderNumberTextBox
            // 
            this.orderNumberTextBox.Location = new System.Drawing.Point(420, 30);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this.orderNumberTextBox.TabIndex = 4;

            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(420, 70);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(150, 20);
            this.amountTextBox.TabIndex = 5;

            // 
            // computerTypeTextBox
            // 
            this.computerTypeTextBox.Location = new System.Drawing.Point(420, 110);
            this.computerTypeTextBox.Name = "computerTypeTextBox";
            this.computerTypeTextBox.Size = new System.Drawing.Size(150, 20);
            this.computerTypeTextBox.TabIndex = 6;

            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Location = new System.Drawing.Point(420, 150);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(150, 20);
            this.dueDatePicker.TabIndex = 7;

            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Location = new System.Drawing.Point(420, 10);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(79, 13);
            this.orderNumberLabel.TabIndex = 8;
            this.orderNumberLabel.Text = "Номер заказа";

            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(420, 50);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(40, 13);
            this.amountLabel.TabIndex = 9;
            this.amountLabel.Text = "Сумма";

            // 
            // computerTypeLabel
            // 
            this.computerTypeLabel.AutoSize = true;
            this.computerTypeLabel.Location = new System.Drawing.Point(420, 90);
            this.computerTypeLabel.Name = "computerTypeLabel";
            this.computerTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.computerTypeLabel.TabIndex = 10;
            this.computerTypeLabel.Text = "Тип ПК";

            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(420, 130);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(83, 13);
            this.dueDateLabel.TabIndex = 11;
            this.dueDateLabel.Text = "Срок выполнения";

            // 
            // OrdersForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.computerTypeLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.orderNumberLabel);
            this.Controls.Add(this.dueDatePicker);
            this.Controls.Add(this.computerTypeTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.orderNumberTextBox);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.editOrderButton);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.ordersDataGridView);
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button editOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.TextBox orderNumberTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox computerTypeTextBox;
        private System.Windows.Forms.TextBox clientIdTextBox;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label computerTypeLabel;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.Label dueDateLabel;
    }
}
