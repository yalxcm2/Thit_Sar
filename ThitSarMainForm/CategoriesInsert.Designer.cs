namespace ThitSarMainForm
{
    partial class CategoriesInsert
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
            this.panCatInsert = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCatInsert = new System.Windows.Forms.TextBox();
            this.lblitemName = new System.Windows.Forms.Label();
            this.btnCloseCat = new System.Windows.Forms.Button();
            this.btnClearCat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panCatInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCatInsert
            // 
            this.panCatInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panCatInsert.Controls.Add(this.dgvCategory);
            this.panCatInsert.Location = new System.Drawing.Point(12, 47);
            this.panCatInsert.Name = "panCatInsert";
            this.panCatInsert.Size = new System.Drawing.Size(337, 473);
            this.panCatInsert.TabIndex = 0;
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.category,
            this._update,
            this._delete});
            this.dgvCategory.Location = new System.Drawing.Point(3, 3);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(327, 463);
            this.dgvCategory.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // category
            // 
            this.category.DataPropertyName = "categoryName";
            this.category.HeaderText = "Category Name";
            this.category.Name = "category";
            this.category.Width = 125;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtCatInsert);
            this.panel2.Controls.Add(this.lblitemName);
            this.panel2.Location = new System.Drawing.Point(355, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 118);
            this.panel2.TabIndex = 1;
            // 
            // txtCatInsert
            // 
            this.txtCatInsert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatInsert.Location = new System.Drawing.Point(17, 63);
            this.txtCatInsert.Name = "txtCatInsert";
            this.txtCatInsert.Size = new System.Drawing.Size(272, 29);
            this.txtCatInsert.TabIndex = 13;
            // 
            // lblitemName
            // 
            this.lblitemName.AutoSize = true;
            this.lblitemName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemName.Location = new System.Drawing.Point(13, 20);
            this.lblitemName.Name = "lblitemName";
            this.lblitemName.Size = new System.Drawing.Size(149, 22);
            this.lblitemName.TabIndex = 12;
            this.lblitemName.Text = "Category Name :";
            // 
            // btnCloseCat
            // 
            this.btnCloseCat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseCat.Location = new System.Drawing.Point(565, 465);
            this.btnCloseCat.Name = "btnCloseCat";
            this.btnCloseCat.Size = new System.Drawing.Size(87, 35);
            this.btnCloseCat.TabIndex = 13;
            this.btnCloseCat.Text = "Close";
            this.btnCloseCat.UseVisualStyleBackColor = true;
            this.btnCloseCat.Click += new System.EventHandler(this.btnCloseCat_Click);
            // 
            // btnClearCat
            // 
            this.btnClearCat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCat.Location = new System.Drawing.Point(457, 465);
            this.btnClearCat.Name = "btnClearCat";
            this.btnClearCat.Size = new System.Drawing.Size(75, 35);
            this.btnClearCat.TabIndex = 12;
            this.btnClearCat.Text = "Clear";
            this.btnClearCat.UseVisualStyleBackColor = true;
            this.btnClearCat.Click += new System.EventHandler(this.btnClearCat_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.Location = new System.Drawing.Point(372, 465);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(79, 35);
            this.btnAddCat.TabIndex = 11;
            this.btnAddCat.Text = "Add";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Category Insert Form";
            // 
            // CategoriesInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(673, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseCat);
            this.Controls.Add(this.btnClearCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panCatInsert);
            this.Name = "CategoriesInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesInsert";
            this.Load += new System.EventHandler(this.CategoriesInsert_Load);
            this.panCatInsert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panCatInsert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCatInsert;
        private System.Windows.Forms.Label lblitemName;
        private System.Windows.Forms.Button btnCloseCat;
        private System.Windows.Forms.Button btnClearCat;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn _update;
        private System.Windows.Forms.DataGridViewTextBoxColumn _delete;
    }
}