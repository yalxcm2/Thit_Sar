using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThitSarMainForm
{

    public partial class ItemInsert : Form
    {
        public ItemInsert()
        {
            InitializeComponent();
            fillCombo();
            
        }

        dsCategory dsCategory = new dsCategory();
        dsCategoryTableAdapters.CategoryTableAdapter taCategory = new dsCategoryTableAdapters.CategoryTableAdapter();

        Boolean isUpdate = false;
        String available = "Available";
        int UpdateID;

        dsItem dsItem = new dsItem();
        dsItemTableAdapters.ItemTableAdapter taItem = new dsItemTableAdapters.ItemTableAdapter();

        dsType dsType = new dsType();
        dsTypeTableAdapters.TypeTableAdapter taType = new dsTypeTableAdapters.TypeTableAdapter();


        private void ItemInsert_Load(object sender, EventArgs e)
        {
           
            fillCombo();

        }

        public void fillCombo()
        {
          
            taCategory.FillCategory(dsCategory.Category);
            comCatName.DataSource = dsCategory.Category;
            comCatName.Text = "";
            comCatName.DisplayMember = "categoryName";
            comCatName.ValueMember = "id";
        }

        private void btnCatInsert_Click(object sender, EventArgs e)
        {
            Visible = false;
            CategoriesInsert catIner = new CategoriesInsert();
            catIner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            TypeInsert typeIner = new TypeInsert();
            typeIner.Show();
        }

        private void comCatName_SelectedIndexChanged(object sender, EventArgs e)
        {
            taType.FillTypeByCategory(dsType.Type, comCatName.Text);

            comTypeName.Text = "";
        
            comTypeName.DataSource = dsType.Type;
            comTypeName.DisplayMember = "typeName";
            comTypeName.ValueMember = "id";

            


        }

        private void comTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            taItem.FillItemByCategoryNameAndTypeName(dsItem.Item, comCatName.Text, comTypeName.Text);
            dgvItem.DataSource = dsItem.Item;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comCatName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please select category name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comCatName.Focus();
                comCatName.SelectAll();
            }
            else if (comTypeName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please select type name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comTypeName.Focus();
                comTypeName.SelectAll();
            }
            else if (txtCode.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter code in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCode.Focus();
                txtCode.SelectAll();
            }
            else if (txtItemName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter item name in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemName.Focus();
                txtItemName.SelectAll();
            }
            else if (txtItemBrand.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter item brand name in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemBrand.Focus();
                txtItemBrand.SelectAll();
            }
            else if (txtItemSize.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter item size in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemSize.Focus();
                txtItemSize.SelectAll();
            }
            else if (txtPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter price in the selected field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrice.Focus();
                txtPrice.SelectAll();
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

                        int i = taItem.InsertItem(txtCode.Text, txtItemName.Text, txtItemBrand.Text, txtItemSize.Text, txtPrice.Text, available, comCatName.Text, comTypeName.Text, "Update", "Delete");

                        if (i > 0)
                        {
                            MessageBox.Show("Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            taItem.FillItemByCategoryNameAndTypeName(dsItem.Item, comCatName.Text, comTypeName.Text);
                            dgvItem.DataSource = dsItem.Item;
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
                    int checkTypeUpdateID = taItem.UpdateItem(txtCode.Text, txtItemName.Text, txtItemBrand.Text, txtItemSize.Text, txtPrice.Text, available, comCatName.Text, comTypeName.Text, UpdateID);
                    if (checkTypeUpdateID > 0)
                    {
                        MessageBox.Show("Update Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        taItem.FillItemByCategoryNameAndTypeName(dsItem.Item, comCatName.Text, comTypeName.Text);
                        dgvItem.DataSource = dsItem.Item;
                        btnClear();
                    }
                }
                isUpdate = false;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comCatName.Text = "";
            comTypeName.Text = "";
            txtCode.Text = "";
            txtItemName.Text = "";
            txtItemBrand.Text = "";
            txtItemSize.Text = "";
            txtPrice.Text = "";

        }
        private void btnClear()
        {
            txtCode.Text = "";
            txtItemName.Text = "";
            txtItemBrand.Text = "";
            txtItemSize.Text = "";
            txtPrice.Text = "";
        }

        private void rbtnAvailable_CheckedChanged(object sender, EventArgs e)
        {
            available = "Available";
        }

        private void rbtnNotAvailable_CheckedChanged(object sender, EventArgs e)
        {
            available = "Not Available";
        }

        private void dgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string msg = String.Format("Row: {0}, Column: {1}",
            //dgvItem.CurrentCell.RowIndex,
            //dgvItem.CurrentCell.ColumnIndex);
            //MessageBox.Show(msg, "Current Cell");

            int ClickedRowID = Convert.ToInt32(dgvItem.CurrentRow.Cells[0].Value);

            if (dgvItem.CurrentCell.ColumnIndex == 9)
            {
                int checkItemQueryID = taItem.FillItemByID(dsItem.Item, ClickedRowID);
                if (checkItemQueryID > 0)
                {
                    comCatName.Text = dsItem.Item.Rows[0]["categoryName"].ToString();
                    comTypeName.Text = dsItem.Item.Rows[0]["typeName"].ToString();
                    txtCode.Text = dsItem.Item.Rows[0]["codeId"].ToString();
                    txtItemName.Text = dsItem.Item.Rows[0]["itemName"].ToString();
                    txtItemBrand.Text = dsItem.Item.Rows[0]["itemBrand"].ToString();
                    txtItemSize.Text = dsItem.Item.Rows[0]["itemSize"].ToString();
                    txtPrice.Text = dsItem.Item.Rows[0]["price"].ToString();
                    rbtnAvailable.Checked = false;
                    rbtnNotAvailable.Checked = false;
                }
                taItem.FillItemByCategoryNameAndTypeName(dsItem.Item, comCatName.Text, comTypeName.Text);
                dgvItem.DataSource = dsItem.Item;
                isUpdate = true;
                UpdateID = ClickedRowID;
            }
            else if (dgvItem.CurrentCell.ColumnIndex == 10)
            {
                int checkItemDeleteID = taItem.DeleteItem(ClickedRowID);
                if (checkItemDeleteID > 0)
                {
                    MessageBox.Show("Delete Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    taItem.FillItemByCategoryNameAndTypeName(dsItem.Item, comCatName.Text, comTypeName.Text);
                    dgvItem.DataSource = dsItem.Item;

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
