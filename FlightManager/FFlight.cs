using FlightManager.BUS;
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
    public partial class FFlight : Form
    {
        BUS_Flight BUS_Flight;
        public FFlight()
        {
            InitializeComponent();
            //dateTimePicker3.ShowUpDown = true;
            BUS_Flight = new BUS_Flight();
        }
        private void FFlight_Load(object sender, EventArgs e)
        {
            BUS_Flight.ListFlight(gVFlight);

            gVFlight.Columns[0].Width = (int)(gVFlight.Width * 0.15);
            gVFlight.Columns[1].Width = (int)(gVFlight.Width * 0.1);
            gVFlight.Columns[2].Width = (int)(gVFlight.Width * 0.1);
            gVFlight.Columns[3].Width = (int)(gVFlight.Width * 0.1);
            gVFlight.Columns[4].Width = (int)(gVFlight.Width * 0.2);
            gVFlight.Columns[5].Width = (int)(gVFlight.Width * 0.2);
            gVFlight.Columns[6].Width = (int)(gVFlight.Width * 0.2);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txtFlightid.Text != "" && txtAirplaneid.Text != "" && txtScheduleid.Text != "" && nUDFlightTime != null && dtbDeparture.Value != null && dtpArrival.Value != null)
            {
                flight flight = new flight();
                flight.flight_id = txtFlightid.Text;
                flight.airplane_id = txtAirplaneid.Text;
                flight.schedule_id = int.Parse(txtScheduleid.Text);
                flight.flight_time = int.Parse(nUDFlightTime.Value.ToString());
                flight.departure_day = dtbDeparture.Value;
                flight.arrival_day = dtpArrival.Value;
                flight.number_of_empty_seats = int.Parse(nEmptySeat.Value.ToString());
                if (BUS_Flight.Add_Flight(flight) == 1)
                {
                    MessageBox.Show("Thêm Chuyến Bay thành công !!");
                    BUS_Flight.ListFlight(gVFlight);
                }
                else if (BUS_Flight.Add_Flight(flight) == -1)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Chuyến bay đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void gVFlight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex <= gVFlight.Rows.Count)
                {
                    txtFlightid.Text = gVFlight.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtAirplaneid.Text = gVFlight.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtScheduleid.Text = gVFlight.Rows[e.RowIndex].Cells[2].Value.ToString();
                    nUDFlightTime.Value = int.Parse(gVFlight.Rows[e.RowIndex].Cells[3].Value.ToString());
                    dtbDeparture.Text = gVFlight.Rows[e.RowIndex].Cells[4].Value.ToString();
                    dtpArrival.Text = gVFlight.Rows[e.RowIndex].Cells[5].Value.ToString();
                    nEmptySeat.Text = gVFlight.Rows[e.RowIndex].Cells[6].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txtFlightid.Text != "" && txtAirplaneid.Text != "" && txtScheduleid.Text != "" && nUDFlightTime != null && dtbDeparture.Value != null && dtpArrival.Value != null)
            {
                string flightID = txtFlightid.Text;
                if (flightID != null)
                {
                    if (BUS_Flight.Delete_Flight(flightID) == 1)
                    {
                        MessageBox.Show("Xóa chuyến bay thành công");
                        BUS_Flight.ListFlight(gVFlight);
                    }
                    else if (BUS_Flight.Delete_Flight(flightID) == -1)
                    {
                        MessageBox.Show("Xóa chuyến bay thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Chuyến bay không tồn tại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtFlightid.Text != "" && txtAirplaneid.Text != "" && txtScheduleid.Text != "" && nUDFlightTime != null && dtbDeparture.Value != null && dtpArrival.Value != null)
            {
                flight flight = new flight();
                flight.flight_id = txtFlightid.Text;
                flight.airplane_id = txtAirplaneid.Text;
                flight.schedule_id = int.Parse(txtScheduleid.Text);
                flight.flight_time = int.Parse(nUDFlightTime.Value.ToString());
                flight.departure_day = dtbDeparture.Value;
                flight.arrival_day = dtpArrival.Value;
                flight.number_of_empty_seats = int.Parse(nEmptySeat.Value.ToString());
                if (BUS_Flight.Update_Flight(flight) == 1)
                {
                    MessageBox.Show("Sửa chuyến bay thành công");
                    BUS_Flight.ListFlight(gVFlight);
                }
                else if (BUS_Flight.Update_Flight(flight) == -1)
                {
                    MessageBox.Show("Sửa chuyến bay thất bại");
                }
                else
                {
                    MessageBox.Show("Chuyến bay không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }
    }
}
