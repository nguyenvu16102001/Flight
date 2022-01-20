using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Bill
    {
        Flight_ManagerEntities db;
        public DAO_Bill()
        {
            db = new Flight_ManagerEntities();
        }

        public bool CheckBill(string billID)
        {
            bill b = db.bills.Find(billID);
            if(b != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddBill(bill bill)
        {
            db.bills.Add(bill);
            db.SaveChanges();
        }
    }
}
