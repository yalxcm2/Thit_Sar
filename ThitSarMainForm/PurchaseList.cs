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
    public partial class PurchaseList : Form
    {
        public PurchaseList()
        {
            InitializeComponent();
        }

        dsPurchase dsPurchase = new dsPurchase();
        dsPurchaseTableAdapters.PurchaseTableAdapter taPurchase = new dsPurchaseTableAdapters.PurchaseTableAdapter();

        private void PurchaseList_Load(object sender, EventArgs e)
        {
            taPurchase.FillPurchase(dsPurchase.Purchase);
            dgvPuchaseVoucherList.DataSource = dsPurchase.Purchase;

            sumAmount();
        }

        private void btnLoadPVL_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;


            string stringStartDate = string.Format("{0:yyyy/MM/dd}", startDate);
            string stringEndDate = string.Format("{0:yyyy/MM/dd}", endDate);
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

                taPurchase.FillPurchaseByDate(dsPurchase.Purchase, Convert.ToDateTime(stringStartDate), Convert.ToDateTime(stringEndDate));
                dgvPuchaseVoucherList.DataSource = dsPurchase.Purchase;

            }
            sumAmount();
            
        }
        private void sumAmount()
        {
            int sum = 0;
            int i;
            

            for (i = 0; i < dgvPuchaseVoucherList.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dgvPuchaseVoucherList.Rows[i].Cells[2].Value);


            }

            txtTotalPVL.Text = sum.ToString() + " Ks";
        }

        private void btnClosePVL_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        
    }
}
