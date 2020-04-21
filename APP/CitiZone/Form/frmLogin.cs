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
    public partial class frmLogin : Form
    {
        #region KHAI BAO BIEN
        public static string loggedUser = "";
        public static string loggedPosition = "";
        #endregion

        #region FORM LOG IN
        CitiZoneDataContext login = new CitiZoneDataContext();
        public frmLogin()
        {
            InitializeComponent();
            #region FONT
            lbluser.Font = new Font("Caviar Dreams", 8, FontStyle.Bold);
            lblpass.Font = new Font("Caviar Dreams", 8, FontStyle.Bold);
            lblquyen.Font = new Font("Caviar Dreams", 8, FontStyle.Bold);
            txtUsername.Font = new Font("Caviar Dreams", 8, FontStyle.Bold);

            #endregion
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region LOG IN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Contains(" ") || txtUsername.Text.Contains(" "))
                MessageBox.Show("Username or Password incorrect", "Notification");
            else
            {
                if (logIn(txtUsername.Text, txtPassword.Text))
                {
                    string pst = (from p in login.accounts
                                  where p.username == txtUsername.Text
                                  select p.position).First().ToString();
                    loggedUser = txtUsername.Text.ToUpper();
                    loggedPosition = pst;
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.ShowDialog();
                    txtPassword.Clear();
                    this.Show();
                }
                else
                    MessageBox.Show("Username or Password incorrect", "Notification");
            }
        }
        private bool logIn(string username, string password)
        {
            var q = from p in login.accounts
                    where p.username == username
                    && p.password == password
                    select new
                    {
                        p.username,
                        p.password,
                        p.position
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

        #region REFRESH / PICTURE BOX CITIZONE
        private void ptbCitiZone_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region CLOSE
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region TEXT CHANGED
        private void txt_TextChanged(object sender, EventArgs e)
        {
            ptbConfirm.Visible = (txtUsername.Text.Trim().Length > 0
                && txtPassword.Text.Trim().Length > 0);
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            if (txtUsername.Text.Trim().Length > 0
                && txtPassword.Text.Trim().Length > 0)
                btnLogin_Click(sender, e);
        }
        #endregion
    }
}
