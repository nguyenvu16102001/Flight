using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Airport
    {
        Flight_ManagerEntities db;
        public DAO_Airport()
        {
            db = new Flight_ManagerEntities();
        }

        public dynamic ListAirport()
        {
            dynamic ds = db.airports.Select(s => new
            {
                s.airport_id,
                s.airport_name,
                s.location
            }).ToList();
            return ds;
        }
    }
}
