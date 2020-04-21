using CitiZone.CitizoneDAOimpl;
using CitiZone.ICitizoneDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneServices
{
    class AccountServices
    {
        IAcount AccountDAO = new AccountImpl();

        //thêm 1 tài khoản
        public void addAcount(account account)
        {
            AccountDAO.addAccount(account);
        }
        //xoá một tài khoản 
        public void deleteAccount(account account)
        {
            AccountDAO.deleteAccount(account);
        }
        //cập nhật thông tin tài khoản
        public void updateAccount(account account)
        {
            AccountDAO.updateAccount(account);
        }
        //lấy tài khoản theo username
        public account getAccountByUsername(string username)
        {
            return AccountDAO.getAccountByUsername(username);
        }
        //lấy tất cả tài khoản
        public List<account> getAllAcount()
        {
            return AccountDAO.getAllAcount();
        }
    }
}
