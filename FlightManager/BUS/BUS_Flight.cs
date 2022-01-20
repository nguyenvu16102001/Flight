using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManager.DAO;
using System.Windows.Forms;

namespace FlightManager.BUS
{
    class BUS_Flight
    {
        DAO_Flight dAO_Flight;
        DAO_Regulations dAO_Regulations;
        public BUS_Flight()
        {
            dAO_Flight = new DAO_Flight();
            dAO_Regulations = new DAO_Regulations();
        }
        public bool GetFlightStatus(DataGridView dg, string departureAirport, string arrivalAirport, DateTime departureDay)
        {
            try
            {
                regulation r = dAO_Regulations.ListRegulations();
                dg.DataSource = dAO_Flight.GetFlightStatus(departureAirport, arrivalAirport, departureDay, r.ticket_sales_time.Value);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public void GetFlightStatusByFlightID(string flightID, Label lbFlight, Label lbDepartureAirport, Label lbDepartureDay, Label lbArrivalAirport, Label lbArrivalDay, Label lbFlightTime, Label lbAirplane, Label lbAirline)
        {
            try
            {
                dynamic flightStatus = dAO_Flight.GetFlightStatusByFlightID(flightID);
                DAO_Airport dAO_Airport = new DAO_Airport();
                dynamic airports = dAO_Airport.ListAirport();
                lbFlight.Text = flightStatus.flightID;
                foreach(var a in airports)
                {
                    if(a.airport_id == flightStatus.departureAirport)
                    {
                        lbDepartureAirport.Text = a.location;
                    }
                }
                lbDepartureDay.Text = flightStatus.departureDay.ToString("dd/MM/yyyy hh:mm:ss");
                foreach (var a in airports)
                {
                    if (a.airport_id == flightStatus.arrivalAirport)
                    {
                        lbArrivalAirport.Text = a.location;
                    }
                }
                lbArrivalDay.Text = flightStatus.arrivalDay.ToString("dd/MM/yyyy hh:mm:ss");
                int flightTime = flightStatus.flightTime;
                lbFlightTime.Text = (Math.Round(flightTime * 1.0 / 60)).ToString() + " tiếng " + (flightTime % 60).ToString() + " phút";
                lbAirplane.Text = flightStatus.airplaneType;
                lbAirline.Text = flightStatus.airlineName;
            }
            catch (Exception)
            {
            }
        }

        public int CheckFlight(string flightID)
        {
            regulation r = dAO_Regulations.ListRegulations();
            try
            {
                if (dAO_Flight.CheckFlight(flightID))
                {
                    if (dAO_Flight.CheckFlight(flightID, r.ticket_sales_time.Value))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
