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
    public partial class frmManageCategories : Form
    {
        #region FORM MANAGE CATEGORIES
        private CitiZoneDataContext MC;
        private FoodServices foodServices = new FoodServices();
        public frmManageCategories()
        {
            InitializeComponent();
            #region FONT
            dgvCategories.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            dgvFoods.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            #endregion
        }
        private void frmManageCategories_Load(object sender, EventArgs e)
        {
            MC = new CitiZoneDataContext();
            var dgv = (from s in MC.categories
                       select new
                       {
                           CategoryID = s.categoryID,
                           CategoryName = s.categoryName
                       }).ToList();
            dgvCategories.DataSource = dgv;
            dgvFN();
        }
        void dgvFN()
        {
            if (dgvCategories.RowCount > 0)
            {
                MC = new CitiZoneDataContext();
                string CategoryID = dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                var dgv = (from s in MC.foods
                           where s.categoryID == CategoryID
                           select new
                           {
                               Food = s.foodName,
                               Price = s.price,
                               ID = s.foodID
                           }).ToList();
                dgvFoods.DataSource = dgv;
            }
        }
        #endregion

        #region CELL CLICK
        private void bgcCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategories.Rows.Count > 0)
            {
                dgvFN();
                if (dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value != null)
                {
                    ptbCategoriesDelete.Visible = true;
                    ptbCategoriesEdit.Visible = true;
                }
                else
                {
                    ptbCategoriesEdit.Visible = false;
                    ptbCategoriesDelete.Visible = false;
                }
            }
            ptbFoodDelete.Visible = false;
            ptbFoodNamesEdit.Visible = false;
        }
        private void dgvFoodNames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFoods.Rows.Count > 0)
            {
                if (dgvFoods.SelectedCells[0].OwningRow.Cells[0].Value != null)
                {
                    ptbFoodDelete.Visible = true;
                    ptbFoodNamesEdit.Visible = true;
                }

                else
                {
                    ptbFoodNamesEdit.Visible = false;
                    ptbFoodDelete.Visible = false;
                }
            }
        }
        #endregion

        #region CLIENT SIZE CHANGED
        private void frmManageCategories_ClientSizeChanged(object sender, EventArgs e)
        {
            pnlManageCategories.Location = new Point(this.ClientSize.Width / 2 - pnlManageCategories.Size.Width / 2,
                                    this.ClientSize.Height / 2 - pnlManageCategories.Size.Height / 2);
            pnlManageCategories.Anchor = AnchorStyles.None;
        }
        #endregion

        #region CATEGORIES CLICKS
        private void ptbCategoriesEdit_Click(object sender, EventArgs e)
        {
            string ctgID = dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string ctgName = dgvCategories.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            frmAddCategory frm = new frmAddCategory(ctgID, ctgName);
            frm.ShowDialog();
            frmManageCategories_Load(sender, e);
        }
        private void ptbCategoriesAdd_Click(object sender, EventArgs e)
        {
            frmAddCategory frm = new frmAddCategory();
            frm.ShowDialog();
            frmManageCategories_Load(sender, e);
        }
        private void ptbCategoriesDelete_Click(object sender, EventArgs e)
        {
            MC = new CitiZoneDataContext();
            string ctgID = dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string ctgName = dgvCategories.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            if(dgvCategories.RowCount>0)
            {
                bool chk = true;
                if (dgvFoods.RowCount > 0)
                {
                    for (int i = 0; i < dgvFoods.RowCount; i++)
                    {
                        int fID = Int32.Parse(dgvFoods.Rows[i].Cells[2].Value.ToString());
                        if (check(fID))
                        {
                            chk = false;
                            break;
                        }
                    }
                }
                if (chk == true)
                {
                    if (dgvFoods.RowCount < 1)
                    {
                        if (MessageBox.Show("Category " + ctgID + " - " + ctgName + " will be permanently DELETED", "Notification",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MC.deleteCategories(ctgID);
                            ptbCategoriesDelete.Visible = false;
                            frmManageCategories_Load(sender, e);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("All Food in Category " + ctgName + " will be permanently DELETED", "Notification",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MC.deleteFoodsByCategories(ctgID);
                            MC.deleteCategories(ctgID);
                            frmManageCategories_Load(sender, e);
                        }
                    }
                }
                else
                    MessageBox.Show("You must delete all bill contains foods of this category first", "Notification");
            }
        }
        private void dgvCategories_KeyDown(object sender, KeyEventArgs e)
        {
            if (ptbCategoriesDelete.Visible == true)
                if (e.KeyCode == Keys.Delete)
                    ptbCategoriesDelete_Click(sender, e);
        }
        #endregion

        #region FOOD CLICKS
        private void ptbFoodNamesEdit_Click(object sender, EventArgs e)
        {
            string FoodName = dgvFoods.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string Price = dgvFoods.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            string ID = dgvFoods.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
            frmEditFood frm = new frmEditFood(FoodName, Price, ID);
            frm.ShowDialog();
            frmManageCategories_Load(sender, e);
        }

        private void ptbFoodNamesADD_Click(object sender, EventArgs e)
        {
            string ctg = "";
            if (dgvCategories.RowCount > 0)
                ctg = dgvCategories.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            frmAddFood frm = new frmAddFood(ctg);
            frm.ShowDialog();
            frmManageCategories_Load(sender, e);
        }

        private void ptbFoodNamesDelete_Click(object sender, EventArgs e)
        {
            MC = new CitiZoneDataContext();
            int FoodID = Int32.Parse(dgvFoods.SelectedCells[0].OwningRow.Cells[2].Value.ToString());
            string Food = dgvFoods.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (check(FoodID))
                MessageBox.Show("You must delete all bill contains this food first", "Notification");
            else
            {
                if (MessageBox.Show("Food " + FoodID + " - " + Food + " will be permanently DELETED", "Notification",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    food food = new food();
                    food.foodID = FoodID;
                    foodServices.deleteFood(food);
                    ptbFoodDelete.Visible = false;
                }
                string CategoryID = dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                var dgv = (from s in MC.foods
                           where s.categoryID == CategoryID
                           select new
                           {
                               Food = s.foodName,
                               Price = s.price,
                               ID = s.foodID
                           }).ToList();
                dgvFoods.DataSource = dgv;
            }
        }
        private void dgvFoods_KeyDown(object sender, KeyEventArgs e)
        {
            if (ptbFoodDelete.Visible == true)
                if (e.KeyCode == Keys.Delete)
                    ptbFoodNamesDelete_Click(sender, e);
        }
        #endregion

        #region CHECK
        private bool check(int fid)
        {
            MC = new CitiZoneDataContext();
            var c = from p in MC.billInfos
                    where p.foodID == fid
                    select p.foodID;
            if (c.Any())
                return true;
            else
                return false;
        }
        #endregion
    }
}
