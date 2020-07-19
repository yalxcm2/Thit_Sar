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
    public partial class SellList : Form
    {
        public SellList()
        {
            InitializeComponent();
        }

        dsSaleVoucher dsSaleVoucher = new dsSaleVoucher();
        dsSaleVoucherTableAdapters.SaleVoucherTableAdapter taSaleVoucher = new dsSaleVoucherTableAdapters.SaleVoucherTableAdapter();

        dsSaleDetail dsSaleDetail = new dsSaleDetail();
        dsSaleDetailTableAdapters.SaleDetailTableAdapter taSaleDetail = new dsSaleDetailTableAdapters.SaleDetailTableAdapter();

        private void SellList_Load(object sender, EventArgs e)
        {
            taSaleVoucher.FillSaleVoucher(dsSaleVoucher.SaleVoucher);
            dgvSellVoucherList.DataSource = dsSaleVoucher.SaleVoucher;

            sumSellAmount();
            sumPaidAmount();
            sumLeftAmount();
        }

        string stringStartDate;
        string stringEndDate;

        Boolean isUpdate = false;
        int UpdateID;


        private void btnLoadSVL_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;


            stringStartDate = string.Format("{0:yyyy/MM/dd}", startDate);
            stringEndDate = string.Format("{0:yyyy/MM/dd}", endDate);
            if (Convert.ToDateTime(stringEndDate) < Convert.ToDateTime(stringStartDate))
            {
                MessageBox.Show("From Date must be greater than To Date");
            }
            else
            {
                //DateTime startDate = dtpStartDate.Value;
                //DateTime endDate = dtpEndDate.Value;

                //string stringStartDate = string.Format("{0:yyyy/MM/dd}", startDate);
                //string stringEndDate = string.Format("{0:yyyy/MM/dd}", endDate);

                taSaleVoucher.FillSaleVoucherByDate(dsSaleVoucher.SaleVoucher, Convert.ToDateTime(stringStartDate), Convert.ToDateTime(stringEndDate));
                dgvSellVoucherList.DataSource = dsSaleVoucher.SaleVoucher;

            }
            sumSellAmount();
            sumPaidAmount();
            sumLeftAmount();
        }

        private void sumSellAmount()
        {
            int sum = 0;
            int i;
            

            for (i = 0; i < dgvSellVoucherList.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dgvSellVoucherList.Rows[i].Cells[6].Value);


            }

            txtTotalSell.Text = sum.ToString() + " Ks";
        }

        private void sumPaidAmount()
        {
            int sum = 0;
            int i;
            

            for (i = 0; i < dgvSellVoucherList.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dgvSellVoucherList.Rows[i].Cells[7].Value);


            }

            txtTotalPaid.Text = sum.ToString() + " Ks";
        }

        private void sumLeftAmount()
        {
            int sum = 0;
            int i;
            

            for (i = 0; i < dgvSellVoucherList.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dgvSellVoucherList.Rows[i].Cells[8].Value);


            }

            txtTotalLeft.Text = sum.ToString() + " Ks";
        }


        private void btnCloseSVL_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        public static string setValueForVoucherID = "";
        public static string setValueForCustomerName = "";
        public static string setValueForAddress = "";
        public static string setValueForPhoneNumber = "";
        public static DateTime setValueForDate;
        public static int setTotalAmount = 0;
        public static int setPaidAmount = 0;
        public static int setLeftAmount = 0;
        public static int setTax = 0;
        private void dgvSellVoucherList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ClickedRowID = Convert.ToInt32(dgvSellVoucherList.CurrentRow.Cells[0].Value);

            if (dgvSellVoucherList.CurrentCell.ColumnIndex == 10)
            {
                //int checkGeneralCostQueryID = taGeneralCost1.FillGeneralCost1ByID(dsGeneralCost1.GeneralCost1, ClickedRowID);
                //if (checkGeneralCostQueryID > 0)
                //{
                //    txtReasonG1.Text = dsGeneralCost1.GeneralCost1.Rows[0]["reason"].ToString();
                //    txtCostG1.Text = dsGeneralCost1.GeneralCost1.Rows[0]["cost"].ToString();
                //    dateTimePicker1.Value = Convert.ToDateTime(dsGeneralCost1.GeneralCost1.Rows[0]["date"]);
                //}
                //taGeneralCost1.FillGeneralCost1(dsGeneralCost1.GeneralCost1);
                //dgvGeneralCost1.DataSource = dsGeneralCost1.GeneralCost1;
                //isUpdate = true;
                //UpdateID = ClickedRowID;
                //MessageBox.Show("This function doen't support now!!!");

                int checkSaleVoucherQueryID = taSaleVoucher.FillSaleVoucherByID(dsSaleVoucher.SaleVoucher, ClickedRowID);
                if (checkSaleVoucherQueryID > 0)
                {
                    setValueForVoucherID = dsSaleVoucher.SaleVoucher.Rows[0]["id"].ToString();
                    setValueForCustomerName = dsSaleVoucher.SaleVoucher.Rows[0]["customerName"].ToString();
                    setValueForAddress = dsSaleVoucher.SaleVoucher.Rows[0]["address"].ToString();
                    setValueForPhoneNumber = dsSaleVoucher.SaleVoucher.Rows[0]["phoneNumber"].ToString();
                    setValueForDate = Convert.ToDateTime(dsSaleVoucher.SaleVoucher.Rows[0]["date"]);
                    //setTotalAmount = Convert.ToInt32(dsSaleVoucher.SaleVoucher.Rows[0]["totalAmount"]);
                    setPaidAmount = Convert.ToInt32(dsSaleVoucher.SaleVoucher.Rows[0]["paidAmount"]);
                    setLeftAmount = Convert.ToInt32(dsSaleVoucher.SaleVoucher.Rows[0]["leftAmount"]);
                    setTax = Convert.ToInt32(dsSaleVoucher.SaleVoucher.Rows[0]["tax"]);
                }

               
                isUpdate = true;
                UpdateID = ClickedRowID;

                Visible = false;
                SaleVoucherUpdate svUpdate = new SaleVoucherUpdate();
                svUpdate.Show();
                Reload();
            }
            else if (dgvSellVoucherList.CurrentCell.ColumnIndex == 11)
            {
                int checkSaleVoucherDeleteID = taSaleVoucher.DeleteSaleVoucher(ClickedRowID);
                taSaleDetail.DeleteItemsBySaleID(ClickedRowID);
                if (checkSaleVoucherDeleteID > 0)
                {
                    MessageBox.Show("Delete Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    taSaleVoucher.FillSaleVoucher(dsSaleVoucher.SaleVoucher);
                    dgvSellVoucherList.DataSource = dsSaleVoucher.SaleVoucher;

                }
            }
        }
        private void Reload()
        {
            taSaleVoucher.FillSaleVoucher(dsSaleVoucher.SaleVoucher);
            dgvSellVoucherList.DataSource = dsSaleVoucher.SaleVoucher;

            sumSellAmount();
            sumPaidAmount();
            sumLeftAmount();
        }


    }
}
