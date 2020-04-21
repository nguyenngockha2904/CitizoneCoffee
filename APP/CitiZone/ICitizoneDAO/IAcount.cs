using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiZone.ICitizoneDAO
{
    interface IAcount
    {
        void addAccount(account account);
        void deleteAccount(account account);
        void updateAccount(account account);
        account getAccountByUsername(string username);
        List<account> getAllAcount();
    }

}
