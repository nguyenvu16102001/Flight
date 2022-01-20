using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_User
    {
        Flight_ManagerEntities db;
        public DAO_User()
        {
            db = new Flight_ManagerEntities();
        }

        public user GetUserByIdentityCard(string identityCard)
        {
            return db.users.FirstOrDefault(s => s.identity_card == identityCard);
        }

        public void AddUser(user u)
        {
            db.users.Add(u);
            db.SaveChanges();
        }
    }
}
