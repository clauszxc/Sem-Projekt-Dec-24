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

            //string connectionString = "Server=localhost;Database=SemProjectDB;Encryption=Optional;TrustServerCertificate=true;";
            string connectionString = "Server=localhost;Database=SemProjectDB;Trusted_Connection=True;TrustServerCertificate=True;";

            _dbManager = new DatabaseManager(connectionString);

            LoadProducts();
            dgvProducts.DataSource = ProductList;
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
            int customerId = 1;
            string customerAdress = txtbAdress.Text;
            string customerEmail = txtbEmail.Text;

            for (int i = 0; i < CustomerList.Count; i++)
            {
                if (CustomerList[i].CustomerEmail == customerEmail)
                {
                    customerId = CustomerList[i].CustomerId;
                    ClearInputFields();
                    return;
                }
                else
                {
                    customerId = CustomerList.Count > 0 ? CustomerList.Max(c => c.CustomerId) + 1 : 1;

                    Customers newCustomer = new Customers(customerId, customerEmail, customerAdress);

                    CustomerList.Add(newCustomer);
                    _dbManager.AddCustomer(newCustomer);

                    ClearInputFields();
                    return;
                }

            }

            int orderId = 1;
            int shipperId = 1;
            string orderStatus = "Ongoing";

            for (int i = 0; i < OrderList.Count; i++)
            {
                if (OrderList[i].OrderId == orderId)
                {
                    orderId = OrderList[i].OrderId;
                    ClearInputFields();
                    return;
                }
                else
                {
                    orderId = OrderList.Count > 0 ? OrderList.Max(c => c.OrderId) + 1 : 1;

                    Orders newOrder = new Orders(orderId, customerId, shipperId, orderStatus);

                    OrderList.Add(newOrder);
                    _dbManager.AddOrder(newOrder);

                    ClearInputFields();
                    return;
                }

            }

            int orderInvoiceId = 1;
            int productId = 1;
            decimal price = 1;
            int quantity = Convert.ToInt32(txtbQuantity.Text);

            for (int i = 0; i < OrderInvoiceList.Count; i++)
            {
                if (OrderInvoiceList[i].OrderInvoiceId == orderInvoiceId)
                {
                    orderInvoiceId = OrderInvoiceList[i].OrderInvoiceId;
                    ClearInputFields();
                    return;
                }
                else
                {
                    orderId = OrderInvoiceList.Count > 0 ? OrderInvoiceList.Max(c => c.OrderInvoiceId) + 1 : 1;

                    OrderInvoices newOrderInvoice = new OrderInvoices(orderInvoiceId, customerId, productId, price, quantity);

                    OrderInvoiceList.Add(newOrderInvoice);
                    _dbManager.AddOrderInvoice(newOrderInvoice);

                    ClearInputFields();
                    return;
                }

            }

            //if (string.IsNullOrWhiteSpace(txtbAdress.Text) || string.IsNullOrWhiteSpace(txtbEmail.Text) || string.IsNullOrWhiteSpace(txtbQuantity.Text))
            //{
            //    MessageBox.Show("All fields must be filled in before proceeding.");
            //    return;
            //}

            //CustomerConfirmationForm customerConfirmationForm = new CustomerConfirmationForm();
            //customerConfirmationForm.StartPosition = FormStartPosition.CenterScreen;
            //customerConfirmationForm.Show();
            //this.Hide();

            ClearInputFields();

        }
    }
}
