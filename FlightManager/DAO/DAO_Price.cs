using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Price
    {
        Flight_ManagerEntities db;

        public DAO_Price()
        {
            db = new Flight_ManagerEntities();
        }
        public ticket_price GetPrice(string flight_id, int ticket_type)
        {
            ticket_price price = db.ticket_price.FirstOrDefault(s => s.flight_id == flight_id && s.ticket_type == ticket_type);
            return price;

        }
        public void Add_Price(ticket_price price)
        {
            db.ticket_price.Add(price);
            db.SaveChanges();
        }
        public void Delete_Price(string flight_id, int ticket_type)
        {
            ticket_price price = db.ticket_price.FirstOrDefault(s => s.flight_id == flight_id && s.ticket_type == ticket_type);
            db.ticket_price.Remove(price);
            db.SaveChanges();
        }
        public void Update_Price(ticket_price price)
        {
            ticket_price p = db.ticket_price.FirstOrDefault(s => s.flight_id == price.flight_id && s.ticket_type == price.ticket_type);
            p.flight_id = price.flight_id;
            p.ticket_type = price.ticket_type;
            p.price = price.price ;
            p.quantity = price.quantity;

            db.SaveChanges();
        }
        public bool CheckPrice(string flight_id, int ticket_type)
        {
            ticket_price p = db.ticket_price.FirstOrDefault(s => s.flight_id == flight_id && s.ticket_type == ticket_type); //lỗi
            if (p != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public dynamic ListPrice()
        {
            var ds = db.ticket_price.Select(s => new
            {
                s.flight_id,
                s.ticket_type,
                s.price,
                s.quantity
            }).ToList();
            return ds;
        }
    }
}
