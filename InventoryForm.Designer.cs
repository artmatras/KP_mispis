using System.Windows.Forms;

namespace ComputerAssembly
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView componentsDataGridView;
        private Button addComponentButton;
        private Button editComponentButton;
        private Button deleteComponentButton;
        private TextBox componentNameTextBox;
        private TextBox quantityTextBox;
        private Label componentNameLabel;
        private Label quantityLabel;

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
            this.componentsDataGridView = new System.Windows.Forms.DataGridView();
            this.addComponentButton = new System.Windows.Forms.Button();
            this.editComponentButton = new System.Windows.Forms.Button();
            this.deleteComponentButton = new System.Windows.Forms.Button();
            this.componentNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.componentNameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.componentsDataGridView)).BeginInit();
            this.SuspendLayout();

            // 
            // componentsDataGridView
            // 
            this.componentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.componentsDataGridView.Name = "componentsDataGridView";
            this.componentsDataGridView.Size = new System.Drawing.Size(400, 300);
            this.componentsDataGridView.TabIndex = 0;

            // 
            // addComponentButton
            // 
            this.addComponentButton.Location = new System.Drawing.Point(420, 230);
            this.addComponentButton.Name = "addComponentButton";
            this.addComponentButton.Size = new System.Drawing.Size(100, 30);
            this.addComponentButton.TabIndex = 1;
            this.addComponentButton.Text = "Добавить";
            this.addComponentButton.UseVisualStyleBackColor = true;
            this.addComponentButton.Click += new System.EventHandler(this.addComponentButton_Click);

            // 
            // editComponentButton
            // 
            this.editComponentButton.Location = new System.Drawing.Point(420, 270);
            this.editComponentButton.Name = "editComponentButton";
            this.editComponentButton.Size = new System.Drawing.Size(100, 30);
            this.editComponentButton.TabIndex = 2;
            this.editComponentButton.Text = "Редактировать";
            this.editComponentButton.UseVisualStyleBackColor = true;
            this.editComponentButton.Click += new System.EventHandler(this.editComponentButton_Click);

            // 
            // deleteComponentButton
            // 
            this.deleteComponentButton.Location = new System.Drawing.Point(420, 310);
            this.deleteComponentButton.Name = "deleteComponentButton";
            this.deleteComponentButton.Size = new System.Drawing.Size(100, 30);
            this.deleteComponentButton.TabIndex = 3;
            this.deleteComponentButton.Text = "Удалить";
            this.deleteComponentButton.UseVisualStyleBackColor = true;
            this.deleteComponentButton.Click += new System.EventHandler(this.deleteComponentButton_Click);

            // 
            // componentNameTextBox
            // 
            this.componentNameTextBox.Location = new System.Drawing.Point(420, 30);
            this.componentNameTextBox.Name = "componentNameTextBox";
            this.componentNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.componentNameTextBox.TabIndex = 4;

            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(420, 70);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(150, 20);
            this.quantityTextBox.TabIndex = 5;

            // 
            // componentNameLabel
            // 
            this.componentNameLabel.AutoSize = true;
            this.componentNameLabel.Location = new System.Drawing.Point(420, 10);
            this.componentNameLabel.Name = "componentNameLabel";
            this.componentNameLabel.Size = new System.Drawing.Size(96, 13);
            this.componentNameLabel.TabIndex = 6;
            this.componentNameLabel.Text = "Название комп.";

            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(420, 50);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(66, 13);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "Количество";

            // 
            // InventoryForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.componentNameLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.componentNameTextBox);
            this.Controls.Add(this.deleteComponentButton);
            this.Controls.Add(this.editComponentButton);
            this.Controls.Add(this.addComponentButton);
            this.Controls.Add(this.componentsDataGridView);
            this.Name = "InventoryForm";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.componentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
