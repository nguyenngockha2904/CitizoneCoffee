using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CitiZone
{
    public partial class frmMain : Form
    {
        public static string viewUser = "";
        #region FORM CITIZONE
        CitiZoneDataContext main = new CitiZoneDataContext();
        public frmMain()
        {
            InitializeComponent();
            #region FONT
            lblSale.Font = new Font("Caviar Dreams", 17, FontStyle.Regular);
            lblManage.Font = new Font("Caviar Dreams", 17, FontStyle.Regular);
            lblViewInfo.Font = new Font("Caviar Dreams", 17, FontStyle.Regular);
            lblLogOut.Font = new Font("Caviar Dreams", 17, FontStyle.Regular);
            lblManageCategories.Font = new Font("Caviar Dreams", 17, FontStyle.Regular);
            lblStatistics.Font = new Font("Caviar Dreams", 17, FontStyle.Regular);
            #endregion
        }
        private void frmCitiZone_Load(object sender, EventArgs e)
        {
                tabCitiZone.Text = (frmLogin.loggedPosition.ToUpper() + ": " + frmLogin.loggedUser.ToUpper());
            if (frmLogin.loggedPosition == "staff")
            {
                tabMain.TabPages.Remove(tabForManagers);
            }
        }
        #endregion

        #region VIEW INFO
        private void ptbViewInfo_Click(object sender, EventArgs e)
        {
            viewUser = frmLogin.loggedUser;
           // MessageBox.Show(viewUser);
            frmInfoAccount viewinfo = new frmInfoAccount();
            viewinfo.ShowDialog();
            frmCitiZone_Load(sender, e);
        }
        #endregion Manage Account

        #region LOG OUT
        public void ptbLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region CLIENT SIZE CHANGED
        private void frmCitiZone_ClientSizeChanged(object sender, EventArgs e)
        {
            pnlCitiZone.Location = new Point (  this.ClientSize.Width / 2 - pnlCitiZone.Size.Width / 2,
                                                this.ClientSize.Height / 2 - pnlCitiZone.Size.Height / 2);
            pnlCitiZone.Anchor = AnchorStyles.None;

            pnlForManagers.Location = new Point(this.ClientSize.Width / 2 - pnlForManagers.Size.Width / 2,
                        this.ClientSize.Height / 2 - pnlForManagers.Size.Height / 2);
            pnlForManagers.Anchor = AnchorStyles.None;
        }
        private void mainTab_Click(object sender, EventArgs e)
        {
            frmCitiZone_ClientSizeChanged(sender, e);
        }

        #endregion

        #region MOUSE MOVE / MOUSE LEAVE
        private void ptbManageAccount_MouseMove(object sender, MouseEventArgs e)
        {
            lblManage.Visible = true;
        }

        private void ptbManageAccount_MouseLeave(object sender, EventArgs e)
        {
            lblManage.Visible = false;
        }

        private void ptbSale_MouseMove(object sender, MouseEventArgs e)
        {
            lblSale.Visible = true;
        }

        private void ptbSale_MouseLeave(object sender, EventArgs e)
        {
            lblSale.Visible = false;
        }

        private void ptbViewInfo_MouseMove(object sender, MouseEventArgs e)
        {
            lblViewInfo.Visible = true;
        }

        private void ptbViewInfo_MouseLeave(object sender, EventArgs e)
        {
            lblViewInfo.Visible = false;
        }

        private void ptbLogOut_MouseMove(object sender, MouseEventArgs e)
        {
            lblLogOut.Visible = true;
        }

        private void ptbLogOut_MouseLeave(object sender, EventArgs e)
        {
            lblLogOut.Visible = false;
        }

        private void ptbManageCategories_MouseMove(object sender, MouseEventArgs e)
        {
            lblManageCategories.Visible = true;
        }

        private void ptbManageCategories_MouseLeave(object sender, EventArgs e)
        {
            lblManageCategories.Visible = false;
        }

        private void ptbStatistical_MouseMove(object sender, MouseEventArgs e)
        {
            lblStatistics.Visible = true;
        }

        private void ptbStatistical_MouseLeave(object sender, EventArgs e)
        {
            lblStatistics.Visible = false;
        }

        #endregion

        #region FOR MANAGERS

        private void ptbManageAccount_Click(object sender, EventArgs e)
        {
            frmManageAccount frm = new frmManageAccount();
            frm.Owner = this;
            frm.ShowDialog();
        }
        private void ptbManageCategories_Click(object sender, EventArgs e)
        {
            frmManageCategories frm = new frmManageCategories();
            frm.ShowDialog();
            frmCitiZone_Load(sender, e);
        }

        private void ptbStatistical_Click(object sender, EventArgs e)
        {
            frmStatistics frm = new frmStatistics();
            frm.ShowDialog();
            frmCitiZone_Load(sender, e);
        }
        #endregion

        #region SALE
        private void ptbSale_Click(object sender, EventArgs e)
        {
            frmSale frm = new frmSale();
            frm.ShowDialog();
        }
        #endregion
    }
}
