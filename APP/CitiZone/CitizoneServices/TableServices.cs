using CitiZone.CitizoneDAOimpl;
using CitiZone.ICitizoneDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneServices
{
    class TableServices
    {
        ITable tableDAO = new TableImpl();
        //cập nhật phòng
        public void updateTable(coffeeTable table)
        {
            tableDAO.updateTable(table);
        }
        //lấy bàn theo id
        public coffeeTable getTableByID(int id)
        {
            return tableDAO.getTableByID(id);
        }
        //lấy tất cả bàn
        public List<coffeeTable> getAllTable()
        {
            return tableDAO.getAllTable();
        }
    }
}