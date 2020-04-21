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
    public partial class frmEditFood : Form
    {
        #region FORM EDIT FOOD NAME
        private FoodServices foodServices = new FoodServices();
        string fn = null, price = null;
        public frmEditFood(string FoodName, string Price, string ID)
        {
            InitializeComponent();
            txtFoodName.Text = FoodName;
            txtPrice.Text = Price;
            txtID.Text = ID;
            #region FONT
            lblFoodID.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            lblFoodName.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            lblPrice.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            txtFoodName.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            txtID.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            txtPrice.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            #endregion
        }
        private void frmEditFoodName_Load(object sender, EventArgs e)
        {
            ptbConfirm.Visible = false;
            fn = txtFoodName.Text;
            price = txtPrice.Text;
        }
        #endregion

        #region CACCEL
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    if (txtPrice.Text.Trim().Length > 0
                         && txtPrice.Text.Trim().Length < 10
                         && parsedValue > 999
                         && txtFoodName.Text.Trim().Length > 0
                         && txtFoodName.Text.Trim().Length < 50
                        )
                    {
                        {
                            if (fn != txtFoodName.Text || price != txtPrice.Text)
                                ptbConfirm.Visible = true;
                            else
                                ptbConfirm.Visible = false;
                        }
                    }
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
            string FoodName = txtFoodName.Text;
            string Price = txtPrice.Text;
                food food = new food();
                food.foodID = Int32.Parse(txtID.Text);
                food.foodName = txtFoodName.Text;
                food.price = Int32.Parse(txtPrice.Text);
                foodServices.updateFood(food);
                MessageBox.Show("Food " + txtID.Text + " has been updated", "Notification");
        }
        #endregion
    }
}
