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
    public partial class CategoriesInsert : Form
    {
        public CategoriesInsert()
        {
            InitializeComponent();
        }

        Boolean isUpdate = false;
        int UpdateID;

        dsCategory dsCategory = new dsCategory();
        dsCategoryTableAdapters.CategoryTableAdapter taCategory = new dsCategoryTableAdapters.CategoryTableAdapter();

        private void CategoriesInsert_Load(object sender, EventArgs e)
        {
            taCategory.FillCategory(dsCategory.Category);
            dgvCategory.DataSource = dsCategory.Category;
        }
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (txtCatInsert.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter category name in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCatInsert.Focus();
                txtCatInsert.SelectAll();
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


                        int i = taCategory.InsertCategory(txtCatInsert.Text, "Update", "Delete");

                        if (i > 0)
                        {
                            MessageBox.Show("Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            taCategory.FillCategory(dsCategory.Category);                          
                            dgvCategory.DataSource = dsCategory.Category;
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
                    int checkCategoryUpdateID = taCategory.UpdateCategory(txtCatInsert.Text, UpdateID);
                    if (checkCategoryUpdateID > 0)
                    {
                        MessageBox.Show("Update Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        taCategory.FillCategory(dsCategory.Category);

                        dgvCategory.DataSource = dsCategory.Category;
                        btnClear();
                    }
                }

            }
        }

        private void btnClearCat_Click(object sender, EventArgs e)
        {
            txtCatInsert.Text = "";

        }
        private void btnClear()
        {
            txtCatInsert.Text = "";
        }

        private void btnCloseCat_Click(object sender, EventArgs e)
        {
            Visible = false;
            
            ItemInsert ItIner = new ItemInsert();
            ItIner.Show();
        }
    }
}
