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

        public bool CheckFlight(string id, int reg)
        {
            DateTime date = DateTime.Now;
            DateTime dateTime = date.AddHours((double)reg);
            flight flight = db.flights.FirstOrDefault(s => s.flight_id == id && s.departure_day >= dateTime);
            if (flight != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public dynamic GetFlightStatus(string departureAirport, string arrivalAirport, DateTime departureDay, int reg)
        {
            DateTime date = DateTime.Now;
            DateTime dateTime = date.AddHours((double)reg);
            dynamic ds = (from flight in db.flights
                          join airplane in db.airplanes on flight.airplane_id equals airplane.airplane_id
                          join airline in db.airlines on airplane.airline_id equals airline.airline_id
                          join airplanetype in db.airplane_type on airplane.airplane_type equals airplanetype.id
                          join schedule in db.schedules on flight.schedule_id equals schedule.schedule_id
                          where schedule.departure_airport == departureAirport
                          where schedule.arrival_airport == arrivalAirport
                          where flight.departure_day.Day == departureDay.Day
                          where flight.departure_day.Month == departureDay.Month
                          where flight.departure_day.Year == departureDay.Year
                          where flight.departure_day >= dateTime
                          select new
                          {
                              flightID = flight.flight_id,
                              airplaneID = flight.airplane_id,
                              flightTime = flight.flight_time,
                              departureDay = flight.departure_day,
                              arrivalDay = flight.arrival_day,
                              airplaneType = airplanetype.name,
                              airlineName = airline.airline_name,
                              departureAirport = schedule.departure_airport,
                              arrivalAirport = schedule.arrival_airport
                          }).ToList();
            return ds;
        }

        public dynamic GetFlightStatusByFlightID(string flightID)
        {
            dynamic ds = (from flight in db.flights
                          join airplane in db.airplanes on flight.airplane_id equals airplane.airplane_id
                          join airline in db.airlines on airplane.airline_id equals airline.airline_id
                          join airplanetype in db.airplane_type on airplane.airplane_type equals airplanetype.id
                          join schedule in db.schedules on flight.schedule_id equals schedule.schedule_id
                          where flight.flight_id == flightID
                          select new
                          {
                              flightID = flight.flight_id,
                              airplaneID = flight.airplane_id,
                              flightTime = flight.flight_time,
                              departureDay = flight.departure_day,
                              arrivalDay = flight.arrival_day,
                              airplaneType = airplanetype.name,
                              airlineName = airline.airline_name,
                              departureAirport = schedule.departure_airport,
                              arrivalAirport = schedule.arrival_airport
                          }).FirstOrDefault();
            return ds;
        }
    }
}
