using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManager.DAO;

namespace FlightManager.BUS
{
    class BUS_Regulations
    {
        DAO_Regulations dAO_Regulations;
        public BUS_Regulations()
        {
            dAO_Regulations = new DAO_Regulations();
        }
        public IDictionary<string, int> ListRegulations()
        {
            regulation reg = dAO_Regulations.ListRegulations(); 
            IDictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("minimum_flight_time", reg.minimum_flight_time.Value);
            dict.Add("minimum_estimated_time_of_the_stop", reg.minimum_estimated_time_of_the_stop.Value);
            dict.Add("maximum_estimated_time_of_the_stop", reg.maximum_estimated_time_of_the_stop.Value);
            return dict;
        }
        public void ListRegulation(DataGridView dg)
        {
            dg.DataSource = dAO_Regulations.ListRegulation();
        }
        public int Add_Regulation(regulation regulation)
        {
            if (dAO_Regulations.CheckRegulation(regulation.regulations_id))
            {
                return 0;
            }
            else
            {
                try
                {
                    dAO_Regulations.Add_Regulation(regulation);
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
        public int Delete_Regulation(int regulations_id)
        {
            try
            {
                if (dAO_Regulations.CheckRegulation(regulations_id))
                {
                    dAO_Regulations.Delete_Regulation(regulations_id);
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
        public int Update_Regulation(regulation regulation)
        {
            if (dAO_Regulations.CheckRegulation(regulation.regulations_id))
            {
                try
                {
                    dAO_Regulations.Update_Regulation(regulation);
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
