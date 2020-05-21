using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using CitiZone.Class;
using CitiZone.CitizoneServices;
using DevExpress.Utils.Serializing;

namespace CitiZone
{
    public partial class frmInfoAccount : Form
    {
        #region FORM INFO ACCOUNT
        private CitiZoneDataContext viewinfo;
        private AccountServices accountServices = new AccountServices();
        string pw = null, fn = null, adr = null, phone = null, il = null, dtp = null;
        public frmInfoAccount()
        {
            InitializeComponent();
            #region FONT
            lblAR.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            lblAvatar.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            lblBD.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            lblFN.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            lblP.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            lblUsername.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            lblPW.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            txtUsername.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            btnChange.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            btnClose.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            btnConfirm.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            #endregion
        }
        private void frmInfo_Load(object sender, EventArgs e)
        {
            #region LOAD
            string vi = frmMain.viewUser;
            account acc=  accountServices.getAccountByUsername(vi);
            txtUsername.Text = acc.username;
            txtPassword.Text = acc.password;
            txtFullname.Text = acc.fullname;
            dtpBirthday.Text = acc.birthday.ToString();
            txtAddress.Text = acc.address;
            txtPhone.Text = acc.phone.ToString();
            string a = acc.pictureLocation;
            if (File.Exists(a))
            {
                ptbAvatar.Image = Bitmap.FromFile(a);
                lblAvatar.Text = a;
            }
            pw = txtPassword.Text;
            fn = txtFullname.Text;
            dtp = dtpBirthday.ToString();
            adr = txtAddress.Text;
            phone = txtPhone.Text;
            il = lblAvatar.Text;
            #endregion
        }
        #endregion

        #region CHANGE
        private void btnChange_Click(object sender, EventArgs e)
        {

            if (frmLogin.loggedUser == txtUsername.Text)
                txtPassword.ReadOnly = false;
            txtFullname.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtAddress.ReadOnly = false;
            dtpBirthday.Enabled = true;
            ptbAvatar.Enabled = true;
            btnChange.Visible = false;
            btnConfirm.Enabled = false;
        }
        #endregion

        #region CONFIRM 
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Contains(" ") || txtPassword.Text.Trim().Length > 20)
                MessageBox.Show("Password must contain at least 20 characters and no spaces");
            else
            {
                DialogResult dlr = MessageBox.Show("Save changes?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    account account = new account();
                    account.username = txtUsername.Text;
                    account.password = txtPassword.Text;
                    account.fullname = txtFullname.Text;
                    account.address = txtAddress.Text;
                    account.phone =Convert.ToInt32(txtPhone.Text);
                    account.pictureLocation = lblAvatar.Text;
                    account.birthday = DateTime.Parse(dtpBirthday.Text);
                    accountServices.updateAccount(account);
                    frmInfo_Load(sender, e);
                    txtPassword.ReadOnly = true;
                    txtFullname.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    btnChange.Enabled = true;
                    dtpBirthday.Enabled = false;
                    ptbAvatar.Enabled = false;
                    btnChange.Visible = true;
                }
            }
        }
        #endregion

        #region CLOSE
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region AVATAR
        private String filename = "";
        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                String DataPath = 
                openFileDialog.InitialDirectory = "E:\\PROJECT\\PYTHON WEB\\static\\AVATAR";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK) 
                {
                    filename = openFileDialog.FileName;
                    lblAvatar.Text = filename;
                    ptbAvatar.Image = Bitmap.FromFile(filename);
                }
            }
        }
        #endregion

        #region TEXT CHANGED
        private void txt_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = pw != txtPassword.Text
            || fn != txtFullname.Text
            || dtp != dtpBirthday.ToString()
            || adr != txtAddress.Text
            || phone != txtPhone.Text
            || il != lblAvatar.Text;
        }
        #endregion
    }
}
