using CitiZone.CitizoneDAOimpl;
using CitiZone.ICitizoneDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneServices
{
    class FoodServices
    {
        IFood foodDAO = new FoodImpl();
        //thêm món mới
        public void addFood(food food)
        {
            foodDAO.addFood(food);

        }
        //xoá món 
        public void deleteFood(food food)
        {
            foodDAO.deleteFood(food);
        }
        //cập nhật món 
        public void updateFood(food food)
        {
            foodDAO.updateFood(food);
        }
    }
}
