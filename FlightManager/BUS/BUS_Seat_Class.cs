using FlightManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager.BUS
{
    class BUS_Seat_Class
    {
        DAO_Seat_Class dAO_Seat_Class;
        public BUS_Seat_Class()
        {
            dAO_Seat_Class = new DAO_Seat_Class();
        }
        public void ListSeat(DataGridView dg)
        {
            dg.DataSource = dAO_Seat_Class.ListSeat();
        }
        public int Add_Seat(seat_class seat)
        {
            if (dAO_Seat_Class.CheckSeat(seat.flight_id, seat.seat_type))
            {
                return 0;
            }
            else
            {
                try
                {
                    dAO_Seat_Class.AddSeatClass(seat);
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
        public int Delete_Seat(string flight_id, int seat_type)
        {
            try
            {
                if (dAO_Seat_Class.CheckSeat(flight_id, seat_type))
                {
                    dAO_Seat_Class.Delete_Seat(flight_id, seat_type);
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
        public int Update_Seat(seat_class seat)
        {
            if (dAO_Seat_Class.CheckSeat(seat.flight_id, seat.seat_type))
            {
                try
                {
                    dAO_Seat_Class.Update_Seat(seat);
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
