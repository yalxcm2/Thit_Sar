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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
           
            panelGcost.Visible = false;
            panelList.Visible = false;
            panelReport.Visible = false;


        }
        private void hideSubMenu()
        {
                if (panelGcost.Visible == true)
                panelGcost.Visible = false;

                if (panelList.Visible == true)
                panelList.Visible = false;

                if (panelReport.Visible == true)
                panelReport.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private void btnItemInsert_Click(object sender, EventArgs e)
        {
            ItemInsert ItIner = new ItemInsert();
            ItIner.Show();
        }

        private void btnGCost_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGcost);
        }

        private void btnGCost1_Click(object sender, EventArgs e)
        {
            GeneralCost1 G1 = new GeneralCost1();
            G1.Show();
        }

        private void btnGCost2_Click(object sender, EventArgs e)
        {
            GeneralCost2 G2 = new GeneralCost2();
            G2.Show();
        }

        private void btnVoucherList_Click(object sender, EventArgs e)
        {
            showSubMenu(panelList);
        }

        private void btnGCostList_Click(object sender, EventArgs e)
        {
            GeneralCostList GL = new GeneralCostList();
            GL.Show();
        }

        private void btnSellList_Click(object sender, EventArgs e)
        {
            SellList SL = new SellList();
            SL.Show();
        }

        private void btnPurchaseList_Click(object sender, EventArgs e)
        {
            PurchaseList PL = new PurchaseList();
            PL.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReport);
        }

        private void btnMonReport_Click(object sender, EventArgs e)
        {
            MonthlyReport MR = new MonthlyReport();
            MR.Show();
        }

        private void btnAnuReport_Click(object sender, EventArgs e)
        {
            AnnualReport AR = new AnnualReport();
            AR.Show();
        }

        private void btnSaleDashboard_Click(object sender, EventArgs e)
        {
            SaleDashboard SD = new SaleDashboard();
            SD.Show();
        }

        private void btnPurchaseDashborad_Click(object sender, EventArgs e)
        {
            PurchaseDashboard PD = new PurchaseDashboard();
            PD.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult confirm = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            //if (confirm == DialogResult.Yes)
            //{

            //    Application.Exit();
            //}
            //else if (confirm == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}

            //this.Close();
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                Application.Exit();
            }
            else if (confirm == DialogResult.No)
            {

            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function doen't support now!!!");
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function doen't support now!!!");
        }

        
    }
}
