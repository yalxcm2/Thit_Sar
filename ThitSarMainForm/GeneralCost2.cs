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
    public partial class GeneralCost2 : Form
    {
        public GeneralCost2()
        {
            InitializeComponent();
        }
        Boolean isUpdate = false;
        int UpdateID;

        dsGeneralCost2 dsGeneralCost2 = new dsGeneralCost2();
        dsGeneralCost2TableAdapters.GeneralCost2TableAdapter taGeneralCost2 = new dsGeneralCost2TableAdapters.GeneralCost2TableAdapter();

        private void GeneralCost2_Load(object sender, EventArgs e)
        {
            panelGC2.Parent = pictureBox1;
            panelGC2.BackColor = Color.Transparent;

            taGeneralCost2.FillGeneralCost2(dsGeneralCost2.GeneralCost2);
            dgvGeneralCost2.DataSource = dsGeneralCost2.GeneralCost2;

        }

        private void btnInsertG2_Click(object sender, EventArgs e)
        {
            if (txtReasonG2.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter reason in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReasonG2.Focus();
                txtReasonG2.SelectAll();
            }
            else if (txtCostG2.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter cost in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCostG2.Focus();
                txtCostG2.SelectAll();
            }
            else
            {
                if (!isUpdate)
                {
                    try
                    {

                        int cv1 = Convert.ToInt32(txtCostG2.Text);


                        int i = taGeneralCost2.InsertGeneralCost2(txtReasonG2.Text, Convert.ToInt32(txtCostG2.Text), dateTimePicker2.Value, "Update", "Delete");
                        if (i > 0)
                        {
                            MessageBox.Show("Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        btnClear();
                        taGeneralCost2.FillGeneralCost2(dsGeneralCost2.GeneralCost2);
                        dgvGeneralCost2.DataSource = dsGeneralCost2.GeneralCost2;
                    }
                    catch
                    {
                        MessageBox.Show("Please check, is the input field in the correct format!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    int checkGeneralCost1UpdateID = taGeneralCost2.UpdateGeneralCost2(txtReasonG2.Text, Convert.ToInt32(txtCostG2.Text), dateTimePicker2.Value, UpdateID);
                    if (checkGeneralCost1UpdateID > 0)
                    {
                        MessageBox.Show("Update Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        taGeneralCost2.FillGeneralCost2(dsGeneralCost2.GeneralCost2);
                        dgvGeneralCost2.DataSource = dsGeneralCost2.GeneralCost2;
                        btnClear();
                    }
                }
                isUpdate = false;

            }
        }

        private void btnClearG2_Click(object sender, EventArgs e)
        {
            txtReasonG2.Text = "";
            txtCostG2.Text = "";
        }
        private void btnClear()
        {
            txtReasonG2.Text = "";
            txtCostG2.Text = "";
        }

        private void dgvGeneralCost2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ClickedRowID = Convert.ToInt32(dgvGeneralCost2.CurrentRow.Cells[0].Value);

            if (dgvGeneralCost2.CurrentCell.ColumnIndex == 4)
            {
                int checkGeneralCostQueryID = taGeneralCost2.FillGeneralCost2ByID(dsGeneralCost2.GeneralCost2, ClickedRowID);
                if (checkGeneralCostQueryID > 0)
                {
                    txtReasonG2.Text = dsGeneralCost2.GeneralCost2.Rows[0]["reason"].ToString();
                    txtCostG2.Text = dsGeneralCost2.GeneralCost2.Rows[0]["cost"].ToString();
                    dateTimePicker2.Value = Convert.ToDateTime(dsGeneralCost2.GeneralCost2.Rows[0]["date"]);
                }
                taGeneralCost2.FillGeneralCost2(dsGeneralCost2.GeneralCost2);
                dgvGeneralCost2.DataSource = dsGeneralCost2.GeneralCost2;
                isUpdate = true;
                UpdateID = ClickedRowID;
            }
            else if (dgvGeneralCost2.CurrentCell.ColumnIndex == 5)
            {
                int checkGeneralCost1DeleteID = taGeneralCost2.DeleteGeneralCost2(ClickedRowID);
                if (checkGeneralCost1DeleteID > 0)
                {
                    MessageBox.Show("Delete Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    taGeneralCost2.FillGeneralCost2(dsGeneralCost2.GeneralCost2);
                    dgvGeneralCost2.DataSource = dsGeneralCost2.GeneralCost2;

                }
            }
        }

        private void btnCloseG2_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
