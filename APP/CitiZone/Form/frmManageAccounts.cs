using CitiZone.CitizoneServices;
using CitiZone.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitiZone
{
    public partial class frmManageAccount : Form
    {
        #region KHAI BAO BIEN
        string loggedUser = frmLogin.loggedUser;
        string loggedPosition = frmLogin.loggedPosition;
        private AccountServices accountServices = new AccountServices();
        private CitiZoneDataContext MA;
        #endregion

        #region FORM MANAGE ACCOUNT

        public frmManageAccount()
        {
            InitializeComponent();
            #region FONT
         //   dgvQLTK.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            #endregion
        }
        private void frmManageAccount_Load(object sender, EventArgs e)
        {
            MA = new CitiZoneDataContext();
            dgvQLTK.DataSource = from q in MA.accounts
                                 orderby q.position ascending
                                 select new
                                 {
                                     usn = q.username,
                                     Fullname = q.fullname,
                                     quyen = q.position,
                                     pw = q.password
                                 };
        }
        #endregion

        #region FORM MANAGE ACCOUNT CLIENT SIZE CHANGED
        private void frmManageAccount_ClientSizeChanged(object sender, EventArgs e)
        {
            pnlManageAccount.Location = new Point(this.ClientSize.Width / 2 - pnlManageAccount.Size.Width / 2,
                                    this.ClientSize.Height / 2 - pnlManageAccount.Size.Height / 2);
            pnlManageAccount.Anchor = AnchorStyles.None;
        }
        #endregion

        #region CLICKS

        #region ADD ACCOUNT
        private void ptbAdd_Click(object sender, EventArgs e)
        {
            frmAddAccount add = new frmAddAccount();
            add.ShowDialog();
            frmManageAccount_Load(sender, e);
        }
        #endregion

        #region EDIT ACCOUNT
        private void ptbEdit_Click(object sender, EventArgs e)
        {
            string username = dgvQLTK.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string password = dgvQLTK.SelectedCells[0].OwningRow.Cells[3].Value.ToString();
            string position = dgvQLTK.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
            
                if ((loggedPosition == "admin" && position != "admin") || (loggedPosition == "manager" && position == "staff")|| loggedUser== username)
                {
                    frmEditAccount editadmin = new frmEditAccount(username, password, position);
                    editadmin.ShowDialog();
                }
                else
                    MessageBox.Show(username + " is "+ position + ", you can not Edit", "Notification");
                frmManageAccount_Load(sender, e);
        }
        #endregion

        #region DELETE ACCOUNT
        private void ptbDelete_Click(object sender, EventArgs e)
        {
            string username = dgvQLTK.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string pst = dgvQLTK.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
            if (checkbill(username))
                MessageBox.Show("You must delete all bill of this user first", "Notification");
            else
            {
                account account = new account();
                account.username = username;

                if (loggedPosition == "admin" && pst != "admin" || loggedPosition == "manager" && pst == "staff")
                {
                    if (MessageBox.Show("Account " + username + " will be permanently DELETED", "Notification",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        accountServices.deleteAccount(account);
                    }
                }
                else
                    MessageBox.Show("You can not delete this account", "Notification");

            }
        frmManageAccount_Load(sender, e);
        }
        private void frmManageAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                ptbDelete_Click(sender, e);
        }
        #endregion

        #region CHECK
        private bool checkbill(string username)
        {
            var q = from p in MA.bills
                    where p.username == username
                    select new
                    {
                        p.username
                    };

            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region INFO ACCOUNT
        private void ptbViewInfo_Click(object sender, EventArgs e)
        {
            string username = dgvQLTK.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string position = dgvQLTK.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
            if ((loggedPosition == "manager" && position == "staff") || (loggedPosition == "admin" && position != "admin")|| (loggedUser==username))
            {
                frmMain.viewUser = username;
                frmInfoAccount viewinfo = new frmInfoAccount();
                viewinfo.ShowDialog();
                frmManageAccount_Load(sender, e);
            }
            else
            {
                MessageBox.Show("You can`t view this account");
            }
        }
        #endregion

        #region CLOSE
        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region PRINT
        private void ptbPrint_Click(object sender, EventArgs e)
        {
            frmPrintAccount frm = new frmPrintAccount();
            frm.ShowDialog();
        }
        #endregion

        #endregion

    }
}