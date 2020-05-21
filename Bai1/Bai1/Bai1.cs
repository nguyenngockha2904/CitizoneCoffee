using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmBaiToan1 : Form
    {
        public frmBaiToan1()
        {
            InitializeComponent();
        }

        private bool KiemTraHopLe(String s)
        {
            bool HopLe = true;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c < 'A' || c > 'Z')
                {
                    HopLe = false;
                    break;
                }
            }
            return HopLe;
        }

        private void txtBanTinRo_TextChanged(object sender, EventArgs e)
        {
            //btnMaHoa.Enabled = KiemTraHopLe(txtBanTinRo.Text);
        }
        int sonud = 0;
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < txtBanTinRo.Text.Length; i++)
            {
                char c = txtBanTinRo.Text[i];
                int n = (int)c;
                if (c >= 'A' && c <= 'Z')
                {
                    c = (Char)((n - 65 + (int)(nudSoViTri.Value)) % 26 + 65);
                    MessageBox.Show("ma hoa chu : "+((n - 65 + (int)(nudSoViTri.Value)) % 26 + 65).ToString());
                    s += c; // s = s + c
                }
                else if(c >'/' && c < ':')
                {

                    // MessageBox.Show((nudSoViTri.Value-nudSoViTri.Value % 10).ToString());
                    if ((int)(nudSoViTri.Value) >= 10)
                    {
                        sonud = (int)(nudSoViTri.Value % 10);
                        if (nudSoViTri.Value % 10 == 0)
                        {
                            sonud = sonud + 5;
                        }
                        c = (Char)((n - 48 + sonud) % 10 + 48);
                        // MessageBox.Show("ma hoa số :" + ((n - 48 + (int)(nudSoViTri.Value)) % 10 + 48));
                        s += c; // s = s + c

                    }
                    else
                    {
                        c = (Char)((n - 48 + (int)(nudSoViTri.Value)) % 10 + 48);
                        MessageBox.Show("ma hoa số :" + ((n - 48 + (int)(nudSoViTri.Value)) % 10 + 48));
                        s += c; // s = s + c }
                    }
                }else if (c >= 'a' && c <= 'z')
                {
                    c = (Char)((n - 97 + (int)(nudSoViTri.Value)) % 26 + 97);
                   // MessageBox.Show("ma hoa chu : " + ((n - 65 + (int)(nudSoViTri.Value)) % 26 + 65).ToString());
                    s += c; // s = s + c
                }


            }
            txtBanTinDuocMaHoa.Text = s;
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < txtBanTinDuocMaHoa.Text.Length; i++)
            {
                char c = txtBanTinDuocMaHoa.Text[i];
                int n = (int)c;
                if (c >= 'A' && c <= 'Z')
                {
                    c = (Char)((n - 65 - (int)(nudSoViTri.Value) + 26) % 26 + 65);
                    s += c; // s = s + c
                    MessageBox.Show("giai ma chu :" + ((n - 65 - (int)(nudSoViTri.Value) + 26) % 26 + 65));
                }
                else if (c > '/' && c < ':')
                {
                    if ((int)(nudSoViTri.Value) >= 10)
                    {
                        c = (Char)((n - 48 - sonud + 10) % 10 + 48);
                        s += c; // s = s + c
                    }
                    else
                    {
                        c = (Char)((n - 48 - (int)(nudSoViTri.Value) + 10) % 10 + 48);
                        s += c; // s = s + c

                    }

                }
                else if (c >= 'a' && c <= 'z')
                {

                    c = (Char)((n - 97 - (int)(nudSoViTri.Value) + 26) % 26 + 97);
                    s += c; // s = s + c
                }
                }
            txtBanTinDuocGiaiMa.Text = s;
        }

        private void txtBanTinDuocMaHoa_TextChanged(object sender, EventArgs e)
        {
          //  btnGiaiMa.Enabled = KiemTraHopLe(txtBanTinDuocMaHoa.Text);
        }
    }
}
