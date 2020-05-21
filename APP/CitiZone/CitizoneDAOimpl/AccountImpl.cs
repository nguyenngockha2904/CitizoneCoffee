using CitiZone.ICitizoneDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.CitizoneDAOimpl
{
    class AccountImpl : IAcount
    {
        private CitiZoneDataContext db;
        private List<account> accounts;
        //lấy database từ csdl
        public AccountImpl()
        {
            db = new CitiZoneDataContext();
            using (db)
            {
                var account = from ac in db.accounts select ac;
                accounts = account.ToList();

            }
        }
        //thêm một nhân viên mới
        public void addAccount(account account)
        {
            db = new CitiZoneDataContext();
            account acc = new account();
            acc = account;
            db.accounts.InsertOnSubmit(acc);
            db.SubmitChanges();
        }
        //xoá nhân viên
        public void deleteAccount(account account)
        {
            db = new CitiZoneDataContext();
            account acc = new account();
            acc = account;
            acc = db.accounts.Single(x => x.username == account.username);
            db.accounts.DeleteOnSubmit(acc);
            db.SubmitChanges();
        }
        //cập nhật thông tin của nhân viên
        public void updateAccount(account account)
        {
            db = new CitiZoneDataContext();
            account acc = new account();
            acc = account;
            acc = db.accounts.Single(x => x.username == account.username);
            setAccountUpdate(acc, account);
            /*acc = db.accounts.Where(ac => ac.username == account.username).Single();
            acc.password = account.password;
            acc.fullname = account.fullname;
            acc.birthday = account.birthday;
            acc.address = account.address;
            acc.phone = account.phone;
            acc.pictureLocation = account.pictureLocation;
                */        
            db.SubmitChanges();
        }
        //lấy tài khoản thông qa username
        public account getAccountByUsername(string username)
        {
            account account = new account();
            accounts.ForEach(acc =>
            {
                if (acc.username == username)
                {
                    account = acc;
                }

            });
            return account;
        }
        //lấy danh sách tài khoản
        public List<account> getAllAcount()
        {
            return accounts;
        }

        // ánh xạ account update qua account tren CitizoneLinq để update
        public void setAccountUpdate(account accDB, account accUpdate)
        {
            if (accUpdate.password != null) { accDB.password = accUpdate.password; }
            if (accUpdate.fullname != null) { accDB.fullname = accUpdate.fullname; }
            if (accUpdate.birthday != null) { accDB.birthday = accUpdate.birthday; ;}
            if (accUpdate.address != null) { accDB.address = accUpdate.address; }
            if (accUpdate.phone != 0) { accDB.phone = accUpdate.phone; }
            if (accUpdate.password != null) { accDB.pictureLocation = accUpdate.pictureLocation; }

           /* accDB.fullname = accUpdate.fullname;
            accDB.birthday = accUpdate.birthday;
            accDB.address = accUpdate.address;
            accDB.phone = accUpdate.phone;
            accDB.pictureLocation = accUpdate.pictureLocation;
            */
        }
    }
}
