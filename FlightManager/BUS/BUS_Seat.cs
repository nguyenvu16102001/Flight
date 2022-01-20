using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManager.DAO;

namespace FlightManager.BUS
{
    class BUS_Seat
    {
        DAO_Seat dAO_Seat;
        public BUS_Seat()
        {
            dAO_Seat = new DAO_Seat();
        }

        public dynamic GetListSeat(string flightID, int seatType)
        {
            return dAO_Seat.GetListSeat(flightID, seatType);
        }

        public string GetSeat(List<int> selectedSeats)
        {
            string result = "";
            try
            {
                foreach (int s in selectedSeats)
                {
                    seat seat = dAO_Seat.GetSeat(s);
                    result += seat.seat_name + " ";
                }
            }
            catch (Exception)
            {
            }
            return result;
        }
    }
}
