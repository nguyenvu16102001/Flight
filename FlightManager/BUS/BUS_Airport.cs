using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManager.DAO;

namespace FlightManager.BUS
{
    class BUS_Airport
    {
        DAO_Airport dAO_Airport;
        public BUS_Airport()
        {
            dAO_Airport = new DAO_Airport();
        }

        public void ListAirport(ComboBox cb)
        {
            cb.DataSource = dAO_Airport.ListAirport();
            cb.DisplayMember = "airport_name";
            cb.ValueMember = "airport_id";
        }
    }
}
