namespace Sem_Projekt_Dec_24.Winforms
{
    partial class ActorCRUDForm
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
            this.dgvActor = new System.Windows.Forms.DataGridView();
            this.btnActorCreate = new System.Windows.Forms.Button();
            this.cmbbChooseActor = new System.Windows.Forms.ComboBox();
            this.txtbActorId = new System.Windows.Forms.TextBox();
            this.txtbActorEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtbActorCustomerAdress = new System.Windows.Forms.TextBox();
            this.txtbActorCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtbActorShipperName = new System.Windows.Forms.TextBox();
            this.txtbActorEmployeeLastName = new System.Windows.Forms.TextBox();
            this.txtbActorEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnActorUpdate = new System.Windows.Forms.Button();
            this.btnActorDelete = new System.Windows.Forms.Button();
            this.btnActorGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActor
            // 
            this.dgvActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActor.Location = new System.Drawing.Point(400, 1);
            this.dgvActor.Name = "dgvActor";
            this.dgvActor.Size = new System.Drawing.Size(400, 449);
            this.dgvActor.TabIndex = 2;
            // 
            // btnActorCreate
            // 
            this.btnActorCreate.Location = new System.Drawing.Point(139, 63);
            this.btnActorCreate.Name = "btnActorCreate";
            this.btnActorCreate.Size = new System.Drawing.Size(75, 23);
            this.btnActorCreate.TabIndex = 4;
            this.btnActorCreate.Text = "Create";
            this.btnActorCreate.UseVisualStyleBackColor = true;
            // 
            // cmbbChooseActor
            // 
            this.cmbbChooseActor.FormattingEnabled = true;
            this.cmbbChooseActor.Location = new System.Drawing.Point(12, 65);
            this.cmbbChooseActor.Name = "cmbbChooseActor";
            this.cmbbChooseActor.Size = new System.Drawing.Size(121, 21);
            this.cmbbChooseActor.TabIndex = 7;
            // 
            // txtbActorId
            // 
            this.txtbActorId.Location = new System.Drawing.Point(12, 127);
            this.txtbActorId.Name = "txtbActorId";
            this.txtbActorId.Size = new System.Drawing.Size(100, 20);
            this.txtbActorId.TabIndex = 8;
            // 
            // txtbActorEmployeeEmail
            // 
            this.txtbActorEmployeeEmail.Location = new System.Drawing.Point(152, 124);
            this.txtbActorEmployeeEmail.Name = "txtbActorEmployeeEmail";
            this.txtbActorEmployeeEmail.Size = new System.Drawing.Size(100, 20);
            this.txtbActorEmployeeEmail.TabIndex = 9;
            // 
            // txtbActorCustomerAdress
            // 
            this.txtbActorCustomerAdress.Location = new System.Drawing.Point(152, 316);
            this.txtbActorCustomerAdress.Name = "txtbActorCustomerAdress";
            this.txtbActorCustomerAdress.Size = new System.Drawing.Size(100, 20);
            this.txtbActorCustomerAdress.TabIndex = 13;
            this.txtbActorCustomerAdress.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtbActorCustomerEmail
            // 
            this.txtbActorCustomerEmail.Location = new System.Drawing.Point(152, 290);
            this.txtbActorCustomerEmail.Name = "txtbActorCustomerEmail";
            this.txtbActorCustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.txtbActorCustomerEmail.TabIndex = 14;
            this.txtbActorCustomerEmail.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtbActorShipperName
            // 
            this.txtbActorShipperName.Location = new System.Drawing.Point(152, 234);
            this.txtbActorShipperName.Name = "txtbActorShipperName";
            this.txtbActorShipperName.Size = new System.Drawing.Size(100, 20);
            this.txtbActorShipperName.TabIndex = 15;
            // 
            // txtbActorEmployeeLastName
            // 
            this.txtbActorEmployeeLastName.Location = new System.Drawing.Point(152, 176);
            this.txtbActorEmployeeLastName.Name = "txtbActorEmployeeLastName";
            this.txtbActorEmployeeLastName.Size = new System.Drawing.Size(100, 20);
            this.txtbActorEmployeeLastName.TabIndex = 16;
            this.txtbActorEmployeeLastName.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtbActorEmployeeFirstName
            // 
            this.txtbActorEmployeeFirstName.Location = new System.Drawing.Point(152, 150);
            this.txtbActorEmployeeFirstName.Name = "txtbActorEmployeeFirstName";
            this.txtbActorEmployeeFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtbActorEmployeeFirstName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Employee Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Shipper Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Customer Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Employee First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Employee Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Customer Adress";
            // 
            // btnActorUpdate
            // 
            this.btnActorUpdate.Location = new System.Drawing.Point(220, 63);
            this.btnActorUpdate.Name = "btnActorUpdate";
            this.btnActorUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnActorUpdate.TabIndex = 25;
            this.btnActorUpdate.Text = "Update";
            this.btnActorUpdate.UseVisualStyleBackColor = true;
            // 
            // btnActorDelete
            // 
            this.btnActorDelete.Location = new System.Drawing.Point(301, 63);
            this.btnActorDelete.Name = "btnActorDelete";
            this.btnActorDelete.Size = new System.Drawing.Size(75, 23);
            this.btnActorDelete.TabIndex = 26;
            this.btnActorDelete.Text = "Delete";
            this.btnActorDelete.UseVisualStyleBackColor = true;
            // 
            // btnActorGoBack
            // 
            this.btnActorGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnActorGoBack.Name = "btnActorGoBack";
            this.btnActorGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnActorGoBack.TabIndex = 27;
            this.btnActorGoBack.Text = "Go Back";
            this.btnActorGoBack.UseVisualStyleBackColor = true;
            this.btnActorGoBack.Click += new System.EventHandler(this.btnActorGoBack_Click);
            // 
            // ActorCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActorGoBack);
            this.Controls.Add(this.btnActorDelete);
            this.Controls.Add(this.btnActorUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbActorEmployeeFirstName);
            this.Controls.Add(this.txtbActorEmployeeLastName);
            this.Controls.Add(this.txtbActorShipperName);
            this.Controls.Add(this.txtbActorCustomerEmail);
            this.Controls.Add(this.txtbActorCustomerAdress);
            this.Controls.Add(this.txtbActorEmployeeEmail);
            this.Controls.Add(this.txtbActorId);
            this.Controls.Add(this.cmbbChooseActor);
            this.Controls.Add(this.btnActorCreate);
            this.Controls.Add(this.dgvActor);
            this.Name = "ActorCRUDForm";
            this.Text = "ActorCRUDForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvActor;
        private System.Windows.Forms.Button btnActorCreate;
        private System.Windows.Forms.ComboBox cmbbChooseActor;
        private System.Windows.Forms.TextBox txtbActorId;
        private System.Windows.Forms.TextBox txtbActorEmployeeEmail;
        private System.Windows.Forms.TextBox txtbActorCustomerAdress;
        private System.Windows.Forms.TextBox txtbActorCustomerEmail;
        private System.Windows.Forms.TextBox txtbActorShipperName;
        private System.Windows.Forms.TextBox txtbActorEmployeeLastName;
        private System.Windows.Forms.TextBox txtbActorEmployeeFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActorUpdate;
        private System.Windows.Forms.Button btnActorDelete;
        private System.Windows.Forms.Button btnActorGoBack;
    }
}