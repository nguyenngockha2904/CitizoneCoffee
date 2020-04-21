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
    public partial class frmBillInfo : Form
    {
        #region FORM BILL INFO
        CitiZoneDataContext db;
        int BId;
        public frmBillInfo(string BillID)
        {
            InitializeComponent();
            lblBillID.Text = BillID;
            BId = Convert.ToInt32(BillID);
            lblBill.Text = "BILL " + BillID;
            #region FONT
            lblBill.Font = new Font("Caviar Dreams", 28, FontStyle.Regular);
            dgvBill.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            #endregion
        }
        private void frmBillInfo_Load(object sender, EventArgs e)
        {
            db = new CitiZoneDataContext();
            var bill = (from p in db.billInfos
                        join x in db.foods
                        on p.foodID equals (x.foodID)
                        where p.billID == Convert.ToInt32(lblBillID.Text.ToString())
                        select new
                        {
                            FoodName = x.foodName,
                            Amount = p.amount,
                            TotalPrice = x.price
                        }).ToList();
            dgvBill.DataSource = bill;
            int totalpc = 0;
            for (int i = 0; i < dgvBill.RowCount; i++)
            {
                int prc = Convert.ToInt32(dgvBill.Rows[i].Cells[2].Value.ToString());
                int amt = Convert.ToInt32(dgvBill.Rows[i].Cells[1].Value.ToString());
                totalpc += prc * amt;
            }
            txtTotal.Text = totalpc.ToString();
            dgvBill.Rows[0].Selected = false;
        }
        #endregion

        #region PRINT
        private void ptbPrint_Click(object sender, EventArgs e)
        {
            db = new CitiZoneDataContext();
            var pbill = (from p in db.billInfos
                        join x in db.foods
                        on p.foodID equals (x.foodID)
                        where p.billID == Convert.ToInt32(lblBillID.Text.ToString())
                        select new Bill
                        {
                            FoodID = x.foodName,
                            Amount = Convert.ToInt32(p.amount),
                            Total = x.price.ToString()
                        });
            List<Bill> lstBill = pbill.ToList();
            using (frmPrintBill pb = new frmPrintBill())
            {
                pb.PrintBill(BId, lstBill, Convert.ToInt32(txtTotal.Text));
                pb.ShowDialog();
            }
        }
        #endregion
    }
}
