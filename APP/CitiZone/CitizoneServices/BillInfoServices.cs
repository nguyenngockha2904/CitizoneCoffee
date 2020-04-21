using CitiZone.CitizoneDAOimpl;
using CitiZone.ICitizoneDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneServices
{
    class BillInfoServices
    {
        IBillinfo billinfoDAO = new BillinfoImpl();
       //thêm 1 billinfo 
        public void addBillinfo(billInfo billInfo)
        {
            billinfoDAO.addBillinfo(billInfo);
        }
    }
}
