namespace ThitSarMainForm
{
    partial class SellList
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
            this.btnCloseSVL = new System.Windows.Forms.Button();
            this.txtTotalSell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelSVL = new System.Windows.Forms.Panel();
            this.dgvSellVoucherList = new System.Windows.Forms.DataGridView();
            this.voucherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintSVL = new System.Windows.Forms.Button();
            this.btnLoadSVL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalLeft = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSVL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellVoucherList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseSVL
            // 
            this.btnCloseSVL.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCloseSVL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSVL.Location = new System.Drawing.Point(1168, 607);
            this.btnCloseSVL.Name = "btnCloseSVL";
            this.btnCloseSVL.Size = new System.Drawing.Size(75, 25);
            this.btnCloseSVL.TabIndex = 72;
            this.btnCloseSVL.Text = "Close";
            this.btnCloseSVL.UseVisualStyleBackColor = false;
            this.btnCloseSVL.Click += new System.EventHandler(this.btnCloseSVL_Click);
            // 
            // txtTotalSell
            // 
            this.txtTotalSell.Enabled = false;
            this.txtTotalSell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSell.Location = new System.Drawing.Point(237, 557);
            this.txtTotalSell.Name = "txtTotalSell";
            this.txtTotalSell.Size = new System.Drawing.Size(194, 29);
            this.txtTotalSell.TabIndex = 69;
            this.txtTotalSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 564);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 22);
            this.label6.TabIndex = 68;
            this.label6.Text = "Total Price For Sell :";
            // 
            // panelSVL
            // 
            this.panelSVL.BackColor = System.Drawing.Color.Transparent;
            this.panelSVL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSVL.Controls.Add(this.dgvSellVoucherList);
            this.panelSVL.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panelSVL.Location = new System.Drawing.Point(12, 125);
            this.panelSVL.Name = "panelSVL";
            this.panelSVL.Size = new System.Drawing.Size(1231, 426);
            this.panelSVL.TabIndex = 64;
            // 
            // dgvSellVoucherList
            // 
            this.dgvSellVoucherList.AllowUserToResizeColumns = false;
            this.dgvSellVoucherList.AllowUserToResizeRows = false;
            this.dgvSellVoucherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellVoucherList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voucherID,
            this.customerName,
            this.address,
            this.phoneNumber,
            this.date,
            this.tax,
            this.totalAmount,
            this.paidAmount,
            this.leftAmount,
            this.status,
            this._update,
            this._delete});
            this.dgvSellVoucherList.Location = new System.Drawing.Point(-1, -1);
            this.dgvSellVoucherList.Name = "dgvSellVoucherList";
            this.dgvSellVoucherList.ReadOnly = true;
            this.dgvSellVoucherList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSellVoucherList.Size = new System.Drawing.Size(1231, 426);
            this.dgvSellVoucherList.TabIndex = 0;
            this.dgvSellVoucherList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellVoucherList_CellDoubleClick);
            // 
            // voucherID
            // 
            this.voucherID.DataPropertyName = "id";
            this.voucherID.HeaderText = "Voucher ID";
            this.voucherID.Name = "voucherID";
            this.voucherID.ReadOnly = true;
            this.voucherID.Width = 70;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 150;
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "phoneNumber";
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // tax
            // 
            this.tax.DataPropertyName = "tax";
            this.tax.HeaderText = "Tax";
            this.tax.Name = "tax";
            this.tax.ReadOnly = true;
            this.tax.Width = 80;
            // 
            // totalAmount
            // 
            this.totalAmount.DataPropertyName = "totalAmount";
            this.totalAmount.HeaderText = "Total Amount";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            this.totalAmount.Width = 125;
            // 
            // paidAmount
            // 
            this.paidAmount.DataPropertyName = "paidAmount";
            this.paidAmount.HeaderText = "Paid Amount";
            this.paidAmount.Name = "paidAmount";
            this.paidAmount.ReadOnly = true;
            this.paidAmount.Width = 125;
            // 
            // leftAmount
            // 
            this.leftAmount.DataPropertyName = "leftAmount";
            this.leftAmount.HeaderText = "Left Amount";
            this.leftAmount.Name = "leftAmount";
            this.leftAmount.ReadOnly = true;
            this.leftAmount.Width = 125;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 70;
            // 
            // _update
            // 
            this._update.DataPropertyName = "_update";
            this._update.HeaderText = "Update";
            this._update.Name = "_update";
            this._update.ReadOnly = true;
            // 
            // _delete
            // 
            this._delete.DataPropertyName = "_delete";
            this._delete.HeaderText = "Delete";
            this._delete.Name = "_delete";
            this._delete.ReadOnly = true;
            // 
            // btnPrintSVL
            // 
            this.btnPrintSVL.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrintSVL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSVL.Location = new System.Drawing.Point(812, 73);
            this.btnPrintSVL.Name = "btnPrintSVL";
            this.btnPrintSVL.Size = new System.Drawing.Size(75, 25);
            this.btnPrintSVL.TabIndex = 60;
            this.btnPrintSVL.Text = "Print";
            this.btnPrintSVL.UseVisualStyleBackColor = false;
            // 
            // btnLoadSVL
            // 
            this.btnLoadSVL.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoadSVL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSVL.Location = new System.Drawing.Point(719, 73);
            this.btnLoadSVL.Name = "btnLoadSVL";
            this.btnLoadSVL.Size = new System.Drawing.Size(75, 25);
            this.btnLoadSVL.TabIndex = 59;
            this.btnLoadSVL.Text = "Load";
            this.btnLoadSVL.UseVisualStyleBackColor = false;
            this.btnLoadSVL.Click += new System.EventHandler(this.btnLoadSVL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "To :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(436, 74);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(258, 24);
            this.dtpEndDate.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "From :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(99, 74);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(258, 24);
            this.dtpStartDate.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(29, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 10);
            this.panel2.TabIndex = 53;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblLogo.Location = new System.Drawing.Point(520, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(214, 31);
            this.lblLogo.TabIndex = 52;
            this.lblLogo.Text = "Sell Voucher List";
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Enabled = false;
            this.txtTotalPaid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPaid.Location = new System.Drawing.Point(693, 557);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Size = new System.Drawing.Size(194, 29);
            this.txtTotalPaid.TabIndex = 74;
            this.txtTotalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 22);
            this.label3.TabIndex = 73;
            this.label3.Text = "Total Amount For Paid :";
            // 
            // txtTotalLeft
            // 
            this.txtTotalLeft.Enabled = false;
            this.txtTotalLeft.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLeft.Location = new System.Drawing.Point(237, 600);
            this.txtTotalLeft.Name = "txtTotalLeft";
            this.txtTotalLeft.Size = new System.Drawing.Size(194, 29);
            this.txtTotalLeft.TabIndex = 76;
            this.txtTotalLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 22);
            this.label4.TabIndex = 75;
            this.label4.Text = "Total Amount For Left :";
            // 
            // SellList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1255, 649);
            this.Controls.Add(this.txtTotalLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCloseSVL);
            this.Controls.Add(this.txtTotalSell);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelSVL);
            this.Controls.Add(this.btnPrintSVL);
            this.Controls.Add(this.btnLoadSVL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblLogo);
            this.Name = "SellList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellList";
            this.Load += new System.EventHandler(this.SellList_Load);
            this.panelSVL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellVoucherList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseSVL;
        private System.Windows.Forms.TextBox txtTotalSell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelSVL;
        private System.Windows.Forms.Button btnPrintSVL;
        private System.Windows.Forms.Button btnLoadSVL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.DataGridView dgvSellVoucherList;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn _update;
        private System.Windows.Forms.DataGridViewTextBoxColumn _delete;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalLeft;
        private System.Windows.Forms.Label label4;
    }
}