using CitiZone.CitizoneDAOimpl;
using CitiZone.ICitizoneDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneServices
{
    class BillServices
    {
        IBill billDAO = new BillImpl();
        //thêm bill
        public void addBill(bill bill)
        {
            billDAO.addBill(bill);
        }
        //xoá bill
        public void deleteBill(bill bill)
        {
            billDAO.deleteBill(bill);
        }
        //lấy tất cả bill
        public List<bill> getAllBill()
        {
            return billDAO.getAllBill();
        }
    }
}

