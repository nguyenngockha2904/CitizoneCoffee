using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.ICitizoneDAO
{
    interface IFood
    {
        void addFood(food food);
        void deleteFood(food food);
        void updateFood(food food);

    }
}
