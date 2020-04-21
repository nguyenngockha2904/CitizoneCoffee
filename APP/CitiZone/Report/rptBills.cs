using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
namespace CitiZone
{
    public partial class rptBill : DevExpress.XtraReports.UI.XtraReport
    {
        #region BILL
        public rptBill()
        {
            InitializeComponent();
        }
        public void InitData(int BillID, List<Bill> list, int totalprice)
        {
            objectDataSource1.DataSource = list;
            lblBillID.Text = BillID.ToString();
            lblTotal.Text = totalprice.ToString();
        }
    }
    #endregion
}
