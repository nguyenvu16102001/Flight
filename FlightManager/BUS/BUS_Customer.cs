using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManager.DAO;

namespace FlightManager.BUS
{
    class BUS_Customer
    {
        DAO_Customer dAO_Customer;
        public BUS_Customer()
        {
            dAO_Customer = new DAO_Customer();
        }

        public int AddCustomer(customer c)
        {
            if (dAO_Customer.CheckCustomer(c.user_id))
            {
                return 0;
            }
            else
            {
                try
                {
                    dAO_Customer.AddCustomer(c);
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
    }
}
