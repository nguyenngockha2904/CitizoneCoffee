using CitiZone.CitizoneServices;
using CitiZone.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitiZone
{
    public partial class frmAddCategory : Form
    {
        #region FORM ADD CATEGORY
        private CitiZoneDataContext add;
        private CategoryServices categoryServices = new CategoryServices();
        int k ;
        string ctg = null;
        public frmAddCategory()
        {
            k = 0;
            InitializeComponent();
            #region FONT
            lblCategoryID.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            lblCategoryName.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            txtCategoryID.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            txtCategoryName.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            #endregion
        }
        public frmAddCategory(string ctgID, string ctgName)
        {
            k = 1;
            InitializeComponent();
            txtCategoryID.Text = ctgID;
            txtCategoryName.Text = ctgName;
            #region FONT
            lblCategoryID.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            lblCategoryName.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            txtCategoryID.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            txtCategoryName.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            #endregion
            
        }
        private void frmAddCategory_Load(object sender, EventArgs e)
        {
            if (k == 1)
            {
                ctg = txtCategoryName.Text;
                ptbConfirm.Visible = false;
            }
        }
        #endregion

        #region TEXT CHANGED
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (k == 0) {
                if (txtCategoryID.Text.Contains(" "))
                    ptbConfirm.Visible = false;
                else
                {
                    ptbConfirm.Visible = (txtCategoryID.Text.Trim().Length > 0
                        && txtCategoryName.Text.Trim().Length > 0
                        && txtCategoryID.Text.Trim().Length < 20
                        && txtCategoryName.Text.Trim().Length < 50);
                }
            }else if (k == 1)
            {
                if ((txtCategoryName.Text.Trim().Length > 0 && txtCategoryName.Text.Trim().Length < 50))
                {
                    if (ctg != txtCategoryName.Text.ToUpper())
                        ptbConfirm.Visible = true;
                    else
                        ptbConfirm.Visible = false;
                }
                else
                    ptbConfirm.Visible = false;
            }
            
        }
        #endregion

        #region CONFIRM
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (k == 0) {
                if (txtCategoryID.Text.Trim().Length > 20)
                    MessageBox.Show("Category ID contain at least 20 characters", "Notification");
                else if (txtCategoryName.Text.Trim().Length > 50)
                    MessageBox.Show("Category Name contain at least 50 characters", "Notification");
                else
                {
                    string ctgID = txtCategoryID.Text.ToUpper();
                    string ctgName = txtCategoryName.Text.ToUpper();
                    if (checkID(ctgID) == false && checkName(ctgName) == false)
                    {
                        category category = new category();
                        category.categoryID = ctgID;
                        category.categoryName = ctgName;
                        categoryServices.addCategory(category);
                        MessageBox.Show("Added Category  " + ctgID + "  " + ctgName, "Notification");
                    }
                    else
                        MessageBox.Show("Category " + ctgID + " or " + ctgName + " is already existed, Please use another name", "Notification");
                }
            }else if (k == 1)
            {
                if (checkName(txtCategoryName.Text))
                    MessageBox.Show("Category " + txtCategoryName.Text + " is already existed, please use another name", "Notification");
                else
                {
                    category category = new category();
                    category.categoryID = txtCategoryID.Text;
                    category.categoryName = txtCategoryName.Text.ToUpper();
                    categoryServices.updateCategory(category);
                    MessageBox.Show("Category " + txtCategoryID.Text + " has been updated", "Notification");
                }
            }
            
        }

        #region CHECK
        private bool checkID(string ctgID)
        {
            add = new CitiZoneDataContext();
            var q = from p in add.categories
                    where p.categoryID == ctgID
                    select p;

            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkName(string ctgName)
        {
            add = new CitiZoneDataContext();
            var c = from p in add.categories
                    where p.categoryName == ctgName
                    select p.categoryName;
            if (c.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #endregion

        #region CANCEL
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
