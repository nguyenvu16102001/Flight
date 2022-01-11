using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Seat_Class
    {
        Flight_ManagerEntities db;
        public DAO_Seat_Class()
        {
            db = new Flight_ManagerEntities();
        }

        public void AddSeatClass(seat_class seat)
        {
            db.seat_class.Add(seat);
            db.SaveChanges();
        }
    }
}
