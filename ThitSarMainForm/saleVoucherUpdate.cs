using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThitSarMainForm
{
    public partial class SaleVoucherUpdate : Form
    {
        public SaleVoucherUpdate()
        {
            InitializeComponent();
        }
        dsSaleDetail dsSaleDetail = new dsSaleDetail();
        dsSaleDetailTableAdapters.SaleDetailTableAdapter taSaleDetail = new dsSaleDetailTableAdapters.SaleDetailTableAdapter();

        dsSaleVoucher dsSaleVoucher = new dsSaleVoucher();
        dsSaleVoucherTableAdapters.SaleVoucherTableAdapter taSaleVoucher = new dsSaleVoucherTableAdapters.SaleVoucherTableAdapter();

        TextBox txt;
        TextBox txtQty;
        Button btn;


        private void SaleVoucherUpdate_Load(object sender, EventArgs e)
        {
            txtID.Text = SellList.setValueForVoucherID;
            txtCustomerName.Text = SellList.setValueForCustomerName;
            txtAddress.Text = SellList.setValueForAddress;
            txtPhoneNumber.Text = SellList.setValueForPhoneNumber;
            dtpDate.Value = Convert.ToDateTime(SellList.setValueForDate);
            


            int saleDetailsRow = taSaleDetail.FillSaleDetailsBySaleID(dsSaleDetail.SaleDetail, Convert.ToInt32(txtID.Text));
            int column = 9;

            for (int i = 0; i < saleDetailsRow; i++)
            {
                for(int j = 0; j<=column; j++)
                {
                    if(j == 0)
                    {
                        TextBox txtTempId = new TextBox();
                        txtTempId.Width = 108;
                        txtTempId.Height = 25;
                        txtTempId.Text = dsSaleDetail.SaleDetail.Rows[i][0].ToString();
                        
                        txtTempId.Visible = false;
                        flSaleVoucherUpdate.Controls.Add(txtTempId);
                    }
                    else if(j == 1)
                    {
                        TextBox txtTempSaleId = new TextBox();
                        txtTempSaleId.Width = 108;
                        txtTempSaleId.Height = 25;
                        txtTempSaleId.Text = dsSaleDetail.SaleDetail.Rows[i][1].ToString();

                        txtTempSaleId.Visible = false;
                        flSaleVoucherUpdate.Controls.Add(txtTempSaleId);
                    }
                    else if (j == 7)
                    {
                        txtQty = new TextBox();
                        txtQty.Width = 108;
                        txtQty.Height = 25;
                        txtQty.Enabled = true;

                        txtQty.Text = dsSaleDetail.SaleDetail.Rows[i][7].ToString();
                        flSaleVoucherUpdate.Controls.Add(txtQty);
                       
                        txtQty.TextChanged += new System.EventHandler(this.textChanged);
                    }
                    else if(j == 9)
                    {
                        btn = new Button();
                        btn.Width = 80;
                        btn.Height = 25;

                        btn.Text = dsSaleDetail.SaleDetail.Rows[i][0].ToString();
                        flSaleVoucherUpdate.Controls.Add(btn);

                        btn.Click += new System.EventHandler(this.btnClick);
                        btn.Click += new System.EventHandler(this.textChanged);

                    }
                    else
                    {
                        txt = new TextBox(); // creating textbox in Vocher By Columns, i (1 to 5)

                        txt.Width = 108;
                        txt.Height = 25;
                        txt.Enabled = false;
                        txt.Text = dsSaleDetail.SaleDetail.Rows[i][j].ToString(); // Add item Text from database to TextBox TextField, Check Line 161

                        flSaleVoucherUpdate.Controls.Add(txt); // add text, TextBox to Flowlayout panel
                    }
                    

                }
                

            }
            //txtTotal.Text = SellList.setTotalAmount.ToString();
            //txtPaid.Text = SellList.setPaidAmount.ToString();
            //txtLeft.Text = SellList.setLeftAmount.ToString();
            //txtTax.Text = SellList.setTax.ToString();
            reloadTotalAmount();



        }

        Button bur;
        Boolean delete;
        public void btnClick(object sender, EventArgs e)
        {
            //delete = false;
            bur = (Button)sender;
            //if (Convert.ToInt32(bur.Text)> 0)
            //{
            //    delete = true;
            //}
            DialogResult confirm = MessageBox.Show("Do you really want to delete this item?", "Deleting Item", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                taSaleDetail.DeleteSaleDetailsItem(Convert.ToInt32(bur.Text));
                reload();
                reloadTotalAmount();
                updateBtn();
            }
            else if (confirm == DialogResult.No)
            {
                
            }
            



        }
       

        public void textChanged(object sender, EventArgs e)
        {
          
            //to check sale detail is correctly inserted or not
            Boolean isSaleDetailFull = false;

            //to check 7 times loop (for insert 1 item)
            int j = 0;
            int column = 9;

            //
            int TotalSum = 0;
            int TotalAmount = 0;


            //temp variable for item detail
            string tempID = "";
            string saleTempID = "";
            string CodeID = "";
            string ItemName = "";
            string ItemBrand = "";
            string ItemSize = "";
            int Price = 0;
            int Quantity = 0;
            int Amount = 0;

            //loop all controls  in flSaleVoucher.Controls
           
            for (int i = 0; i < flSaleVoucherUpdate.Controls.Count; i++)
            {
                isSaleDetailFull = false;

                //fill control to temp variable on each its time
                if (j <= column)
                {
                    if (j == 0)
                    {
                        tempID = flSaleVoucherUpdate.Controls[i].Text;
                    }
                    else if(j == 1)
                    {
                        saleTempID = flSaleVoucherUpdate.Controls[i].Text;
                    }
                    if (j == 2)
                    {
                        CodeID = flSaleVoucherUpdate.Controls[i].Text;
                    }

                    else if (j == 3)
                    {

                        ItemName = flSaleVoucherUpdate.Controls[i].Text;
                    }

                    else if (j == 4)
                    {

                        ItemBrand = flSaleVoucherUpdate.Controls[i].Text;
                    }

                    else if (j == 5)
                    {

                        ItemSize = flSaleVoucherUpdate.Controls[i].Text;
                    }

                    else if (j == 6)
                    {
                        
                        Price = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);

                    }

                    else if (j == 7)
                    {
                        if (!flSaleVoucherUpdate.Controls[i].Text.Equals(""))
                        {
                            //if control's value is not a number then show notice
                            try
                            {
                                Quantity = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);
                            }
                            catch
                            {

                                MessageBox.Show("Please, enter the corrected format in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                flSaleVoucherUpdate.Controls[i].Focus();
                                break;
                            }
                        }

                    }

                    else if (j == 8)
                    {

                        //calculate total amount for each item
                        TotalAmount = (Quantity * Price);

                        //calculate voucher total amount
                        TotalSum += TotalAmount;

                        //fill total amount to control
                        flSaleVoucherUpdate.Controls[i].Text = TotalAmount.ToString();
                        Amount = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);

                        
                    }
                    else if(j == 9)
                    {
                        //after 7 times loop
                        isSaleDetailFull = true;
                    }
                    
                    //increase j
                    j++;
                }

                //if item is completely inserted then reset j, to insert next item
                if (isSaleDetailFull)
                {
                    j = 0;
                }


            }

            //fill voucher total amount'text
            txtTotal.Text = TotalSum.ToString();

            int leftAmount = 0;
            leftAmount = TotalSum - tempPaid;
            txtLeft.Text = leftAmount.ToString();



        }

        int tempPaid;
        int tempTotal;
        private void txtPaid_TextChanged_1(object sender, EventArgs e)
        {
            tempPaid = 0;
            tempTotal = Convert.ToInt32(txtTotal.Text);
            if (!txtPaid.Text.Equals(""))
            {
                try
                {
                    tempPaid = Convert.ToInt32(txtPaid.Text);
                }
                catch
                {
                    MessageBox.Show("Please, enter the corrected format in the selected field", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPaid.SelectAll();
                    txtPaid.Focus();
                }
            }

            txtLeft.Text = (tempTotal - tempPaid).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if(delete == true)
            //{ 
            //    taSaleDetail.DeleteSaleDetailsItem(Convert.ToInt32(bur.Text));
            //    delete = false;
            //}
     

                int saleDetailsRow = taSaleDetail.FillSaleDetailsBySaleID(dsSaleDetail.SaleDetail, Convert.ToInt32(txtID.Text));

                Boolean wrongInput = false;
                Boolean isSaleDetailFull = false;
                int j = 0;
                int column = 9;

                string tempID = "";
                string saleTempID = "";
                string CodeID = "";
                string ItemName = "";
                string ItemBrand = "";
                string ItemSize = "";
                int Price = 0;
                int Quantity = 0;
                int Amount = 0;

                

                //loop all controls in flSaleVoucher
                for (int i = 0; i < flSaleVoucherUpdate.Controls.Count; i++)
                {
                    isSaleDetailFull = false;
                    if (j <= column)
                    {
                        if (j == 0)
                        {
                            tempID = flSaleVoucherUpdate.Controls[i].Text;
                        }
                        else if(j == 1)
                        {
                            saleTempID = flSaleVoucherUpdate.Controls[i].Text; 
                        }
                        if (j == 2)
                        {
                            CodeID = flSaleVoucherUpdate.Controls[i].Text;
                          
                        }

                        else if (j == 3)
                        {

                            ItemName = flSaleVoucherUpdate.Controls[i].Text;
                          
                        }

                        else if (j == 4)
                        {

                            ItemBrand = flSaleVoucherUpdate.Controls[i].Text;
                        
                        }

                        else if (j == 5)
                        {

                            ItemSize = flSaleVoucherUpdate.Controls[i].Text;
                            
                        }

                        else if (j == 6)
                        {

                            Price = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);
                           
                        }

                        else if (j == 7)
                        {

                            if (!flSaleVoucherUpdate.Controls[i].Text.Equals(""))
                            {
                                try
                                {
                                    Quantity = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);
                                }
                                catch
                                {
                                    MessageBox.Show("Please, enter the corrected format in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    wrongInput = true;
                                    flSaleVoucherUpdate.Controls[i].Focus();
                                }
                            }
                         
                        }

                        else if (j == 8)
                        {
                            Amount = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);
                            

                        }
                        else if (j == 9)
                        {
                            
                            //after 7 times loop
                            isSaleDetailFull = true;
                            taSaleDetail.UpdateSaleDetails(CodeID, ItemName, ItemBrand, ItemSize, Price, Quantity, Amount, Convert.ToInt32(tempID));

                        }
                        //MessageBox.Show("J value " + j);
                        j++;

                    }
                    if (isSaleDetailFull)
                    {
                        
                        j = 0;
                    }

                
                
            }
            

            if(Convert.ToInt32(txtLeft.Text)<0)
            {
                if(wrongInput == true)
                {
                    MessageBox.Show("Wrong Input Format!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    taSaleVoucher.UpdateSaleVoucher(txtCustomerName.Text, txtAddress.Text, txtPhoneNumber.Text, dtpDate.Value,
                                                0, Convert.ToInt32(txtTotal.Text), Convert.ToInt32(txtPaid.Text), Convert.ToInt32(txtLeft.Text), "Paid", Convert.ToInt32(txtID.Text));
                    MessageBox.Show("Sale Voucher Update is successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                if(wrongInput == true)
                {
                    MessageBox.Show("Wrong Input Format!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    taSaleVoucher.UpdateSaleVoucher(txtCustomerName.Text, txtAddress.Text, txtPhoneNumber.Text, dtpDate.Value,
                                                 0, Convert.ToInt32(txtTotal.Text), Convert.ToInt32(txtPaid.Text), Convert.ToInt32(txtLeft.Text), "Left", Convert.ToInt32(txtID.Text));
                    MessageBox.Show("Sale Voucher Update is successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

            //taSaleVoucher.UpdateSaleVoucher(txtCustomerName.Text, txtAddress.Text, txtPhoneNumber.Text, dtpDate.Value, Convert.ToInt32(txtTax.Text), Convert.ToInt32(txtTotal.Text), Convert.ToInt32(txtPaid.Text), Convert.ToInt32(txtLeft.Text), Convert.ToInt32(txtID.Text));
            wrongInput = false;
            this.Visible = false;
            SellList sellList = new SellList();
            sellList.Show();


        }
        public void reload()
        {
            flSaleVoucherUpdate.Controls.Clear();

            txtID.Text = SellList.setValueForVoucherID;
            txtCustomerName.Text = SellList.setValueForCustomerName;
            txtAddress.Text = SellList.setValueForAddress;
            txtPhoneNumber.Text = SellList.setValueForPhoneNumber;
            dtpDate.Value = Convert.ToDateTime(SellList.setValueForDate);
            txtTotal.Text = SellList.setTotalAmount.ToString();
            txtPaid.Text = SellList.setPaidAmount.ToString();
            txtLeft.Text = SellList.setLeftAmount.ToString();
            txtTax.Text = SellList.setTax.ToString();



            int saleDetailsRow = taSaleDetail.FillSaleDetailsBySaleID(dsSaleDetail.SaleDetail, Convert.ToInt32(txtID.Text));
            int column = 9;

            for (int i = 0; i < saleDetailsRow; i++)
            {
                for (int j = 0; j <= column; j++)
                {
                    if (j == 0)
                    {
                        TextBox txtTempId = new TextBox();
                        txtTempId.Width = 108;
                        txtTempId.Height = 25;
                        txtTempId.Text = dsSaleDetail.SaleDetail.Rows[i][0].ToString();

                        txtTempId.Visible = false;
                        flSaleVoucherUpdate.Controls.Add(txtTempId);
                    }
                    else if (j == 1)
                    {
                        TextBox txtTempSaleId = new TextBox();
                        txtTempSaleId.Width = 108;
                        txtTempSaleId.Height = 25;
                        txtTempSaleId.Text = dsSaleDetail.SaleDetail.Rows[i][1].ToString();

                        txtTempSaleId.Visible = false;
                        flSaleVoucherUpdate.Controls.Add(txtTempSaleId);
                    }
                    else if (j == 7)
                    {
                        txtQty = new TextBox();
                        txtQty.Width = 108;
                        txtQty.Height = 25;
                        txtQty.Enabled = true;

                        txtQty.Text = dsSaleDetail.SaleDetail.Rows[i][7].ToString();
                        flSaleVoucherUpdate.Controls.Add(txtQty);

                        txtQty.TextChanged += new System.EventHandler(this.textChanged);
                    }
                    else if (j == 9)
                    {
                        btn = new Button();
                        btn.Width = 80;
                        btn.Height = 25;

                        btn.Text = dsSaleDetail.SaleDetail.Rows[i][0].ToString();
                        flSaleVoucherUpdate.Controls.Add(btn);

                        btn.Click += new System.EventHandler(this.btnClick);

                    }
                    else
                    {
                        txt = new TextBox(); // creating textbox in Vocher By Columns, i (1 to 5)

                        txt.Width = 108;
                        txt.Height = 25;
                        txt.Enabled = false;
                        txt.Text = dsSaleDetail.SaleDetail.Rows[i][j].ToString(); // Add item Text from database to TextBox TextField, Check Line 161

                        flSaleVoucherUpdate.Controls.Add(txt); // add text, TextBox to Flowlayout panel
                    }


                }


            }
        }

        public void reloadTotalAmount()
        {

            //to check sale detail is correctly inserted or not
            Boolean isSaleDetailFull = false;

            //to check 7 times loop (for insert 1 item)
            int j = 0;
            int column = 9;

            //
            int TotalSum = 0;
            int TotalAmount = 0;


            //temp variable for item detail
            string tempID = "";
            string saleTempID = "";
            string CodeID = "";
            string ItemName = "";
            string ItemBrand = "";
            string ItemSize = "";
            int Price = 0;
            int Quantity = 0;
            int Amount = 0;

            //loop all controls  in flSaleVoucher.Controls

            for (int i = 0; i < flSaleVoucherUpdate.Controls.Count; i++)
            {
                isSaleDetailFull = false;

                //fill control to temp variable on each its time
                if (j <= column)
                {
                    if (j == 0)
                    {
                        tempID = flSaleVoucherUpdate.Controls[i].Text;
                    }
                    else if (j == 1)
                    {
                        saleTempID = flSaleVoucherUpdate.Controls[i].Text;
                    }
                    if (j == 2)
                    {
                        CodeID = flSaleVoucherUpdate.Controls[i].Text;
                    }

                    else if (j == 3)
                    {

                        ItemName = flSaleVoucherUpdate.Controls[i].Text;
                    }

                    else if (j == 4)
                    {

                        ItemBrand = flSaleVoucherUpdate.Controls[i].Text;
                    }

                    else if (j == 5)
                    {

                        ItemSize = flSaleVoucherUpdate.Controls[i].Text;
                    }

                    else if (j == 6)
                    {

                        Price = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);

                    }

                    else if (j == 7)
                    {
                        if (!flSaleVoucherUpdate.Controls[i].Text.Equals(""))
                        {
                            //if control's value is not a number then show notice
                            try
                            {
                                Quantity = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);
                            }
                            catch
                            {

                                MessageBox.Show("Please, enter the corrected format in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                flSaleVoucherUpdate.Controls[i].Focus();
                                break;
                            }
                        }

                    }

                    else if (j == 8)
                    {

                        //calculate total amount for each item
                        TotalAmount = (Quantity * Price);

                        //calculate voucher total amount
                        TotalSum += TotalAmount;

                        //fill total amount to control
                        flSaleVoucherUpdate.Controls[i].Text = TotalAmount.ToString();
                        Amount = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);


                    }
                    else if (j == 9)
                    {
                        //after 7 times loop
                        isSaleDetailFull = true;
                    }

                    //increase j
                    j++;
                }

                //if item is completely inserted then reset j, to insert next item
                if (isSaleDetailFull)
                {
                    j = 0;
                }


            }

            //fill voucher total amount'text
            txtTotal.Text = TotalSum.ToString();

            int leftAmount = 0;
            leftAmount = TotalSum - tempPaid;
            txtLeft.Text = leftAmount.ToString();
            txtPaid.Text = SellList.setPaidAmount.ToString();
           
        }
        public void updateBtn()
        {
            int saleDetailsRow = taSaleDetail.FillSaleDetailsBySaleID(dsSaleDetail.SaleDetail, Convert.ToInt32(txtID.Text));


            Boolean isSaleDetailFull = false;
            int j = 0;
            int column = 9;

            string tempID = "";
            string saleTempID = "";
            string CodeID = "";
            string ItemName = "";
            string ItemBrand = "";
            string ItemSize = "";
            int Price = 0;
            int Quantity = 0;
            int Amount = 0;



            //loop all controls in flSaleVoucher
            for (int i = 0; i < flSaleVoucherUpdate.Controls.Count; i++)
            {
                isSaleDetailFull = false;
                if (j <= column)
                {
                    if (j == 0)
                    {
                        tempID = flSaleVoucherUpdate.Controls[i].Text;
                    }
                    else if (j == 1)
                    {
                        saleTempID = flSaleVoucherUpdate.Controls[i].Text;
                    }
                    if (j == 2)
                    {
                        CodeID = flSaleVoucherUpdate.Controls[i].Text;

                    }

                    else if (j == 3)
                    {

                        ItemName = flSaleVoucherUpdate.Controls[i].Text;

                    }

                    else if (j == 4)
                    {

                        ItemBrand = flSaleVoucherUpdate.Controls[i].Text;

                    }

                    else if (j == 5)
                    {

                        ItemSize = flSaleVoucherUpdate.Controls[i].Text;

                    }

                    else if (j == 6)
                    {

                        Price = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);

                    }

                    else if (j == 7)
                    {

                        if (!flSaleVoucherUpdate.Controls[i].Text.Equals(""))
                        {
                            try
                            {
                                Quantity = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);
                            }
                            catch
                            {
                                MessageBox.Show("Please, enter the corrected format in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                flSaleVoucherUpdate.Controls[i].Focus();
                            }
                        }

                    }

                    else if (j == 8)
                    {
                        Amount = Convert.ToInt32(flSaleVoucherUpdate.Controls[i].Text);



                    }
                    else if (j == 9)
                    {

                        //after 7 times loop
                        isSaleDetailFull = true;
                        taSaleDetail.UpdateSaleDetails(CodeID, ItemName, ItemBrand, ItemSize, Price, Quantity, Amount, Convert.ToInt32(tempID));

                    }
                    //MessageBox.Show("J value " + j);
                    j++;

                }
                if (isSaleDetailFull)
                {

                    j = 0;
                }



            }


            if (Convert.ToInt32(txtLeft.Text) < 0)
            {
                taSaleVoucher.UpdateSaleVoucher(txtCustomerName.Text, txtAddress.Text, txtPhoneNumber.Text, dtpDate.Value,
                                                0, Convert.ToInt32(txtTotal.Text), Convert.ToInt32(txtPaid.Text), Convert.ToInt32(txtLeft.Text), "Paid", Convert.ToInt32(txtID.Text));
            }
            else
            {
                taSaleVoucher.UpdateSaleVoucher(txtCustomerName.Text, txtAddress.Text, txtPhoneNumber.Text, dtpDate.Value,
                                                 0, Convert.ToInt32(txtTotal.Text), Convert.ToInt32(txtPaid.Text), Convert.ToInt32(txtLeft.Text), "Left", Convert.ToInt32(txtID.Text));
            }
        }

        private void btnCloseSaleDB_Click(object sender, EventArgs e)
        {
            Visible = false;
            SellList sellList = new SellList();
            sellList.Show();
        }

        
    }
}
