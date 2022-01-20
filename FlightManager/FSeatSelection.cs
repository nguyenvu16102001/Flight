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
    public partial class FSeatSelection : Form
    {
        public static string flightID;
        public static int ticketType;
        BUS_Flight bUS_Flight;
        BUS_TicketType bUS_TicketType;
        BUS_TicketPrice bUS_TicketPrice;
        BUS_Seat bUS_Seat;
        public static List<int> selectedSeats;
        public FSeatSelection()
        {
            InitializeComponent();
            bUS_Flight = new BUS_Flight();
            bUS_TicketType = new BUS_TicketType();
            bUS_TicketPrice = new BUS_TicketPrice();
            bUS_Seat = new BUS_Seat();
            selectedSeats = new List<int>();
        }

        private void FSeatSelection_Load(object sender, EventArgs e)
        {
            bUS_TicketType.ListTicketType(cbTicketType);
            bUS_Flight.GetFlightStatusByFlightID(flightID, lbFlight, lbDepartureAirport, lbDepartureDay, lbArrivalAirport, lbArrivalDay, lbFlightTime, lbAirplane, lbAirline);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Yellow;
            int seat_id = int.Parse(btn.Name.Substring(2));
            if (selectedSeats.Contains(seat_id))
            {
                btn.BackColor = Color.Green;
                selectedSeats.Remove(seat_id);
            }
            else
            {
                selectedSeats.Add(seat_id);
            }
        }

        private void cbTicketType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            ticketType = int.Parse(cb.SelectedValue.ToString());
            bUS_TicketPrice.GetListTicketPrice(lbSeatClass, lbFare, flightID, ticketType);
            pnSeat.Controls.Clear();
            dynamic seats = bUS_Seat.GetListSeat(flightID, ticketType);
            int p = 20;
            int i = 1;
            int j = 0;
            int t = 1;
            string temp = seats[0].seat_name;
            temp = temp.Substring(0, 1);
            if (temp == "B")
            {
                t = 2;
            }
            else if (temp == "C")
            {
                t = 3;
            }
            else if (temp == "D")
            {
                t = 4;
            }
            else if (temp == "E")
            {
                t = 5;
            }
            else if (temp == "G")
            {
                t = 6;
            }
            foreach (var s in seats)
            {
                if (i == 1 && j == 0 && t > 0)
                {
                    i = t;
                    j++;
                }
                Button bt = new Button();
                if (i % 6 == 1)
                {
                    if (i > 6)
                    {
                        i = 1;
                    }
                    bt.Location = new Point(i * p, ((j) * 50 + ((j) * p)));
                    j++;
                }
                else
                {
                    bt.Location = new Point(((i - 1) * 75 + (i * p)), ((j - 1) * 50 + ((j - 1) * p)));
                }
                if(s.active == 1)
                {
                    bt.BackColor = Color.Green;
                    bt.Click += (sen, EventArgs) => { btn_Click(sen, EventArgs); };
                }
                bt.Size = new Size(75, 50);
                bt.Name = "bt" + s.seat_id.ToString();
                bt.Text = s.seat_name;
                pnSeat.Controls.Add(bt);
                i++;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            FPassengers fPassengers = new FPassengers();
            fPassengers.ShowDialog();
            this.Show();
        }
    }
}
