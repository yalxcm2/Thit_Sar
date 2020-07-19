namespace ThitSarMainForm
{
    partial class GeneralCost1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralCost1));
            this.panelViewG1 = new System.Windows.Forms.Panel();
            this.dgvGeneralCost1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGC1 = new System.Windows.Forms.Panel();
            this.btnClearG1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtReasonG1 = new System.Windows.Forms.RichTextBox();
            this.btnInsertG1 = new System.Windows.Forms.Button();
            this.txtCostG1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseG1 = new System.Windows.Forms.Button();
            this.panelViewG1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralCost1)).BeginInit();
            this.panelGC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelViewG1
            // 
            this.panelViewG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelViewG1.Controls.Add(this.dgvGeneralCost1);
            this.panelViewG1.Location = new System.Drawing.Point(464, 22);
            this.panelViewG1.Name = "panelViewG1";
            this.panelViewG1.Size = new System.Drawing.Size(696, 374);
            this.panelViewG1.TabIndex = 42;
            // 
            // dgvGeneralCost1
            // 
            this.dgvGeneralCost1.AllowDrop = true;
            this.dgvGeneralCost1.AllowUserToAddRows = false;
            this.dgvGeneralCost1.AllowUserToOrderColumns = true;
            this.dgvGeneralCost1.AllowUserToResizeColumns = false;
            this.dgvGeneralCost1.AllowUserToResizeRows = false;
            this.dgvGeneralCost1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneralCost1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Reason,
            this.Cost,
            this.Date,
            this.Update,
            this.Delete});
            this.dgvGeneralCost1.Location = new System.Drawing.Point(25, -1);
            this.dgvGeneralCost1.Name = "dgvGeneralCost1";
            this.dgvGeneralCost1.ReadOnly = true;
            this.dgvGeneralCost1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGeneralCost1.Size = new System.Drawing.Size(658, 362);
            this.dgvGeneralCost1.TabIndex = 0;
            this.dgvGeneralCost1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneralCost1_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.Width = 225;
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
            // panelGC1
            // 
            this.panelGC1.BackColor = System.Drawing.Color.Transparent;
            this.panelGC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGC1.Controls.Add(this.btnClearG1);
            this.panelGC1.Controls.Add(this.label1);
            this.panelGC1.Controls.Add(this.lblLogo);
            this.panelGC1.Controls.Add(this.txtReasonG1);
            this.panelGC1.Controls.Add(this.btnInsertG1);
            this.panelGC1.Controls.Add(this.txtCostG1);
            this.panelGC1.Controls.Add(this.label3);
            this.panelGC1.Controls.Add(this.dateTimePicker1);
            this.panelGC1.Controls.Add(this.label2);
            this.panelGC1.Location = new System.Drawing.Point(22, 22);
            this.panelGC1.Name = "panelGC1";
            this.panelGC1.Size = new System.Drawing.Size(427, 339);
            this.panelGC1.TabIndex = 45;
            // 
            // btnClearG1
            // 
            this.btnClearG1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClearG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearG1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearG1.ForeColor = System.Drawing.Color.White;
            this.btnClearG1.Location = new System.Drawing.Point(253, 294);
            this.btnClearG1.Name = "btnClearG1";
            this.btnClearG1.Size = new System.Drawing.Size(112, 28);
            this.btnClearG1.TabIndex = 33;
            this.btnClearG1.Text = "Clear";
            this.btnClearG1.UseVisualStyleBackColor = false;
            this.btnClearG1.Click += new System.EventHandler(this.btnClearG1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Date :";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(117, 13);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(186, 31);
            this.lblLogo.TabIndex = 24;
            this.lblLogo.Text = "General Cost I";
            // 
            // txtReasonG1
            // 
            this.txtReasonG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonG1.Location = new System.Drawing.Point(107, 81);
            this.txtReasonG1.Name = "txtReasonG1";
            this.txtReasonG1.Size = new System.Drawing.Size(258, 72);
            this.txtReasonG1.TabIndex = 31;
            this.txtReasonG1.Text = "";
            // 
            // btnInsertG1
            // 
            this.btnInsertG1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInsertG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertG1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertG1.ForeColor = System.Drawing.Color.White;
            this.btnInsertG1.Location = new System.Drawing.Point(107, 294);
            this.btnInsertG1.Name = "btnInsertG1";
            this.btnInsertG1.Size = new System.Drawing.Size(112, 28);
            this.btnInsertG1.TabIndex = 22;
            this.btnInsertG1.Text = "Insert";
            this.btnInsertG1.UseVisualStyleBackColor = false;
            this.btnInsertG1.Click += new System.EventHandler(this.btnInsertG1_Click);
            // 
            // txtCostG1
            // 
            this.txtCostG1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostG1.Location = new System.Drawing.Point(107, 174);
            this.txtCostG1.Name = "txtCostG1";
            this.txtCostG1.Size = new System.Drawing.Size(150, 29);
            this.txtCostG1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cost :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 24);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Reason :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseG1
            // 
            this.btnCloseG1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCloseG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseG1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseG1.ForeColor = System.Drawing.Color.White;
            this.btnCloseG1.Location = new System.Drawing.Point(1036, 408);
            this.btnCloseG1.Name = "btnCloseG1";
            this.btnCloseG1.Size = new System.Drawing.Size(112, 28);
            this.btnCloseG1.TabIndex = 44;
            this.btnCloseG1.Text = "Close";
            this.btnCloseG1.UseVisualStyleBackColor = false;
            this.btnCloseG1.Click += new System.EventHandler(this.btnCloseG1_Click);
            // 
            // GeneralCost1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1171, 448);
            this.Controls.Add(this.panelViewG1);
            this.Controls.Add(this.panelGC1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCloseG1);
            this.Name = "GeneralCost1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralCost1";
            this.Load += new System.EventHandler(this.GeneralCost1_Load);
            this.panelViewG1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralCost1)).EndInit();
            this.panelGC1.ResumeLayout(false);
            this.panelGC1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelViewG1;
        private System.Windows.Forms.Panel panelGC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.RichTextBox txtReasonG1;
        private System.Windows.Forms.Button btnInsertG1;
        private System.Windows.Forms.TextBox txtCostG1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseG1;
        private System.Windows.Forms.Button btnClearG1;
        private System.Windows.Forms.DataGridView dgvGeneralCost1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
    }
}