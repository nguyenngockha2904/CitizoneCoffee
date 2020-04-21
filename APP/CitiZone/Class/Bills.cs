using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.Class
{
    class Bills
    {
        public Bills()
        {

        }

        CitiZoneDataContext bills = new CitiZoneDataContext();

        private int billID;
        private string username;
        private string billName;
        private int total;

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string BillName
        {
            get { return billName; }
            set { billName = value; }
        }

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
