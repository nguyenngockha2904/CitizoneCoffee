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
    public partial class frmChart : Form
    {
        #region CHARTS
        CitiZoneDataContext db = new CitiZoneDataContext();
        DateTime dmy = new DateTime();
        DateTime dmyEnd = new DateTime();
        int choice;
        string usn;
        public frmChart(DateTimePicker dtp, int chos, string usn1, DateTimePicker dtpEnd)
        {
            InitializeComponent();
            dmy = dtp.Value;
            choice = chos;
            usn = usn1;
            dmyEnd = dtpEnd.Value;
            #region FONT
            lblChart.Font = new Font("Caviar Dreams", 30, FontStyle.Regular);
            cbUser.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            crtStaticDay.Font = new Font("iCiel Fester", 9, FontStyle.Regular);
            #endregion
        }
        public void frmChart_Load(object sender, EventArgs e)
        {

            crtStaticDay.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            crtStaticDay.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            crtStaticDay.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            cbCTG_load();
            combobox_load();
            FirstLoad();

            if (usn == "ALL")
                btShowAll_Click(sender, e);
            else
                btShow_Click(sender, e);
        }
        #endregion

        #region EVENTS
        private void btShow_Click(object sender, EventArgs e)
        {
            if (cbUser.Text == "ALL")
                btShowAll_Click(sender, e);
            else
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
                var abc = from c in ab
                          join d in db.foods on c.foodID equals d.foodID
                          select new
                          {
                              d.categoryID,
                              c.billDate,
                              d.foodName,
                              c.amount
                          };
                var abcd = from k in abc
                           join l in db.categories
                           on k.categoryID equals l.categoryID
                           where l.categoryName == cbCTG.Text
                           select new
                           {
                               k.billDate,
                               k.foodName,
                               k.amount
                           };
                var day = from d in abcd
                          where d.billDate.Value.Date == dmy.Date
                          group d by d.foodName into g
                          select new
                          {
                              name = g.Key,
                              ts = g.Sum(d => d.amount)
                          };
                var m = from d in abcd
                        where d.billDate.Value.Month == dmy.Month && d.billDate.Value.Year == dmy.Year
                        group d by d.foodName into g
                        select new
                        {
                            name = g.Key,
                            ts = g.Sum(d => d.amount)
                        };
                var y = from d in abcd
                        where d.billDate.Value.Year == dmy.Year
                        group d by d.foodName into g
                        select new
                        {
                            name = g.Key,
                            ts = g.Sum(d => d.amount)
                        };
                var ed = from d in abcd
                         where d.billDate.Value.Date <= dmyEnd.Date && d.billDate.Value.Date >= dmy.Date
                            group d by d.foodName into g
                         select new
                         {
                             name = g.Key,
                             ts = g.Sum(d => d.amount)
                         };
                var all = from d in abcd
                          group d by d.foodName into g
                          select new
                          {
                              name = g.Key,
                              ts = g.Sum(d => d.amount)
                          };
                #endregion
                switch (choice)
                {
                    case 1:
                        crtStaticDay.DataSource = day;
                        lblChart.Text = "DAILY CHART OF DAY " + dmy.Day + "-" + dmy.Month + "-" + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD";
                        break;
                    case 2:
                        crtStaticDay.DataSource = m;
                        lblChart.Text = "MONTHLY CHART OF MONTH " + dmy.Month + "-" + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD";
                        break;
                    case 3:
                        crtStaticDay.DataSource = y;
                        lblChart.Text = "YEARLY CHART OF YEAR " + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD";
                        break;
                    case 4:
                        crtStaticDay.DataSource = ed;
                        lblChart.Text = "CHART FROM DAY " + dmy.Day + "-" + dmy.Month + "-" + dmy.Year +
                                        " TO DAY " + dmyEnd.Day + "-" + dmyEnd.Month + "-" + dmyEnd.Year +
                                        "\nABOUT THE AMOUNT OF SOLD FOOD";
                        break;
                    case 5:
                        crtStaticDay.DataSource = all;
                        lblChart.Text = "CHART OF WHOLE TIME \nABOUT THE AMOUNT OF SOLD FOOD";
                        break;
                }
                crtStaticDay.Series["Food"].XValueMember = "name";
                crtStaticDay.Series["Food"].YValueMembers = "ts";
                crtStaticDay.Series["Food"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            }
        }
        private void btShowAll_Click(object sender, EventArgs e)
        {
            cbUser.DataSource = null;
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
            var abc = from c in ab
                      join d in db.foods on c.foodID equals d.foodID
                      select new
                      {
                          d.categoryID,
                          c.billDate,
                          d.foodName,
                          c.amount
                      };
            var abcd = from k in abc
                       join l in db.categories
                       on k.categoryID equals l.categoryID
                       where l.categoryName == cbCTG.Text
                       select new
                       {
                           k.billDate,
                           k.foodName,
                           k.amount
                       };
            var day = from d in abcd
                      where d.billDate.Value.Date == dmy.Date
                      group d by d.foodName into g
                      select new
                      {
                          name = g.Key,
                          ts = g.Sum(d => d.amount)
                      };
            var m = from d in abcd
                    where d.billDate.Value.Month == dmy.Month && d.billDate.Value.Year == dmy.Year
                    group d by d.foodName into g
                    select new
                    {
                        name = g.Key,
                        ts = g.Sum(d => d.amount)
                    };
            var y = from d in abcd
                    where d.billDate.Value.Year == dmy.Year
                    group d by d.foodName into g
                    select new
                    {
                        name = g.Key,
                        ts = g.Sum(d => d.amount)
                    };
            var ed = from d in abcd
                     where d.billDate.Value.Date <= dmyEnd.Date && d.billDate.Value.Date >= dmy.Date
                     group d by d.foodName into g
                     select new
                     {
                         name = g.Key,
                         ts = g.Sum(d => d.amount)
                     };
            var all = from d in abcd
                      group d by d.foodName into g
                      select new
                      {
                          name = g.Key,
                          ts = g.Sum(d => d.amount)
                      };
            #endregion
            switch (choice)
            {
                case 1:
                    crtStaticDay.DataSource = day;
                    lblChart.Text = "DAILY CHART OF DAY " + dmy.Day + "-" + dmy.Month + "-" + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD";
                    break;
                case 2:
                    crtStaticDay.DataSource = m;
                    lblChart.Text = "MONTHLY CHART OF MONTH " + dmy.Month + "-" + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD";
                    break;
                case 3:
                    crtStaticDay.DataSource = y;
                    lblChart.Text = "YEARLY CHART OF YEAR " + dmy.Year + "\nABOUT THE AMOUNT OF SOLD FOOD";
                    break;
                case 4:
                    crtStaticDay.DataSource = ed;
                    lblChart.Text = "CHART FROM DAY " + dmy.Day + "-" + dmy.Month + "-" + dmy.Year +
                                    " TO DAY " + dmyEnd.Day + "-" + dmyEnd.Month + "-" + dmyEnd.Year +
                                    "\nABOUT THE AMOUNT OF SOLD FOOD";
                    break;
                case 5:
                    crtStaticDay.DataSource = all;
                    lblChart.Text = "CHART OF WHOLE TIME \nABOUT THE AMOUNT OF SOLD FOOD";
                    break;
            }
            crtStaticDay.Series["Food"].XValueMember = "name";
            crtStaticDay.Series["Food"].YValueMembers = "ts";
            crtStaticDay.Series["Food"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
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
        public void cbCTG_load()
        {
            var k = (from c in db.categories
                     select c.categoryName
         ).ToList();
            cbCTG.DataSource = k;
        }
        private void cbUser_Click(object sender, EventArgs e)
        {
            combobox_load();
        }
        #endregion

    }
}
