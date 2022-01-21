using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Bill
    {
        Flight_ManagerEntities db;

        public DAO_Bill()
        {
            db = new Flight_ManagerEntities();
        }
        public bill GetBills(string bill_id)
        {
            bill b = db.bills.FirstOrDefault(s => s.bill_id == bill_id);
            return b;

        }
        public void Add_Bill(bill bill)
        {
            db.bills.Add(bill);
            db.SaveChanges();
        }
        public void Delete_Bill(string bill_id)
        {
            bill b = db.bills.Find(bill_id);
            db.bills.Remove(b);
            db.SaveChanges();
        }
        public void Update_Bill(bill bill)
        {
            bill b = db.bills.Find(bill.bill_id);
            b.bill_id = bill.bill_id;
            b.employee_id = bill.employee_id;
            b.date_of_payment = bill.date_of_payment;
            b.status = bill.status;

            db.SaveChanges();
        }
        public bool CheckBill(string id)
        {
            bill b = db.bills.Find(id);
            if (b != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public dynamic ListBill()
        {
            var ds = db.bills.Select(s => new
            {
                s.bill_id,
                s.employee_id,
                s.date_of_payment,
                s.amount,
                s.status,
            }).ToList();
            return ds;
        }
    }
}
