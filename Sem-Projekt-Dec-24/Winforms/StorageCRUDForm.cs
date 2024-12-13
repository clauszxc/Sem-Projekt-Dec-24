using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout.Element;
using iText.Layout.Properties;
using Sem_Projekt_Dec_24.Data;
using Sem_Projekt_Dec_24.Tables;
using Sem_Projekt_Dec_24.Winforms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.Kernel.Pdf.Canvas.Draw;
using Sem_Projekt_Dec_24.Tables;

namespace Sem_Projekt_Dec_24.Winforms
{
    public partial class StorageCRUDForm : Form
    {
        private readonly string _connectionString;

        private readonly DatabaseManager _dbManager;
        public BindingList<Products> ProductList { get; set; } = new BindingList<Products>();
        public BindingList<Items> ItemList { get; set; } = new BindingList<Items>();

        // Connect and Load List
        public StorageCRUDForm()
        {
            InitializeComponent();
            string connectionString = "Server=mssql2.unoeuro.com;Database=ferrariconnie_dk_db_semprojectdb;User Id=ferrariconnie_dk;Password=bkngcw5BmR6DEx2ep4a3;";
            _connectionString = connectionString;
            _dbManager = new DatabaseManager(connectionString);

            LoadProducts();
            dgvStorageProducts.DataSource = ProductList;

            LoadItems();
            dgvStorageItems.DataSource = ItemList;

            for (int i = 1; i <= 25; i++)
            {
                cmbAmount.Items.Add(i);
            }
            cmbAmount.SelectedIndex = 0;
        }

        // Loading Products Method
        private void LoadProducts()
        {
            List<Products> productsFromDB = _dbManager.GetProducts();
            foreach (var product in productsFromDB)
            {
                ProductList.Add(product);
            }
        }

        // Loading Items Method
        private void LoadItems()
        {
            List<Items> itemsFromDB = _dbManager.GetItems();
            foreach (var item in itemsFromDB)
            {
                ItemList.Add(item);
            }
        }

        // Go Back Button
        private void btnStorageGoBack_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.StartPosition = FormStartPosition.CenterScreen;
            employeeForm.Show();
            this.Hide();
        }

        // Clear Fields
        private void ClearInputFields()
        {
            txtbStorageItemsId.Clear();
            txtbStorageItemsName.Clear();
            txtbStorageItemsCategory.Clear();
        }

        // Create Item
        private void btnStorageItemsCreate_Click(object sender, EventArgs e)
        {
            string txtbStorageItemsIdString = txtbStorageItemsId.Text;
            string txtbStorageItemsNameString = txtbStorageItemsName.Text;
            string txtbStorageItemsCategoryString = txtbStorageItemsCategory.Text;

            int txtbStorageItemsIdInt;

            if (!int.TryParse(txtbStorageItemsIdString, out txtbStorageItemsIdInt))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            var existingItem = ItemList.FirstOrDefault(i => i.ItemId == txtbStorageItemsIdInt);

            if (existingItem != null)
            {
                MessageBox.Show("Item with this ID already exists.");
                ClearInputFields();
                return;
            }

            txtbStorageItemsIdInt = ItemList.Count > 0 ? ItemList.Max(c => c.ItemId) + 1 : 1;

            Items newItems = new Items(txtbStorageItemsIdInt, txtbStorageItemsNameString, txtbStorageItemsCategoryString, 0);

            ItemList.Add(newItems);

            try
            {
                _dbManager.AddItemsToStorage(newItems);
                MessageBox.Show("Item added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the item: {ex.Message}");
            }

            ClearInputFields();
        }

