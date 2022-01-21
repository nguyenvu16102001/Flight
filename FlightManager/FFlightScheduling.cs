using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;
using FlightManager.BUS;

namespace FlightManager
{
    public partial class FFlightScheduling : Form
    {
        BUS_Airport bUS_Airport;
        BUS_Regulations bUS_Regulations;
        BUS_Airplane bUS_Airplane;
        FlightScheduling flightScheduling;
        BUS_Schedule bUS_Schedule;
        public FFlightScheduling()
        {
            InitializeComponent();
            bUS_Airport = new BUS_Airport();
            bUS_Regulations = new BUS_Regulations();
            bUS_Airplane = new BUS_Airplane();
            flightScheduling = new FlightScheduling();
            bUS_Schedule = new BUS_Schedule();
        }

        private void FFlightScheduling_Load(object sender, EventArgs e)
        {
            IDictionary<string, int> dict = bUS_Regulations.ListRegulations();
            bUS_Airport.ListAirport(cbDepartureAirport);
            bUS_Airport.ListAirport(cbArrivalAirport);
            bUS_Airport.ListAirport(cbTransitAirport1);
            bUS_Airport.ListAirport(cbTransitAirport2);
            bUS_Airplane.ListAirplane(cbAirplaneID);
            nUDFlightTime.Minimum = dict["minimum_flight_time"];
            nUDFlightTime.Maximum = 9999;
            nUDTimmingStop1.Minimum = dict["minimum_estimated_time_of_the_stop"];
            nUDTimmingStop1.Maximum = dict["maximum_estimated_time_of_the_stop"];
            nUDTimmingStop2.Minimum = dict["minimum_estimated_time_of_the_stop"];
            nUDTimmingStop2.Maximum = dict["maximum_estimated_time_of_the_stop"];
        }

        private void btFlightScheduling_Click(object sender, EventArgs e)
        {
            string flightID = null;
            string airplaneID = null;
            string departureAirport = null;
            string arrivalAirport = null;
            DateTime departureDay = DateTime.Now;
            int flightTime = 0;
            int businessClass = 0;
            int economyClass = 0;
            if(txtFlightID.Text != "" && cbAirplaneID.SelectedValue != null && cbDepartureAirport.SelectedValue != null && cbArrivalAirport.SelectedValue != null && dTPDepartureDay.Value != null)
            {
                try
                {
                    flightID = txtFlightID.Text;
                    airplaneID = cbAirplaneID.SelectedValue.ToString();
                    departureAirport = cbDepartureAirport.SelectedValue.ToString();
                    arrivalAirport = cbArrivalAirport.SelectedValue.ToString();
                    departureDay = dTPDepartureDay.Value;
                    flightTime = int.Parse(nUDFlightTime.Value.ToString());
                    businessClass = int.Parse(nUDBusinessClass.Value.ToString());
                    economyClass = int.Parse(nUDEconomyClass.Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                List<String> transitAirport = new List<String>();
                List<DateTime> arrivalDay = new List<DateTime>();
                List<int> timmingStop = new List<int>();
                List<String> note = new List<String>();
                if (cbTransitAirport1.SelectedValue != null)
                {
                    transitAirport.Add(cbTransitAirport1.SelectedValue.ToString());
                    arrivalDay.Add(dTPArrivalDay1.Value);
                    timmingStop.Add(int.Parse(nUDTimmingStop1.Value.ToString()));
                    note.Add(txtnote1.Text);
                }
                if (cbTransitAirport2.SelectedValue != null)
                    if(cbTransitAirport2.SelectedValue.ToString() != cbTransitAirport1.SelectedValue.ToString())
                        {
                            transitAirport.Add(cbTransitAirport2.SelectedValue.ToString());
                            arrivalDay.Add(dTPArrivalDay2.Value);
                            timmingStop.Add(int.Parse(nUDTimmingStop2.Value.ToString()));
                            note.Add(txtnote2.Text);
                        }
                int result = flightScheduling.AddFlightScheduling(flightID, airplaneID, departureAirport, arrivalAirport, departureDay, flightTime, businessClass, economyClass, transitAirport, arrivalDay, timmingStop, note);
                if(result == 1)
                {
                    MessageBox.Show("Thêm lịch bay thành công");
                }
                else if(result == -1)
                {
                    MessageBox.Show("Thêm lịch bay thất bại");
                }
                else if(result == 2)
                {
                    MessageBox.Show("Tuyến bay không tồn tại");
                }
                else if(result == 3)
                {
                    MessageBox.Show("Mã chuyến bay đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
        }
    }
}
