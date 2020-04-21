using CitiZone.ICitizoneDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneDAOimpl
{
    class BillinfoImpl :IBillinfo
    {
        private CitiZoneDataContext db;
        public BillinfoImpl()
        {

        }
        //thêm 1 billinfo 
        public void addBillinfo(billInfo billInfo)
        {
            db = new CitiZoneDataContext();
            billInfo bifo = new billInfo();
            bifo = billInfo;
            db.billInfos.InsertOnSubmit(bifo);
            db.SubmitChanges();
        }
    }
}
