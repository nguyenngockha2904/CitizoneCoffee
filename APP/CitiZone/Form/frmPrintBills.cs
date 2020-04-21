using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CitiZone
{
    public partial class frmPrintBill : DevExpress.XtraEditors.XtraForm
    {
        #region FORM PRINT BILL
        public frmPrintBill()
        {
            InitializeComponent();
        }
        public void PrintBill(int BillID, List<Bill> list, int totalprice)
        {
            rptBill rpt = new rptBill();
            rpt.InitData(BillID, list, totalprice);
            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }
        #endregion
    }
}