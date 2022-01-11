using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Airplane
    {
        Flight_ManagerEntities db;
        public DAO_Airplane()
        {
            db = new Flight_ManagerEntities();
        }

        public dynamic ListAirplane()
        {
            return db.airplanes.Select(s => new
            {
                s.airplane_id,
                s.airline.airline_name,
                s.airplane_type1.name
            }).ToList();
        }
    }
}
