using CitiZone.ICitizoneDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneDAOimpl
{
    class CategoryImpl :ICategory
    {
        private CitiZoneDataContext db;
        private List<category> categories;
        //đổ dữ liệu từ database vào
        public CategoryImpl()
        {
            db = new CitiZoneDataContext();
            using (db)
            {
                var category = from ct in db.categories select ct;
                categories = category.ToList();
            }
        }
        //thêm danh mục
        public void addCategory(category category)
        {
            db = new CitiZoneDataContext();
            category ct = new category();
            ct = category;
            db.categories.InsertOnSubmit(ct);
            db.SubmitChanges();
        }
        //xoá danh mục
        public void deleteCategory(category category)
        {
            db = new CitiZoneDataContext();
            category ct = new category();
            ct = category;
            ct = db.categories.Single(x=>x.categoryID==category.categoryID);
            db.categories.DeleteOnSubmit(ct);
            db.SubmitChanges();
        }
        //cập nhật danh mục
        public void updateCategory(category category)
        {
            db = new CitiZoneDataContext();
            category ct = new category();
            ct = category;
            ct = db.categories.Single(x => x.categoryID == category.categoryID);
            setUpdateCategory(ct, category);
            db.SubmitChanges();
        }
        //lấy danh sách category
        public List<category> getAllCategory()
        {
            return categories;
        }

        //ánh xạ update qa linq
        public void setUpdateCategory(category ctDB,category ctUpdate)
        {
            ctDB.categoryName = ctUpdate.categoryName;
        }
    }
}
