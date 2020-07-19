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
    public partial class GeneralCost1 : Form
    {
        public GeneralCost1()
        {
            InitializeComponent();
        }
        
        Boolean isXiongchaoda = false;

        Boolean isUpdate = false;
        int UpdateID;

        dsGeneralCost1 dsGeneralCost1 = new dsGeneralCost1();
        dsGeneralCost1TableAdapters.GeneralCost1TableAdapter taGeneralCost1 = new dsGeneralCost1TableAdapters.GeneralCost1TableAdapter();

        private void GeneralCost1_Load(object sender, EventArgs e)
        {
            panelGC1.Parent = pictureBox1;
            panelGC1.BackColor = Color.Transparent;

            taGeneralCost1.FillGeneralCost1(dsGeneralCost1.GeneralCost1);
            dgvGeneralCost1.DataSource = dsGeneralCost1.GeneralCost1;
        }

        private void btnInsertG1_Click(object sender, EventArgs e)
        {
            if (txtReasonG1.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter reason in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReasonG1.Focus();
                txtReasonG1.SelectAll();
            }
            else if (txtCostG1.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter cost in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCostG1.Focus();
                txtCostG1.SelectAll();
            }
            
            else
            {
                if (!isUpdate)
                {
                    try
                    {

                        int cv1 = Convert.ToInt32(txtCostG1.Text);

                        
                        //DateTime dp1 = dateTimePicker1.Value;
                        //// Modify next line, set HH:MM to HH:mm
                        //String dpstring = dp1.ToString("MMMM dd, yyyy - dddd HH:mm");
                        //MessageBox.Show("MB10 ~ " + dpstring, "Date/Time Saved");


                        int i = taGeneralCost1.InsertGeneralCost1(txtReasonG1.Text, Convert.ToInt32(txtCostG1.Text), dateTimePicker1.Value, "Update", "Delete");

                            if (i > 0)
                            {
                                MessageBox.Show("Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                taGeneralCost1.FillGeneralCost1(dsGeneralCost1.GeneralCost1);
                                dgvGeneralCost1.DataSource = dsGeneralCost1.GeneralCost1;
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
                    int checkGeneralCost1UpdateID = taGeneralCost1.UpdateGeneralCost1(txtReasonG1.Text, Convert.ToInt32(txtCostG1.Text), dateTimePicker1.Value, UpdateID);
                    if (checkGeneralCost1UpdateID > 0)
                    {
                        MessageBox.Show("Update Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        taGeneralCost1.FillGeneralCost1(dsGeneralCost1.GeneralCost1);
                        dgvGeneralCost1.DataSource = dsGeneralCost1.GeneralCost1;

                        btnClear();
                    }
                }
                isUpdate = false;

            }
        }

        private void btnClearG1_Click(object sender, EventArgs e)
        {
            txtReasonG1.Text = "";
            txtCostG1.Text = "";
        }
        private void btnClear()
        {
            txtReasonG1.Text = "";
            txtCostG1.Text = "";
        }

        private void dgvGeneralCost1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string msg = String.Format("Row: {0}, Column: {1}",
            //dgvGeneralCost1.CurrentCell.RowIndex,
            //dgvGeneralCost1.CurrentCell.ColumnIndex);
            //MessageBox.Show(msg, "Current Cell");
            int ClickedRowID = Convert.ToInt32(dgvGeneralCost1.CurrentRow.Cells[0].Value);

            if (dgvGeneralCost1.CurrentCell.ColumnIndex == 4)
            {
                int checkGeneralCostQueryID = taGeneralCost1.FillGeneralCost1ByID(dsGeneralCost1.GeneralCost1, ClickedRowID);
                if (checkGeneralCostQueryID > 0)
                {
                    txtReasonG1.Text = dsGeneralCost1.GeneralCost1.Rows[0]["reason"].ToString();
                    txtCostG1.Text = dsGeneralCost1.GeneralCost1.Rows[0]["cost"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dsGeneralCost1.GeneralCost1.Rows[0]["date"]);
                }
                taGeneralCost1.FillGeneralCost1(dsGeneralCost1.GeneralCost1);
                dgvGeneralCost1.DataSource = dsGeneralCost1.GeneralCost1;
                isUpdate = true;
                UpdateID = ClickedRowID;
            }
            else if (dgvGeneralCost1.CurrentCell.ColumnIndex == 5)
            {
                int checkGeneralCost1DeleteID = taGeneralCost1.DeleteGeneralCost1(ClickedRowID);
                if (checkGeneralCost1DeleteID > 0)
                {
                    MessageBox.Show("Delete Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    taGeneralCost1.FillGeneralCost1(dsGeneralCost1.GeneralCost1);
                    dgvGeneralCost1.DataSource = dsGeneralCost1.GeneralCost1;

                }
            }
        }

        private void btnCloseG1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
