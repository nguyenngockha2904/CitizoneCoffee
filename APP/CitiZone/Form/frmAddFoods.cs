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
    public partial class frmAddFood : Form
    {
        #region FORM ADD FOOD
        private CitiZoneDataContext add;
        private FoodServices foodServices = new FoodServices();
        string ct = null;
        public frmAddFood(string ctg)
        {
            InitializeComponent();
            ct = ctg;
            #region FONT
            lblCategoryID.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            lblFoodName.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            lblPrice.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            txtPrice.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            cbCategories.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            txtFoodName.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            txtPrice.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            #endregion
        }
        private void frmAddFood_Load(object sender, EventArgs e)
        {
            add = new CitiZoneDataContext();
            var cbC = (from s in add.categories
                       select s.categoryName).ToList();
            cbCategories.DataSource = cbC;
            cbCategories.SelectedItem = ct;
        }
        #endregion

        #region CONFIRM
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            add = new CitiZoneDataContext();
            food food = new food();
            food.categoryID = (from p in add.categories
                                where p.categoryName == cbCategories.Text
                                select p.categoryID).First().ToString();
            food.foodName = txtFoodName.Text;
            food.price = Int32.Parse(txtPrice.Text);
            if (check(txtFoodName.Text))
                MessageBox.Show("Food " + txtFoodName.Text + " is already existed, please use another name", "Notification");
            else
            {
                foodServices.addFood(food);
                MessageBox.Show("Added " + txtFoodName.Text, "Notification");
            }
        }
        #endregion

        #region CHECK
        private bool check(string fn)
        {
            add = new CitiZoneDataContext();
            var chk = (from p in add.foods
                       where p.foodName == fn
                       select p.foodName);
            if (chk.Any())
                return true;
            else
                return false;
        }
        #endregion

        #region TEXT CHANGED
        private void txt_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (txtPrice.Text.Contains(" "))
                ptbConfirm.Visible = false;
            else
            {
                if (int.TryParse(txtPrice.Text, out parsedValue))
                {
                    int.TryParse(txtPrice.Text, out parsedValue);
                    ptbConfirm.Visible = (txtPrice.Text.Trim().Length > 0
                         && txtPrice.Text.Trim().Length < 10
                         && parsedValue > 999
                         && txtFoodName.Text.Trim().Length > 0
                         && txtFoodName.Text.Trim().Length < 50);
                }
                else
                    ptbConfirm.Visible = false;
            }
        }
        #endregion

        #region  CANCEL
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion;
    }
}
