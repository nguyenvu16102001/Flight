using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_TicketType
    {
        Flight_ManagerEntities db;

        public DAO_TicketType()
        {
            db = new Flight_ManagerEntities();
        }

        public dynamic ListTicketType()
        {
            dynamic ds = db.ticket_type.Select(s => new
            {
                s.id,
                s.name
            }).ToList();
            return ds;
        }
    }
}
