using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Seat
    {
        Flight_ManagerEntities db;
        public DAO_Seat()
        {
            db = new Flight_ManagerEntities();
        }

        public dynamic GetListSeat(string flightID, int seatType)
        {
            flight f = db.flights.Find(flightID);
            return db.seats.Where(s => s.airplane_id == f.airplane_id && s.seat_type == seatType).Select(s => new
            {
                s.seat_id,
                s.seat_name,
                s.active
            }).ToList();
        }

        public seat GetSeat(int seatID)
        {
            return db.seats.FirstOrDefault(s => s.seat_id == seatID);
        }
    }
}
