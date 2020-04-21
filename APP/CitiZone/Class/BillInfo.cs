using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.Class
{
    class BillInfo : Bills
    {
        public BillInfo()
        {

        }

        private int foodID;
        private int amount;
        private int total;

        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public new int Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
