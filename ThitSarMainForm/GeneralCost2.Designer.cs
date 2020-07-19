namespace ThitSarMainForm
{
    partial class GeneralCost2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralCost2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelViewG2 = new System.Windows.Forms.Panel();
            this.dgvGeneralCost2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGC2 = new System.Windows.Forms.Panel();
            this.btnClearG2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtReasonG2 = new System.Windows.Forms.RichTextBox();
            this.btnInsertG2 = new System.Windows.Forms.Button();
            this.txtCostG2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseG2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelViewG2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralCost2)).BeginInit();
            this.panelGC2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelViewG2
            // 
            this.panelViewG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelViewG2.Controls.Add(this.dgvGeneralCost2);
            this.panelViewG2.Location = new System.Drawing.Point(466, 21);
            this.panelViewG2.Name = "panelViewG2";
            this.panelViewG2.Size = new System.Drawing.Size(696, 374);
            this.panelViewG2.TabIndex = 37;
            // 
            // dgvGeneralCost2
            // 
            this.dgvGeneralCost2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneralCost2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.reason,
            this.cost,
            this.date,
            this._update,
            this._delete});
            this.dgvGeneralCost2.Location = new System.Drawing.Point(31, -1);
            this.dgvGeneralCost2.Name = "dgvGeneralCost2";
            this.dgvGeneralCost2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGeneralCost2.Size = new System.Drawing.Size(652, 362);
            this.dgvGeneralCost2.TabIndex = 0;
            this.dgvGeneralCost2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneralCost2_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // reason
            // 
            this.reason.DataPropertyName = "reason";
            this.reason.HeaderText = "Reason";
            this.reason.Name = "reason";
            this.reason.ReadOnly = true;
            this.reason.Width = 225;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 75;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // _update
            // 
            this._update.DataPropertyName = "_update";
            this._update.HeaderText = "Update";
            this._update.Name = "_update";
            this._update.Width = 65;
            // 
            // _delete
            // 
            this._delete.DataPropertyName = "_delete";
            this._delete.HeaderText = "Delete";
            this._delete.Name = "_delete";
            this._delete.Width = 65;
            // 
            // panelGC2
            // 
            this.panelGC2.BackColor = System.Drawing.Color.Transparent;
            this.panelGC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGC2.Controls.Add(this.btnClearG2);
            this.panelGC2.Controls.Add(this.label1);
            this.panelGC2.Controls.Add(this.lblLogo);
            this.panelGC2.Controls.Add(this.txtReasonG2);
            this.panelGC2.Controls.Add(this.btnInsertG2);
            this.panelGC2.Controls.Add(this.txtCostG2);
            this.panelGC2.Controls.Add(this.label3);
            this.panelGC2.Controls.Add(this.dateTimePicker2);
            this.panelGC2.Controls.Add(this.label2);
            this.panelGC2.Location = new System.Drawing.Point(12, 24);
            this.panelGC2.Name = "panelGC2";
            this.panelGC2.Size = new System.Drawing.Size(427, 339);
            this.panelGC2.TabIndex = 40;
            // 
            // btnClearG2
            // 
            this.btnClearG2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClearG2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearG2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearG2.ForeColor = System.Drawing.Color.White;
            this.btnClearG2.Location = new System.Drawing.Point(253, 294);
            this.btnClearG2.Name = "btnClearG2";
            this.btnClearG2.Size = new System.Drawing.Size(112, 28);
            this.btnClearG2.TabIndex = 33;
            this.btnClearG2.Text = "Clear";
            this.btnClearG2.UseVisualStyleBackColor = false;
            this.btnClearG2.Click += new System.EventHandler(this.btnClearG2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 225);
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
            this.lblLogo.Size = new System.Drawing.Size(196, 31);
            this.lblLogo.TabIndex = 24;
            this.lblLogo.Text = "General Cost II";
            // 
            // txtReasonG2
            // 
            this.txtReasonG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonG2.Location = new System.Drawing.Point(107, 81);
            this.txtReasonG2.Name = "txtReasonG2";
            this.txtReasonG2.Size = new System.Drawing.Size(258, 72);
            this.txtReasonG2.TabIndex = 31;
            this.txtReasonG2.Text = "";
            // 
            // btnInsertG2
            // 
            this.btnInsertG2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInsertG2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertG2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertG2.ForeColor = System.Drawing.Color.White;
            this.btnInsertG2.Location = new System.Drawing.Point(107, 294);
            this.btnInsertG2.Name = "btnInsertG2";
            this.btnInsertG2.Size = new System.Drawing.Size(112, 28);
            this.btnInsertG2.TabIndex = 22;
            this.btnInsertG2.Text = "Insert";
            this.btnInsertG2.UseVisualStyleBackColor = false;
            this.btnInsertG2.Click += new System.EventHandler(this.btnInsertG2_Click);
            // 
            // txtCostG2
            // 
            this.txtCostG2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostG2.Location = new System.Drawing.Point(107, 174);
            this.txtCostG2.Name = "txtCostG2";
            this.txtCostG2.Size = new System.Drawing.Size(150, 29);
            this.txtCostG2.TabIndex = 30;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(107, 224);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(258, 24);
            this.dateTimePicker2.TabIndex = 25;
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
            // btnCloseG2
            // 
            this.btnCloseG2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCloseG2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseG2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseG2.ForeColor = System.Drawing.Color.White;
            this.btnCloseG2.Location = new System.Drawing.Point(1038, 407);
            this.btnCloseG2.Name = "btnCloseG2";
            this.btnCloseG2.Size = new System.Drawing.Size(112, 28);
            this.btnCloseG2.TabIndex = 39;
            this.btnCloseG2.Text = "Close";
            this.btnCloseG2.UseVisualStyleBackColor = false;
            this.btnCloseG2.Click += new System.EventHandler(this.btnCloseG2_Click);
            // 
            // GeneralCost2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1171, 448);
            this.Controls.Add(this.panelViewG2);
            this.Controls.Add(this.panelGC2);
            this.Controls.Add(this.btnCloseG2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GeneralCost2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralCost2";
            this.Load += new System.EventHandler(this.GeneralCost2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelViewG2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralCost2)).EndInit();
            this.panelGC2.ResumeLayout(false);
            this.panelGC2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelViewG2;
        private System.Windows.Forms.Panel panelGC2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.RichTextBox txtReasonG2;
        private System.Windows.Forms.Button btnInsertG2;
        private System.Windows.Forms.TextBox txtCostG2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseG2;
        private System.Windows.Forms.Button btnClearG2;
        private System.Windows.Forms.DataGridView dgvGeneralCost2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _update;
        private System.Windows.Forms.DataGridViewTextBoxColumn _delete;
    }
}