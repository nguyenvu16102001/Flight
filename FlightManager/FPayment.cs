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
    public partial class FPayment : Form
    {
        BUS_TicketPrice bUS_TicketPrice;
        BUS_Billl bUS_Billl;
        BUS_Flight bUS_Flight;
        BUS_Seat bUS_Seat;
        BUS_Ticket bUS_Ticket;
        string flightID;
        int ticketType;
        List<int> selectedSeats;
        string billID;
        user user;
        public FPayment()
        {
            InitializeComponent();
            bUS_TicketPrice = new BUS_TicketPrice();
            bUS_Billl = new BUS_Billl();
            bUS_Flight = new BUS_Flight();
            bUS_Seat = new BUS_Seat();
            bUS_Ticket = new BUS_Ticket();
            flightID = FSeatSelection.flightID;
            ticketType = FSeatSelection.ticketType;
            selectedSeats = FSeatSelection.selectedSeats;
            user = FPassengers.user;
        }

        private void FPayment_Load(object sender, EventArgs e)
        {
            billID = bUS_Billl.GetBillID();
            lbBillID.Text = billID;
            lbPassenger.Text = user.last_name + " " + user.first_name;
            lbSeats.Text = bUS_Seat.GetSeat(selectedSeats);
            bUS_TicketPrice.GetListTicketPrice(lbSeatClass, lbFare, flightID, ticketType, selectedSeats.Count());
            bUS_Flight.GetFlightStatusByFlightID(flightID, lbFlight, lbDepartureAirport, lbDepartureDay, lbArrivalAirport, lbArrivalDay, lbFlightTime, lbAirplane, lbAirline);
        }

        private void btPayment_Click(object sender, EventArgs e)
        {
            bill bill = new bill();
            bill.bill_id = billID;
            bill.employee_id = 1;
            bill.date_of_payment = DateTime.Now;
            bill.amount = Decimal.Parse(lbFare.Text);
            bill.status = 1;

            if(bUS_Ticket.AddTicket(bill, flightID, user.user_id, ticketType, selectedSeats))
            {
                MessageBox.Show("Thanh toán thành công");
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }
    }
}
