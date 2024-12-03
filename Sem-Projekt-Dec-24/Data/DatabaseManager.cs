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
                    command.Parameters.AddWithValue("@CustomerId", order.OrderId);
                    command.Parameters.AddWithValue("@CustomerEmail", order.CustomerId);
                    command.Parameters.AddWithValue("@CustomerAdress", order.ShipperId);
                    command.Parameters.AddWithValue("@CustomerAdress", order.OrderStatus);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}