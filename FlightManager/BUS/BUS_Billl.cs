using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManager.DAO;

namespace FlightManager.BUS
{
    class BUS_Billl
    {
        DAO_Bill dAO_Bill;
        public BUS_Billl()
        {
            dAO_Bill = new DAO_Bill();
        }

        public string GetBillID()
        {
            Guid guid = new Guid();
            guid = Guid.NewGuid();
            string billID = guid.ToString().Substring(0, 6).ToUpper();
            while (dAO_Bill.CheckBill(billID))
            {
                guid = Guid.NewGuid();
                billID = guid.ToString().Substring(0, 6).ToUpper();
            }
            return billID;
        }

        public bool AddBill(bill bill)
        {
            try
            {
                dAO_Bill.AddBill(bill);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
