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
        public seat_class GetSeat(string flight_id, int seat_type)
        {
            seat_class seat = db.seat_class.FirstOrDefault(s => s.flight_id == flight_id && s.seat_type==seat_type);
            return seat;

        }
        public void AddSeatClass(seat_class seat)
        {
            db.seat_class.Add(seat);
            db.SaveChanges();
        }
        public void Delete_Seat(string flight_id, int seat_type)
        {
            seat_class seat = db.seat_class.FirstOrDefault(s => s.flight_id == flight_id && s.seat_type == seat_type);
            db.seat_class.Remove(seat);
            db.SaveChanges();
        }
        public void Update_Seat(seat_class seat)
        {
            seat_class sc = db.seat_class.FirstOrDefault(s => s.flight_id == seat.flight_id && s.seat_type == seat.seat_type);
            sc.flight_id = seat.flight_id;
            sc.seat_type = seat.seat_type;
            sc.seat_number = seat.seat_number;

            db.SaveChanges();
        }
        public bool CheckSeat(string flight_id, int seat_type)
        {
            seat_class seat = db.seat_class.FirstOrDefault(s => s.flight_id == flight_id && s.seat_type == seat_type);
            if (seat != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public dynamic ListSeat()
        {
            var ds = db.seat_class.Select(s => new
            {
                s.flight_id,
                s.seat_type,
                s.seat_number
            }).ToList();
            return ds;
        }
    }
}
