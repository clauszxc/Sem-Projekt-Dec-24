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
    public partial class StorageCRUDForm : Form
    {
        public StorageCRUDForm()
        {
            InitializeComponent();
        }

        private void btnStorageGoBack_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.StartPosition = FormStartPosition.CenterScreen;
            employeeForm.Show();
            this.Hide();
        }

        private void btnStorageItemsCreate_Click(object sender, EventArgs e)
        {
            string txtbStorageItemsIdString = txtbStorageItemsId.Text;
            string txtbStorageItemsNameString = txtbStorageItemsName.Text;
            string txtbStorageItemsCategoryString = txtbStorageItemsCategory.Text;

            try
            {
                int txtbStorageItemsIdInt = Convert.ToInt32(txtbStorageItemsIdString);

            }
            catch
            {

            }
        }
    }
}
