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
    class BUS_Ticket
    {
        DAO_Ticket dAO_Ticket;
        DAO_Bill dAO_Bill;
        public BUS_Ticket()
        {
            dAO_Ticket = new DAO_Ticket();
            dAO_Bill = new DAO_Bill();
        }

        public bool AddTicket(bill bill, string flightID, int customerID, int ticketType, List<int> selectedSeats)
        {
            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    dAO_Bill.AddBill(bill);
                    foreach(int s in selectedSeats)
                    {
                        ticket ticket = new ticket();
                        ticket.flight_id = flightID;
                        ticket.customer_id = customerID;
                        ticket.bill_id = bill.bill_id;
                        ticket.booking_date = DateTime.Now;
                        ticket.ticket_type = ticketType;
                        ticket.seat_id = s;
                        dAO_Ticket.AddTicket(ticket);
                    }
                    trans.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
            }
        }
    }
}
