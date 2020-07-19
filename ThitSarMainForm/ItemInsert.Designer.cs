namespace ThitSarMainForm
{
    partial class ItemInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comCatName = new System.Windows.Forms.ComboBox();
            this.comTypeName = new System.Windows.Forms.ComboBox();
            this.btnCatInsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panItemView = new System.Windows.Forms.Panel();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availablestatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panInsert = new System.Windows.Forms.Panel();
            this.rbtnNotAvailable = new System.Windows.Forms.RadioButton();
            this.rbtnAvailable = new System.Windows.Forms.RadioButton();
            this.txtItemSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemBrand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblitemName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnItemClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panItemView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.panInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Types Name :";
            // 
            // comCatName
            // 
            this.comCatName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCatName.FormattingEnabled = true;
            this.comCatName.Location = new System.Drawing.Point(255, 31);
            this.comCatName.Name = "comCatName";
            this.comCatName.Size = new System.Drawing.Size(302, 30);
            this.comCatName.TabIndex = 2;
            this.comCatName.SelectedIndexChanged += new System.EventHandler(this.comCatName_SelectedIndexChanged);
            // 
            // comTypeName
            // 
            this.comTypeName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTypeName.FormattingEnabled = true;
            this.comTypeName.Location = new System.Drawing.Point(255, 76);
            this.comTypeName.Name = "comTypeName";
            this.comTypeName.Size = new System.Drawing.Size(302, 30);
            this.comTypeName.TabIndex = 3;
            this.comTypeName.SelectedIndexChanged += new System.EventHandler(this.comTypeName_SelectedIndexChanged);
            // 
            // btnCatInsert
            // 
            this.btnCatInsert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatInsert.Location = new System.Drawing.Point(572, 29);
            this.btnCatInsert.Name = "btnCatInsert";
            this.btnCatInsert.Size = new System.Drawing.Size(168, 35);
            this.btnCatInsert.TabIndex = 4;
            this.btnCatInsert.Text = "Category Insert";
            this.btnCatInsert.UseVisualStyleBackColor = true;
            this.btnCatInsert.Click += new System.EventHandler(this.btnCatInsert_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(572, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Type Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panItemView
            // 
            this.panItemView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panItemView.Controls.Add(this.dgvItem);
            this.panItemView.Location = new System.Drawing.Point(6, 125);
            this.panItemView.Name = "panItemView";
            this.panItemView.Size = new System.Drawing.Size(677, 504);
            this.panItemView.TabIndex = 6;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToResizeColumns = false;
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codeId,
            this.itemName,
            this.itemBrand,
            this.itemSize,
            this.price,
            this.availablestatus,
            this.categoryName,
            this.typeName,
            this._update,
            this._delete});
            this.dgvItem.Location = new System.Drawing.Point(-2, -2);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItem.Size = new System.Drawing.Size(672, 504);
            this.dgvItem.TabIndex = 0;
            this.dgvItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 60;
            // 
            // codeId
            // 
            this.codeId.DataPropertyName = "codeId";
            this.codeId.HeaderText = "Code";
            this.codeId.Name = "codeId";
            this.codeId.ReadOnly = true;
            this.codeId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codeId.Width = 80;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemName.Width = 125;
            // 
            // itemBrand
            // 
            this.itemBrand.DataPropertyName = "itemBrand";
            this.itemBrand.HeaderText = "Item Brand";
            this.itemBrand.Name = "itemBrand";
            this.itemBrand.ReadOnly = true;
            this.itemBrand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemBrand.Width = 125;
            // 
            // itemSize
            // 
            this.itemSize.DataPropertyName = "itemSize";
            this.itemSize.HeaderText = "Item Size";
            this.itemSize.Name = "itemSize";
            this.itemSize.ReadOnly = true;
            this.itemSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // availablestatus
            // 
            this.availablestatus.DataPropertyName = "available";
            this.availablestatus.HeaderText = "Available";
            this.availablestatus.Name = "availablestatus";
            this.availablestatus.ReadOnly = true;
            this.availablestatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "categoryName";
            this.categoryName.HeaderText = "Category Name";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            this.categoryName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryName.Visible = false;
            // 
            // typeName
            // 
            this.typeName.DataPropertyName = "typeName";
            this.typeName.HeaderText = "Type Name";
            this.typeName.Name = "typeName";
            this.typeName.ReadOnly = true;
            this.typeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeName.Visible = false;
            // 
            // _update
            // 
            this._update.DataPropertyName = "_update";
            this._update.HeaderText = "Update";
            this._update.Name = "_update";
            this._update.ReadOnly = true;
            this._update.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _delete
            // 
            this._delete.DataPropertyName = "_delete";
            this._delete.HeaderText = "Delete";
            this._delete.Name = "_delete";
            this._delete.ReadOnly = true;
            this._delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panInsert
            // 
            this.panInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panInsert.Controls.Add(this.rbtnNotAvailable);
            this.panInsert.Controls.Add(this.rbtnAvailable);
            this.panInsert.Controls.Add(this.txtItemSize);
            this.panInsert.Controls.Add(this.label6);
            this.panInsert.Controls.Add(this.txtItemBrand);
            this.panInsert.Controls.Add(this.label5);
            this.panInsert.Controls.Add(this.txtPrice);
            this.panInsert.Controls.Add(this.label4);
            this.panInsert.Controls.Add(this.txtItemName);
            this.panInsert.Controls.Add(this.lblitemName);
            this.panInsert.Controls.Add(this.txtCode);
            this.panInsert.Controls.Add(this.label3);
            this.panInsert.Location = new System.Drawing.Point(689, 125);
            this.panInsert.Name = "panInsert";
            this.panInsert.Size = new System.Drawing.Size(290, 440);
            this.panInsert.TabIndex = 7;
            // 
            // rbtnNotAvailable
            // 
            this.rbtnNotAvailable.AutoSize = true;
            this.rbtnNotAvailable.Location = new System.Drawing.Point(136, 384);
            this.rbtnNotAvailable.Name = "rbtnNotAvailable";
            this.rbtnNotAvailable.Size = new System.Drawing.Size(88, 17);
            this.rbtnNotAvailable.TabIndex = 20;
            this.rbtnNotAvailable.TabStop = true;
            this.rbtnNotAvailable.Text = "Not Available";
            this.rbtnNotAvailable.UseVisualStyleBackColor = true;
            this.rbtnNotAvailable.CheckedChanged += new System.EventHandler(this.rbtnNotAvailable_CheckedChanged);
            // 
            // rbtnAvailable
            // 
            this.rbtnAvailable.AutoSize = true;
            this.rbtnAvailable.Checked = true;
            this.rbtnAvailable.Location = new System.Drawing.Point(8, 384);
            this.rbtnAvailable.Name = "rbtnAvailable";
            this.rbtnAvailable.Size = new System.Drawing.Size(68, 17);
            this.rbtnAvailable.TabIndex = 19;
            this.rbtnAvailable.TabStop = true;
            this.rbtnAvailable.Text = "Available";
            this.rbtnAvailable.UseVisualStyleBackColor = true;
            this.rbtnAvailable.CheckedChanged += new System.EventHandler(this.rbtnAvailable_CheckedChanged);
            // 
            // txtItemSize
            // 
            this.txtItemSize.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSize.Location = new System.Drawing.Point(6, 260);
            this.txtItemSize.Name = "txtItemSize";
            this.txtItemSize.Size = new System.Drawing.Size(260, 29);
            this.txtItemSize.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Item Size :";
            // 
            // txtItemBrand
            // 
            this.txtItemBrand.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemBrand.Location = new System.Drawing.Point(6, 180);
            this.txtItemBrand.Name = "txtItemBrand";
            this.txtItemBrand.Size = new System.Drawing.Size(260, 29);
            this.txtItemBrand.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Item Brand :";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(6, 335);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(166, 29);
            this.txtPrice.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price :";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(6, 100);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(260, 29);
            this.txtItemName.TabIndex = 11;
            // 
            // lblitemName
            // 
            this.lblitemName.AutoSize = true;
            this.lblitemName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemName.Location = new System.Drawing.Point(2, 64);
            this.lblitemName.Name = "lblitemName";
            this.lblitemName.Size = new System.Drawing.Size(110, 22);
            this.lblitemName.TabIndex = 10;
            this.lblitemName.Text = "Item Name :";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(77, 11);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(129, 29);
            this.txtCode.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Code :";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(696, 585);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnItemClear
            // 
            this.btnItemClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemClear.Location = new System.Drawing.Point(781, 585);
            this.btnItemClear.Name = "btnItemClear";
            this.btnItemClear.Size = new System.Drawing.Size(75, 35);
            this.btnItemClear.TabIndex = 9;
            this.btnItemClear.Text = "Clear";
            this.btnItemClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(889, 585);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ItemInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnItemClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panInsert);
            this.Controls.Add(this.panItemView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCatInsert);
            this.Controls.Add(this.comTypeName);
            this.Controls.Add(this.comCatName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thit Sar";
            this.Load += new System.EventHandler(this.ItemInsert_Load);
            this.panItemView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.panInsert.ResumeLayout(false);
            this.panInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comCatName;
        private System.Windows.Forms.ComboBox comTypeName;
        private System.Windows.Forms.Button btnCatInsert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panItemView;
        private System.Windows.Forms.Panel panInsert;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblitemName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnItemClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.RadioButton rbtnNotAvailable;
        private System.Windows.Forms.RadioButton rbtnAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn availablestatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _update;
        private System.Windows.Forms.DataGridViewTextBoxColumn _delete;
    }
}