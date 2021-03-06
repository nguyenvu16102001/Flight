using FlightManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager.BUS
{
    class BUS_Flight
    {
        DAO_Flight dAO_Flight;
        public BUS_Flight()
        {
            dAO_Flight = new DAO_Flight();
        }
        public void ListFlight(DataGridView dg)
        {
            dg.DataSource = dAO_Flight.ListFlight();
        }
        public int Add_Flight(flight flight)
        {
            if (dAO_Flight.CheckFlight(flight.flight_id))
            {
                return 0;
            }
            else
            {
                try
                {
                    dAO_Flight.Add_Flight(flight);
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
        public int Delete_Flight(string flight_id)
        {
            try
            {
                if (dAO_Flight.CheckFlight(flight_id))
                {
                    dAO_Flight.Delete_Flight(flight_id);
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
        public int Update_Flight(flight flight)
        {
            if (dAO_Flight.CheckFlight(flight.flight_id))
            {
                try
                {
                    dAO_Flight.Update_Flight(flight);
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
