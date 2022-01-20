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
    public partial class FTicketSales : Form
    {
        string flightID;
        BUS_Flight bUS_Flight;
        public FTicketSales()
        {
            InitializeComponent();
            bUS_Flight = new BUS_Flight();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            flightID = txtFlightID.Text;
            if (bUS_Flight.CheckFlight(flightID) == 1)
            {
                FSeatSelection fSeatSelection = new FSeatSelection();
                FSeatSelection.flightID = flightID;
                fSeatSelection.ShowDialog(); 
            }
            else if(bUS_Flight.CheckFlight(flightID) == 0)
            {
                MessageBox.Show("Chuyến bay không đúng thời gian quy định");
            }
            else
            {
                MessageBox.Show("Chuyến bay không tồn tại");
            }
        }
    }
}
