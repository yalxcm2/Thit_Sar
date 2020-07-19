using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThitSarMainForm
{
    public partial class SaleDashboard : Form
    {
        public SaleDashboard()
        {
            InitializeComponent();
        }

        dsCategory dsCategory = new dsCategory();
        dsCategoryTableAdapters.CategoryTableAdapter taCategory = new dsCategoryTableAdapters.CategoryTableAdapter();

        dsType dsType = new dsType();
        dsTypeTableAdapters.TypeTableAdapter taType = new dsTypeTableAdapters.TypeTableAdapter();

        dsItem dsItem = new dsItem();
        dsItemTableAdapters.ItemTableAdapter taItem = new dsItemTableAdapters.ItemTableAdapter();

        dsSaleDetail dsSaleDetail = new dsSaleDetail();
        dsSaleDetailTableAdapters.SaleDetailTableAdapter taSaleDetail = new dsSaleDetailTableAdapters.SaleDetailTableAdapter();

        dsSaleVoucher dsSaleVoucher = new dsSaleVoucher();
        dsSaleVoucherTableAdapters.SaleVoucherTableAdapter taSaleVoucher = new dsSaleVoucherTableAdapters.SaleVoucherTableAdapter();

        TextBox txtQty;
        TextBox txtAmount;
        TextBox txt;

        List<string> list;

        int quantity = 0;
        int amount = 0;
        int sum = 0;
        int totalAmount = 0;
        int paidAmount = 0;
        int leftAmount = 0;

        Boolean isUpdate = false;

        List<clsSaleDetail> l;


        private void SaleDashboard_Load(object sender, EventArgs e)
        {
            txtTotalASaleDB.Text = "0";
            txtTaxSaleDB.Text = "0";
            txtPaidASaleDB.Text = "0";
            //fLPanelButCat.Parent = SaleDashboard;
            //fLPanelButCat.BackColor = Color.Transparent;
            int btnRow = taCategory.FillCategoryByCategory(dsCategory.Category); // Searching Category from Category Table

            

            int top = 50;
            int left = 50;
            for(int i=0;i<btnRow;i++)
            {
                Button button = new Button(); // creating Button by Category Rows
                
                button.Left = left;
                button.Top = top;
                button.Width = 98;
                button.Height = 72;
                button.BackColor = Color.White;

                button.Text = dsCategory.Category.Rows[i]["categoryName"].ToString(); // Adding Button Text with categoryName from category Table

                this.Controls.Add(button);
                fLPanelButCat.Controls.Add(button);

                top += button.Height + 2;
                button.Click += new System.EventHandler(this.btnClick); // Calling btnClick method by Button Click Event, btnClick method equal Type, Line 77
                

            }
            

        }
        private void btnClick(object sender, EventArgs e) // Clicking Category > Type
        {
            Button cur = (Button)sender;
            int curBtnRow = taType.FillTypeByCategory(dsType.Type, cur.Text); // Searching Type from Type Table By Category Name

            string str = cur.Text;

            clearType();

            int top = 50;
            int left = 50;
            for (int i = 0; i < curBtnRow; i++)
            {
                
                Button button = new Button();  // creating Button by Type Rows

                button.Left = left;
                button.Top = top;
                button.Width = 98;
                button.Height = 72;
                button.BackColor = Color.White;

                button.Text = dsType.Type.Rows[i]["typeName"].ToString(); // Adding Button Text with typeName from type Table

                this.Controls.Add(button);
                
                flowLayoutPanelType.Controls.Add(button);

                top += button.Height + 2;
                
                button.Click += new System.EventHandler(this.btnClickType); // Calling btnClickType method by Button Click Event, btnClickType method equal item, Line 116




            }

        }

        private void btnClickType(object sender, EventArgs e) // Clicking Category > Type > Item
        {
            Button cur = (Button)sender;

            int curBtnRow = taItem.FillItemByTypeNameAndAvailable(dsItem.Item, cur.Text, "Available"); // Searching Item from Item Table By TypeName and Item status is Available

            clearType();

            int top = 50;
            int left = 50;
            for (int i = 0; i < curBtnRow; i++)
            {

                Button button = new Button();  // creating Button by Item Rows

                button.Left = left;
                button.Top = top;
                button.Width = 98;
                button.Height = 72;
                button.BackColor = Color.White;

                button.Text = dsItem.Item.Rows[i]["itemName"].ToString();
                //button.Text = dsItem.Item.Rows[i]["itemName"].ToString()+"\n" + dsItem.Item.Rows[i]["price"].ToString() + "\n" + dsItem.Item.Rows[i]["itemSize"].ToString();
                
               

                this.Controls.Add(button);

                flowLayoutPanelType.Controls.Add(button);

                top += button.Height + 2;
                button.Click += new System.EventHandler(this.btnClickForVoucher); // Calling btnClickForVoucher method by Button Click Event, btnClickForVoucher method equal item adding to vocher , Line 157
                button.Click += new System.EventHandler(this.txtQuantity_Leave); // Calling txtQuantity_Leave method by Button Click Event, txtQuantity_Leave method equal Caculate Amount by quantity , Line 205


            }

        }


        // create method - click item to add voucher (item)
        private void btnClickForVoucher(object sender, EventArgs e) // Voucher
        {
            Button cur = (Button)sender;

            taItem.FillItemByItemName(dsItem.Item, cur.Text); // searching item by item Name
           
            int curLblRow = 5; // creating row ( 1 = Code ID, 2 = Item Name, 3 = Item Brand, 4 = Item Size, 5 = Price

            for (int i = 1; i <= curLblRow; i++)
            {
                txt = new TextBox(); // creating textbox in Vocher By Columns, i (1 to 5)
                
                txt.Width = 108;
                txt.Height = 25;

                txt.Text = dsItem.Item.Rows[0][i].ToString(); // Add item Text from database to TextBox TextField, Check Line 161
              
                flSaleVoucher.Controls.Add(txt); // add text, TextBox to Flowlayout panel

                txt.Enabled = false;

               


            }
            txtQty = new TextBox(); // creating textbox in Vocher By Columns, this is equal colum 6
            txtAmount = new TextBox(); // creating textbox in Vocher By Columns, this is equal colum 7

            txtQty.Text = "0";
            txtAmount.Text = "0";

            txtQty.Width = 108;
            txtQty.Height = 25;
            txtAmount.Width = 108;
            txtAmount.Height = 25;
            txtAmount.Enabled = false;

            flSaleVoucher.Controls.Add(txtQty);
            flSaleVoucher.Controls.Add(txtAmount);  

            txtQty.TextChanged += new System.EventHandler(this.textChanged); // method calling txtQuantity_Leave by txtQty Leave Action Event - Line 205
            txtQty.TextChanged += new System.EventHandler(this.textChanged); // method calling txtTotalASaleDB_Enter by txtQty Leave Action Event - Line 234
            
        }
        


        private void txtQuantity_Leave(object sender, EventArgs e) // Calculate Amount with Quantity and Item Price
        {
            

            //quantity = Convert.ToInt32(txtQty.Text); // quantity = quantity Text Field
            //amount = Convert.ToInt32(dsItem.Item.Rows[0][5].ToString()); // amount = price Text Field
            //sum = quantity * amount;
            //txtAmount.Text = sum.ToString(); // adding Amount to Amount Text Field, 

            //flSaleVoucher.Controls.Add(txtQty);
            //flSaleVoucher.Controls.Add(txtAmount);
            
         
        }

        private void clearType()
        {
            
            flowLayoutPanelType.Controls.Clear();
            txtTotalASaleDB.Text = "0";
            txtPaidASaleDB.Text = "0";
            txtLeftASaleDB.Text = "0";
        }

        private void btnClearSaleDB_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";

            flSaleVoucher.Controls.Clear();
            
            txtTotalASaleDB.Text = "0";
            txtPaidASaleDB.Text = "0";
            txtLeftASaleDB.Text = "0";
        }

        private void allClear()
        {
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";

            flSaleVoucher.Controls.Clear();

            txtTotalASaleDB.Text = "0";
            txtPaidASaleDB.Text = "0";
            txtLeftASaleDB.Text = "0";
        }

        private void txtTotalASaleDB_Enter(object sender, EventArgs e) // Calculate Total Amount
        {
            
            //totalAmount += sum;
            //txtTotalASaleDB.Text = totalAmount.ToString(); // Adding Total Amount to Total Amount Text Field
            //txtLeftASaleDB.Text = totalAmount.ToString();
        }

        int tempPaid;
        int tempTotal;
        private void txtPaidASaleDB_TextChanged(object sender, EventArgs e)
        {
            tempPaid = 0;
            tempTotal = Convert.ToInt32(txtTotalASaleDB.Text);
            if (!txtPaidASaleDB.Text.Equals(""))
            {
                try
                {
                    tempPaid = Convert.ToInt32(txtPaidASaleDB.Text);
                }
                catch
                {
                    MessageBox.Show("Please, enter the corrected format in the selected field", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPaidASaleDB.SelectAll();
                    txtPaidASaleDB.Focus();
                }
            }
            
            txtLeftASaleDB.Text = (tempTotal - tempPaid).ToString();

            //paidAmount = 0;
            //paidAmount = Convert.ToInt32(txtPaidASaleDB.Text); // paidAmount = Paid Amount Text Field
            //leftAmount = totalAmount - paidAmount;
            //txtLeftASaleDB.Text = leftAmount.ToString();// Adding Left Amount to Left Amount Text Field

        }

        private void btnSaveSaleDB_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter customer name in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerName.Focus();
                txtCustomerName.SelectAll();
            }
            else if (txtAddress.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter address in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                txtAddress.SelectAll();
            }
            else if (txtPhoneNumber.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter phone number in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNumber.Focus();
                txtPhoneNumber.SelectAll();
            }
            //else if (txtPaidASaleDB.Text.Equals(string.Empty))
            //{
            //    MessageBox.Show("Please enter paid amount in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtPaidASaleDB.Focus();
            //    txtPaidASaleDB.SelectAll();
            //}
            else
            {
                //if user didn't enter any item then show notice
                if(flSaleVoucher.Controls.Count < 6)
                {
                    MessageBox.Show("Please, at least enter 1 item for voucher!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    //insert sale voucher
                    if (!isUpdate)
                    {

                        //insert sale voucher
                        int checkSaleVoucherInsertID = taSaleVoucher.InsertSaleVoucher(txtCustomerName.Text, txtAddress.Text, txtPhoneNumber.Text, dtpDate.Value, 0,
                                                                                       Convert.ToInt32(txtTotalASaleDB.Text), Convert.ToInt32(txtPaidASaleDB.Text), Convert.ToInt32(txtLeftASaleDB.Text), "Left", "Update", "Delete");
                        int checkSaleSaleDetailInsertID = 0;

                        if (checkSaleVoucherInsertID > 0)
                        {
                            //get last inserted sale voucher' ID
                            taSaleVoucher.FillMaxIDByQuery(dsSaleVoucher.SaleVoucher);
                            int SaleIDTemp = Convert.ToInt32(dsSaleVoucher.SaleVoucher.Rows[0]["last_id"]);

                            //to check sale detail item is inserted or not
                            Boolean isSaleDetailFull = false;
                            int j = 0;


                            //temp variable for sale detail item
                            string CodeID = "";
                            string ItemName = "";
                            string ItemBrand = "";
                            string ItemSize = "";
                            int Price = 0;
                            int Quantity = 0;
                            int Amount = 0;


                            //loop all controls in flSaleVoucher
                            for (int i = 0; i < flSaleVoucher.Controls.Count; i++)
                            {
                                isSaleDetailFull = false;
                                if (j < 7)
                                {
                                    if (j == 0)
                                    {
                                        CodeID = flSaleVoucher.Controls[i].Text;
                                        //break;
                                    }

                                    else if (j == 1)
                                    {

                                        ItemName = flSaleVoucher.Controls[i].Text;
                                        //break;
                                    }

                                    else if (j == 2)
                                    {

                                        ItemBrand = flSaleVoucher.Controls[i].Text;
                                        //break;
                                    }

                                    else if (j == 3)
                                    {

                                        ItemSize = flSaleVoucher.Controls[i].Text;
                                        // MessageBox.Show(ItemSize);
                                        //break;
                                    }

                                    else if (j == 4)
                                    {

                                        Price = Convert.ToInt32(flSaleVoucher.Controls[i].Text);
                                        //break;
                                    }

                                    else if (j == 5)
                                    {

                                        if (!flSaleVoucher.Controls[i].Text.Equals(""))
                                        {
                                            try
                                            {
                                                Quantity = Convert.ToInt32(flSaleVoucher.Controls[i].Text);
                                            }
                                            catch
                                            {
                                                MessageBox.Show("Please, enter the corrected format in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                flSaleVoucher.Controls[i].Focus();
                                            }
                                        }
                                        //break;
                                    }

                                    else if (j == 6)
                                    {
                                        Amount = Convert.ToInt32(flSaleVoucher.Controls[i].Text);
                                        checkSaleSaleDetailInsertID = taSaleDetail.InsertSaleDetail(SaleIDTemp, CodeID, ItemName, ItemBrand, ItemSize, Price, Quantity, Amount);
                                        //taSaleVoucher.InsertSaleVoucher(txtCustomerName.Text, txtAddress.Text, txtPhoneNumber.Text, dtpVoucher.Value, CodeID, ItemName, ItemBrand, ItemSize, Price, Quantity, Amount, 0, Convert.ToInt32(txtTotalASaleDB.Text), Convert.ToInt32(txtPaidASaleDB.Text), Convert.ToInt32(txtLeftASaleDB.Text), "Left");

                                        isSaleDetailFull = true;
                                        //break;
                                    }
                                    j++;
                                }
                                if (isSaleDetailFull)
                                {

                                    j = 0;
                                }

                            }
                            if (checkSaleSaleDetailInsertID > 0)
                            {
                                if(Convert.ToInt32(txtLeftASaleDB.Text) == 0)
                                {
                                    taSaleVoucher.UpdateVoucherStatus("Paid", SaleIDTemp);
                                }
                                
                                MessageBox.Show("Sale Voucher is successful created!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                allClear();
                            }

                        }

                    }
                    else
                    {

                    }
                }
                
            }

        }

        private void btnCloseSaleDB_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        public void textChanged(object sender, EventArgs e)
        {
            //to check sale detail is correctly inserted or not
            Boolean isSaleDetailFull = false;

            //to check 7 times loop (for insert 1 item)
            int j = 0;

            //
            int TotalSum = 0;
            int TotalAmount = 0;


            //temp variable for item detail
            string CodeID = "";
            string ItemName = "";
            string ItemBrand = "";
            string ItemSize = "";
            int Price = 0;
            int Quantity = 0;
            int Amount = 0;

            //loop all controls  in flSaleVoucher.Controls
            for (int i = 0; i < flSaleVoucher.Controls.Count; i++)
            {
                isSaleDetailFull = false;

                //fill control to temp variable on each its time
                if (j < 7)
                {
                    if (j == 0)
                    {
                        CodeID = flSaleVoucher.Controls[i].Text;
                    }

                    else if (j == 1)
                    {

                        ItemName = flSaleVoucher.Controls[i].Text;
                    }

                    else if (j == 2)
                    {

                        ItemBrand = flSaleVoucher.Controls[i].Text;
                    }

                    else if (j == 3)
                    {

                        ItemSize = flSaleVoucher.Controls[i].Text;
                    }

                    else if (j == 4)
                    {

                        Price = Convert.ToInt32(flSaleVoucher.Controls[i].Text);
                    }

                    else if (j == 5)
                    {
                        if(!flSaleVoucher.Controls[i].Text.Equals(""))
                        {
                            //if control's value is not a number then show notice
                            try
                            {
                                Quantity = Convert.ToInt32(flSaleVoucher.Controls[i].Text);
                            }
                            catch
                            {
                                    
                                MessageBox.Show("Please, enter the corrected format in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                flSaleVoucher.Controls[i].Focus();
                                break;
                            }
                        }
                        
                    }

                    else if (j == 6)
                    {

                        //calculate total amount for each item
                        TotalAmount = (Quantity * Price);

                        //calculate voucher total amount
                        TotalSum += TotalAmount;

                        //fill total amount to control
                        flSaleVoucher.Controls[i].Text = TotalAmount.ToString();
                        Amount = Convert.ToInt32(flSaleVoucher.Controls[i].Text);

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
            txtTotalASaleDB.Text = TotalSum.ToString();

            int leftAmount = 0;
            leftAmount = TotalSum - tempPaid;
            txtLeftASaleDB.Text = leftAmount.ToString();
        }
    }


}
