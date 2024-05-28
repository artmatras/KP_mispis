using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerAssembly
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ContactInfo { get; set; }
        public string Address { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public decimal Amount { get; set; }
        public string ComputerType { get; set; }
        public DateTime DueDate { get; set; }
        public int ClientId { get; set; }
    }

    public class InventoryItem
    {
        public int Id { get; set; }
        public string ComponentName { get; set; }
        public int Quantity { get; set; }
    }

    public class Supply
    {
        public int Id { get; set; }
        public string Supplier { get; set; }
        public string ComponentName { get; set; }
        public int Quantity { get; set; }
        public DateTime SupplyDate { get; set; }
    }

    public static class DataStorage
    {
        public static List<Client> Clients = new List<Client>();
        public static List<Order> Orders = new List<Order>();
        public static List<InventoryItem> Inventory = new List<InventoryItem>();
        public static List<Supply> Supplies = new List<Supply>();
    }
}

namespace ComputerAssembly
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
