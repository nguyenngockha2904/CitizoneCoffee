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
    public partial class frmEditAccount : Form
    {
        private AccountServices accountServices = new AccountServices();
        #region FORM EDIT ACCOUNT
        CitiZoneDataContext edit = new CitiZoneDataContext();
        string pw = null, ps = null;
        public frmEditAccount(string username, string password, string position)
        {
            InitializeComponent();
            txtUsername.Text = username;
            txtPassword.Text = password;
            lblps.Text= position;
            #region FONT
            lblPassword.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            lblUsername.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            lblPosition.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            txtUsername.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            cbPostion.Font = new Font("Caviar Dreams", 9, FontStyle.Bold);
            #endregion
        }
        private void frmEdit_Load(object sender, EventArgs e)
        {

            if (frmLogin.loggedPosition == "admin")
                cbPostion.Items.Add("Manager");
            else if(frmLogin.loggedUser != txtUsername.Text)
                txtPassword.ReadOnly = true;
            cbPostion.Items.Add("Staff");
            cbPostion.SelectedItem = lblps.Text;
            pw = txtPassword.Text;
            ps = cbPostion.Text;
            ptbConfirm.Visible = false;
        }
        #endregion
        #region CONFIRM EDIT ACCOUNT
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            account account = new account();
            if (txtPassword.Text.Contains(" ") || txtPassword.Text.Trim().Length > 20)
                MessageBox.Show("Password must contain at least 20 characters and no spaces");
            else
            {
                account.username = txtUsername.Text.ToUpper();
                account.password = txtPassword.Text;
                account.position = cbPostion.Text.ToLower();
                string pst = frmLogin.loggedPosition;
                string us = frmLogin.loggedUser;
                if (cbPostion.Text != pst && txtUsername.Text == us)
                {
                    if (MessageBox.Show("If you edit your position you will be logged out of the system", "Notification",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        accountServices.updateAccount(account);
                        MessageBox.Show("Account  " + account.username + " has been updated", "Notification");
                        this.Close();
                    }
                }
                else
                {
                    accountServices.updateAccount(account);
                    MessageBox.Show("Account  " + account.username + " has been updated", "Notification");
                    this.Close();
                }
            }
        }
        #endregion

        #region CANCEL EDIT ACCOUNT
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region EDIT ACCOUNT TEXT CHANGED
        private void tbx_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length < 21)
            {
                if (pw != txtPassword.Text || ps != cbPostion.Text)
                    ptbConfirm.Visible = true;
                else
                    ptbConfirm.Visible = false;
            }
            else
                ptbConfirm.Visible = false;
        }
        #endregion
    }
}
