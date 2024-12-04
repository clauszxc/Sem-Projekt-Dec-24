namespace Sem_Projekt_Dec_24.Winforms
{
    partial class CustomerConfirmationForm
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
            this.dgvOrderConfirmation = new System.Windows.Forms.DataGridView();
            this.btnCreateOrderInvoice = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnCustomerGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderConfirmation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderConfirmation
            // 
            this.dgvOrderConfirmation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderConfirmation.Location = new System.Drawing.Point(1, 152);
            this.dgvOrderConfirmation.Name = "dgvOrderConfirmation";
            this.dgvOrderConfirmation.Size = new System.Drawing.Size(800, 297);
            this.dgvOrderConfirmation.TabIndex = 0;
            // 
            // btnCreateOrderInvoice
            // 
            this.btnCreateOrderInvoice.Location = new System.Drawing.Point(649, 87);
            this.btnCreateOrderInvoice.Name = "btnCreateOrderInvoice";
            this.btnCreateOrderInvoice.Size = new System.Drawing.Size(125, 23);
            this.btnCreateOrderInvoice.TabIndex = 1;
            this.btnCreateOrderInvoice.Text = "Create Order Invoice";
            this.btnCreateOrderInvoice.UseVisualStyleBackColor = true;
            this.btnCreateOrderInvoice.Click += new System.EventHandler(this.btnCreateOrderInvoice_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(649, 58);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnCustomerGoBack
            // 
            this.btnCustomerGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnCustomerGoBack.Name = "btnCustomerGoBack";
            this.btnCustomerGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerGoBack.TabIndex = 3;
            this.btnCustomerGoBack.Text = "Go Back";
            this.btnCustomerGoBack.UseVisualStyleBackColor = true;
            this.btnCustomerGoBack.Click += new System.EventHandler(this.btnCustomerGoBack_Click);
            // 
            // CustomerConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomerGoBack);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnCreateOrderInvoice);
            this.Controls.Add(this.dgvOrderConfirmation);
            this.Name = "CustomerConfirmationForm";
            this.Text = "CustomerConfirmationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderConfirmation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderConfirmation;
        private System.Windows.Forms.Button btnCreateOrderInvoice;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnCustomerGoBack;
    }
}