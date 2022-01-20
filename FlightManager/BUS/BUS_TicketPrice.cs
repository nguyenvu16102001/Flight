using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManager.DAO;
using System.Windows.Forms;

namespace FlightManager.BUS
{
    class BUS_TicketPrice
    {
        DAO_TicketPrice dAO_TicketPrice;
        public BUS_TicketPrice()
        {
            dAO_TicketPrice = new DAO_TicketPrice();
        }

        public void GetListTicketPrice(Label lbSeatClass, Label lbFare, string flightID, int ticketType)
        {
            try
            {
                ticket_price ticketPrice = dAO_TicketPrice.GetListTicketPrice(flightID, ticketType);
                if(ticketType == 1)
                {
                    lbSeatClass.Text = "Hạng thương gia";
                }
                else
                {
                    lbSeatClass.Text = "Hạng phổ thông";
                }
                if(ticketPrice != null)
                {
                    lbFare.Text = String.Format("{0:0}", ticketPrice.price);
                }
                else
                {
                    lbFare.Text = "";
                }
            }
            catch (Exception)
            {
            }
        }

        public void GetListTicketPrice(Label lbSeatClass, Label lbFare, string flightID, int ticketType, int quantity)
        {
            try
            {
                ticket_price ticketPrice = dAO_TicketPrice.GetListTicketPrice(flightID, ticketType);
                if (ticketType == 1)
                {
                    lbSeatClass.Text = "Hạng thương gia";
                }
                else
                {
                    lbSeatClass.Text = "Hạng phổ thông";
                }
                lbFare.Text = String.Format("{0:0}", ticketPrice.price * quantity);
            }
            catch (Exception)
            {
            }
        }
    }
}
