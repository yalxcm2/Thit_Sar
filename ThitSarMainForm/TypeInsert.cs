using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ThitSarMainForm
{
    public partial class TypeInsert : Form
    {
        public TypeInsert()
        {
            InitializeComponent();
            fillCombo();
        }

        Boolean isUpdate = false;
        int UpdateID;

        dsType dsType = new dsType();
        dsTypeTableAdapters.TypeTableAdapter taType = new dsTypeTableAdapters.TypeTableAdapter();

        dsCategory dsCategory = new dsCategory();
        dsCategoryTableAdapters.CategoryTableAdapter taCategory = new dsCategoryTableAdapters.CategoryTableAdapter();

        private void TypeInsert_Load(object sender, EventArgs e)
        {
            
            taType.FillTypeByCategory(dsType.Type, comCurrentCat.Text);
            dgvType.DataSource = dsType.Type;
        }

        public void fillCombo()
        {
            taCategory.FillCategory(dsCategory.Category);
            comCurrentCat.DataSource = dsCategory.Category;

            comCurrentCat.DisplayMember = "categoryName";
            comCurrentCat.ValueMember = "id";
        }
        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (comCurrentCat.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please select current category!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comCurrentCat.Focus();
                comCurrentCat.SelectAll();
            }
            else if (txtTypeInsert.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter type name in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTypeInsert.Focus();
                txtTypeInsert.SelectAll();
            }

            else
            {
                if (!isUpdate)
                {
                    try
                    {

                        //DateTime dp1 = dateTimePicker1.Value;
                        //// Modify next line, set HH:MM to HH:mm
                        //String dpstring = dp1.ToString("MMMM dd, yyyy - dddd HH:mm");
                        //MessageBox.Show("MB10 ~ " + dpstring, "Date/Time Saved");

                        int i = taType.InsertType( txtTypeInsert.Text, comCurrentCat.Text, "Update", "Delete");

                        if (i > 0)
                        {
                            MessageBox.Show("Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            taType.FillTypeByCategory(dsType.Type, comCurrentCat.Text);
                            dgvType.DataSource = dsType.Type;
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
                    int checkTypeUpdateID = taType.UpdateType( txtTypeInsert.Text, comCurrentCat.Text, UpdateID);
                    if (checkTypeUpdateID > 0)
                    {
                        MessageBox.Show("Update Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        taType.FillTypeByCategory(dsType.Type, comCurrentCat.Text);
                        dgvType.DataSource = dsType.Type;
                        btnClear();
                    }
                }

            }
        }

        private void btnClearType_Click(object sender, EventArgs e)
        {
            comCurrentCat.Text = "";
            txtTypeInsert.Text = "";

        }
        private void btnClear()
        {
            
            txtTypeInsert.Text = "";
        }

        private void comCurrentCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            taType.FillTypeByCategory(dsType.Type, comCurrentCat.Text);
            dgvType.DataSource = dsType.Type;
        }

        private void btnCloseType_Click(object sender, EventArgs e)
        {
            Visible = false;
            ItemInsert ItIner = new ItemInsert();
            ItIner.Show();
        }
    }
}
