namespace Sem_Projekt_Dec_24.Winforms
{
    partial class EmployeeForm
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
            this.btnProductsList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnItemsList = new System.Windows.Forms.Button();
            this.btnShipmentsList = new System.Windows.Forms.Button();
            this.btnCustomersList = new System.Windows.Forms.Button();
            this.btnShippersList = new System.Windows.Forms.Button();
            this.btnOrdersList = new System.Windows.Forms.Button();
            this.btnEmployeesList = new System.Windows.Forms.Button();
            this.btnPurchaseOrdersList = new System.Windows.Forms.Button();
            this.btnSuppliersList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductsList
            // 
            this.btnProductsList.Location = new System.Drawing.Point(37, 43);
            this.btnProductsList.Name = "btnProductsList";
            this.btnProductsList.Size = new System.Drawing.Size(124, 23);
            this.btnProductsList.TabIndex = 0;
            this.btnProductsList.Text = "Products";
            this.btnProductsList.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(607, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 446);
            this.listBox1.TabIndex = 1;
            // 
            // btnItemsList
            // 
            this.btnItemsList.Location = new System.Drawing.Point(37, 72);
            this.btnItemsList.Name = "btnItemsList";
            this.btnItemsList.Size = new System.Drawing.Size(124, 23);
            this.btnItemsList.TabIndex = 2;
            this.btnItemsList.Text = "Items";
            this.btnItemsList.UseVisualStyleBackColor = true;
            // 
            // btnShipmentsList
            // 
            this.btnShipmentsList.Location = new System.Drawing.Point(37, 346);
            this.btnShipmentsList.Name = "btnShipmentsList";
            this.btnShipmentsList.Size = new System.Drawing.Size(124, 23);
            this.btnShipmentsList.TabIndex = 3;
            this.btnShipmentsList.Text = "Shipments";
            this.btnShipmentsList.UseVisualStyleBackColor = true;
            // 
            // btnCustomersList
            // 
            this.btnCustomersList.Location = new System.Drawing.Point(37, 141);
            this.btnCustomersList.Name = "btnCustomersList";
            this.btnCustomersList.Size = new System.Drawing.Size(124, 23);
            this.btnCustomersList.TabIndex = 4;
            this.btnCustomersList.Text = "Customers";
            this.btnCustomersList.UseVisualStyleBackColor = true;
            // 
            // btnShippersList
            // 
            this.btnShippersList.Location = new System.Drawing.Point(37, 199);
            this.btnShippersList.Name = "btnShippersList";
            this.btnShippersList.Size = new System.Drawing.Size(124, 23);
            this.btnShippersList.TabIndex = 5;
            this.btnShippersList.Text = "Shippers";
            this.btnShippersList.UseVisualStyleBackColor = true;
            // 
            // btnOrdersList
            // 
            this.btnOrdersList.Location = new System.Drawing.Point(37, 317);
            this.btnOrdersList.Name = "btnOrdersList";
            this.btnOrdersList.Size = new System.Drawing.Size(124, 23);
            this.btnOrdersList.TabIndex = 6;
            this.btnOrdersList.Text = "Orders";
            this.btnOrdersList.UseVisualStyleBackColor = true;
            // 
            // btnEmployeesList
            // 
            this.btnEmployeesList.Location = new System.Drawing.Point(37, 170);
            this.btnEmployeesList.Name = "btnEmployeesList";
            this.btnEmployeesList.Size = new System.Drawing.Size(124, 23);
            this.btnEmployeesList.TabIndex = 7;
            this.btnEmployeesList.Text = "Employees";
            this.btnEmployeesList.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseOrdersList
            // 
            this.btnPurchaseOrdersList.Location = new System.Drawing.Point(37, 288);
            this.btnPurchaseOrdersList.Name = "btnPurchaseOrdersList";
            this.btnPurchaseOrdersList.Size = new System.Drawing.Size(124, 23);
            this.btnPurchaseOrdersList.TabIndex = 8;
            this.btnPurchaseOrdersList.Text = "Purchase Orders";
            this.btnPurchaseOrdersList.UseVisualStyleBackColor = true;
            // 
            // btnSuppliersList
            // 
            this.btnSuppliersList.Location = new System.Drawing.Point(37, 228);
            this.btnSuppliersList.Name = "btnSuppliersList";
            this.btnSuppliersList.Size = new System.Drawing.Size(124, 23);
            this.btnSuppliersList.TabIndex = 9;
            this.btnSuppliersList.Text = "Suppliers";
            this.btnSuppliersList.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuppliersList);
            this.Controls.Add(this.btnPurchaseOrdersList);
            this.Controls.Add(this.btnEmployeesList);
            this.Controls.Add(this.btnOrdersList);
            this.Controls.Add(this.btnShippersList);
            this.Controls.Add(this.btnCustomersList);
            this.Controls.Add(this.btnShipmentsList);
            this.Controls.Add(this.btnItemsList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnProductsList);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductsList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnItemsList;
        private System.Windows.Forms.Button btnShipmentsList;
        private System.Windows.Forms.Button btnCustomersList;
        private System.Windows.Forms.Button btnShippersList;
        private System.Windows.Forms.Button btnOrdersList;
        private System.Windows.Forms.Button btnEmployeesList;
        private System.Windows.Forms.Button btnPurchaseOrdersList;
        private System.Windows.Forms.Button btnSuppliersList;
    }
}