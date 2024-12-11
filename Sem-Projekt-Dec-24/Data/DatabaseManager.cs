using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem_Projekt_Dec_24.Winforms;
using Sem_Projekt_Dec_24.Tables;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Windows.Forms;

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
                string query = @"
            INSERT INTO Items (ItemId, ItemName, ItemCategory, ItemStock)
            VALUES (@ItemId, @ItemName, @ItemCategory, @ItemStock)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemId", items.ItemId);
                    command.Parameters.AddWithValue("@ItemName", items.ItemName);
                    command.Parameters.AddWithValue("@ItemCategory", items.ItemCategory);
                    command.Parameters.AddWithValue("@ItemStock", 0);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddProductToStorage(Products products)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =@"
                    INSERT INTO Products (ProductId, ProductName, ProductCategory, ProductStock)
                    VALUES (@ProductId, @ProductName, @ProductCategory, @ProductStock)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", products.ProductId);
                    command.Parameters.AddWithValue("@ProductName", products.ProductName);
                    command.Parameters.AddWithValue("@ProductCategory", products.ProductCategory);
                    command.Parameters.AddWithValue("@ProductStock", 0);
                    command.ExecuteNonQuery();
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

        public List<Employees> GetEmployees()
        {
            List<Employees> EmployeesList = new List<Employees>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Employees";
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

                            EmployeesList.Add(e);
                        }
                    }
                }
            }
            return EmployeesList;
        }

        public List<Shippers> GetShippers()
        {
            List<Shippers> ShippersList = new List<Shippers>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Shippers";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Shippers e = new Shippers(
                                reader.GetInt32(0),
                                reader.GetString(1)
                            );

                            ShippersList.Add(e);
                        }
                    }
                }
            }
            return ShippersList;
        }

        public List<Suppliers> GetSuppliers()
        {
            List<Suppliers> SuppliersList = new List<Suppliers>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Suppliers";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Suppliers e = new Suppliers(
                                reader.GetInt32(0)
                            );

                            SuppliersList.Add(e);
                        }
                    }
                }
            }
            return SuppliersList;
        }

        public List<PurchaseOrders> GetPurchaseOrders()
        {
            List<PurchaseOrders> PurchaseOrderList = new List<PurchaseOrders>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM PurchaseOrders";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PurchaseOrders e = new PurchaseOrders(
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetInt32(3)
                            );

                            PurchaseOrderList.Add(e);
                        }
                    }
                }
            }
            return PurchaseOrderList;
        }

        public List<Shipments> GetShipments()
        {
            List<Shipments> Shipmentlist = new List<Shipments>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Shipments";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Shipments e = new Shipments(
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetInt32(3),
                                reader.GetString(4),
                                reader.GetString(5)
                            );

                            Shipmentlist.Add(e);
                        }
                    }
                }
            }
            return Shipmentlist;
        }

        // Update methods for actors
        public void UpdateActor(int actorId, string employeeEmail, string employeeFirstName, string employeeLastName, string shipperName, string customerEmail, string customerAdress)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string tableToUpdate = GetTableToUpdate(employeeEmail, customerAdress, shipperName);
                string query = MakeUpdateQuery(tableToUpdate, employeeEmail, employeeFirstName, employeeLastName, shipperName, customerEmail, customerAdress);

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", actorId);

                    if (tableToUpdate == "Employees")
                    {
                        if (!string.IsNullOrEmpty(employeeEmail))
                            command.Parameters.AddWithValue("@EmployeeEmail", employeeEmail);
                        if (!string.IsNullOrEmpty(employeeFirstName)) 
                            command.Parameters.AddWithValue("@EmployeeFirstName", employeeFirstName);
                        if (!string.IsNullOrEmpty(employeeLastName))
                            command.Parameters.AddWithValue("@EmployeeLastName", employeeLastName);
                    }
                    else if (tableToUpdate == "Shippers")
                    {
                        if (!string.IsNullOrEmpty(shipperName)) 
                            command.Parameters.AddWithValue("@ShipperName", shipperName);
                    }
                    else if (tableToUpdate == "Customers")
                    {
                        if (!string.IsNullOrEmpty(customerEmail)) 
                            command.Parameters.AddWithValue("@CustomerEmail", customerEmail);
                        if (!string.IsNullOrEmpty(customerAdress)) 
                            command.Parameters.AddWithValue("@CustomerAdress", customerAdress);
                    }

                    command.ExecuteNonQuery();
                }
            }
        }

        private string GetTableToUpdate(string employeeEmail, string customerEmail, string shipperName)
        {
            if (string.IsNullOrEmpty(employeeEmail) && string.IsNullOrEmpty(customerEmail) && string.IsNullOrEmpty(shipperName))
            {
                MessageBox.Show($"der skete en fucking fejl");
                return "Employees";
            }

            if (!string.IsNullOrEmpty(employeeEmail))
            {
                return "Employees";
            }

            if (!string.IsNullOrEmpty(customerEmail))
            {
                return "Customers";
            }

            if (!string.IsNullOrEmpty(shipperName))
            {
                return "Shippers";
            }

            throw new ArgumentException("Can't determine table");
        }

        private string MakeUpdateQuery(string tableName, string employeeEmail, string employeeFirstName, string employeeLastName, string shipperName, string customerEmail, string customerAdress)
        {
            string setClause = string.Empty;

            if (tableName == "Employees")
            {
                if (!string.IsNullOrEmpty(employeeEmail)) setClause += "EmployeeEmail = @EmployeeEmail, ";
                if (!string.IsNullOrEmpty(employeeFirstName)) setClause += "EmployeeFirstName = @EmployeeFirstName, ";
                if (!string.IsNullOrEmpty(employeeLastName)) setClause += "EmployeeLastName = @EmployeeLastName, ";

                setClause = setClause.TrimEnd(',', ' ');

                return $"UPDATE Employees SET {setClause} WHERE EmployeeId = @Id";
            }

            else if (tableName == "Shippers")
            {
                if (!string.IsNullOrEmpty(shipperName)) setClause += "ShipperName = @ShipperName, ";

                setClause = setClause.TrimEnd(',', ' ');

                return $"UPDATE Shippers SET {setClause} WHERE ShipperId = @Id";
            }

            else if (tableName == "Customers")
            {
                if (!string.IsNullOrEmpty(customerEmail)) setClause += "CustomerEmail = @CustomerEmail, ";
                if (!string.IsNullOrEmpty(customerAdress)) setClause += "CustomerAdress = @CustomerAdress, ";

                setClause = setClause.TrimEnd(',', ' ');

                return $"UPDATE Customers SET {setClause} WHERE CustomerId = @Id";
            }

            throw new ArgumentException("Invalid table name.");
        }

        // Update Methods for Storage
        public void UpdateItemStock (int itemId, int itemQuantity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =  "UPDATE Items SET ItemStock = ItemStock + @ItemQuantity " +
                                "WHERE ItemId = @ItemId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemQuantity", itemQuantity);
                    command.Parameters.AddWithValue("@ItemId", itemId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new InvalidOperationException("Insufficient stock or invalid item ID.");
                    }
                }
            };
        }
        public void UpdateProductStock(int productId, int productQuantity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Products SET ProductStock = ProductStock - @ProductQuantity " +
                                "WHERE ProductId = @ProductId AND ProductStock >= @ProductQuantity";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductQuantity", productQuantity);
                    command.Parameters.AddWithValue("@ProductId", productId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new InvalidOperationException("Insufficient stock or invalid product ID.");
                    }
                }
            };
        }
        public void UpdateItemsInStorage(int itemId, string itemName, string itemCategory)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Items SET ItemName = @ItemName, ItemCategory = @ItemCategory " +
                                "WHERE ItemId = @ItemId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemId", itemId);
                    command.Parameters.AddWithValue("@ItemName", itemName);
                    command.Parameters.AddWithValue("@ItemCategory", itemCategory);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Item update failed or no changes made.");
                    }
                }
            }
        }

        public void UpdateProductsInStorage(int productId, string productName, string productCategory)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Products SET ProductName = @ProductName, ProductCategory = @ProductCategory " +
                                "WHERE ProductId = @ProductId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ProductCategory", productCategory);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Product update failed or no changes made.");
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
        public void DeleteProductsInStorage(int productId, string productName, string productCategory)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query =
                    "DELETE FROM Products " +
                    "WHERE ProductId = @ProductId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}