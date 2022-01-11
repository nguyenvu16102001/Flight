using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManager.DAO;

namespace FlightManager.BUS
{
    class BUS_Airplane
    {
        DAO_Airplane dAO_Airplane;
        public BUS_Airplane()
        {
            dAO_Airplane = new DAO_Airplane();
        }
        public void ListAirplane(ComboBox cb)
        {
            cb.DataSource = dAO_Airplane.ListAirplane();
            cb.ValueMember = "airplane_id";
        }
    }
}
