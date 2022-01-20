using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager
{
    public partial class FHomeTicketSales : Form
    {
        public FHomeTicketSales()
        {
            InitializeComponent();
        }

        private void btnTicketSales_Click(object sender, EventArgs e)
        {
            FTicketSales fTicket = new FTicketSales();
            fTicket.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FSearch fSearch = new FSearch();
            fSearch.ShowDialog();
        }

        private void btnFlightScheduling_Click(object sender, EventArgs e)
        {
            FFlightScheduling fFlightScheduling = new FFlightScheduling();
            fFlightScheduling.ShowDialog();
        }
    }
}
