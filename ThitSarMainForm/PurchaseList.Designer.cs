namespace ThitSarMainForm
{
    partial class PurchaseList
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
            this.btnClosePVL = new System.Windows.Forms.Button();
            this.txtTotalPVL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPVL = new System.Windows.Forms.Panel();
            this.dgvPuchaseVoucherList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintPVL = new System.Windows.Forms.Button();
            this.btnLoadPVL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelPVL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuchaseVoucherList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClosePVL
            // 
            this.btnClosePVL.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClosePVL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePVL.Location = new System.Drawing.Point(1168, 560);
            this.btnClosePVL.Name = "btnClosePVL";
            this.btnClosePVL.Size = new System.Drawing.Size(75, 25);
            this.btnClosePVL.TabIndex = 88;
            this.btnClosePVL.Text = "Close";
            this.btnClosePVL.UseVisualStyleBackColor = false;
            this.btnClosePVL.Click += new System.EventHandler(this.btnClosePVL_Click);
            // 
            // txtTotalPVL
            // 
            this.txtTotalPVL.Enabled = false;
            this.txtTotalPVL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPVL.Location = new System.Drawing.Point(299, 556);
            this.txtTotalPVL.Name = "txtTotalPVL";
            this.txtTotalPVL.Size = new System.Drawing.Size(194, 29);
            this.txtTotalPVL.TabIndex = 87;
            this.txtTotalPVL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 22);
            this.label6.TabIndex = 86;
            this.label6.Text = "Total Price For Purchase :";
            // 
            // panelPVL
            // 
            this.panelPVL.BackColor = System.Drawing.Color.Transparent;
            this.panelPVL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPVL.Controls.Add(this.dgvPuchaseVoucherList);
            this.panelPVL.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panelPVL.Location = new System.Drawing.Point(12, 125);
            this.panelPVL.Name = "panelPVL";
            this.panelPVL.Size = new System.Drawing.Size(1231, 426);
            this.panelPVL.TabIndex = 85;
            // 
            // dgvPuchaseVoucherList
            // 
            this.dgvPuchaseVoucherList.AllowUserToResizeColumns = false;
            this.dgvPuchaseVoucherList.AllowUserToResizeRows = false;
            this.dgvPuchaseVoucherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuchaseVoucherList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.itemName,
            this.cost,
            this.date,
            this.supplierName,
            this.supplierAddress,
            this.phoneNumber,
            this._update,
            this._delete});
            this.dgvPuchaseVoucherList.Location = new System.Drawing.Point(-1, -1);
            this.dgvPuchaseVoucherList.Name = "dgvPuchaseVoucherList";
            this.dgvPuchaseVoucherList.ReadOnly = true;
            this.dgvPuchaseVoucherList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPuchaseVoucherList.Size = new System.Drawing.Size(1231, 426);
            this.dgvPuchaseVoucherList.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemName.Width = 175;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cost.Width = 150;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.Width = 200;
            // 
            // supplierName
            // 
            this.supplierName.DataPropertyName = "supplierName";
            this.supplierName.HeaderText = "Supplier Name";
            this.supplierName.Name = "supplierName";
            this.supplierName.ReadOnly = true;
            this.supplierName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierName.Width = 175;
            // 
            // supplierAddress
            // 
            this.supplierAddress.DataPropertyName = "supplierAddress";
            this.supplierAddress.HeaderText = "Supplier Address";
            this.supplierAddress.Name = "supplierAddress";
            this.supplierAddress.ReadOnly = true;
            this.supplierAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierAddress.Width = 213;
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "phoneNumber";
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phoneNumber.Width = 175;
            // 
            // _update
            // 
            this._update.DataPropertyName = "_update";
            this._update.HeaderText = "Update";
            this._update.Name = "_update";
            this._update.ReadOnly = true;
            this._update.Visible = false;
            // 
            // _delete
            // 
            this._delete.DataPropertyName = "_delete";
            this._delete.HeaderText = "Delete";
            this._delete.Name = "_delete";
            this._delete.ReadOnly = true;
            this._delete.Visible = false;
            // 
            // btnPrintPVL
            // 
            this.btnPrintPVL.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrintPVL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPVL.Location = new System.Drawing.Point(812, 73);
            this.btnPrintPVL.Name = "btnPrintPVL";
            this.btnPrintPVL.Size = new System.Drawing.Size(75, 25);
            this.btnPrintPVL.TabIndex = 81;
            this.btnPrintPVL.Text = "Print";
            this.btnPrintPVL.UseVisualStyleBackColor = false;
            // 
            // btnLoadPVL
            // 
            this.btnLoadPVL.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoadPVL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPVL.Location = new System.Drawing.Point(719, 73);
            this.btnLoadPVL.Name = "btnLoadPVL";
            this.btnLoadPVL.Size = new System.Drawing.Size(75, 25);
            this.btnLoadPVL.TabIndex = 80;
            this.btnLoadPVL.Text = "Load";
            this.btnLoadPVL.UseVisualStyleBackColor = false;
            this.btnLoadPVL.Click += new System.EventHandler(this.btnLoadPVL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 78;
            this.label2.Text = "To :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(436, 74);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(258, 24);
            this.dtpEndDate.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 76;
            this.label1.Text = "From :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(99, 74);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(258, 24);
            this.dtpStartDate.TabIndex = 75;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(29, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 10);
            this.panel2.TabIndex = 74;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblLogo.Location = new System.Drawing.Point(488, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(279, 31);
            this.lblLogo.TabIndex = 73;
            this.lblLogo.Text = "Purchase Voucher List";
            // 
            // PurchaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1255, 595);
            this.Controls.Add(this.btnClosePVL);
            this.Controls.Add(this.txtTotalPVL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelPVL);
            this.Controls.Add(this.btnPrintPVL);
            this.Controls.Add(this.btnLoadPVL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblLogo);
            this.Name = "PurchaseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseList";
            this.Load += new System.EventHandler(this.PurchaseList_Load);
            this.panelPVL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuchaseVoucherList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClosePVL;
        private System.Windows.Forms.TextBox txtTotalPVL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPVL;
        private System.Windows.Forms.Button btnPrintPVL;
        private System.Windows.Forms.Button btnLoadPVL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.DataGridView dgvPuchaseVoucherList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _update;
        private System.Windows.Forms.DataGridViewTextBoxColumn _delete;
    }
}