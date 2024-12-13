namespace Sem_Projekt_Dec_24.Winforms
{
    partial class StorageCRUDForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStorageItems = new System.Windows.Forms.DataGridView();
            this.dgvStorageProducts = new System.Windows.Forms.DataGridView();
            this.btnStorageItemsUpdate = new System.Windows.Forms.Button();
            this.btnStorageProductsUpdate = new System.Windows.Forms.Button();
            this.txtbStorageItemsCategory = new System.Windows.Forms.TextBox();
            this.txtbStorageProductsId = new System.Windows.Forms.TextBox();
            this.txtbStorageItemsId = new System.Windows.Forms.TextBox();
            this.txtbStorageItemsName = new System.Windows.Forms.TextBox();
            this.txtbStorageProductsName = new System.Windows.Forms.TextBox();
            this.txtbStorageProductsCategory = new System.Windows.Forms.TextBox();
            this.btnStorageItemsCreate = new System.Windows.Forms.Button();
            this.btnStorageItemsDelete = new System.Windows.Forms.Button();
            this.btnStorageProductsDelete = new System.Windows.Forms.Button();
            this.btnStorageProductsCreate = new System.Windows.Forms.Button();
            this.btnStorageGoBack = new System.Windows.Forms.Button();
            this.btnCreateStorageReport = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.cmbAmount = new System.Windows.Forms.ComboBox();
            this.btnPurchaseItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStorageItems
            // 
            this.dgvStorageItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorageItems.Location = new System.Drawing.Point(1, 196);
            this.dgvStorageItems.Name = "dgvStorageItems";
            this.dgvStorageItems.RowHeadersWidth = 62;
            this.dgvStorageItems.Size = new System.Drawing.Size(386, 254);
            this.dgvStorageItems.TabIndex = 0;
            // 
            // dgvStorageProducts
            // 
            this.dgvStorageProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorageProducts.Location = new System.Drawing.Point(384, 196);
            this.dgvStorageProducts.Name = "dgvStorageProducts";
            this.dgvStorageProducts.RowHeadersWidth = 62;
            this.dgvStorageProducts.Size = new System.Drawing.Size(416, 254);
            this.dgvStorageProducts.TabIndex = 1;
            // 
            // btnStorageItemsUpdate
            // 
            this.btnStorageItemsUpdate.Location = new System.Drawing.Point(144, 103);
            this.btnStorageItemsUpdate.Name = "btnStorageItemsUpdate";
            this.btnStorageItemsUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnStorageItemsUpdate.TabIndex = 2;
            this.btnStorageItemsUpdate.Text = "Update";
            this.btnStorageItemsUpdate.UseVisualStyleBackColor = true;
            this.btnStorageItemsUpdate.Click += new System.EventHandler(this.btnStorageItemsUpdate_Click);
            // 
            // btnStorageProductsUpdate
            // 
            this.btnStorageProductsUpdate.Location = new System.Drawing.Point(570, 103);
            this.btnStorageProductsUpdate.Name = "btnStorageProductsUpdate";
            this.btnStorageProductsUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnStorageProductsUpdate.TabIndex = 3;
            this.btnStorageProductsUpdate.Text = "Update";
            this.btnStorageProductsUpdate.UseVisualStyleBackColor = true;
            this.btnStorageProductsUpdate.Click += new System.EventHandler(this.btnStorageProductsUpdate_Click);
            // 
            // txtbStorageItemsCategory
            // 
            this.txtbStorageItemsCategory.Location = new System.Drawing.Point(12, 153);
            this.txtbStorageItemsCategory.Name = "txtbStorageItemsCategory";
            this.txtbStorageItemsCategory.Size = new System.Drawing.Size(100, 20);
            this.txtbStorageItemsCategory.TabIndex = 4;
            // 
            // txtbStorageProductsId
            // 
            this.txtbStorageProductsId.Location = new System.Drawing.Point(688, 58);
            this.txtbStorageProductsId.Name = "txtbStorageProductsId";
            this.txtbStorageProductsId.Size = new System.Drawing.Size(100, 20);
            this.txtbStorageProductsId.TabIndex = 5;
            // 
            // txtbStorageItemsId
            // 
            this.txtbStorageItemsId.Location = new System.Drawing.Point(13, 58);
            this.txtbStorageItemsId.Name = "txtbStorageItemsId";
            this.txtbStorageItemsId.Size = new System.Drawing.Size(100, 20);
            this.txtbStorageItemsId.TabIndex = 6;
            // 
            // txtbStorageItemsName
            // 
            this.txtbStorageItemsName.Location = new System.Drawing.Point(13, 106);
            this.txtbStorageItemsName.Name = "txtbStorageItemsName";
            this.txtbStorageItemsName.Size = new System.Drawing.Size(100, 20);
            this.txtbStorageItemsName.TabIndex = 7;
            // 
            // txtbStorageProductsName
            // 
            this.txtbStorageProductsName.Location = new System.Drawing.Point(688, 106);
            this.txtbStorageProductsName.Name = "txtbStorageProductsName";
            this.txtbStorageProductsName.Size = new System.Drawing.Size(100, 20);
            this.txtbStorageProductsName.TabIndex = 8;
            // 
            // txtbStorageProductsCategory
            // 
            this.txtbStorageProductsCategory.Location = new System.Drawing.Point(688, 153);
            this.txtbStorageProductsCategory.Name = "txtbStorageProductsCategory";
            this.txtbStorageProductsCategory.Size = new System.Drawing.Size(100, 20);
            this.txtbStorageProductsCategory.TabIndex = 9;
            // 
            // btnStorageItemsCreate
            // 
            this.btnStorageItemsCreate.Location = new System.Drawing.Point(144, 58);
            this.btnStorageItemsCreate.Name = "btnStorageItemsCreate";
            this.btnStorageItemsCreate.Size = new System.Drawing.Size(75, 23);
            this.btnStorageItemsCreate.TabIndex = 10;
            this.btnStorageItemsCreate.Text = "Create";
            this.btnStorageItemsCreate.UseVisualStyleBackColor = true;
            this.btnStorageItemsCreate.Click += new System.EventHandler(this.btnStorageItemsCreate_Click);
            // 
            // btnStorageItemsDelete
            // 
            this.btnStorageItemsDelete.Location = new System.Drawing.Point(144, 150);
            this.btnStorageItemsDelete.Name = "btnStorageItemsDelete";
            this.btnStorageItemsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStorageItemsDelete.TabIndex = 11;
            this.btnStorageItemsDelete.Text = "Delete";
            this.btnStorageItemsDelete.UseVisualStyleBackColor = true;
            this.btnStorageItemsDelete.Click += new System.EventHandler(this.btnStorageItemsDelete_Click);
            // 
            // btnStorageProductsDelete
            // 
            this.btnStorageProductsDelete.Location = new System.Drawing.Point(570, 151);
            this.btnStorageProductsDelete.Name = "btnStorageProductsDelete";
            this.btnStorageProductsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStorageProductsDelete.TabIndex = 12;
            this.btnStorageProductsDelete.Text = "Delete";
            this.btnStorageProductsDelete.UseVisualStyleBackColor = true;
            this.btnStorageProductsDelete.Click += new System.EventHandler(this.btnStorageProductsDelete_Click);
            // 
            // btnStorageProductsCreate
            // 
            this.btnStorageProductsCreate.Location = new System.Drawing.Point(570, 58);
            this.btnStorageProductsCreate.Name = "btnStorageProductsCreate";
            this.btnStorageProductsCreate.Size = new System.Drawing.Size(75, 23);
            this.btnStorageProductsCreate.TabIndex = 13;
            this.btnStorageProductsCreate.Text = "Create";
            this.btnStorageProductsCreate.UseVisualStyleBackColor = true;
            this.btnStorageProductsCreate.Click += new System.EventHandler(this.btnStorageProductsCreate_Click);
            // 
            // btnStorageGoBack
            // 
            this.btnStorageGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnStorageGoBack.Name = "btnStorageGoBack";
            this.btnStorageGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnStorageGoBack.TabIndex = 14;
            this.btnStorageGoBack.Text = "Go Back";
            this.btnStorageGoBack.UseVisualStyleBackColor = true;
            this.btnStorageGoBack.Click += new System.EventHandler(this.btnStorageGoBack_Click);
            // 
            // btnCreateStorageReport
            // 
            this.btnCreateStorageReport.Location = new System.Drawing.Point(328, 167);
            this.btnCreateStorageReport.Name = "btnCreateStorageReport";
            this.btnCreateStorageReport.Size = new System.Drawing.Size(131, 23);
            this.btnCreateStorageReport.TabIndex = 15;
            this.btnCreateStorageReport.Text = "Create Storage Report";
            this.btnCreateStorageReport.UseVisualStyleBackColor = true;
            this.btnCreateStorageReport.Click += new System.EventHandler(this.btnCreateStorageReport_Click);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(328, 12);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(117, 34);
            this.btnCreateProduct.TabIndex = 16;
            this.btnCreateProduct.Text = "Create Products From Items";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // cmbAmount
            // 
            this.cmbAmount.FormattingEnabled = true;
            this.cmbAmount.Location = new System.Drawing.Point(328, 69);
            this.cmbAmount.Name = "cmbAmount";
            this.cmbAmount.Size = new System.Drawing.Size(121, 21);
            this.cmbAmount.TabIndex = 17;
            // 
            // btnPurchaseItem
            // 
            this.btnPurchaseItem.Location = new System.Drawing.Point(328, 138);
            this.btnPurchaseItem.Name = "btnPurchaseItem";
            this.btnPurchaseItem.Size = new System.Drawing.Size(131, 23);
            this.btnPurchaseItem.TabIndex = 16;
            this.btnPurchaseItem.Text = "Purchase Item";
            this.btnPurchaseItem.UseVisualStyleBackColor = true;
            this.btnPurchaseItem.Click += new System.EventHandler(this.btnPurchaseItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Item Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Product ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(688, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(688, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Product Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Item ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Choose the amount of products you wanna make";
            // 
            // StorageCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbAmount);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPurchaseItem);
            this.Controls.Add(this.btnCreateStorageReport);
            this.Controls.Add(this.btnStorageGoBack);
            this.Controls.Add(this.btnStorageProductsCreate);
            this.Controls.Add(this.btnStorageProductsDelete);
            this.Controls.Add(this.btnStorageItemsDelete);
            this.Controls.Add(this.btnStorageItemsCreate);
            this.Controls.Add(this.txtbStorageProductsCategory);
            this.Controls.Add(this.txtbStorageProductsName);
            this.Controls.Add(this.txtbStorageItemsName);
            this.Controls.Add(this.txtbStorageItemsId);
            this.Controls.Add(this.txtbStorageProductsId);
            this.Controls.Add(this.txtbStorageItemsCategory);
            this.Controls.Add(this.btnStorageProductsUpdate);
            this.Controls.Add(this.btnStorageItemsUpdate);
            this.Controls.Add(this.dgvStorageProducts);
            this.Controls.Add(this.dgvStorageItems);
            this.Name = "StorageCRUDForm";
            this.Text = "StorageCRUDForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStorageItems;
        private System.Windows.Forms.DataGridView dgvStorageProducts;
        private System.Windows.Forms.Button btnStorageItemsUpdate;
        private System.Windows.Forms.Button btnStorageProductsUpdate;
        private System.Windows.Forms.TextBox txtbStorageItemsCategory;
        private System.Windows.Forms.TextBox txtbStorageProductsId;
        private System.Windows.Forms.TextBox txtbStorageItemsId;
        private System.Windows.Forms.TextBox txtbStorageItemsName;
        private System.Windows.Forms.TextBox txtbStorageProductsName;
        private System.Windows.Forms.TextBox txtbStorageProductsCategory;
        private System.Windows.Forms.Button btnStorageItemsCreate;
        private System.Windows.Forms.Button btnStorageItemsDelete;
        private System.Windows.Forms.Button btnStorageProductsDelete;
        private System.Windows.Forms.Button btnStorageProductsCreate;
        private System.Windows.Forms.Button btnStorageGoBack;
        private System.Windows.Forms.Button btnCreateStorageReport;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.ComboBox cmbAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPurchaseItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}