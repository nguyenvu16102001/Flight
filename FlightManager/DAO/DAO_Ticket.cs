using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Ticket
    {
        Flight_ManagerEntities db;
        public DAO_Ticket()
        {
            db = new Flight_ManagerEntities();
        }

        public void AddTicket(ticket ticket)
        {
            db.tickets.Add(ticket);
            db.SaveChanges();
        }
    }
}
