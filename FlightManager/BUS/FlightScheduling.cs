using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using FlightManager.DAO;

namespace FlightManager.BUS
{
    class FlightScheduling
    {
        DAO_Flight dAO_Flight;
        DAO_Transit_Airport dAO_Transit_Airport;
        DAO_Seat_Class dAO_Seat_Class;
        DAO_Schedule dAO_Schedule;
        public FlightScheduling()
        {
            dAO_Flight = new DAO_Flight();
            dAO_Transit_Airport = new DAO_Transit_Airport();
            dAO_Seat_Class = new DAO_Seat_Class();
            dAO_Schedule = new DAO_Schedule();
        }
        public int AddFlightScheduling(string flightID, string airplaneID, string departureAirport, string arrivalAirport, DateTime departureDay, int flightTime, int businessClass, int economyClass, List<String> transitAirport, List<DateTime> arrivalDay, List<int> timmingStop, List<String> note)
        {
            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    if (!dAO_Flight.CheckFlight(flightID))
                    {
                        BUS_Schedule bUS_Schedule = new BUS_Schedule();
                        int schedule_id = 0;
                        try
                        {
                            schedule_id = bUS_Schedule.GetScheduleID(departureAirport, arrivalAirport);
                        }
                        catch (Exception)
                        {
                            return 2;
                        }
                        flight f = new flight();
                        f.flight_id = flightID;
                        f.airplane_id = airplaneID;
                        f.schedule_id = schedule_id;
                        f.flight_time = flightTime;
                        f.departure_day = departureDay;
                        f.arrival_day = departureDay.AddMinutes(flightTime);
                        f.number_of_empty_seats = businessClass + economyClass;
                        dAO_Flight.Add_Flight(f);
                        seat_class seat_Class1 = new seat_class();
                        seat_Class1.flight_id = flightID;
                        seat_Class1.seat_type = 1;
                        seat_Class1.seat_number = businessClass;
                        seat_class seat_Class2 = new seat_class();
                        seat_Class2.flight_id = flightID;
                        seat_Class2.seat_type = 2;
                        seat_Class2.seat_number = economyClass;
                        dAO_Seat_Class.AddSeatClass(seat_Class1);
                        dAO_Seat_Class.AddSeatClass(seat_Class2);
                        if (transitAirport.Count > 0)
                        {
                            for (int i = 0; i < transitAirport.Count; i++)
                            {
                                transit_airport transit_Airport = new transit_airport();
                                transit_Airport.transit_airport_id = transitAirport[i];
                                transit_Airport.flight_id = flightID;
                                transit_Airport.timing_point = timmingStop[i];
                                transit_Airport.arrival_day = arrivalDay[i];
                                transit_Airport.note = note[i];
                                dAO_Transit_Airport.AddTransitAirport(transit_Airport);
                            }
                        }
                        trans.Complete();
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return -1;
                } 
            }
        }
    }
}
