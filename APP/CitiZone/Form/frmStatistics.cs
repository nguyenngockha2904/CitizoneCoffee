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
    public partial class frmStatistics : Form
    {
        #region FORM STATISTICS
        CitiZoneDataContext Statistics = new CitiZoneDataContext();
        DateTime date = new DateTime();
        public frmStatistics()
        {
            InitializeComponent();
            #region FONT
            dgvBill.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            dgvUsername.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            dtpStaticDate.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            dtpEndDate.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            txtTotal.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            txtSearch.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            chbViewAll.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            rbDay.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            rbMonth.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            rbYear.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            rbBetWeen.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            lblFrom.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            lblTo.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            #endregion
        }
        private void frmStatistics_Load(object sender, EventArgs e)
        {
            var usn = (from p in Statistics.accounts
                       select new
                       {
                           Username = p.username,
                           Position = p.position
                       }).ToList();
            dgvUsername.DataSource = usn;
            
            var bill = (from p in Statistics.bills
                        where p.username == ""
                        select new
                        {
                            BillID = p.billID,
                            BillName = p.billName,
                            BillDate = p.billDate,
                            Creator = p.username,
                            BillTotal = p.total
                        }).ToList();
            dgvBill.DataSource = bill;
            ptbDelete.Visible = false;
            ptbInfo.Visible = false;
            ptbDeleteAll.Visible = false;
            dtpStaticDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }
        #endregion

        #region CELLCLICKS
        private void dgvUsername_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpStaticDate_ValueChanged(sender, e);
            if (dgvBill.RowCount == 0)
                txtTotal.Clear();
            ptbDelete.Visible = false;
            ptbInfo.Visible = false;
            ptbDeleteAll.Visible = false;
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBill.RowCount > 0)
            {
                if (dgvBill.SelectedCells[0].OwningRow.Cells[0].Value != null)
                {
                    ptbDelete.Visible = true;
                    ptbInfo.Visible = true;
                    ptbDeleteAll.Visible = true;
                }
                else
                {
                    ptbDelete.Visible = false;
                    ptbInfo.Visible = false;
                    ptbDeleteAll.Visible = false;
                }
            }
        }
        #endregion

        #region DELETE
        private void ptbDelete_Click(object sender, EventArgs e)
        {
            if (dgvBill.RowCount > 0)
            {
                int BillID = Convert.ToInt32(dgvBill.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                if (MessageBox.Show("Bill" + BillID + " will be permanently DELETED", "Notification",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateBoT(BillID);
                    Statistics.deleteBillInfo(BillID);
                    Statistics.deleteBills(BillID);
                    if (dgvBill.RowCount > 0)
                    {
                        string usn = dgvUsername.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                        var bill = (from p in Statistics.bills
                                    where p.username == usn
                                    select new
                                    {
                                        BillID = p.billID,
                                        BillName = p.billName,
                                        BillDate = p.billDate,
                                        Creator = p.username,
                                        BillTotal = p.total
                                    }).ToList();
                        dgvBill.DataSource = bill;
                    }
                    ptbDelete.Visible = false;
                    ptbInfo.Visible = false;
                    ptbDeleteAll.Visible = false;
                    ptbClear_Click(sender, e);
                }
            }
        }
        private void dgvBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (ptbDelete.Visible == true)
                if (e.KeyCode == Keys.Delete)
                    ptbDelete_Click(sender, e);
        }
        #endregion

        #region INFO
        private void ptbInfo_Click(object sender, EventArgs e)
        {
            frmBillInfo frm = new frmBillInfo(dgvBill.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }
        #endregion

        #region VIEW ALL
        private void ptbViewAll_Click(object sender, EventArgs e)
        {
            date = dtpStaticDate.Value;
            if (rbDay.Checked)
            {
                if (txtSearch.Text != "")
                {
                    int bID = 0;
                    if (int.TryParse(txtSearch.Text, out bID))
                        int.TryParse(txtSearch.Text, out bID);
                    string BillName = txtSearch.Text;
                    var s = Statistics.searchBills(bID, BillName);
                    var bill = (from p in s
                                where p.billDate.Value.Date == date.Date
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
                else
                {
                    var bill = (from p in Statistics.bills
                                where p.billDate.Value.Date == date.Date
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
            }
            else if( rbMonth.Checked)
            {
                if (txtSearch.Text != "")
                {
                    int bID = 0;
                    if (int.TryParse(txtSearch.Text, out bID))
                        int.TryParse(txtSearch.Text, out bID);
                    string BillName = txtSearch.Text;
                    var s = Statistics.searchBills(bID, BillName);
                    var bill = (from p in s
                                where p.billDate.Value.Month == date.Month &&
                                p.billDate.Value.Year == date.Year
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
                else
                {
                    var bill = (from p in Statistics.bills
                                where p.billDate.Value.Month == date.Month &&
                                p.billDate.Value.Year == date.Year
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
            }
            else if (rbYear.Checked)
            {
                if (txtSearch.Text != "")
                {
                    int bID = 0;
                    if (int.TryParse(txtSearch.Text, out bID))
                        int.TryParse(txtSearch.Text, out bID);
                    string BillName = txtSearch.Text;
                    var s = Statistics.searchBills(bID, BillName);
                    var bill = (from p in s
                                where p.billDate.Value.Year == date.Year
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
                else
                {
                    var bill = (from p in Statistics.bills
                                where p.billDate.Value.Year == date.Year
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
            }
            else if (rbBetWeen.Checked)
            {
                if (txtSearch.Text != "")
                {
                    int bID = 0;
                    if (int.TryParse(txtSearch.Text, out bID))
                        int.TryParse(txtSearch.Text, out bID);
                    string BillName = txtSearch.Text;
                    var s = Statistics.searchBills(bID, BillName);
                    var bill = (from p in s
                                where
                                p.billDate.Value.Date >= date.Date && p.billDate.Value.Date <= dtpEndDate.Value.Date
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
                else
                {
                    var bill = (from p in Statistics.bills
                                where
                                p.billDate.Value.Date >= date.Date && p.billDate.Value.Date <= dtpEndDate.Value.Date
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
            }
            else
            {
                if (txtSearch.Text != "")
                {
                    int bID = 0;
                    if (int.TryParse(txtSearch.Text, out bID))
                        int.TryParse(txtSearch.Text, out bID);
                    string BillName = txtSearch.Text;
                    var s = Statistics.searchBills(bID, BillName);
                    var bill = (from p in s
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
                else
                {
                    var bill = (from p in Statistics.bills
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
            }
            if (dgvBill.RowCount > 0)
                total();
            else
            {
                txtTotal.Clear();
                ptbDelete.Visible = false;
                ptbInfo.Visible = false;
                ptbDeleteAll.Visible = false;
            }
        }
        private void chbViewAll_CheckedChanged(object sender, EventArgs e)
        {
            dtpStaticDate_ValueChanged(sender, e);
        }
        #endregion

        #region DELETE ALL
        private void ptbDeleteAll_Click(object sender, EventArgs e)
        {
            if (dgvBill.RowCount > 0)
            {
                if (MessageBox.Show("All Bill will be permanently DELETED", "Notification",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvBill.RowCount; i++)
                    {
                        int BillID = Convert.ToInt32(dgvBill.Rows[i].Cells[0].Value.ToString());
                        UpdateBoT(BillID);
                        Statistics.deleteBillInfo(BillID);
                        Statistics.deleteBills(BillID);
                    }
                    if (dgvBill.RowCount > 0)
                    {
                        string usn = dgvUsername.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                        var bill = (from p in Statistics.bills
                                    where p.username == usn
                                    select new
                                    {
                                        BillID = p.billID,
                                        BillName = p.billName,
                                        Date = p.billDate,
                                        Total = p.total
                                    }).ToList();
                        dgvBill.DataSource = bill;
                    }
                    ptbDelete.Visible = false;
                    ptbInfo.Visible = false;
                    ptbDeleteAll.Visible = false;
                    ptbClear_Click(sender, e);
                }
            }
        }
        #endregion

        #region UPDATE BOT
        private void UpdateBoT(int BillID)
        {
            var c = (from p in Statistics.coffeeTables
                     where p.billID == BillID
                     select p);

            if (c.Any())
            {
                int tblID = Convert.ToInt32((from p in Statistics.coffeeTables
                             where p.billID == BillID
                             select p.tableID).First().ToString());
                Statistics.updateCoffeeTable(tblID, null, "empty");
            }
        }
        #endregion

        #region STATISTICS DATE
        private void dtpStaticDate_ValueChanged(object sender, EventArgs e)
        {
            date = dtpStaticDate.Value;
            string usn = dgvUsername.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (rbDay.Checked)
            {
                if (txtSearch.Text != "")
                {
                    int bID = 0;
                    if (int.TryParse(txtSearch.Text, out bID))
                        int.TryParse(txtSearch.Text, out bID);
                    string BillName = txtSearch.Text;
                    var s = Statistics.searchBills(bID, BillName);
                    var bill = (from p in s
                                where p.billDate.Value.Date == date.Date && p.username == usn
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
                else
                {
                    var bill = (from p in Statistics.bills
                                where p.billDate.Value.Date == date.Date && p.username == usn
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
            }
            else if( rbMonth.Checked)
            {
                if (txtSearch.Text != "")
                {
                    int bID = 0;
                    if (int.TryParse(txtSearch.Text, out bID))
                        int.TryParse(txtSearch.Text, out bID);
                    string BillName = txtSearch.Text;
                    var s = Statistics.searchBills(bID, BillName);
                    var bill = (from p in s
                                where p.billDate.Value.Month == date.Month &&
                                p.billDate.Value.Year == date.Year &&
                                p.username == usn
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
                else
                { 
                    var bill = (from p in Statistics.bills
                                where p.billDate.Value.Month == date.Month &&
                                p.billDate.Value.Year == date.Year &&
                                p.username == usn
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
            }
            else if (rbYear.Checked)
            {
                if (txtSearch.Text != "")
                {
                    int bID = 0;
                    if (int.TryParse(txtSearch.Text, out bID))
                        int.TryParse(txtSearch.Text, out bID);
                    string BillName = txtSearch.Text;
                    var s = Statistics.searchBills(bID, BillName);
                    var bill = (from p in s
                                where p.billDate.Value.Year == date.Year && p.username == usn
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
                else
                {
                    var bill = (from p in Statistics.bills
                                where p.billDate.Value.Year == date.Year && p.username == usn
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
            }
            else if (rbBetWeen.Checked)
            {
                if (txtSearch.Text != "")
                {
                    int bID = 0;
                    if (int.TryParse(txtSearch.Text, out bID))
                        int.TryParse(txtSearch.Text, out bID);
                    string BillName = txtSearch.Text;
                    var s = Statistics.searchBills(bID, BillName);
                    var bill = (from p in s
                                where
                                p.billDate.Value.Date >= date.Date
                                && p.billDate.Value.Date <= dtpEndDate.Value.Date
                                && p.username == usn
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
                else
                {
                    var bill = (from p in Statistics.bills
                                where
                                p.billDate.Value.Date >= date.Date
                                && p.billDate.Value.Date <= dtpEndDate.Value.Date
                                && p.username == usn
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
            }
            else
            {
                if (txtSearch.Text != "")
                {
                    int bID = 0;
                    if (int.TryParse(txtSearch.Text, out bID))
                        int.TryParse(txtSearch.Text, out bID);
                    string BillName = txtSearch.Text;
                    var s = Statistics.searchBills(bID, BillName);
                    var bill = (from p in s
                                where p.username == usn
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
                else
                {
                    var bill = (from p in Statistics.bills
                                where p.username == usn
                                select new
                                {
                                    BillID = p.billID,
                                    BillName = p.billName,
                                    BillDate = p.billDate,
                                    Creator = p.username,
                                    BillTotal = p.total
                                }).ToList();
                    dgvBill.DataSource = bill;
                }
            }
            if (dgvBill.RowCount > 0)
                total();
            else
            {
                txtTotal.Clear();
                ptbDelete.Visible = false;
                ptbInfo.Visible = false;
                ptbDeleteAll.Visible = false;
            }
            if (chbViewAll.Checked)
            {
                ptbViewAll_Click(sender, e);
            }
        }
        #endregion

        #region TOTAL
        private void total()
        {
            int total = 0;
            for(int i =0; i<dgvBill.RowCount;i++)
            {
                total += Convert.ToInt32(dgvBill.Rows[i].Cells[4].Value.ToString());
            }
            txtTotal.Text = total.ToString();
        }
        #endregion

        #region RB CHECKED CHANGED
        private void rbCheckedChanged(object sender, EventArgs e)
        {
            if (rbDay.Checked == true || rbMonth.Checked == true || rbYear.Checked == true || rbBetWeen.Checked == true)
            {
                ptbClear.Visible = true;
                if(rbBetWeen.Checked == true)
                {
                    lblFrom.Visible = true;
                    lblTo.Visible = true;
                    dtpEndDate.Enabled = true;
                }
                else
                {
                    lblFrom.Visible = false;
                    lblTo.Visible = false;
                    dtpEndDate.Enabled = false;
                }
            }
            dtpStaticDate_ValueChanged(sender, e);
        }
        #endregion

        #region CLEAR
        private void ptbClear_Click(object sender, EventArgs e)
        {
            rbDay.Checked = false;
            rbMonth.Checked = false;
            rbYear.Checked = false;
            rbBetWeen.Checked = false;
            ptbClear.Visible = false;
            lblFrom.Visible = false;
            lblTo.Visible = false;
            dtpEndDate.Enabled = false;
        }
        #endregion

        #region CHART
        private void ptbChart_Click(object sender, EventArgs e)
        {
            string usn = dgvUsername.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (rbDay.Checked)
            {
                frmChart frm = new frmChart(dtpStaticDate, 1, usn, dtpEndDate);
                frm.ShowDialog();
            }
            else if (rbMonth.Checked)
            {
                frmChart frm = new frmChart(dtpStaticDate, 2, usn, dtpEndDate);
                frm.ShowDialog();
            }
            else if (rbYear.Checked)
            {
                frmChart frm = new frmChart(dtpStaticDate, 3, usn, dtpEndDate);
                frm.ShowDialog();
            }
            else if(rbBetWeen.Checked)
            {
                frmChart frm = new frmChart(dtpStaticDate, 4, usn, dtpEndDate);
                frm.ShowDialog();
            }
            else
            {
                frmChart frm = new frmChart(dtpStaticDate, 5, usn, dtpEndDate);
                frm.ShowDialog();
            }
        }
        private void ptbPieChart_Click(object sender, EventArgs e)
        {
            string usn = dgvUsername.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (rbDay.Checked)
            {
                frmPieChart frm = new frmPieChart(dtpStaticDate, 1, usn, dtpEndDate);
                frm.ShowDialog();
            }
            else if (rbMonth.Checked)
            {
                frmPieChart frm = new frmPieChart(dtpStaticDate, 2, usn, dtpEndDate);
                frm.ShowDialog();
            }
            else if (rbYear.Checked)
            {
                frmPieChart frm = new frmPieChart(dtpStaticDate, 3, usn, dtpEndDate);
                frm.ShowDialog();
            }
            else if (rbBetWeen.Checked)
            {
                frmPieChart frm = new frmPieChart(dtpStaticDate, 4, usn, dtpEndDate);
                frm.ShowDialog();
            }
            else
            {
                frmPieChart frm = new frmPieChart(dtpStaticDate, 5, usn, dtpEndDate);
                frm.ShowDialog();
            }
        }
        #endregion

        #region SEARCH
        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            rbCheckedChanged(sender, e);
        }

        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
        #endregion

    }
}