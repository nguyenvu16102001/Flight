using FlightManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager.BUS
{
    class BUS_Price
    {
        DAO_Price dAO_Price;
        public BUS_Price()
        {
            dAO_Price = new DAO_Price();
        }
        public void ListPrice(DataGridView dg)
        {
            dg.DataSource = dAO_Price.ListPrice();
        }
        public int Add_Price(ticket_price price)
        {
            if (dAO_Price.CheckPrice(price.flight_id, price.ticket_type))
            {
                return 0;
            }
            else
            {
                try
                {
                    dAO_Price.Add_Price(price);
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
        public int Delete_Price(string flight_id, int ticket_type)
        {
            try
            {
                if (dAO_Price.CheckPrice(flight_id, ticket_type))
                {
                    dAO_Price.Delete_Price(flight_id, ticket_type);
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
        public int Update_Price(ticket_price price)
        {
            if (dAO_Price.CheckPrice(price.flight_id, price.ticket_type))
            {
                try
                {
                    dAO_Price.Update_Price(price);
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
