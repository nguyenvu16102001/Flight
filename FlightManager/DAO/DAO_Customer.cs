using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Customer
    {
        Flight_ManagerEntities db;
        public DAO_Customer()
        {
            db = new Flight_ManagerEntities();
        }

        public bool CheckCustomer(int customerID)
        {
            customer c = db.customers.Find(customerID);

            if (c != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddCustomer(customer c)
        {
            db.customers.Add(c);
            db.SaveChanges();
        }
    }
}
