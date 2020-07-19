namespace ThitSarMainForm
{
    partial class TypeInsert
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTypeInsert = new System.Windows.Forms.TextBox();
            this.lblitemName = new System.Windows.Forms.Label();
            this.panTypeInsert = new System.Windows.Forms.Panel();
            this.dgvType = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseType = new System.Windows.Forms.Button();
            this.btnClearType = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.comCurrentCat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panTypeInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtTypeInsert);
            this.panel2.Controls.Add(this.lblitemName);
            this.panel2.Location = new System.Drawing.Point(350, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 118);
            this.panel2.TabIndex = 16;
            // 
            // txtTypeInsert
            // 
            this.txtTypeInsert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeInsert.Location = new System.Drawing.Point(17, 63);
            this.txtTypeInsert.Name = "txtTypeInsert";
            this.txtTypeInsert.Size = new System.Drawing.Size(272, 29);
            this.txtTypeInsert.TabIndex = 13;
            // 
            // lblitemName
            // 
            this.lblitemName.AutoSize = true;
            this.lblitemName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemName.Location = new System.Drawing.Point(13, 20);
            this.lblitemName.Name = "lblitemName";
            this.lblitemName.Size = new System.Drawing.Size(113, 22);
            this.lblitemName.TabIndex = 12;
            this.lblitemName.Text = "Type Name :";
            // 
            // panTypeInsert
            // 
            this.panTypeInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panTypeInsert.Controls.Add(this.dgvType);
            this.panTypeInsert.Location = new System.Drawing.Point(7, 57);
            this.panTypeInsert.Name = "panTypeInsert";
            this.panTypeInsert.Size = new System.Drawing.Size(337, 462);
            this.panTypeInsert.TabIndex = 15;
            // 
            // dgvType
            // 
            this.dgvType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.typeName,
            this.category,
            this._update,
            this._delete});
            this.dgvType.Location = new System.Drawing.Point(1, -2);
            this.dgvType.Name = "dgvType";
            this.dgvType.Size = new System.Drawing.Size(334, 462);
            this.dgvType.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Width = 50;
            // 
            // typeName
            // 
            this.typeName.DataPropertyName = "typeName";
            this.typeName.HeaderText = "Type Name";
            this.typeName.Name = "typeName";
            this.typeName.Width = 125;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.Visible = false;
            this.category.Width = 5;
            // 
            // _update
            // 
            this._update.DataPropertyName = "_update";
            this._update.HeaderText = "Update";
            this._update.Name = "_update";
            this._update.Width = 60;
            // 
            // _delete
            // 
            this._delete.DataPropertyName = "_delete";
            this._delete.HeaderText = "Delete";
            this._delete.Name = "_delete";
            this._delete.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Type Insert Form";
            // 
            // btnCloseType
            // 
            this.btnCloseType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseType.Location = new System.Drawing.Point(560, 464);
            this.btnCloseType.Name = "btnCloseType";
            this.btnCloseType.Size = new System.Drawing.Size(87, 35);
            this.btnCloseType.TabIndex = 19;
            this.btnCloseType.Text = "Close";
            this.btnCloseType.UseVisualStyleBackColor = true;
            this.btnCloseType.Click += new System.EventHandler(this.btnCloseType_Click);
            // 
            // btnClearType
            // 
            this.btnClearType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearType.Location = new System.Drawing.Point(452, 464);
            this.btnClearType.Name = "btnClearType";
            this.btnClearType.Size = new System.Drawing.Size(75, 35);
            this.btnClearType.TabIndex = 18;
            this.btnClearType.Text = "Clear";
            this.btnClearType.UseVisualStyleBackColor = true;
            this.btnClearType.Click += new System.EventHandler(this.btnClearType_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.Location = new System.Drawing.Point(367, 464);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(79, 35);
            this.btnAddType.TabIndex = 17;
            this.btnAddType.Text = "Add";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // comCurrentCat
            // 
            this.comCurrentCat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCurrentCat.FormattingEnabled = true;
            this.comCurrentCat.Location = new System.Drawing.Point(173, 14);
            this.comCurrentCat.Name = "comCurrentCat";
            this.comCurrentCat.Size = new System.Drawing.Size(194, 29);
            this.comCurrentCat.TabIndex = 21;
            this.comCurrentCat.SelectedIndexChanged += new System.EventHandler(this.comCurrentCat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Current Category :";
            // 
            // TypeInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(673, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comCurrentCat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panTypeInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseType);
            this.Controls.Add(this.btnClearType);
            this.Controls.Add(this.btnAddType);
            this.Name = "TypeInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeInsert";
            this.Load += new System.EventHandler(this.TypeInsert_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panTypeInsert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTypeInsert;
        private System.Windows.Forms.Label lblitemName;
        private System.Windows.Forms.Panel panTypeInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseType;
        private System.Windows.Forms.Button btnClearType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.ComboBox comCurrentCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn _update;
        private System.Windows.Forms.DataGridViewTextBoxColumn _delete;
    }
}