        // Update Item
        private void btnStorageItemsUpdate_Click(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(txtbStorageItemsId.Text);
            string itemName = txtbStorageItemsName.Text;
            string itemCategory = txtbStorageItemsCategory.Text;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT itemStock FROM Items WHERE ItemId = @ItemId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItemId", itemId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int itemStock = Convert.ToInt32(reader["ItemStock"]);

                    _dbManager.UpdateItemsInStorage(itemId, itemName, itemCategory);

                    var itemToUpdate = ItemList.FirstOrDefault(p => p.ItemId == itemId);
                    if (itemToUpdate != null)
                    {
                        itemToUpdate.ItemName = itemName;
                        itemToUpdate.ItemCategory = itemCategory;
                        itemToUpdate.ItemStock = itemStock;

                        dgvStorageItems.DataSource = null;
                        dgvStorageItems.DataSource = ItemList;
                        dgvStorageItems.Refresh();
                    }

                    MessageBox.Show("Item updated successfully.");
                }
                else
                {
                    MessageBox.Show("Item not found.");
                }

                reader.Close();
            }
        }

        // Delete Item
        private void btnStorageItemsDelete_Click(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(txtbStorageItemsId.Text);

            var itemToDelete = ItemList.FirstOrDefault(i => i.ItemId == itemId);
            if (itemToDelete == null)
            {
                MessageBox.Show("Item not found in the list.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM Items WHERE ItemId = @ItemId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ItemId", itemId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ItemList.Remove(itemToDelete);

                        dgvStorageItems.DataSource = null;
                        dgvStorageItems.DataSource = ItemList;
                        dgvStorageItems.Refresh();

                        MessageBox.Show("Item deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Item not found in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the item: {ex.Message}");
            }
        }

        //Create Product
        private void btnStorageProductsCreate_Click(object sender, EventArgs e)
        {
            string txtbStorageProductsIdString = txtbStorageProductsId.Text;
            string txtbStorageProductsNameString = txtbStorageProductsName.Text;
            string txtbStorageProductsCategoryString = txtbStorageProductsCategory.Text;

            int txtbStorageProductsIdInt;

            if (!int.TryParse(txtbStorageProductsIdString, out txtbStorageProductsIdInt))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            var existingProduct = ProductList.FirstOrDefault(i => i.ProductId == txtbStorageProductsIdInt);

            if (existingProduct != null)
            {
                MessageBox.Show("Product with this ID already exists.");
                ClearInputFields();
                return;
            }

            txtbStorageProductsIdInt = ProductList.Count > 0 ? ProductList.Max(c => c.ProductId) + 1 : 1;

            Products newProducts = new Products(txtbStorageProductsIdInt, txtbStorageProductsNameString, txtbStorageProductsCategoryString, 0);

            ProductList.Add(newProducts);

            try
            {
                _dbManager.AddProductToStorage(newProducts);
                MessageBox.Show("Product added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the Product: {ex.Message}");
            }

            ClearInputFields();
        }

        // Update Product
        private void btnStorageProductsUpdate_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(txtbStorageProductsId.Text);
            string productName = txtbStorageProductsName.Text;
            string productCategory = txtbStorageProductsCategory.Text;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT ProductStock FROM Products WHERE ProductId = @ProductId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductId", productId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int productStock = Convert.ToInt32(reader["ProductStock"]);

                    _dbManager.UpdateProductsInStorage(productId, productName, productCategory);

                    var productToUpdate = ProductList.FirstOrDefault(p => p.ProductId == productId);
                    if (productToUpdate != null)
                    {
                        productToUpdate.ProductName = productName;
                        productToUpdate.ProductCategory = productCategory;
                        productToUpdate.ProductStock = productStock;

                        dgvStorageProducts.DataSource = null;
                        dgvStorageProducts.DataSource = ProductList;
                        dgvStorageProducts.Refresh();
                    }

                    MessageBox.Show("Product updated successfully.");
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }

                reader.Close();
            }
        }

        // Delete Product
        private void btnStorageProductsDelete_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(txtbStorageProductsId.Text);

            // Check if the product exists in the list first
            var productToDelete = ProductList.FirstOrDefault(p => p.ProductId == productId);
            if (productToDelete == null)
            {
                MessageBox.Show("Product not found in the list.");
                return;
            }

            // Confirm deletion with the user
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM Products WHERE ProductId = @ProductId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductId", productId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ProductList.Remove(productToDelete);

                        dgvStorageProducts.DataSource = null;
                        dgvStorageProducts.DataSource = ProductList;
                        dgvStorageProducts.Refresh();

                        MessageBox.Show("Product deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Product not found in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the product: {ex.Message}");
            }
        }

        private void btnCreateStorageReport_Click(object sender, EventArgs e)
        {
            CreateStorageReport();
        }

        private void CreateStorageReport()
        {
            List<Items> itemsFromDBToReport = _dbManager.GetItems();
            List<Products> productsFromDBToReport = _dbManager.GetProducts();

            string fileName = "Storage_Report.pdf";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                Document document = new Document(pdf);

                Paragraph header = new Paragraph("Storage Report")
                    .SetFontSize(20)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontColor(ColorConstants.BLACK);
                document.Add(header);

                Paragraph date = new Paragraph($"Date: {DateTime.Now:dd-MM-yyyy}")
                    .SetFontSize(14)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetMarginTop(20);
                document.Add(date);

                LineSeparator separator = new LineSeparator(new SolidLine(1));
                document.Add(separator);

                Table table = new Table(5);
                table.AddHeaderCell("Type");
                table.AddHeaderCell("ID");
                table.AddHeaderCell("Name");
                table.AddHeaderCell("Category");
                table.AddHeaderCell("Stock");

                var allStorage = new List<object>();
                allStorage.AddRange(ItemList);
                allStorage.AddRange(ProductList);

                foreach (var item in allStorage)
                {
                    if (item is Items itm)
                    {
                        table.AddCell("Item");
                        table.AddCell(itm.ItemId.ToString());
                        table.AddCell(itm.ItemName);
                        table.AddCell(itm.ItemCategory);
                        table.AddCell(itm.ItemStock.ToString());
                    }
                    else if (item is Products prod)
                    {
                        table.AddCell("Product");
                        table.AddCell(prod.ProductId.ToString());
                        table.AddCell(prod.ProductName);
                        table.AddCell(prod.ProductCategory);
                        table.AddCell(prod.ProductStock.ToString());
                    }
                }

                document.Add(table);

                Paragraph footer = new Paragraph("List of all items and products currently in storage.")
                    .SetFontSize(14)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetMarginTop(30);
                document.Add(footer);
            }

            MessageBox.Show($"PDF Invoice created at: {filePath}");
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            if (dgvStorageProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product from the list.");
                return;
            }

            if (cmbAmount.SelectedItem == null)
            {
                MessageBox.Show("Please select an amount.");
                return;
            }

            var selectedRow = dgvStorageProducts.SelectedRows[0];
            var selectedProduct = (Products)selectedRow.DataBoundItem;
            if (selectedRow.DataBoundItem is Products product)
            {
                selectedProduct = product;
            }
            else
            {
                MessageBox.Show("Selected row does not contain a valid product.");
                return;
            }
            string ChosenAmount = cmbAmount.SelectedItem.ToString();
            int selectedAmount = 1 * Int32.Parse(ChosenAmount);
            try
            {
                foreach (var item in ItemList)
                {
                    if (item.ItemStock <= 0)
                    {
                        MessageBox.Show("There is not enough items to create the product");
                    }
                    else
                    {
                        item.ItemStock = item.ItemStock - selectedAmount;
                        _dbManager.UpdateItemStockDown(item.ItemId, item.ItemStock);
                    }
                }
                selectedProduct.ProductStock = selectedProduct.ProductStock + selectedAmount;
                _dbManager.UpdateProductStockUp(selectedProduct.ProductId, selectedProduct.ProductStock);

                dgvStorageItems.DataSource = null;
                dgvStorageItems.DataSource = ItemList;
                dgvStorageItems.Refresh();

                dgvStorageProducts.DataSource = null;
                dgvStorageProducts.DataSource = ProductList;
                dgvStorageProducts.Refresh();

                MessageBox.Show("Product added successfully and items removed from storage.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the product: {ex.Message}");
            }
        }
    }
}