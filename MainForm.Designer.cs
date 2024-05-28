using System.Windows.Forms;

namespace ComputerAssembly
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem clientsMenuItem;
        private ToolStripMenuItem ordersMenuItem;
        private ToolStripMenuItem inventoryMenuItem;
        private ToolStripMenuItem suppliesMenuItem;

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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsMenuItem,
            this.ordersMenuItem,
            this.inventoryMenuItem,
            this.suppliesMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";

            // 
            // clientsMenuItem
            // 
            this.clientsMenuItem.Name = "clientsMenuItem";
            this.clientsMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientsMenuItem.Text = "Клиенты";
            this.clientsMenuItem.Click += new System.EventHandler(this.clientsMenuItem_Click);

            // 
            // ordersMenuItem
            // 
            this.ordersMenuItem.Name = "ordersMenuItem";
            this.ordersMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersMenuItem.Text = "Заказы";
            this.ordersMenuItem.Click += new System.EventHandler(this.ordersMenuItem_Click);

            // 
            // inventoryMenuItem
            // 
            this.inventoryMenuItem.Name = "inventoryMenuItem";
            this.inventoryMenuItem.Size = new System.Drawing.Size(47, 20);
            this.inventoryMenuItem.Text = "Склад";
            this.inventoryMenuItem.Click += new System.EventHandler(this.inventoryMenuItem_Click);

            // 
            // suppliesMenuItem
            // 
            this.suppliesMenuItem.Name = "suppliesMenuItem";
            this.suppliesMenuItem.Size = new System.Drawing.Size(65, 20);
            this.suppliesMenuItem.Text = "Поставки";
            this.suppliesMenuItem.Click += new System.EventHandler(this.suppliesMenuItem_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Система Управления Сборкой Компьютеров Матросов";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


