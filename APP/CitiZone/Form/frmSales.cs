using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CitiZone
{
    public partial class frmSale : Form
    {
        #region FORM SALE
        CitiZoneDataContext sale = new CitiZoneDataContext();
        public frmSale()
        {
            InitializeComponent();
            #region FONT
            lblCategory.Font = new Font("Caviar Dreams", 12, FontStyle.Regular);
            lblFood.Font = new Font("Caviar Dreams", 12, FontStyle.Regular);
            lblAmount.Font = new Font("Caviar Dreams", 12, FontStyle.Regular);
            lblTotal.Font = new Font("Caviar Dreams", 12, FontStyle.Regular);
            txtAmount.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            txtBillName.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            txtTotal.Font = new Font("Caviar Dreams", 12, FontStyle.Regular);
            btnClear.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            btnConfirm.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            dgvSell.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            cbFoodCategony.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            cbFoodName.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            cbTable.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            lblTable.Font = new Font("Caviar Dreams", 12, FontStyle.Regular);
            #endregion
        }
        private void frmSale_Load(object sender, EventArgs e)
        {
            var cbC = (from s in sale.categories
                       select s.categoryName).ToList();
            cbFoodCategony.DataSource = cbC;
            dgvSell.DataSource = null;
            var cbT = (from p in sale.coffeeTables
                       where p.status == "Empty"
                       select p.tableID).ToList();
            cbTable.DataSource = cbT;
            cbTable.SelectedItem = "0";
        }
        #endregion

        #region TEXT CHANGED
        private void txt_TextChanged(object sender, EventArgs e)
        {
            bool check = false;
            int parsedValue;
            if (int.TryParse(txtAmount.Text, out parsedValue))
            {
                int.TryParse(txtAmount.Text, out parsedValue);
                if (cbFoodName.SelectedItem != null && parsedValue > 0 && parsedValue < 101
                    && Convert.ToInt32(dgvSell.RowCount.ToString()) < 14)
                    {
                        for (int i = 0; i < dgvSell.RowCount; i++)
                        {
                            if (cbFoodName.Text == dgvSell.Rows[i].Cells[0].Value.ToString())
                            {
                                check = true;
                                break;
                            }
                        }
                    if (check == true)
                        ptbAdd.Visible = false;
                    else
                        ptbAdd.Visible = true;
                    }
                else
                    ptbAdd.Visible = false;
                if (parsedValue > 99)
                {
                    ptbPlus.Visible = false;
                    ptbMinus.Visible = true;
                }
                else if(parsedValue < 2)
                {
                    ptbPlus.Visible = true;
                    ptbMinus.Visible = false;
                }
                else
                {
                    ptbPlus.Visible = true;
                    ptbMinus.Visible = true;
                }
            }
            else
            {
                ptbAdd.Visible = false;
                ptbPlus.Visible = false;
                ptbMinus.Visible = false;
            }
            if(dgvSell.RowCount>0)
            {
                    string fn = dgvSell.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                    string am = dgvSell.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
                if (fn == cbFoodName.Text && am != txtAmount.Text)
                    ptbAdd.Visible = true;
            }
        }
        #endregion

        #region TOTAL
        void total()
        {
            int ttl = 0;
            if (dgvSell.RowCount > 0)
            {
                for (int i = 0; i < dgvSell.RowCount; i++)
                {
                    int gia = Convert.ToInt32(dgvSell.Rows[i].Cells[2].Value.ToString());
                    int a = Convert.ToInt32(dgvSell.Rows[i].Cells[1].Value.ToString());
                    ttl += gia * a;
                }
                txtTotal.Text = ttl.ToString();
                if (ttl != 0)
                    btnConfirm.Enabled = true;
                else
                    btnConfirm.Enabled = false;
            }
        }
        #endregion

        #region DELETE
        private void ptbDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvSell.CurrentCell.RowIndex;
            dgvSell.Rows.RemoveAt(rowIndex);
            ptbDelete.Visible = false;
            if (dgvSell.RowCount < 14)
                txt_TextChanged(sender, e);
            total();
            if (dgvSell.RowCount == 0)
                btnConfirm.Enabled = false;
        }
        private void dgvSell_KeyDown(object sender, KeyEventArgs e)
        {
            if (ptbDelete.Visible == true)
                if (e.KeyCode == Keys.Delete)
                    ptbDelete_Click(sender, e);
        }
        #endregion

        #region  ADD
        private void ptbAdd_Click(object sender, EventArgs e)
        {
            string fn = "", cg = "", am = "";
            if (dgvSell.RowCount > 0)
            {
                fn = dgvSell.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                cg = (from p in sale.foods
                             join x in sale.categories
                             on (p.categoryID) equals x.categoryID
                             where p.foodName == fn
                             select x.categoryName).First().ToString();
                am = dgvSell.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            }
            if (cbFoodCategony.Text == cg && cbFoodName.Text == fn && txtAmount.Text != am)
            {
                ptbDelete_Click(sender, e);
                ptbAdd_Click(sender, e);
            }
            else
            {
                string price = (from a in sale.foods
                                where a.foodName == cbFoodName.Text
                                select a.price).First().ToString();
                string[] row = new string[] { cbFoodName.Text, txtAmount.Text, price };
                bool ck = false;
                for (int i = 0; i < dgvSell.RowCount; i++)
                {
                    if (cbFoodName.Text == dgvSell.Rows[i].Cells[0].Value.ToString())
                    {
                        ck = true;
                        break;
                    }
                }
                if (ck == true)
                    MessageBox.Show(cbFoodName.Text + " is already in the list", "Notification");
                else
                {
                    dgvSell.Rows.Add(row);
                    total();
                    ptbAdd.Visible = false;
                }
            }
        }
        #endregion

        #region  CELL MOUSE CLICK
        private void dgvSell_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvSell.SelectedCells[0].OwningRow.Cells[0].Value != null)
                ptbDelete.Visible = true;
            else
                ptbDelete.Visible = false;
            string fn = dgvSell.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string cg = (from p in sale.foods
                         join x in sale.categories
                         on (p.categoryID) equals x.categoryID
                         where p.foodName == fn
                         select x.categoryName).First().ToString();
            string am = dgvSell.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            cbFoodCategony.SelectedItem = cg;
            cbFoodName.SelectedItem = fn;
            txtAmount.Text = am;
            ptbAdd.Visible = false;
        }
        #endregion

        #region CONFIRM/CLEAR
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string Username = frmLogin.loggedUser;
            if (dgvSell.RowCount > 0)
            {
                int rowcount = dgvSell.RowCount;
                sale.addBills(Username, txtBillName.Text.ToUpper(), DateTime.Now);
                int BillID = Convert.ToInt32((from p in sale.bills
                                              orderby p.billID descending
                                              select p.billID).First());
                for (int i = 0; i < rowcount; i++)
                {
                    int Price = Convert.ToInt32(dgvSell.Rows[i].Cells[2].Value.ToString());
                    string FoodName = dgvSell.Rows[i].Cells[0].Value.ToString();
                    int Amount = Convert.ToInt32(dgvSell.Rows[i].Cells[1].Value.ToString());
                    int Total = Price * Amount;
                    int FoodID = Convert.ToInt32((from p in sale.foods
                                                  where p.foodName == FoodName
                                                  select p.foodID).First().ToString());
                    sale.addBillInfo(FoodID, BillID, Amount, Total);
                }
                sale.updateBills(BillID, Convert.ToInt32(txtTotal.Text));
                if (cbTable.Text != "0")
                    sale.updateCoffeeTable(Convert.ToInt32(cbTable.Text), BillID, "full");
                frmBillInfo frm = new frmBillInfo(BillID.ToString());
                frm.ShowDialog();
            }
            btnClear_Click(sender, e);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvSell.Rows.Clear();
            txtTotal.Clear();
            txtAmount.Text = "1";
            btnConfirm.Enabled = false;
            ptbDelete.Visible = false;
            frmSale_Load(sender, e);
        }

        #endregion

        #region FOOD CATEGONY SELECTED VALUE CHANGED
        private void cbFoodCategony_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeCategony();
        }
        private void ChangeCategony()
        {
            cbFoodName.DataSource = null;
            var cbN = (from s in sale.foods
                       join x in sale.categories
                       on (s.categoryID) equals x.categoryID
                       where x.categoryName == cbFoodCategony.Text
                       select s.foodName).ToList();
            cbFoodName.DataSource = cbN;
        }
        #endregion

        #region PLUS/MINUS
        private void ptbPlus_Click(object sender, EventArgs e)
        {
            int plus = Convert.ToInt32(txtAmount.Text);
            if (plus < 100)
            {
                plus++;
                txtAmount.Text = plus.ToString();
            }
        }

        private void ptbMinus_Click(object sender, EventArgs e)
        {
            int minus = Convert.ToInt32(txtAmount.Text);
            if (minus > 1)
            {
                minus--;
                txtAmount.Text = minus.ToString();
            }
        }
        #endregion

        #region TABLE
        private void ptbTable_Click(object sender, EventArgs e)
        {
            frmTable frm = new frmTable();
            frm.ShowDialog();
            frmSale_Load(sender, e);
        }
        #endregion
    }
}
