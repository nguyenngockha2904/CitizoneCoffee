using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.ICitizoneDAO
{
    interface IBill
    {
        void addBill(bill bill);
        void deleteBill(bill bill);
        List<bill> getAllBill();
    }
}
