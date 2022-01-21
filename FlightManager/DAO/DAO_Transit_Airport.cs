using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Transit_Airport
    {
        Flight_ManagerEntities db;
        public DAO_Transit_Airport()
        {
            db = new Flight_ManagerEntities();
        }
        public void AddTransitAirport(transit_airport airport)
        {
            db.transit_airport.Add(airport);
            db.SaveChanges();
        }
    }
}
