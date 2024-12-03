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
    public partial class CustomerConfirmationForm : Form
    {
        public CustomerConfirmationForm()
        {
            InitializeComponent();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm2 = new CustomerForm();
            customerForm2.StartPosition = FormStartPosition.CenterScreen;
            customerForm2.Show();
            this.Hide();
        }

        private void btnCustomerGoBack_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.StartPosition = FormStartPosition.CenterScreen;
            customerForm.Show();
            this.Hide();
        }

       
    }
}
