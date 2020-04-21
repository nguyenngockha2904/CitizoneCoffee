using CitiZone.ICitizoneDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneDAOimpl
{
    class FoodImpl :IFood
    {
        private CitiZoneDataContext db;
        private List<food> foods;
        //lấy dữ liệu từ database
        public FoodImpl()
        {
            db = new CitiZoneDataContext();
            using (db)
            {
                var fd = from x in db.foods select x;
                foods = fd.ToList();
            }
        }
        //thêm món mới
        public void addFood(food food)
        {
            db = new CitiZoneDataContext();
            food fd = new food();
            fd = food;
            db.foods.InsertOnSubmit(fd);
            db.SubmitChanges();
        }
        //xoá món 
        public void deleteFood(food food)
        {
            db = new CitiZoneDataContext();
            food fd = new food();
            fd = food;
            fd = db.foods.Single(x => x.foodID == food.foodID);
            db.foods.DeleteOnSubmit(fd);
            db.SubmitChanges();

        }
        //cập nhật món 
        public void updateFood(food food)
        {
            db = new CitiZoneDataContext();
            food fd = new food();
            fd = food;
            fd = db.foods.Single(x => x.foodID == food.foodID);
            setUpdateFood(fd,food);
            db.SubmitChanges();
        }

        public void setUpdateFood(food fdDB,food fdUpdate)
        {
            fdDB.foodName = fdUpdate.foodName;
            fdDB.price = fdUpdate.price;
        }
    }
}
