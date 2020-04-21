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
    public partial class frmPrintAccount : DevExpress.XtraEditors.XtraForm
    {
        #region FORM PRINT ACCOUNT
        public frmPrintAccount()
        {
            InitializeComponent();
        }

        private void frmPrintAccount_Load(object sender, EventArgs e)
        {
            rptAccount rpt = new rptAccount();
            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
            
        }
        #endregion
    }
}
