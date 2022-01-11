using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Schedule
    {
        Flight_ManagerEntities db;
        public DAO_Schedule()
        {
            db = new Flight_ManagerEntities();
        }
        public List<schedule> GetScheduleID(string departureAirport, string arrivalAirport)
        {
            return db.schedules.Where(s => s.departure_airport == departureAirport && s.arrival_airport == arrivalAirport).Select(s => s).ToList();
        }
        public bool CheckSchedule(int id)
        {
            schedule schedule = db.schedules.Find(id);
            if (schedule != null)
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
