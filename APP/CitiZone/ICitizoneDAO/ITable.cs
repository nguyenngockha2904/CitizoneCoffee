using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.ICitizoneDAO
{
    interface ITable
    {
        void updateTable(coffeeTable table);
        coffeeTable getTableByID(int id);
        List<coffeeTable> getAllTable();
    }
}
