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
    public partial class frmAddAccount : Form
    {
        private AccountServices accountServices = new AccountServices();
        private CitiZoneDataContext db;
        #region FORM ADD ACCOUNT
        public frmAddAccount()
        {
            InitializeComponent();
            #region FONT
            lblPassword.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            lblUsername.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            lblRPW.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            lblPosition.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            txtUsername.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            cbPosition.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            #endregion
        }
        private void frmAdd_Load(object sender, EventArgs e)
        {
            string pst = frmLogin.loggedPosition;
            if (pst == "admin")
                cbPosition.Items.Add("Manager");
            cbPosition.Items.Add("Staff");
        }
        #endregion

        #region CONFIRM ADD ACCOUNT
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            account account = new account(); ;
            if (txtUsername.Text.Trim().Length > 9)
                MessageBox.Show("Username contain at least 20 characters", "Notification");
            else if (txtPassword.Text.Trim().Length > 20)
                MessageBox.Show("Password must contain at least 20 characters", "Notification");
            else if (txtPassword.Text != txtRePassword.Text)
                MessageBox.Show("Passwords do not match", "Notification");
            else
            {
                if (check(txtPassword.Text))
                {
                    
                    account.username = txtUsername.Text.ToUpper();
                    account.password = txtPassword.Text;
                    account.position = cbPosition.Text.ToLower();
                    accountServices.addAcount(account);
                    MessageBox.Show("Added an account " + account.username + " as " + account.position, "Notification");
                }
                else
                    MessageBox.Show("An account " + account.username + " is already existed, Please use another Username", "Notification");
            }
        }
        private bool check(string usn)
        {
            db = new CitiZoneDataContext();
            var q = from p in db.accounts
                    where p.username == usn
                    select p;

            if (q.Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region CANCEL ADD ACCOUNT
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region ADD ACCOUNT TEXT CHANGED
        private void tbx_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Contains(" ") || txtPassword.Text.Contains(" "))
                ptbConfirm.Visible = false;
            else
            {
                ptbConfirm.Visible = txtUsername.Text.Trim().Length > 0
                     && txtPassword.Text.Trim().Length > 0
                    && txtRePassword.Text.Trim().Length > 0
                    && txtUsername.Text.Trim().Length < 21
                     && txtPassword.Text.Trim().Length < 21
                    && txtRePassword.Text.Trim().Length < 21
                    && cbPosition.SelectedItem != null;
            }
        }
        #endregion
    }
}
