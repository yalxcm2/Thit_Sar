namespace ThitSarMainForm
{
    partial class PurchaseDashboard
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
            this.btnClosePD = new System.Windows.Forms.Button();
            this.btnClearPD = new System.Windows.Forms.Button();
            this.panelGC1 = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSuppAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnInsertPD = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPurchaseDashboard = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelViewG1 = new System.Windows.Forms.Panel();
            this.panelGC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.panelViewG1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClosePD
            // 
            this.btnClosePD.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClosePD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePD.ForeColor = System.Drawing.Color.White;
            this.btnClosePD.Location = new System.Drawing.Point(1132, 460);
            this.btnClosePD.Name = "btnClosePD";
            this.btnClosePD.Size = new System.Drawing.Size(112, 28);
            this.btnClosePD.TabIndex = 49;
            this.btnClosePD.Text = "Close";
            this.btnClosePD.UseVisualStyleBackColor = false;
            this.btnClosePD.Click += new System.EventHandler(this.btnClosePD_Click);
            // 
            // btnClearPD
            // 
            this.btnClearPD.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClearPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPD.ForeColor = System.Drawing.Color.White;
            this.btnClearPD.Location = new System.Drawing.Point(264, 370);
            this.btnClearPD.Name = "btnClearPD";
            this.btnClearPD.Size = new System.Drawing.Size(112, 28);
            this.btnClearPD.TabIndex = 33;
            this.btnClearPD.Text = "Clear";
            this.btnClearPD.UseVisualStyleBackColor = false;
            this.btnClearPD.Click += new System.EventHandler(this.btnClearPD_Click);
            // 
            // panelGC1
            // 
            this.panelGC1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelGC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGC1.Controls.Add(this.txtPhoneNumber);
            this.panelGC1.Controls.Add(this.txtSuppAddress);
            this.panelGC1.Controls.Add(this.label6);
            this.panelGC1.Controls.Add(this.label5);
            this.panelGC1.Controls.Add(this.txtSuppName);
            this.panelGC1.Controls.Add(this.label4);
            this.panelGC1.Controls.Add(this.txtItemName);
            this.panelGC1.Controls.Add(this.btnClearPD);
            this.panelGC1.Controls.Add(this.label1);
            this.panelGC1.Controls.Add(this.lblLogo);
            this.panelGC1.Controls.Add(this.btnInsertPD);
            this.panelGC1.Controls.Add(this.txtCost);
            this.panelGC1.Controls.Add(this.label3);
            this.panelGC1.Controls.Add(this.dtpPurchaseDashboard);
            this.panelGC1.Controls.Add(this.label2);
            this.panelGC1.Location = new System.Drawing.Point(32, 22);
            this.panelGC1.Name = "panelGC1";
            this.panelGC1.Size = new System.Drawing.Size(514, 414);
            this.panelGC1.TabIndex = 50;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(228, 317);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(187, 29);
            this.txtPhoneNumber.TabIndex = 40;
            // 
            // txtSuppAddress
            // 
            this.txtSuppAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppAddress.Location = new System.Drawing.Point(228, 274);
            this.txtSuppAddress.Name = "txtSuppAddress";
            this.txtSuppAddress.Size = new System.Drawing.Size(187, 29);
            this.txtSuppAddress.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 38;
            this.label6.Text = "Phone Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Supplier Address :";
            // 
            // txtSuppName
            // 
            this.txtSuppName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppName.Location = new System.Drawing.Point(228, 226);
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.Size = new System.Drawing.Size(187, 29);
            this.txtSuppName.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Supplier Name :";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(228, 84);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(187, 29);
            this.txtItemName.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Date :";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(117, 14);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(259, 31);
            this.lblLogo.TabIndex = 24;
            this.lblLogo.Text = "Purchase Dashboard";
            // 
            // btnInsertPD
            // 
            this.btnInsertPD.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInsertPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertPD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertPD.ForeColor = System.Drawing.Color.White;
            this.btnInsertPD.Location = new System.Drawing.Point(107, 370);
            this.btnInsertPD.Name = "btnInsertPD";
            this.btnInsertPD.Size = new System.Drawing.Size(112, 28);
            this.btnInsertPD.TabIndex = 22;
            this.btnInsertPD.Text = "Insert";
            this.btnInsertPD.UseVisualStyleBackColor = false;
            this.btnInsertPD.Click += new System.EventHandler(this.btnInsertPD_Click);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(228, 131);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(187, 29);
            this.txtCost.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cost :";
            // 
            // dtpPurchaseDashboard
            // 
            this.dtpPurchaseDashboard.Checked = false;
            this.dtpPurchaseDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDashboard.Location = new System.Drawing.Point(228, 182);
            this.dtpPurchaseDashboard.Name = "dtpPurchaseDashboard";
            this.dtpPurchaseDashboard.Size = new System.Drawing.Size(259, 24);
            this.dtpPurchaseDashboard.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Item Name :";
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.AllowDrop = true;
            this.dgvPurchase.AllowUserToAddRows = false;
            this.dgvPurchase.AllowUserToOrderColumns = true;
            this.dgvPurchase.AllowUserToResizeColumns = false;
            this.dgvPurchase.AllowUserToResizeRows = false;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.itemName,
            this.Cost,
            this.Date,
            this.supplierName,
            this.supplierAddress,
            this.supplierPhoneNumber,
            this.Update,
            this.Delete});
            this.dgvPurchase.Location = new System.Drawing.Point(3, 3);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.ReadOnly = true;
            this.dgvPurchase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPurchase.Size = new System.Drawing.Size(665, 410);
            this.dgvPurchase.TabIndex = 0;
            this.dgvPurchase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 75;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // supplierName
            // 
            this.supplierName.DataPropertyName = "supplierName";
            this.supplierName.HeaderText = "Supplier Name";
            this.supplierName.Name = "supplierName";
            this.supplierName.ReadOnly = true;
            // 
            // supplierAddress
            // 
            this.supplierAddress.DataPropertyName = "supplierAddress";
            this.supplierAddress.HeaderText = "Supplier Address";
            this.supplierAddress.Name = "supplierAddress";
            this.supplierAddress.ReadOnly = true;
            // 
            // supplierPhoneNumber
            // 
            this.supplierPhoneNumber.DataPropertyName = "phoneNumber";
            this.supplierPhoneNumber.HeaderText = "Supplier Phone Number";
            this.supplierPhoneNumber.Name = "supplierPhoneNumber";
            this.supplierPhoneNumber.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.DataPropertyName = "_update";
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Width = 65;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "_delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 65;
            // 
            // panelViewG1
            // 
            this.panelViewG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelViewG1.Controls.Add(this.dgvPurchase);
            this.panelViewG1.Location = new System.Drawing.Point(575, 22);
            this.panelViewG1.Name = "panelViewG1";
            this.panelViewG1.Size = new System.Drawing.Size(673, 414);
            this.panelViewG1.TabIndex = 47;
            // 
            // PurchaseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1271, 504);
            this.Controls.Add(this.btnClosePD);
            this.Controls.Add(this.panelGC1);
            this.Controls.Add(this.panelViewG1);
            this.Name = "PurchaseDashboard";
            this.Text = "PurchaseDashboard";
            this.Load += new System.EventHandler(this.PurchaseDashboard_Load);
            this.panelGC1.ResumeLayout(false);
            this.panelGC1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.panelViewG1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClosePD;
        private System.Windows.Forms.Button btnClearPD;
        private System.Windows.Forms.Panel panelGC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnInsertPD;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.Panel panelViewG1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSuppAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
    }
}