using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManager.DAO;
using System.Windows.Forms;

namespace FlightManager.BUS
{
    class BUS_TicketType
    {
        DAO_TicketType dAO_TicketType;
        public BUS_TicketType()
        {
            dAO_TicketType = new DAO_TicketType();
        }

        public void ListTicketType(ComboBox cb)
        {
            cb.DataSource = dAO_TicketType.ListTicketType();
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
        }
    }
}
