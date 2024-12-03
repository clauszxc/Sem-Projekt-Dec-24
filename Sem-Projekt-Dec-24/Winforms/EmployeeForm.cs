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
        public EmployeeForm()
        {
            InitializeComponent();
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
    }
}
