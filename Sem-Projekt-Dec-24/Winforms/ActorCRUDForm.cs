﻿using System;
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
    public partial class ActorCRUDForm : Form
    {
        private readonly string _connectionString;

        private readonly DatabaseManager _dbManager;
        public ActorCRUDForm()
        {
            InitializeComponent();
            string connectionString = "Server=mssql2.unoeuro.com;Database=ferrariconnie_dk_db_semprojectdb;User Id=ferrariconnie_dk;Password=bkngcw5BmR6DEx2ep4a3;";
            _dbManager = new DatabaseManager(connectionString);
        }

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

        private void btnActorGoBack_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.StartPosition = FormStartPosition.CenterScreen;
            employeeForm.Show();
            this.Hide();
        }

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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                ClearInputFields();
            }
        }
    }
}
