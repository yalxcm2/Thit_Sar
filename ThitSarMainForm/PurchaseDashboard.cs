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
    public partial class PurchaseDashboard : Form
    {
        public PurchaseDashboard()
        {
            InitializeComponent();
        }

        private void PurchaseDashboard_Load(object sender, EventArgs e)
        {
            taPurchase.FillPurchase(dsPurchase.Purchase);
            dgvPurchase.DataSource = dsPurchase.Purchase;
        }

        Boolean isUpdate = false;
        int UpdateID;

        dsPurchase dsPurchase = new dsPurchase();
        dsPurchaseTableAdapters.PurchaseTableAdapter taPurchase = new dsPurchaseTableAdapters.PurchaseTableAdapter();


        private void btnInsertPD_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter reason in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemName.Focus();
                txtItemName.SelectAll();
            }
            else if (txtCost.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter cost in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCost.Focus();
                txtCost.SelectAll();
            }
            else if (txtSuppName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter supplier name in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSuppName.Focus();
                txtSuppName.SelectAll();
            }
            else if (txtSuppAddress.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter supplier address in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSuppAddress.Focus();
                txtSuppAddress.SelectAll();
            }
            else if (txtPhoneNumber.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter supplier phone number in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNumber.Focus();
                txtPhoneNumber.SelectAll();
            }

            else
            {
                if (!isUpdate)
                {
                    try
                    {

                        int cv1 = Convert.ToInt32(txtCost.Text);
                        int cv2 = Convert.ToInt32(txtPhoneNumber.Text);


                        //DateTime dp1 = dateTimePicker1.Value;
                        //// Modify next line, set HH:MM to HH:mm
                        //String dpstring = dp1.ToString("MMMM dd, yyyy - dddd HH:mm");
                        //MessageBox.Show("MB10 ~ " + dpstring, "Date/Time Saved");


                        int i = taPurchase.InsertPurchase(txtItemName.Text, Convert.ToInt32(txtCost.Text), dtpPurchaseDashboard.Value, txtSuppName.Text, txtSuppAddress.Text, txtPhoneNumber.Text, "Update", "Delete");

                        if (i > 0)
                        {
                            MessageBox.Show("Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            taPurchase.FillPurchase(dsPurchase.Purchase);
                            dgvPurchase.DataSource = dsPurchase.Purchase;
                        }
                        btnClear();
                    }
                    catch
                    {
                        MessageBox.Show("Please check, is the input field in the correct format!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    int checkPurchaseUpdateID = taPurchase.UpdatePurchase(txtItemName.Text, Convert.ToInt32(txtCost.Text), dtpPurchaseDashboard.Value, txtSuppName.Text, txtSuppAddress.Text, txtPhoneNumber.Text, UpdateID);
                    if (checkPurchaseUpdateID > 0)
                    {
                        MessageBox.Show("Update Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        taPurchase.FillPurchase(dsPurchase.Purchase);
                        dgvPurchase.DataSource = dsPurchase.Purchase;

                        btnClear();
                    }
                }
                isUpdate = false;

            }
        }

        private void btnClearPD_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            txtCost.Text = "";
            txtSuppName.Text = "";
            txtSuppAddress.Text = "";
            txtPhoneNumber.Text = "";

        }
        private void btnClear()
        {
            txtItemName.Text = "";
            txtCost.Text = "";
            txtSuppName.Text = "";
            txtSuppAddress.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void dgvPurchase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string msg = String.Format("Row: {0}, Column: {1}",
            //dgvGeneralCost1.CurrentCell.RowIndex,
            //dgvGeneralCost1.CurrentCell.ColumnIndex);
            //MessageBox.Show(msg, "Current Cell");
            int ClickedRowID = Convert.ToInt32(dgvPurchase.CurrentRow.Cells[0].Value);

            if (dgvPurchase.CurrentCell.ColumnIndex == 7)
            {
                int checkGeneralCostQueryID = taPurchase.FillPurchaseByID(dsPurchase.Purchase, ClickedRowID);
                if (checkGeneralCostQueryID > 0)
                {
                    txtItemName.Text = dsPurchase.Purchase.Rows[0]["itemName"].ToString();
                    txtCost.Text = dsPurchase.Purchase.Rows[0]["cost"].ToString();
                    dtpPurchaseDashboard.Value = Convert.ToDateTime(dsPurchase.Purchase.Rows[0]["date"]);
                    txtSuppName.Text = dsPurchase.Purchase.Rows[0]["supplierName"].ToString();
                    txtSuppAddress.Text = dsPurchase.Purchase.Rows[0]["supplierAddress"].ToString();
                    txtPhoneNumber.Text = dsPurchase.Purchase.Rows[0]["phoneNumber"].ToString();
                }
                taPurchase.FillPurchase(dsPurchase.Purchase);
                dgvPurchase.DataSource = dsPurchase.Purchase;
                isUpdate = true;
                UpdateID = ClickedRowID;
            }
            else if (dgvPurchase.CurrentCell.ColumnIndex == 8)
            {
                int checkGeneralCost1DeleteID = taPurchase.DeletePurchase(ClickedRowID);
                if (checkGeneralCost1DeleteID > 0)
                {
                    MessageBox.Show("Delete Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    taPurchase.FillPurchase(dsPurchase.Purchase);
                    dgvPurchase.DataSource = dsPurchase.Purchase;

                }
            }
        }

        private void btnClosePD_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
