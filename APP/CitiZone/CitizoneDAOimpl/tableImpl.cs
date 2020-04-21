using CitiZone.ICitizoneDAO;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneDAOimpl
{
    class TableImpl :ITable
    {
        private CitiZoneDataContext db;
        private List<coffeeTable> tables;
        public TableImpl()
        {
            db = new CitiZoneDataContext();
            using (db)
            {
                var tbl = from x in db.coffeeTables select x;
                tables = tbl.ToList();
            }
        }
        //cập nhật bàn
        public void updateTable(coffeeTable table)
        {
            db = new CitiZoneDataContext();
            coffeeTable tab = new coffeeTable();
            tab = table;
            tab = db.coffeeTables.Single(x => x.tableID == table.tableID);
            setUpdateTable(tab, table);
            db.SubmitChanges();

        }
        //lấy bàn theo id
        public coffeeTable getTableByID(int id)
        {
            coffeeTable table = new coffeeTable();
            tables.ForEach(tbl =>{
                if (tbl.tableID == id)
                {
                    table = tbl;
                }
            });
            return table;
        }
        //lấy tất cả bàn
        public List<coffeeTable> getAllTable()
        {
            return tables;
        }
        public void setUpdateTable(coffeeTable tbDB,coffeeTable tbUpdate)
        {
            tbDB.status = tbUpdate.status;
        }
    }
}
