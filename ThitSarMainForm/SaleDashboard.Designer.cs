namespace ThitSarMainForm
{
    partial class SaleDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrintSaleDB = new System.Windows.Forms.Button();
            this.btnClearSaleDB = new System.Windows.Forms.Button();
            this.btnCloseSaleDB = new System.Windows.Forms.Button();
            this.btnSaveSaleDB = new System.Windows.Forms.Button();
            this.fLPanelButCat = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelType = new System.Windows.Forms.FlowLayoutPanel();
            this.panelShowItem = new System.Windows.Forms.Panel();
            this.flSaleVoucher = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customerInfoPanel = new System.Windows.Forms.Panel();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtTaxSaleDB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLeftASaleDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaidASaleDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalASaleDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearchBoxSaleDB = new System.Windows.Forms.TextBox();
            this.btnBackSaleDB = new System.Windows.Forms.Button();
            this.txtCodeSaleDB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelShowItem.SuspendLayout();
            this.panel2.SuspendLayout();
            this.customerInfoPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPrintSaleDB);
            this.panel1.Controls.Add(this.btnClearSaleDB);
            this.panel1.Controls.Add(this.btnCloseSaleDB);
            this.panel1.Controls.Add(this.btnSaveSaleDB);
            this.panel1.Location = new System.Drawing.Point(5, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 85);
            this.panel1.TabIndex = 0;
            // 
            // btnPrintSaleDB
            // 
            this.btnPrintSaleDB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSaleDB.Location = new System.Drawing.Point(723, 25);
            this.btnPrintSaleDB.Name = "btnPrintSaleDB";
            this.btnPrintSaleDB.Size = new System.Drawing.Size(79, 35);
            this.btnPrintSaleDB.TabIndex = 21;
            this.btnPrintSaleDB.Text = "Print";
            this.btnPrintSaleDB.UseVisualStyleBackColor = true;
            // 
            // btnClearSaleDB
            // 
            this.btnClearSaleDB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSaleDB.Location = new System.Drawing.Point(1095, 25);
            this.btnClearSaleDB.Name = "btnClearSaleDB";
            this.btnClearSaleDB.Size = new System.Drawing.Size(79, 35);
            this.btnClearSaleDB.TabIndex = 20;
            this.btnClearSaleDB.Text = "Clear";
            this.btnClearSaleDB.UseVisualStyleBackColor = true;
            this.btnClearSaleDB.Click += new System.EventHandler(this.btnClearSaleDB_Click);
            // 
            // btnCloseSaleDB
            // 
            this.btnCloseSaleDB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSaleDB.Location = new System.Drawing.Point(1232, 25);
            this.btnCloseSaleDB.Name = "btnCloseSaleDB";
            this.btnCloseSaleDB.Size = new System.Drawing.Size(79, 35);
            this.btnCloseSaleDB.TabIndex = 19;
            this.btnCloseSaleDB.Text = "Close";
            this.btnCloseSaleDB.UseVisualStyleBackColor = true;
            this.btnCloseSaleDB.Click += new System.EventHandler(this.btnCloseSaleDB_Click);
            // 
            // btnSaveSaleDB
            // 
            this.btnSaveSaleDB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSaleDB.Location = new System.Drawing.Point(566, 25);
            this.btnSaveSaleDB.Name = "btnSaveSaleDB";
            this.btnSaveSaleDB.Size = new System.Drawing.Size(79, 35);
            this.btnSaveSaleDB.TabIndex = 18;
            this.btnSaveSaleDB.Text = "Save";
            this.btnSaveSaleDB.UseVisualStyleBackColor = true;
            this.btnSaveSaleDB.Click += new System.EventHandler(this.btnSaveSaleDB_Click);
            // 
            // fLPanelButCat
            // 
            this.fLPanelButCat.AutoScroll = true;
            this.fLPanelButCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLPanelButCat.Location = new System.Drawing.Point(5, 8);
            this.fLPanelButCat.Name = "fLPanelButCat";
            this.fLPanelButCat.Size = new System.Drawing.Size(108, 602);
            this.fLPanelButCat.TabIndex = 1;
            // 
            // flowLayoutPanelType
            // 
            this.flowLayoutPanelType.AutoScroll = true;
            this.flowLayoutPanelType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelType.Location = new System.Drawing.Point(116, 8);
            this.flowLayoutPanelType.Name = "flowLayoutPanelType";
            this.flowLayoutPanelType.Size = new System.Drawing.Size(435, 517);
            this.flowLayoutPanelType.TabIndex = 2;
            // 
            // panelShowItem
            // 
            this.panelShowItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShowItem.Controls.Add(this.flSaleVoucher);
            this.panelShowItem.Controls.Add(this.panel2);
            this.panelShowItem.Controls.Add(this.customerInfoPanel);
            this.panelShowItem.Controls.Add(this.txtTaxSaleDB);
            this.panelShowItem.Controls.Add(this.label5);
            this.panelShowItem.Controls.Add(this.txtLeftASaleDB);
            this.panelShowItem.Controls.Add(this.label4);
            this.panelShowItem.Controls.Add(this.txtPaidASaleDB);
            this.panelShowItem.Controls.Add(this.label3);
            this.panelShowItem.Controls.Add(this.txtTotalASaleDB);
            this.panelShowItem.Controls.Add(this.label2);
            this.panelShowItem.Controls.Add(this.label1);
            this.panelShowItem.Controls.Add(this.dtpDate);
            this.panelShowItem.Location = new System.Drawing.Point(557, 8);
            this.panelShowItem.Name = "panelShowItem";
            this.panelShowItem.Size = new System.Drawing.Size(806, 602);
            this.panelShowItem.TabIndex = 3;
            // 
            // flSaleVoucher
            // 
            this.flSaleVoucher.AutoScroll = true;
            this.flSaleVoucher.BackColor = System.Drawing.Color.Silver;
            this.flSaleVoucher.Location = new System.Drawing.Point(3, 164);
            this.flSaleVoucher.Name = "flSaleVoucher";
            this.flSaleVoucher.Size = new System.Drawing.Size(798, 337);
            this.flSaleVoucher.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(3, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 42);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(3, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 5);
            this.panel4.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(707, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(589, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(489, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(358, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Item Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(240, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Item Brand";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(130, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Item Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Code ID";
            // 
            // customerInfoPanel
            // 
            this.customerInfoPanel.BackColor = System.Drawing.Color.Silver;
            this.customerInfoPanel.Controls.Add(this.lblPhoneNumber);
            this.customerInfoPanel.Controls.Add(this.lblAddress);
            this.customerInfoPanel.Controls.Add(this.lblCustomerName);
            this.customerInfoPanel.Controls.Add(this.txtPhoneNumber);
            this.customerInfoPanel.Controls.Add(this.txtAddress);
            this.customerInfoPanel.Controls.Add(this.txtCustomerName);
            this.customerInfoPanel.Location = new System.Drawing.Point(3, 43);
            this.customerInfoPanel.Name = "customerInfoPanel";
            this.customerInfoPanel.Size = new System.Drawing.Size(798, 81);
            this.customerInfoPanel.TabIndex = 11;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(537, 14);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(114, 16);
            this.lblPhoneNumber.TabIndex = 46;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(284, 14);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 16);
            this.lblAddress.TabIndex = 45;
            this.lblAddress.Text = "Address:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(19, 11);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(122, 16);
            this.lblCustomerName.TabIndex = 44;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(575, 35);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(181, 26);
            this.txtPhoneNumber.TabIndex = 43;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(309, 35);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(181, 26);
            this.txtAddress.TabIndex = 42;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(66, 35);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(181, 26);
            this.txtCustomerName.TabIndex = 41;
            // 
            // txtTaxSaleDB
            // 
            this.txtTaxSaleDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxSaleDB.Location = new System.Drawing.Point(349, 507);
            this.txtTaxSaleDB.Name = "txtTaxSaleDB";
            this.txtTaxSaleDB.Size = new System.Drawing.Size(170, 26);
            this.txtTaxSaleDB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tax :";
            // 
            // txtLeftASaleDB
            // 
            this.txtLeftASaleDB.Enabled = false;
            this.txtLeftASaleDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftASaleDB.Location = new System.Drawing.Point(625, 571);
            this.txtLeftASaleDB.Name = "txtLeftASaleDB";
            this.txtLeftASaleDB.ReadOnly = true;
            this.txtLeftASaleDB.Size = new System.Drawing.Size(170, 26);
            this.txtLeftASaleDB.TabIndex = 8;
            this.txtLeftASaleDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(531, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Left Amount :";
            // 
            // txtPaidASaleDB
            // 
            this.txtPaidASaleDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidASaleDB.Location = new System.Drawing.Point(625, 539);
            this.txtPaidASaleDB.Name = "txtPaidASaleDB";
            this.txtPaidASaleDB.Size = new System.Drawing.Size(170, 26);
            this.txtPaidASaleDB.TabIndex = 6;
            this.txtPaidASaleDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaidASaleDB.TextChanged += new System.EventHandler(this.txtPaidASaleDB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paid Amount :";
            // 
            // txtTotalASaleDB
            // 
            this.txtTotalASaleDB.Enabled = false;
            this.txtTotalASaleDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalASaleDB.Location = new System.Drawing.Point(625, 507);
            this.txtTotalASaleDB.Name = "txtTotalASaleDB";
            this.txtTotalASaleDB.ReadOnly = true;
            this.txtTotalASaleDB.Size = new System.Drawing.Size(170, 26);
            this.txtTotalASaleDB.TabIndex = 4;
            this.txtTotalASaleDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Amount :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(595, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txtSearchBoxSaleDB);
            this.panel3.Controls.Add(this.btnBackSaleDB);
            this.panel3.Controls.Add(this.txtCodeSaleDB);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(116, 527);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 83);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Search Item Name or Code";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearchBoxSaleDB
            // 
            this.txtSearchBoxSaleDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBoxSaleDB.Location = new System.Drawing.Point(40, 8);
            this.txtSearchBoxSaleDB.Name = "txtSearchBoxSaleDB";
            this.txtSearchBoxSaleDB.Size = new System.Drawing.Size(181, 26);
            this.txtSearchBoxSaleDB.TabIndex = 39;
            // 
            // btnBackSaleDB
            // 
            this.btnBackSaleDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSaleDB.Location = new System.Drawing.Point(354, 47);
            this.btnBackSaleDB.Name = "btnBackSaleDB";
            this.btnBackSaleDB.Size = new System.Drawing.Size(75, 31);
            this.btnBackSaleDB.TabIndex = 13;
            this.btnBackSaleDB.Text = "Back";
            this.btnBackSaleDB.UseVisualStyleBackColor = true;
            // 
            // txtCodeSaleDB
            // 
            this.txtCodeSaleDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeSaleDB.Location = new System.Drawing.Point(340, 4);
            this.txtCodeSaleDB.Name = "txtCodeSaleDB";
            this.txtCodeSaleDB.Size = new System.Drawing.Size(89, 26);
            this.txtCodeSaleDB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(287, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Code :";
            // 
            // SaleDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1375, 708);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelShowItem);
            this.Controls.Add(this.flowLayoutPanelType);
            this.Controls.Add(this.fLPanelButCat);
            this.Controls.Add(this.panel1);
            this.Name = "SaleDashboard";
            this.Text = "SaleDashboard";
            this.Load += new System.EventHandler(this.SaleDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panelShowItem.ResumeLayout(false);
            this.panelShowItem.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.customerInfoPanel.ResumeLayout(false);
            this.customerInfoPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel fLPanelButCat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelType;
        private System.Windows.Forms.Panel panelShowItem;
        private System.Windows.Forms.TextBox txtTaxSaleDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLeftASaleDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaidASaleDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalASaleDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearchBoxSaleDB;
        private System.Windows.Forms.Button btnBackSaleDB;
        private System.Windows.Forms.TextBox txtCodeSaleDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrintSaleDB;
        private System.Windows.Forms.Button btnClearSaleDB;
        private System.Windows.Forms.Button btnCloseSaleDB;
        private System.Windows.Forms.Button btnSaveSaleDB;
        private System.Windows.Forms.Panel customerInfoPanel;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flSaleVoucher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
    }
}