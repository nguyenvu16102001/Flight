using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Flight
    {
        Flight_ManagerEntities db;

        public DAO_Flight()
        {
            db = new Flight_ManagerEntities();
        }

        public void Add_Flight(flight flight)
        {
            db.flights.Add(flight);
            db.SaveChanges();
        }

        public bool CheckFlight(string id)
        {
            flight flight = db.flights.Find(id);
            if (flight != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
