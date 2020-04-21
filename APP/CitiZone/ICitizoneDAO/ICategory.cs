using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.ICitizoneDAO
{
    interface ICategory
    {
        void addCategory(category category);
        void deleteCategory(category category);
        void updateCategory(category category);
        List<category> getAllCategory();
    }
}
