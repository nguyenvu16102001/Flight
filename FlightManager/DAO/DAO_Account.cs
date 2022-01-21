using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Account
    {
        Flight_ManagerEntities db;

        public DAO_Account()
        {
            db = new Flight_ManagerEntities();
        }
        public account GetAccounts(int account_id)
        {
            account acc = db.accounts.FirstOrDefault(s => s.account_id == account_id);
            return acc;

        }
        public void Add_Account(account account)
        {
            db.accounts.Add(account);
            db.SaveChanges();
        }
        public void Delete_Account(int account_id)
        {
            account acc = db.accounts.Find(account_id);
            db.accounts.Remove(acc);
            db.SaveChanges();
        }
        public void Update_Account(account account)
        {
            account acc = db.accounts.Find(account.account_id);
            acc.account_id = account.account_id;
            acc.user_id = account.user_id;
            acc.username = account.username;
            acc.password = account.password;
            acc.active = account.active;
            acc.join_date = account.join_date;
            acc.user_role = account.user_role;

            db.SaveChanges();
        }
        public bool CheckAccount(int id)
        {
            account acc = db.accounts.Find(id);
            if (acc != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public dynamic ListAccount()
        {
            var ds = db.accounts.Select(s => new
            {
                s.account_id,
                s.user_id,
                s.username,
                s.password,
                s.active,
                s.join_date,
                s.user_role
            }).ToList();
            return ds;
        }
    }
}
