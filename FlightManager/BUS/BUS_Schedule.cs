using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManager.DAO;

namespace FlightManager.BUS
{
    class BUS_Schedule
    {
        DAO_Schedule dAO_Schedule;
        public BUS_Schedule()
        {
            dAO_Schedule = new DAO_Schedule();
        }

        public int GetScheduleID(string departureAirport,string arrivalAirport)
        {
            List<schedule> s = dAO_Schedule.GetScheduleID(departureAirport, arrivalAirport);
            return s[0].schedule_id;
        }
    }
}
