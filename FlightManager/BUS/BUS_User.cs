using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManager.DAO;

namespace FlightManager.BUS
{
    class BUS_User
    {
        DAO_User dAO_User;
        public BUS_User()
        {
            dAO_User = new DAO_User();
        }

        public bool AddUser(user u)
        {
            try
            {
                dAO_User.AddUser(u);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public user Passengers(user u)
        {
            user user = dAO_User.GetUserByIdentityCard(u.identity_card);
            if(user != null)
            {
                return user;
            }
            else
            {
                dAO_User.AddUser(u);
                user result = dAO_User.GetUserByIdentityCard(u.identity_card);
                DAO_Customer dAO_Customer = new DAO_Customer();
                if (dAO_Customer.CheckCustomer(result.user_id))
                {
                    return result;
                }
                else
                {
                    customer c = new customer();
                    c.user_id = result.user_id;
                    dAO_Customer.AddCustomer(c);
                    return result;
                }
            }
        }
    }
}
