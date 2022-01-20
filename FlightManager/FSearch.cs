using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManager.BUS;

namespace FlightManager
{
    public partial class FSearch : Form
    {
        BUS_Airport bUS_Airport;
        BUS_Flight bUS_Flight;
        string departureAirport = null;
        string arrivalAirport = null;
        DateTime departureDay = DateTime.Now;
        public FSearch()
        {
            InitializeComponent();
            bUS_Airport = new BUS_Airport();
            bUS_Flight = new BUS_Flight();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            bUS_Airport.ListAirport(cbDepartureAirport);
            bUS_Airport.ListAirport(cbArrivalAirport);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if( cbArrivalAirport.SelectedValue != null && cbDepartureAirport.SelectedValue != null && dTPDepartureDay.Value != null)
            {
                departureAirport = cbDepartureAirport.SelectedValue.ToString();
                arrivalAirport = cbArrivalAirport.SelectedValue.ToString();
                departureDay = dTPDepartureDay.Value;
                if (bUS_Flight.GetFlightStatus(dGVFlight, departureAirport, arrivalAirport, departureDay))
                {
                    dGVFlight.Columns[0].Width = (int)(dGVFlight.Width * 0.1);
                    dGVFlight.Columns[1].Width = (int)(dGVFlight.Width * 0.1);
                    dGVFlight.Columns[2].Width = (int)(dGVFlight.Width * 0.1);
                    dGVFlight.Columns[3].Width = (int)(dGVFlight.Width * 0.2);
                    dGVFlight.Columns[4].Width = (int)(dGVFlight.Width * 0.2);
                    dGVFlight.Columns[5].Width = (int)(dGVFlight.Width * 0.2);
                    dGVFlight.Columns[6].Width = (int)(dGVFlight.Width * 0.2);
                    dGVFlight.Columns[7].Width = (int)(dGVFlight.Width * 0.1);
                    dGVFlight.Columns[8].Width = (int)(dGVFlight.Width * 0.1);
                }
                else
                {
                    MessageBox.Show("Tìm chuyến bay thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
        }

        private void dGVFlight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex <= dGVFlight.Rows.Count)
                {
                    FSeatSelection fSeatSelection = new FSeatSelection();
                    FSeatSelection.flightID = dGVFlight.Rows[e.RowIndex].Cells["flightID"].Value.ToString();
                    fSeatSelection.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
