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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtbAdress.Text) || string.IsNullOrWhiteSpace(txtbEmail.Text) || string.IsNullOrWhiteSpace(txtbQuantity.Text))
            {
                MessageBox.Show("All fields must be filled in before proceeding.");
                return;
            }

            CustomerConfirmationForm customerConfirmationForm = new CustomerConfirmationForm();
            customerConfirmationForm.StartPosition = FormStartPosition.CenterScreen;
            customerConfirmationForm.Show();
            this.Hide();
        }
    }
}
