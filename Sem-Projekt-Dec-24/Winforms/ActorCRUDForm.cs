using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sem_Projekt_Dec_24.Data;
using Sem_Projekt_Dec_24.Tables;
using Sem_Projekt_Dec_24.Winforms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sem_Projekt_Dec_24.Winforms
{
    public partial class ActorCRUDForm : Form
    {
        private readonly string _connectionString;
        public BindingList<Customers> CustomerList { get; set; } = new BindingList<Customers>();
        public BindingList<Employees> EmployeeList { get; set; } = new BindingList<Employees>();
        public BindingList<Shippers> ShipperList { get; set; } = new BindingList<Shippers>();

        private readonly DatabaseManager _dbManager;
        public ActorCRUDForm()
        {
            InitializeComponent();
            _connectionString = "Server=mssql2.unoeuro.com;Database=ferrariconnie_dk_db_semprojectdb;User Id=ferrariconnie_dk;Password=bkngcw5BmR6DEx2ep4a3;";
            _dbManager = new DatabaseManager(_connectionString);
        }

        private void LoadEmployees()
        {
            List<Employees> employeesFromDB = _dbManager.GetEmployees();
            foreach (var employee in employeesFromDB)
            {
                EmployeeList.Add(employee);
            }
        }

        private void LoadShippers()
        {
            List<Shippers> shippersFromDB = _dbManager.GetShippers();
            foreach (var shipper in shippersFromDB)
            {
                ShipperList.Add(shipper);
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

        // Combobox
        private void cmbbChooseActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedActor.Text = cmbbChooseActor.Text;
            if (cmbbChooseActor.SelectedItem.ToString() == "Employees")
            {
                EmployeeList.Clear();
                LoadEmployees();
                dgvActor.DataSource = null;
                dgvActor.DataSource = EmployeeList;
            }
            if (cmbbChooseActor.SelectedItem.ToString() == "Shippers")
            {
                ShipperList.Clear();
                LoadShippers();
                dgvActor.DataSource = null;
                dgvActor.DataSource = ShipperList;
            }
            if (cmbbChooseActor.SelectedItem.ToString() == "Customers")
            {
                CustomerList.Clear();
                LoadCustomers();
                dgvActor.DataSource = null;
                dgvActor.DataSource = CustomerList;
            }
        }

        //Clear Input Fields
        private void ClearInputFields()
        {
            txtbActorId.Clear();
            txtbActorEmployeeEmail.Clear();
            txtbActorEmployeeFirstName.Clear();
            txtbActorEmployeeLastName.Clear();
            txtbActorShipperName.Clear();
            txtbActorCustomerEmail.Clear();
            txtbActorCustomerAdress.Clear();
        }

        // Go Back Button
        private void btnActorGoBack_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.StartPosition = FormStartPosition.CenterScreen;
            employeeForm.Show();
            this.Hide();
        }

        // Update Actor
        private void btnActorUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int actorId = int.Parse(txtbActorId.Text);
                string employeeEmail = txtbActorEmployeeEmail.Text;
                string employeeFirstName = txtbActorEmployeeFirstName.Text;
                string employeeLastName = txtbActorEmployeeLastName.Text;
                string shipperName = txtbActorShipperName.Text;
                string customerEmail = txtbActorCustomerEmail.Text;
                string customerAdress = txtbActorCustomerAdress.Text;

                _dbManager.UpdateActor(actorId, employeeEmail, employeeFirstName, employeeLastName, shipperName, customerEmail, customerAdress);
                MessageBox.Show("Actor Updated Succesfully");
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                ClearInputFields();
            }
        }

        // Add Actor
        private void btnActorCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string actorIdString = txtbActorId.Text;
                int actorId = int.Parse(txtbActorId.Text);
                string employeeEmail = txtbActorEmployeeEmail.Text;
                string employeeFirstName = txtbActorEmployeeFirstName.Text;
                string employeeLastName = txtbActorEmployeeLastName.Text;
                string shipperName = txtbActorShipperName.Text;
                string customerEmail = txtbActorCustomerEmail.Text;
                string customerAdress = txtbActorCustomerAdress.Text;

                int txtbActorIdInt;

                if (!int.TryParse(actorIdString, out txtbActorIdInt))
                {
                    MessageBox.Show("Please enter a valid ID.");
                    return;
                }
                else
                {
                    _dbManager.AddActor(actorId, employeeEmail, employeeFirstName, employeeLastName, shipperName, customerEmail, customerAdress);
                    MessageBox.Show("Actor Added Succesfully");
                    ClearInputFields();

                    if (employeeEmail != null)
                    {
                        Employees newEmployee = new Employees(actorId, employeeEmail, employeeFirstName, employeeLastName);

                        EmployeeList.Add(newEmployee);

                        dgvActor.DataSource = null;
                        dgvActor.DataSource = EmployeeList;
                        dgvActor.Refresh();
                    }
                    if (shipperName != null)
                    {
                        Shippers newShipper = new Shippers(actorId, shipperName);

                        ShipperList.Add(newShipper);

                        dgvActor.DataSource = null;
                        dgvActor.DataSource = ShipperList;
                        dgvActor.Refresh();
                    }
                    if (customerEmail != null)
                    {
                        Customers newCustomer = new Customers(actorId, customerEmail, customerAdress);

                        CustomerList.Add(newCustomer);

                        dgvActor.DataSource = null;
                        dgvActor.DataSource = CustomerList;
                        dgvActor.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                ClearInputFields();
            }
        }
        
        // Delete Actor
        private void btnActorDelete_Click(object sender, EventArgs e)
        {
            int actorId = Convert.ToInt32(txtbActorId.Text);
            if (!int.TryParse(txtbActorId.Text, out actorId))
            {
                MessageBox.Show("Invalid Actor ID.");
                return;
            }

            if (cmbbChooseActor.SelectedItem.ToString() == "Employees")
            {
                var employeeToDelete = EmployeeList.FirstOrDefault(p => p.EmployeeId == actorId);
                _dbManager.DeleteEmployee(actorId);

                EmployeeList.Remove(employeeToDelete);

                dgvActor.DataSource = null;
                dgvActor.DataSource = EmployeeList;
                dgvActor.Refresh();
            }
            else if (cmbbChooseActor.SelectedItem.ToString() == "Shippers")
            {
                var shipperToDelete = ShipperList.FirstOrDefault(p => p.ShipperId == actorId);
                _dbManager.DeleteShipper(actorId);

                ShipperList.Remove(shipperToDelete);

                dgvActor.DataSource = null;
                dgvActor.DataSource = ShipperList;
                dgvActor.Refresh();
            }
            else if (cmbbChooseActor.SelectedItem.ToString() == "Customers")
            {
                var customerToDelete = CustomerList.FirstOrDefault(p => p.CustomerId == actorId);
                _dbManager.DeleteCustomer(actorId);

                CustomerList.Remove(customerToDelete);

                dgvActor.DataSource = null;
                dgvActor.DataSource = CustomerList;
                dgvActor.Refresh();
            }
            else
            {
                MessageBox.Show("An error has occured. Please try again.");
                return;
            }
        } 
    }
}
