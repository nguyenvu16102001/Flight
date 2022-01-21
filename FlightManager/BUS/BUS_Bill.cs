using FlightManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager.BUS
{
    class BUS_Bill
    {
        DAO_Bill dAO_Bill;
        public BUS_Bill()
        {
            dAO_Bill = new DAO_Bill();
        }
        public void ListBill(DataGridView dg)
        {
            dg.DataSource = dAO_Bill.ListBill();
        }
        public int Add_Bill(bill bill)
        {
            if (dAO_Bill.CheckBill(bill.bill_id))
            {
                return 0;
            }
            else
            {
                try
                {
                    dAO_Bill.Add_Bill(bill);
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
        public int Delete_Bill(string bill_id)
        {
            try
            {
                if (dAO_Bill.CheckBill(bill_id))
                {
                    dAO_Bill.Delete_Bill(bill_id);
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
        public int Update_Bill(bill bill)
        {
            if (dAO_Bill.CheckBill(bill.bill_id))
            {
                try
                {
                    dAO_Bill.Update_Bill(bill);
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
