using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Regulations
    {
        Flight_ManagerEntities db;
        public DAO_Regulations()
        {
            db = new Flight_ManagerEntities();
        }
        public regulation ListRegulations()
        {
            return db.regulations.FirstOrDefault();
        }
        public regulation GetRegulation(int regulation_id)
        {
            regulation regulation = db.regulations.FirstOrDefault(s => s.regulations_id == regulation_id);
            return regulation;

        }
        public void Add_Regulation(regulation regulation)
        {
            db.regulations.Add(regulation);
            db.SaveChanges();
        }
        public void Delete_Regulation(int regulation_id)
        {
            regulation regulation = db.regulations.Find(regulation_id);
            db.regulations.Remove(regulation);
            db.SaveChanges();
        }
        public void Update_Regulation(regulation regulation)
        {
            regulation r = db.regulations.Find(regulation.regulations_id);
            r.regulations_id = regulation.regulations_id;
            r.number_of_airports = regulation.number_of_airports;
            r.minimum_flight_time = regulation.minimum_flight_time;
            r.maximum_number_of_intermediate_airports = regulation.maximum_number_of_intermediate_airports;
            r.minimum_estimated_time_of_the_stop = regulation.minimum_estimated_time_of_the_stop;
            r.maximum_estimated_time_of_the_stop = regulation.maximum_estimated_time_of_the_stop;
            r.ticket_sales_time = regulation.ticket_sales_time;
            r.ticket_booking_time = regulation.ticket_booking_time;

            db.SaveChanges();
        }
        public bool CheckRegulation(int id)
        {
            regulation r = db.regulations.Find(id);
            if (r != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public dynamic ListRegulation()
        {
            var ds = db.regulations.Select(s => new
            {
                s.regulations_id,
                s.number_of_airports,
                s.minimum_flight_time,
                s.maximum_number_of_intermediate_airports,
                s.minimum_estimated_time_of_the_stop,
                s.maximum_estimated_time_of_the_stop,
                s.ticket_sales_time,
                s.ticket_booking_time
            }).ToList();
            return ds;
        }
    }
}
