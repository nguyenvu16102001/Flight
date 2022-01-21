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
        public flight GetFlights(string flight_id)
        {
            flight flights = db.flights.FirstOrDefault(s => s.flight_id == flight_id);
            return flights;
  
        }
        public void Add_Flight(flight flight)
        {
            db.flights.Add(flight);
            db.SaveChanges();
        }
        public void Delete_Flight(string flight_id)
        {
            flight flight = db.flights.Find(flight_id);
            db.flights.Remove(flight);
            db.SaveChanges();
        }
        public void Update_Flight(flight flight)
        {
            flight f = db.flights.Find(flight.flight_id);
            f.flight_id = flight.flight_id;
            f.airplane_id = flight.airplane_id;
            f.schedule_id = flight.schedule_id;
            f.flight_time = flight.flight_time;
            f.departure_day = flight.departure_day;
            f.arrival_day = flight.arrival_day;
            f.number_of_empty_seats = flight.number_of_empty_seats;

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
        public dynamic ListFlight()
        {
            var ds = db.flights.Select(s => new
            {
                s.flight_id,
                s.airplane_id,
                s.schedule_id,
                s.flight_time,
                s.departure_day,
                s.arrival_day,
                s.number_of_empty_seats
            }).ToList();
            return ds;
        }
    }
}
