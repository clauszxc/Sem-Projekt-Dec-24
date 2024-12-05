using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sem_Projekt_Dec_24.Data;
using Sem_Projekt_Dec_24.Tables;
using Sem_Projekt_Dec_24.Winforms;

namespace Sem_Projekt_Dec_24.Winforms
{
    public partial class CustomerForm : Form
    {
        private readonly DatabaseManager _dbManager;
        public BindingList<Products> ProductList { get; set; } = new BindingList<Products>();
        public BindingList<Customers> CustomerList { get; set; } = new BindingList<Customers>();
        public BindingList<Orders> OrderList { get; set; } = new BindingList<Orders>();
        public BindingList<OrderInvoices> OrderInvoiceList { get; set; } = new BindingList<OrderInvoices>();

        public CustomerForm()
        {
            InitializeComponent();

            string connectionString = "Server=mssql2.unoeuro.com;Database=ferrariconnie_dk_db_semprojectdb;User Id=ferrariconnie_dk;Password=bkngcw5BmR6DEx2ep4a3;";

            _dbManager = new DatabaseManager(connectionString);

            LoadProducts();
            dgvProducts.DataSource = ProductList;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Customize selected row color
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void LoadProducts()
        {
            List<Products> productsFromDB = _dbManager.GetProducts();
            foreach (var product in productsFromDB)
            {
                ProductList.Add(product);
            }
        }
        private void LoadCustomers()
        {
            List<Customers> customersFromDB = _dbManager.GetCustomers();
            foreach (var customer in customersFromDB)
            {
                CustomerList.Add(customer);
            }
        }
        private void LoadOrders()
        {
            List<Orders> ordersFromDB = _dbManager.GetOrders();
            foreach (var order in ordersFromDB)
            {
                OrderList.Add(order);
            }
        }
        private void LoadOrderInvoices()
        {
            List<OrderInvoices> orderInvoicesFromDB = _dbManager.GetOrderInvoices();
            foreach (var orderInvoice in orderInvoicesFromDB)
            {
                OrderInvoiceList.Add(orderInvoice);
            }
        }
        private void ClearInputFields()
        {
            txtbAdress.Clear();
            txtbEmail.Clear();
            txtbQuantity.Clear();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = GetOrCreateCustomer();
                int orderId = GetOrCreateOrder(customerId);
                CreateOrderInvoice(customerId, orderId);

                var selectedInvoices = GetSelectedInvoicesFromGrid();
                if (selectedInvoices.Count == 0)
                {
                    MessageBox.Show("Please select at least one product or order.");
                    return;
                }

                CustomerConfirmationForm customerConfirmationForm = new CustomerConfirmationForm(selectedInvoices);
                customerConfirmationForm.StartPosition = FormStartPosition.CenterScreen;
                customerConfirmationForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                ClearInputFields();
            }
        }

        private int GetOrCreateCustomer()
        {
            string customerAdress = txtbAdress.Text;
            string customerEmail = txtbEmail.Text;

            var existingCustomer = CustomerList.FirstOrDefault(c => c.CustomerEmail == customerEmail);
            if (existingCustomer != null)
            {
                return existingCustomer.CustomerId;
            }

            int newCustomerId = CustomerList.Count > 0 ? CustomerList.Max(c => c.CustomerId) + 1 : 1;
            var newCustomer = new Customers(newCustomerId, customerEmail, customerAdress);

            CustomerList.Add(newCustomer);
            _dbManager.AddCustomer(newCustomer);

            return newCustomerId;
        }
        private int GetOrCreateOrder(int customerId)
        {
            string orderStatus = "Ongoing";
            int shipperId = 1;

            var existingOrder = OrderList.FirstOrDefault(o => o.CustomerId == customerId && o.OrderStatus == orderStatus);
            if (existingOrder != null)
            {
                return existingOrder.OrderId;
            }

            int newOrderId = OrderList.Count > 0 ? OrderList.Max(c => c.OrderId) + 1 : 1;
            var newOrder = new Orders(newOrderId, customerId, shipperId, orderStatus);

            OrderList.Add(newOrder);
            _dbManager.AddOrder(newOrder);

            return newOrderId;
        }

        private void CreateOrderInvoice(int  customerId, int orderId)
        {
            int productId = GetSelectedProductId();
            decimal price = 100;
            if (!int.TryParse(txtbQuantity.Text, out int quantity) || quantity <= 0)
            {
                throw new InvalidOperationException("Please enter valid quantity.");
            }

            int newOrderInvoiceId = OrderInvoiceList.Count > 0 ? OrderInvoiceList.Max(oi => oi.OrderInvoiceId) + 1 : 1;
            var newOrderInvoice = new OrderInvoices(newOrderInvoiceId, customerId, productId, price, quantity);

            OrderInvoiceList.Add(newOrderInvoice);
            _dbManager.AddOrderInvoice(newOrderInvoice);
        }

        private List<OrderInvoices> GetSelectedInvoicesFromGrid()
        {
            var selectedInvoices = new List<OrderInvoices>();
            foreach (DataGridViewRow row in dgvProducts.SelectedRows)
            {
                if (row.DataBoundItem is OrderInvoices invoice)
                {
                    selectedInvoices.Add(invoice);
                }
            }
            return selectedInvoices;
        }

        private int GetSelectedProductId()
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dgvProducts.SelectedRows[0];
                if (selectedRow.DataBoundItem is Products product)
                {
                    return product.ProductId;
                }
            }
            throw new InvalidOperationException("Please select a valid product.");
        }
    }
}
