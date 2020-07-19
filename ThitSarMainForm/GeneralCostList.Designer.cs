namespace ThitSarMainForm
{
    partial class GeneralCostList
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
            this.lblLogo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panelG1 = new System.Windows.Forms.Panel();
            this.dgvGeneralCost1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panelG2 = new System.Windows.Forms.Panel();
            this.dgvGeneralCost2 = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._update2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._delete2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalG1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalG2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelG1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralCost1)).BeginInit();
            this.panelG2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralCost2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblLogo.Location = new System.Drawing.Point(516, 12);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(222, 31);
            this.lblLogo.TabIndex = 25;
            this.lblLogo.Text = "General Cost List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(29, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 10);
            this.panel2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "From :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(99, 77);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(258, 24);
            this.dtpStartDate.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "To :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(436, 77);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(258, 24);
            this.dtpEndDate.TabIndex = 35;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(719, 76);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 25);
            this.btnLoad.TabIndex = 38;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(812, 76);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 25);
            this.btnPrint.TabIndex = 39;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // panelG1
            // 
            this.panelG1.BackColor = System.Drawing.Color.Transparent;
            this.panelG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelG1.Controls.Add(this.dgvGeneralCost1);
            this.panelG1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panelG1.Location = new System.Drawing.Point(12, 169);
            this.panelG1.Name = "panelG1";
            this.panelG1.Size = new System.Drawing.Size(619, 385);
            this.panelG1.TabIndex = 43;
            // 
            // dgvGeneralCost1
            // 
            this.dgvGeneralCost1.AllowUserToResizeColumns = false;
            this.dgvGeneralCost1.AllowUserToResizeRows = false;
            this.dgvGeneralCost1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneralCost1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.reason,
            this.cost,
            this.date,
            this._update,
            this._delete});
            this.dgvGeneralCost1.Location = new System.Drawing.Point(-1, -1);
            this.dgvGeneralCost1.Name = "dgvGeneralCost1";
            this.dgvGeneralCost1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGeneralCost1.Size = new System.Drawing.Size(619, 385);
            this.dgvGeneralCost1.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // reason
            // 
            this.reason.DataPropertyName = "reason";
            this.reason.HeaderText = "Reason";
            this.reason.Name = "reason";
            this.reason.ReadOnly = true;
            this.reason.Width = 200;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // _update
            // 
            this._update.DataPropertyName = "_update";
            this._update.HeaderText = "Update";
            this._update.Name = "_update";
            this._update.Visible = false;
            this._update.Width = 5;
            // 
            // _delete
            // 
            this._delete.DataPropertyName = "_delete";
            this._delete.HeaderText = "Delete";
            this._delete.Name = "_delete";
            this._delete.Visible = false;
            this._delete.Width = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "General Cost I";
            // 
            // panelG2
            // 
            this.panelG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelG2.Controls.Add(this.dgvGeneralCost2);
            this.panelG2.Location = new System.Drawing.Point(637, 169);
            this.panelG2.Name = "panelG2";
            this.panelG2.Size = new System.Drawing.Size(606, 385);
            this.panelG2.TabIndex = 45;
            // 
            // dgvGeneralCost2
            // 
            this.dgvGeneralCost2.AllowUserToResizeColumns = false;
            this.dgvGeneralCost2.AllowUserToResizeRows = false;
            this.dgvGeneralCost2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneralCost2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.reason2,
            this.cost2,
            this.date2,
            this._update2,
            this._delete2});
            this.dgvGeneralCost2.Location = new System.Drawing.Point(-1, -1);
            this.dgvGeneralCost2.Name = "dgvGeneralCost2";
            this.dgvGeneralCost2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGeneralCost2.Size = new System.Drawing.Size(606, 385);
            this.dgvGeneralCost2.TabIndex = 0;
            // 
            // id2
            // 
            this.id2.DataPropertyName = "id";
            this.id2.HeaderText = "ID";
            this.id2.Name = "id2";
            this.id2.ReadOnly = true;
            // 
            // reason2
            // 
            this.reason2.DataPropertyName = "reason";
            this.reason2.HeaderText = "Reason";
            this.reason2.Name = "reason2";
            this.reason2.ReadOnly = true;
            this.reason2.Width = 200;
            // 
            // cost2
            // 
            this.cost2.DataPropertyName = "cost";
            this.cost2.HeaderText = "Cost";
            this.cost2.Name = "cost2";
            this.cost2.ReadOnly = true;
            this.cost2.Width = 112;
            // 
            // date2
            // 
            this.date2.DataPropertyName = "date";
            this.date2.HeaderText = "Date";
            this.date2.Name = "date2";
            this.date2.ReadOnly = true;
            this.date2.Width = 150;
            // 
            // _update2
            // 
            this._update2.DataPropertyName = "_update";
            this._update2.HeaderText = "Update";
            this._update2.Name = "_update2";
            this._update2.Visible = false;
            this._update2.Width = 5;
            // 
            // _delete2
            // 
            this._delete2.DataPropertyName = "_delete";
            this._delete2.HeaderText = "Delete";
            this._delete2.Name = "_delete2";
            this._delete2.Visible = false;
            this._delete2.Width = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(871, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "General Cost II";
            // 
            // txtTotalG1
            // 
            this.txtTotalG1.Enabled = false;
            this.txtTotalG1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalG1.Location = new System.Drawing.Point(205, 560);
            this.txtTotalG1.Name = "txtTotalG1";
            this.txtTotalG1.Size = new System.Drawing.Size(194, 29);
            this.txtTotalG1.TabIndex = 48;
            this.txtTotalG1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 22);
            this.label6.TabIndex = 47;
            this.label6.Text = "Total Price G I";
            // 
            // txtTotalG2
            // 
            this.txtTotalG2.Enabled = false;
            this.txtTotalG2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalG2.Location = new System.Drawing.Point(823, 560);
            this.txtTotalG2.Name = "txtTotalG2";
            this.txtTotalG2.Size = new System.Drawing.Size(194, 29);
            this.txtTotalG2.TabIndex = 50;
            this.txtTotalG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(678, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "Total Price G II";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1168, 563);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GeneralCostList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1255, 606);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTotalG2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalG1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelG2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelG1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblLogo);
            this.Name = "GeneralCostList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralCostList";
            this.Load += new System.EventHandler(this.GeneralCostList_Load);
            this.panelG1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralCost1)).EndInit();
            this.panelG2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralCost2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panelG1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelG2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalG1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalG2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvGeneralCost1;
        private System.Windows.Forms.DataGridView dgvGeneralCost2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _update;
        private System.Windows.Forms.DataGridViewTextBoxColumn _delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _update2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _delete2;
    }
}