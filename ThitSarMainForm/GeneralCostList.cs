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
    public partial class GeneralCostList : Form
    {
        public GeneralCostList()
        {
            InitializeComponent();
        }

        

        dsGeneralCost1 dsGeneralCost1 = new dsGeneralCost1();
        dsGeneralCost1TableAdapters.GeneralCost1TableAdapter taGeneralCost1 = new dsGeneralCost1TableAdapters.GeneralCost1TableAdapter();

        dsGeneralCost2 dsGeneralCost2 = new dsGeneralCost2();
        dsGeneralCost2TableAdapters.GeneralCost2TableAdapter taGeneralCost2 = new dsGeneralCost2TableAdapters.GeneralCost2TableAdapter();

        private void GeneralCostList_Load(object sender, EventArgs e)
        {
            taGeneralCost1.FillGeneralCost1(dsGeneralCost1.GeneralCost1);
            dgvGeneralCost1.DataSource = dsGeneralCost1.GeneralCost1;

            taGeneralCost2.FillGeneralCost2(dsGeneralCost2.GeneralCost2);
            dgvGeneralCost2.DataSource = dsGeneralCost2.GeneralCost2;

            sumAmountG1();
            sumAmountG2();

        }

        private void btnLoad_Click(object sender, EventArgs e)
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

                

                taGeneralCost1.FillGeneralCost1ByDate(dsGeneralCost1.GeneralCost1, Convert.ToDateTime(stringStartDate), Convert.ToDateTime(stringEndDate));
                dgvGeneralCost1.DataSource = dsGeneralCost1.GeneralCost1;

                taGeneralCost2.FillGeneralCost2ByDate(dsGeneralCost2.GeneralCost2, Convert.ToDateTime(stringStartDate), Convert.ToDateTime(stringEndDate));
                dgvGeneralCost2.DataSource = dsGeneralCost2.GeneralCost2;


            }
            sumAmountG1();
            sumAmountG2();
            
        }
        private void sumAmountG1()
        {
            int sum = 0;
            int i;
            

            for (i = 0; i < dgvGeneralCost1.Rows.Count; i++)
            {

                sum += Convert.ToInt32( dgvGeneralCost1.Rows[i].Cells[2].Value);
              

            }
            

            txtTotalG1.Text = sum.ToString()+" Ks";
        }

        private void sumAmountG2()
        {
            int sum = 0;
            int i;
            

            for (i = 0; i < dgvGeneralCost2.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dgvGeneralCost2.Rows[i].Cells[2].Value);


            }


            txtTotalG2.Text = sum.ToString() + " Ks";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        
    }
}
