namespace ComputerAssembly
{
    partial class ClientsForm
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
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.addClientButton = new System.Windows.Forms.Button();
            this.editClientButton = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.contactInfoTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.contactInfoLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(400, 300);
            this.clientsDataGridView.TabIndex = 0;
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(420, 190);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(75, 23);
            this.addClientButton.TabIndex = 1;
            this.addClientButton.Text = "Добавить";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // editClientButton
            // 
            this.editClientButton.Location = new System.Drawing.Point(510, 190);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(75, 23);
            this.editClientButton.TabIndex = 2;
            this.editClientButton.Text = "Изменить";
            this.editClientButton.UseVisualStyleBackColor = true;
            this.editClientButton.Click += new System.EventHandler(this.editClientButton_Click);
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.Location = new System.Drawing.Point(600, 190);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(75, 23);
            this.deleteClientButton.TabIndex = 3;
            this.deleteClientButton.Text = "Удалить";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            this.deleteClientButton.Click += new System.EventHandler(this.deleteClientButton_Click);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(420, 30);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(255, 20);
            this.fullNameTextBox.TabIndex = 4;
            // 
            // contactInfoTextBox
            // 
            this.contactInfoTextBox.Location = new System.Drawing.Point(420, 70);
            this.contactInfoTextBox.Name = "contactInfoTextBox";
            this.contactInfoTextBox.Size = new System.Drawing.Size(255, 20);
            this.contactInfoTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(420, 110);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(255, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(420, 10);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(54, 13);
            this.fullNameLabel.TabIndex = 7;
            this.fullNameLabel.Text = "ФИО";
            // 
            // contactInfoLabel
            // 
            this.contactInfoLabel.AutoSize = true;
            this.contactInfoLabel.Location = new System.Drawing.Point(420, 50);
            this.contactInfoLabel.Name = "contactInfoLabel";
            this.contactInfoLabel.Size = new System.Drawing.Size(68, 13);
            this.contactInfoLabel.TabIndex = 8;
            this.contactInfoLabel.Text = "Контакты";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(420, 90);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "Адрес";
            // 
            // ClientsForm
            // 
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.contactInfoLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.contactInfoTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.deleteClientButton);
            this.Controls.Add(this.editClientButton);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.clientsDataGridView);
            this.Name = "ClientsForm";
            this.Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button editClientButton;
        private System.Windows.Forms.Button deleteClientButton;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox contactInfoTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label contactInfoLabel;
        private System.Windows.Forms.Label addressLabel;
    }
}
