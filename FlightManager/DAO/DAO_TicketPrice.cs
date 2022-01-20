using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_TicketPrice
    {
        Flight_ManagerEntities db;
        public DAO_TicketPrice()
        {
            db = new Flight_ManagerEntities();
        }

        public ticket_price GetListTicketPrice(string flightID, int ticketType)
        {
            return db.ticket_price.FirstOrDefault(s => s.flight_id == flightID && s.ticket_type == ticketType);
        }
    }
}
