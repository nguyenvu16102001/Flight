using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.DAO
{
    class DAO_Regulations
    {
        Flight_ManagerEntities db;
        public DAO_Regulations()
        {
            db = new Flight_ManagerEntities();
        }
        public regulation ListRegulations()
        {
            return db.regulations.FirstOrDefault();
        }
    }
}
