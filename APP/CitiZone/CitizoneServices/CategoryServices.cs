using CitiZone.CitizoneDAOimpl;
using CitiZone.ICitizoneDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneServices
{
    class CategoryServices
    {
        ICategory categoryDAO = new CategoryImpl();
        //thêm danh mục
        public void addCategory(category category)
        {
            categoryDAO.addCategory(category);
        }
        //xoá danh mục
        public void deleteCategory(category category)
        {
            categoryDAO.deleteCategory(category);
        }
        //cập nhật danh mục
        public void updateCategory(category category)
        {
            categoryDAO.updateCategory(category);
        }
        //lấy danh sách category
        public List<category> getAllCategory()
        {
            return categoryDAO.getAllCategory();
        }
    }
}
