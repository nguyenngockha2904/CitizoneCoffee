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
    public partial class frmPieChart : Form
    {
        #region FORM PIE CHART
        CitiZoneDataContext db = new CitiZoneDataContext();
        DateTime dmy = new DateTime();
        DateTime dmyEnd = new DateTime();
        DateTimePicker dmyt = new DateTimePicker();
        DateTimePicker dmyEndt = new DateTimePicker();
        int choice;
        string usn;
        public frmPieChart(DateTimePicker dtp, int chos, string usn1, DateTimePicker dtpEnd)
        {
            InitializeComponent();
            dmy = dtp.Value;
            choice = chos;
            usn = usn1;
            dmyEnd = dtpEnd.Value;
            dmyt.Value = dtp.Value;
            dmyEndt.Value = dtpEnd.Value;
            #region FONT
            lblChart.Font = new Font("Caviar Dreams", 30, FontStyle.Regular);
            cbUser.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            chartCG.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            #endregion
        }

        private void frm_Load(object sender, EventArgs e)
        {
            combobox_load();
            FirstLoad();
            btnShow_Click(sender, e);
        }
        #endregion

        #region LOAD
        public void FirstLoad()
        {
            cbUser.SelectedItem = usn;
        }
        public void combobox_load()
        {
            var d = (from c in db.accounts
                     select c.username
                   ).ToList();
            cbUser.DataSource = d;
        }
        private void cbUser_Click(object sender, EventArgs e)
        {
            frm_Load(sender, e);
        }
        #endregion

        #region SHOW
        private void btnShow_Click(object sender, EventArgs e)
        {
            #region VAR
            var ab = from a in db.bills
                     join b in db.billInfos on a.billID equals b.billID
                     where a.username == cbUser.Text
                     select new
                     {
                         b.foodID,
                         b.amount,
                         a.billDate
                     };
            var abc = from x in ab
                      join d in db.foods
                      on x.foodID equals d.foodID
                      select new
                      {
                          x.billDate,
                          d.categoryID,
                          x.amount
                      };
            var abcd = from x in abc
                       join k in db.categories
                       on x.categoryID equals k.categoryID
                       select new
                       {
                           x.billDate,
                           k.categoryName,
                           x.amount
                       };
            var day = from d in abcd
                      where d.billDate.Value.Date == dmy.Date
                      group d by d.categoryName into g
                      select new
                      {
                          ctg = g.Key,
                          amt = g.Sum(d => d.amount)
                      };
            var m = from d in abcd
                    where d.billDate.Value.Month == dmy.Month && d.billDate.Value.Year == dmy.Year
                    group d by d.categoryName into g
                    select new
                    {
                        ctg = g.Key,
                        amt = g.Sum(d => d.amount)
                    };
            var y = from d in abcd
                    where d.billDate.Value.Year == dmy.Year
                    group d by d.categoryName into g
                    select new
                    {
                        ctg = g.Key,
                        amt = g.Sum(d => d.amount)
                    };
            var ed = from d in abcd
                     where d.billDate.Value.Date <= dmyEnd.Date && d.billDate.Value.Date >= dmy.Date
                     group d by d.categoryName into g
                     select new
                     {
                         ctg= g.Key,
                         amt = g.Sum(d => d.amount)
                     };
            var all = from d in abcd
                      group d by d.categoryName into g
                      select new
                      {
                          ctg = g.Key,
                          amt = g.Sum(d => d.amount)
                      };
            #endregion
            switch (choice)
            {
                case 1:
                    chartCG.DataSource = day;
                    lblChart.Text = "DAILY PIE CHART OF DAY " + dmy.Day + "-" + dmy.Month + "-" + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD CATEGORIES";
                    break;
                case 2:
                    chartCG.DataSource = m;
                    lblChart.Text = "MONTHLY PIE CHART OF MONTH " + dmy.Month + "-" + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD CATEGORIES";
                    break;
                case 3:
                    chartCG.DataSource = y;
                    lblChart.Text = "YEARLY PIE CHART OF YEAR " + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD CATEGORIES";
                    break;
                case 4:
                    chartCG.DataSource = ed;
                    lblChart.Text = "PIE CHART FROM DAY " + dmy.Day + "-" + dmy.Month + "-" + dmy.Year +
                                    " TO DAY " + dmyEnd.Day + "-" + dmyEnd.Month + "-" + dmyEnd.Year +
                                    "\nABOUT THE AMOUNT OF SOLD FOOD CATEGORIES";
                    break;
                case 5:
                    chartCG.DataSource = all;
                    lblChart.Text = "PIE CHART OF WHOLE TIME\nABOUT THE AMOUNT OF SOLD FOOD CATEGORIES";
                    break;
            }
            chartCG.Series["s1"].IsValueShownAsLabel = true;
        }

        private void btnSA_Click(object sender, EventArgs e)
        {
            cbUser.DataSource = null;
            cbUser.Items.Clear();
            cbUser.Items.Add("ALL");
            cbUser.SelectedItem = "ALL";
            #region VAR
            var ab = from a in db.bills
                     join b in db.billInfos on a.billID equals b.billID
                     select new
                     {
                         b.foodID,
                         b.amount,
                         a.billDate
                     };
            var abc = from x in ab
                      join d in db.foods
                      on x.foodID equals d.foodID
                      select new
                      {
                          x.billDate,
                          d.categoryID,
                          x.amount
                      };
            var abcd = from x in abc
                       join k in db.categories
                       on x.categoryID equals k.categoryID
                       select new
                       {
                           x.billDate,
                           k.categoryName,
                           x.amount
                       };
            var day = from d in abcd
                      where d.billDate.Value.Date == dmy.Date
                      group d by d.categoryName into g
                      select new
                      {
                          ctg = g.Key,
                          amt = g.Sum(d => d.amount)
                      };
            var m = from d in abcd
                    where d.billDate.Value.Month == dmy.Month && d.billDate.Value.Year == dmy.Year
                    group d by d.categoryName into g
                    select new
                    {
                        ctg = g.Key,
                        amt = g.Sum(d => d.amount)
                    };
            var y = from d in abcd
                    where d.billDate.Value.Year == dmy.Year
                    group d by d.categoryName into g
                    select new
                    {
                        ctg = g.Key,
                        amt = g.Sum(d => d.amount)
                    };
            var ed = from d in abcd
                     where d.billDate.Value.Date <= dmyEnd.Date && d.billDate.Value.Date >= dmy.Date
                     group d by d.categoryName into g
                     select new
                     {
                         ctg = g.Key,
                         amt = g.Sum(d => d.amount)
                     };
            var all = from d in abcd
                      group d by d.categoryName into g
                      select new
                      {
                          ctg = g.Key,
                          amt = g.Sum(d => d.amount)
                      };
            #endregion
            switch (choice)
            {
                case 1:
                    chartCG.DataSource = day;
                    lblChart.Text = "DAILY PIE CHART OF DAY " + dmy.Day + "-" + dmy.Month + "-" + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD CATEGORIES";
                    break;
                case 2:
                    chartCG.DataSource = m;
                    lblChart.Text = "MONTHLY PIE CHART OF MONTH " + dmy.Month + "-" + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD CATEGORIES";
                    break;
                case 3:
                    chartCG.DataSource = y;
                    lblChart.Text = "YEARLY PIE CHART OF YEAR " + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD CATEGORIES";
                    break;
                case 4:
                    chartCG.DataSource = ed;
                    lblChart.Text = "PIE CHART FROM DAY " + dmy.Day + "-" + dmy.Month + "-" + dmy.Year +
                                    " TO DAY " + dmyEnd.Day + "-" + dmyEnd.Month + "-" + dmyEnd.Year +
                                    "\nABOUT THE AMOUNT OF SOLD FOOD CATEGORIES";
                    break;
                case 5:
                    chartCG.DataSource = all;
                    lblChart.Text = "PIE CHART OF WHOLE TIME\nABOUT THE AMOUNT OF SOLD FOOD CATEGORIES";
                    break;
            }
            chartCG.Series["s1"].IsValueShownAsLabel = true;
        }
        private void cbUser_Click_1(object sender, EventArgs e)
        {
            frm_Load(sender, e);
        }
        #endregion

        #region CHART
        private void ptbChart_Click(object sender, EventArgs e)
        {
            frmChart frm = new frmChart(dmyt, choice, cbUser.Text, dmyEndt);
            frm.ShowDialog();
        }
        #endregion
    }
}
