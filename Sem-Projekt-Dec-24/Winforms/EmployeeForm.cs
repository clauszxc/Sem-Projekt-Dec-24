using Sem_Projekt_Dec_24.Data;
using Sem_Projekt_Dec_24.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem_Projekt_Dec_24.Winforms
{
    public partial class EmployeeForm : Form
    {
        private readonly DatabaseManager _dbManager;
        public BindingList<Products> ProductList { get; set; } = new BindingList<Products>();
        public BindingList<Items> ItemList { get; set; } = new BindingList<Items>();
        public BindingList<Customers> CustomerList { get; set; } = new BindingList<Customers>();
        public BindingList<Orders> OrderList { get; set; } = new BindingList<Orders>();
        public BindingList<Employees> EmployeeList { get; set; } = new BindingList<Employees>();
        public BindingList<Shippers> ShipperList { get; set; } = new BindingList<Shippers>();
        public BindingList<Suppliers> SupplierList { get; set; } = new BindingList<Suppliers>();
        public BindingList<PurchaseOrders> PurchaseOrderList { get; set; } = new BindingList<PurchaseOrders>();
        public BindingList<Shipments> ShipmentList { get; set; } = new BindingList<Shipments>();


        public EmployeeForm()
        {
            InitializeComponent();
            string connectionString = "Server=mssql2.unoeuro.com;Database=ferrariconnie_dk_db_semprojectdb;User Id=ferrariconnie_dk;Password=bkngcw5BmR6DEx2ep4a3;";

            _dbManager = new DatabaseManager(connectionString);
        }

        private void btnEmployeeManageStorage_Click(object sender, EventArgs e)
        {
            StorageCRUDForm storageCRUDForm = new StorageCRUDForm();
            storageCRUDForm.StartPosition = FormStartPosition.CenterScreen;
            storageCRUDForm.Show();
            this.Hide();
        }

        private void btnEmployeeManageActors_Click(object sender, EventArgs e)
        {
            ActorCRUDForm actorCRUDForm = new ActorCRUDForm();
            actorCRUDForm.StartPosition = FormStartPosition.CenterScreen;
            actorCRUDForm.Show();
            this.Hide();
        }

        private void btnEmployeeGoBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
            this.Hide();
        }

        private void btnProductsList_Click(object sender, EventArgs e)
        {
            List<Products> productsFromDB = _dbManager.GetProducts();
            ProductList.Clear();
            foreach (var product in productsFromDB)
            {
                ProductList.Add(product);
            }
            lboxEmployee.DataSource = ProductList;
            lboxEmployee.DisplayMember = "ProductInformation";
        }

        private void btnItemsList_Click(object sender, EventArgs e)
        {
            List<Items> ItemsFromDB = _dbManager.GetItems();
            ItemList.Clear();
            foreach (var product in ItemsFromDB)
            {
                ItemList.Add(product);
            }
            lboxEmployee.DataSource = ItemList;
            lboxEmployee.DisplayMember = "ItemInformation";
        }

        private void btnCustomersList_Click(object sender, EventArgs e)
        {
            List<Customers> CustomersFromDB = _dbManager.GetCustomers();
            CustomerList.Clear();
            foreach (var customers in CustomersFromDB)
            {
                CustomerList.Add(customers);
            }
            lboxEmployee.DataSource = CustomerList;
            lboxEmployee.DisplayMember = "CustomerInformation";
        }

        private void btnEmployeesList_Click(object sender, EventArgs e)
        {
            List<Employees> EmployeesFromDB = _dbManager.GetEmployees();
            EmployeeList.Clear();
            foreach (var employees in EmployeesFromDB)
            {
                EmployeeList.Add(employees);
            }
            lboxEmployee.DataSource = EmployeeList;
            lboxEmployee.DisplayMember = "EmployeeInformation";
        }

        private void btnShippersList_Click(object sender, EventArgs e)
        {
            List<Shippers> ShippersFromDB = _dbManager.GetShippers();
            ShipperList.Clear();
            foreach (var shippers in ShippersFromDB)
            {
                ShipperList.Add(shippers);
            }
            lboxEmployee.DataSource = ShipperList;
            lboxEmployee.DisplayMember = "ShipperName";
        }

        private void btnSuppliersList_Click(object sender, EventArgs e)
        {
            List<Suppliers> SuppliersFromDB = _dbManager.GetSuppliers();
            SupplierList.Clear();
            foreach (var suppliers in SuppliersFromDB)
            {
                SupplierList.Add(suppliers);
            }
            lboxEmployee.DataSource = SupplierList;
            lboxEmployee.DisplayMember = "SupplierId";
        }

        private void btnPurchaseOrdersList_Click(object sender, EventArgs e)
        {
            List<PurchaseOrders> PurchaseOrdersFromDB = _dbManager.GetPurchaseOrders();
            PurchaseOrderList.Clear();
            foreach (var purchaseorders in PurchaseOrdersFromDB)
            {
                PurchaseOrderList.Add(purchaseorders);
            }
            lboxEmployee.DataSource = PurchaseOrderList;
            lboxEmployee.DisplayMember = "PurchaseOrderInformation";
        }

        private void btnOrdersList_Click(object sender, EventArgs e)
        {
            List<Orders> OrdersFromDB = _dbManager.GetOrders();
            OrderList.Clear();
            foreach (var orders in OrdersFromDB)
            {
                OrderList.Add(orders);
            }
            lboxEmployee.DataSource = OrderList;
            lboxEmployee.DisplayMember = "OrderInformation";
        }

        private void btnShipmentsList_Click(object sender, EventArgs e)
        {
            List<Shipments> ShipmentsFromDB = _dbManager.GetShipments();
            ShipmentList.Clear();
            foreach (var shipments in ShipmentsFromDB)
            {
                ShipmentList.Add(shipments);
            }
            lboxEmployee.DataSource = ShipmentList;
            lboxEmployee.DisplayMember = "ShipmentInformation";
        }
    }
}
