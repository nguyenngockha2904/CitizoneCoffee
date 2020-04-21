using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CitiZone
{
    public partial class frmTable : Form
    {
        #region FORM TABLE
        CitiZoneDataContext table = new CitiZoneDataContext();
        public frmTable()
        {
            InitializeComponent();
            #region FONT
            lblTable.Font = new Font("Caviar Dreams", 12, FontStyle.Regular);
            lblTN.Font = new Font("Caviar Dreams", 12, FontStyle.Regular);
            #endregion
        }
        private void frmTable_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                string stt = (from p in table.coffeeTables
                              where p.tableID == i
                              select p.status).First().ToString();
                if (stt == "full")
                    switch (i)
                    {
                        case 1:
                            ptbTable1F.Visible = true;
                            break;
                        case 2:
                            ptbTable2F.Visible = true;
                            break;
                        case 3:
                            ptbTable3F.Visible = true;
                            break;
                        case 4:
                            ptbTable4F.Visible = true;
                            break;
                        case 5:
                            ptbTable5F.Visible = true;
                            break;
                        case 6:
                            ptbTable6F.Visible = true;
                            break;
                        case 7:
                            ptbTable7F.Visible = true;
                            break;
                        case 8:
                            ptbTable8F.Visible = true;
                            break;
                        case 9:
                            ptbTable9F.Visible = true;
                            break;
                    }
            }
        }
        #endregion

        #region CLICKS
        private void ptbTable1F_Click(object sender, EventArgs e)
        {
            lblTN.Text = "" + 1;
        }
        private void ptbTable2F_Click(object sender, EventArgs e)
        {
            lblTN.Text = "" + 2;
        }

        private void ptbTable3F_Click(object sender, EventArgs e)
        {
            lblTN.Text = "" + 3;
        }

        private void ptbTable4F_Click(object sender, EventArgs e)
        {
            lblTN.Text = "" + 4;
        }

        private void ptbTable5F_Click(object sender, EventArgs e)
        {
            lblTN.Text = "" + 5;
        }

        private void ptbTable6F_Click(object sender, EventArgs e)
        {
            lblTN.Text = "" + 6;
        }

        private void ptbTable7F_Click(object sender, EventArgs e)
        {
            lblTN.Text = "" + 7;
        }

        private void ptbTable8F_Click(object sender, EventArgs e)
        {
            lblTN.Text = "" + 8;
        }

        private void ptbTable9F_Click(object sender, EventArgs e)
        {
            lblTN.Text = "" + 9;
        }
        #endregion

        #region VIEW
        private void ptbView_Click(object sender, EventArgs e)
        {
            string BillID = (from p in table.coffeeTables
                             where p.tableID == Convert.ToInt32(lblTN.Text)
                             select p.billID).First().ToString();
            frmBillInfo fr = new frmBillInfo(BillID);
            fr.ShowDialog();
        }
        #endregion

        #region DELETE
        private void ptbDelete_Click(object sender, EventArgs e)
        {
            string BillID = (from p in table.coffeeTables
                             where p.tableID == Convert.ToInt32(lblTN.Text)
                             select p.billID).First().ToString();
            table.updateCoffeeTable(Convert.ToInt32(lblTN.Text), null, "empty");
            ptbView.Visible = false;
            ptbDelete.Visible = false;
            lblTable.Visible = false;
            lblTN.Visible = false;
            int i = Convert.ToInt32(lblTN.Text);
            switch(i)
            {
                case 1:
                    ptbTable1F.Visible = false;
                    break;
                case 2:
                    ptbTable2F.Visible = false;
                    break;
                case 3:
                    ptbTable3F.Visible = false;
                    break;
                case 4:
                    ptbTable4F.Visible = false;
                    break;
                case 5:
                    ptbTable5F.Visible = false;
                    break;
                case 6:
                    ptbTable6F.Visible = false;
                    break;
                case 7:
                    ptbTable7F.Visible = false;
                    break;
                case 8:
                    ptbTable8F.Visible = false;
                    break;
                case 9:
                    ptbTable9F.Visible = false;
                    break;
            }
        }
        private void frmTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (ptbDelete.Visible == true)
                ptbDelete_Click(sender, e);
        }
        #endregion

        #region TEXT CHANGED
        private void lblTN_TextChanged(object sender, EventArgs e)
        {
            if(lblTN != null)
            {
                lblTN.Visible = true;
                ptbView.Visible = true;
                ptbDelete.Visible = true;
                lblTable.Visible = true;
            }
        }
        #endregion
    }
}
