using CitiZone.ICitizoneDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneDAOimpl
{
    class BillImpl : IBill
    {
        private CitiZoneDataContext db;
        private List<bill> bills;
        //lấy dữ liệu từ database
        public BillImpl()
        {
            db = new CitiZoneDataContext();
            using (db)
            {
                var bl = from x in db.bills select x;
                bills = bl.ToList();
            }
        }
        //thêm bill
        public void addBill(bill bill)
        {
            db = new CitiZoneDataContext();
            bill bl = new bill();
            bl = bill;
            db.bills.InsertOnSubmit(bl);
            db.SubmitChanges();
        }
        //xoá bill
        public void deleteBill(bill bill)
        {
            db = new CitiZoneDataContext();
            bill bl = new bill();
            bl = bill;
            bl = db.bills.Single(x => x.billID == bill.billID);
            db.bills.DeleteOnSubmit(bl);
            db.SubmitChanges();
        }
        //lấy tất cả bill
        public List<bill> getAllBill()
        {
            return bills;
        }
    }
}
