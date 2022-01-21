using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public int GetScheduleID(string departureAirport, string arrivalAirport)
        {
            List<schedule> s = dAO_Schedule.getscheduleid(departureAirport, arrivalAirport);
            return s[0].schedule_id;
        }
        public void ListSchedule(DataGridView dg)
        {
            dg.DataSource = dAO_Schedule.ListSchedule();
        }
        public int Add_Schedule(schedule schedule)
        {
            if (dAO_Schedule.CheckSchedule(schedule.schedule_id))
            {
                return 0;
            }
            else
            {
                try
                {
                    dAO_Schedule.Add_Schedule(schedule);
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
        public int Delete_Schedule(int schedule_id)
        {
            try
            {
                if (dAO_Schedule.CheckSchedule(schedule_id))
                {
                    dAO_Schedule.Delete_Schedule(schedule_id);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int Update_Schedule(schedule schedule)
        {
            if (dAO_Schedule.CheckSchedule(schedule.schedule_id))
            {
                try
                {
                    dAO_Schedule.Update_Schedule(schedule);
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
