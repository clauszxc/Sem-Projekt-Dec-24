using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem_Projekt_Dec_24.Winforms;
using Sem_Projekt_Dec_24.Tables;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Sem_Projekt_Dec_24.Data
{
    public class DatabaseManager
    {
        private readonly string _connectionString;
        public BindingList<Products> ProductList { get; set; } = new BindingList<Products>();


        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Create methods for actors
        public void AddEmployee(Employees employee)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =
                    "INSERT INTO Employees (EmployeeId, EmployeeEmail, EmployeeFirstName, EmployeeLastName) " +
                    "VALUES (@EmployeeId, @EmployeeEmail, @EmployeeFirstName, @EmployeeLastName)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                    command.Parameters.AddWithValue("@EmployeeEmail", employee.EmployeeEmail);
                    command.Parameters.AddWithValue("@EmployeeFirstName", employee.EmployeeFirstName);
                    command.Parameters.AddWithValue("@EmployeeLastName", employee.EmployeeLastName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddCustomer(Customers customer)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =
                    "INSERT INTO Customers (CustomerId, CustomerEmail, CustomerAdress) " +
                    "VALUES (@CustomerId, @CustomerEmail, @CustomerAdress)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                    command.Parameters.AddWithValue("@CustomerEmail", customer.CustomerEmail);
                    command.Parameters.AddWithValue("@CustomerAdress", customer.CustomerAdress);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Create methods for storage
        public void AddOrder(Orders order)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =
                    "INSERT INTO Orders (OrderId, CustomerId, ShipperId, OrderStatus) " +
                    "VALUES (@OrderId, @CustomerId, @ShipperId, @OrderStatus)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", order.OrderId);
                    command.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                    command.Parameters.AddWithValue("@ShipperId", order.ShipperId);
                    command.Parameters.AddWithValue("@OrderStatus", order.OrderStatus);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddOrderInvoice(OrderInvoices orderInvoice)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =
                    "INSERT INTO OrderInvoices (OrderInvoiceId, CustomerId, ProductId, Price, Quantity) " +
                    "VALUES (@OrderInvoiceId, @CustomerId, @ProductId, @Price, @Quantity)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderInvoiceId", orderInvoice.OrderInvoiceId);
                    command.Parameters.AddWithValue("@CustomerId", orderInvoice.CustomerId);
                    command.Parameters.AddWithValue("@ProductId", orderInvoice.ProductId);
                    command.Parameters.AddWithValue("@Price", orderInvoice.Price);
                    command.Parameters.AddWithValue("@Quantity", orderInvoice.Quantity);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddItemsToStorage(Items items)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =
                    "INSERT INTO Items (ItemId, ItemName, ItemCategory, ItemStock)" +
                    "VALUES (@ItemId, @ItemName, @ItemCategory, @ItemStock";
                using (SqlCommand command = new SqlCommand(_connectionString, connection))
                {
                    command.Parameters.AddWithValue("@ItemId", items.ItemId);
                    command.Parameters.AddWithValue("@ItemName", items.ItemName);
                    command.Parameters.AddWithValue("@ItemCategory", items.ItemCategory);
                    command.Parameters.AddWithValue("@ItemStock", 0);
                }
            }
        }

        public void AddProductToStorage(Products products)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =
                    "INSERT INTO Products(ProductId, ProductName, ProductCategory, ProductStock" +
                    "VALUES (@ProductId, @ProductName, @ProductCategory, @ProductStock)";
                using (SqlCommand command = new SqlCommand(_connectionString, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", products.ProductId);
                    command.Parameters.AddWithValue("@ProductName", products.ProductName);
                    command.Parameters.AddWithValue("@ProductCategory", products.ProductName);
                    command.Parameters.AddWithValue("@ProductStock", 0);
                }
            }
        }

        // Read methods for actors
        public List<Customers> GetCustomers()
        {
            List<Customers> customerList = new List<Customers>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Customers";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customers e = new Customers(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2)
                            );

                            customerList.Add(e);
                        }
                    }
                }
            }
            return customerList;
        }

        // Read methods for storage
        public List<Products> GetProducts()
        {
            List<Products> productList = new List<Products>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Products";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Products e = new Products(
                                reader.GetInt32(0),
                                reader.GetString(1), 
                                reader.GetString(2),
                                reader.GetInt32(3)
                            );

                            productList.Add(e);
                        }
                    }
                }
            }
            return productList;
        }
        public List<Items> GetItems()
        {
            List<Items> itemList = new List<Items>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Items";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Items e = new Items(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetInt32(3)
                            );

                            itemList.Add(e);
                        }
                    }
                }
            }
            return itemList;
        }

        public List<Orders> GetOrders()
        {
            List<Orders> orderList = new List<Orders>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Orders";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Orders e = new Orders(
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetString(3)
                            );

                            orderList.Add(e);
                        }
                    }
                }
            }
            return orderList;
        }

        public List<OrderInvoices> GetOrderInvoices()
        {
            List<OrderInvoices> orderInvoiceList = new List<OrderInvoices>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM OrderInvoices";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderInvoices e = new OrderInvoices(
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetDecimal(3),
                                reader.GetInt32(4)
                            );

                            orderInvoiceList.Add(e);
                        }
                    }
                }
            }
            return orderInvoiceList;
        }

        // Update methods for actors
        public void UpdateEmployee(string employeeEmail, string employeeFirstName, string employeeLastName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Employees SET EmployeeEmail = @EmployeeEmail, EmployeeFirstName = @EmployeeFirstName, EmployeeLastName = @EmployeeLastName" +
                                "WHERE EmployeeId = @EmployeeId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employees e = new Employees(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)
                            );
                        }
                    }
                }
            }
        }
        public void UpdateCustomer(string customerEmail, string customerAdress)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Customers SET CustomerEmail = @CustomerEmail, CustomerAdress = @CustomerAdress" +
                                "WHERE CustomerId = @CustomerId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customers e = new Customers(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2)
                            );
                        }
                    }
                }
            }
        }
        // Update Methods for Storage
        public void UpdateItemsInStorage(int txtbStorageItemsIdInt, string txtbStorageItemsNameString, string txtbStorageItemsCategoryString, int itemStockPre)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Items SET ItemName = @ItemName, ItemCategory = @ItemCategory"+
                                "WHERE ItemId = @ItemId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Items e = new Items(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetInt32(3)
                            );
                        }
                    }
                }
            }
        }
        public void UpdateProductsInStorage(int productId, string productName, string productCategory)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Products SET ProductName = @ProductName, ProductCategory = @ProductCategory" +
                                "WHERE ProductId = @ProductId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Products e = new Products(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetInt32(3)
                            );
                        }
                    }
                }
            }
        }

        // Delete methods for Actors
        public void DeleteEmployee(Employees employee)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =
                    "DELETE FROM Employees " +
                    "WHERE EmployeeId = @EmployeeId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId.ToString());
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCustomer(Customers customer)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =
                    "DELETE FROM Customers " +
                    "WHERE EmployeeId = @CustomerId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customer.CustomerId.ToString());
                    command.ExecuteNonQuery();
                }
            }
        }
        // Delete Methods for Storage
        public void DeleteItemsInStorage(Items items)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =
                    "DELETE FROM Items " +
                    "WHERE ItemId = @ItemId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemId", items.ItemId.ToString());
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteProductsInStorage(Products products)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =
                    "DELETE FROM Products " +
                    "WHERE ProductId = @ProductId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", products.ProductId.ToString());
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}