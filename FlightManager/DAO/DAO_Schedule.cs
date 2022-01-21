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
        public List<schedule> getscheduleid(string departureairport, string arrivalairport)
        {
            return db.schedules.Where(s => s.departure_airport == departureairport && s.arrival_airport == arrivalairport).Select(s => s).ToList();
        }
        public schedule GetSchedule(int schedule_id)
        {
            schedule schedule = db.schedules.FirstOrDefault(s => s.schedule_id == schedule_id);
            return schedule;
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
        public void Add_Schedule(schedule schedule)
        {
            db.schedules.Add(schedule);
            db.SaveChanges();
        }
        public void Delete_Schedule(int schedule_id )
        {
            schedule schedule = db.schedules.Find(schedule_id);
            db.schedules.Remove(schedule);
            db.SaveChanges();
        }
        public void Update_Schedule(schedule schedule)
        {
            schedule s = db.schedules.Find(schedule.schedule_id);
            s.schedule_id = schedule.schedule_id;
            s.departure_airport = schedule.departure_airport;
            s.arrival_airport = schedule.arrival_airport;

            db.SaveChanges();
        }
        public dynamic ListSchedule()
        {
            var ds = db.schedules.Select(s => new
            {
                s.schedule_id,
                s.departure_airport,
                s.arrival_airport,
            }).ToList();
            return ds;
        }
    }
}
