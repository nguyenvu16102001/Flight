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
    public partial class FSeatclass : Form
    {
        BUS_Seat_Class BUS_Seat_Class;
        public FSeatclass()
        {
            InitializeComponent();
            BUS_Seat_Class = new BUS_Seat_Class();
        }

        private void FSeatclass_Load(object sender, EventArgs e)
        {
            BUS_Seat_Class.ListSeat(gVSeat);

            gVSeat.Columns[0].Width = (int)(gVSeat.Width * 0.2);
            gVSeat.Columns[1].Width = (int)(gVSeat.Width * 0.2);
            gVSeat.Columns[2].Width = (int)(gVSeat.Width * 0.2);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txtFlightid.Text != "" && txtSeattype.Text != "" && txtSeatnumber.Text != "")
            {
                seat_class seat = new seat_class();
                seat.flight_id = txtFlightid.Text;
                seat.seat_type = int.Parse(txtSeattype.Text);
                seat.seat_number = int.Parse(txtSeatnumber.Text);

                if (BUS_Seat_Class.Add_Seat(seat) == 1)
                {
                    MessageBox.Show("Success");
                    BUS_Seat_Class.ListSeat(gVSeat);
                }
                else if (BUS_Seat_Class.Add_Seat(seat) == -1)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show(" đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void gVSeat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex <= gVSeat.Rows.Count)
                {
                    txtFlightid.Text = gVSeat.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtSeattype.Text = gVSeat.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSeatnumber.Text = gVSeat.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txtFlightid.Text != "" && txtSeattype.Text != "" && txtSeatnumber.Text != "")
            {
                string flightID = txtFlightid.Text;
                int seatType = int.Parse(txtSeattype.Text);
                if (flightID != null && seatType > 0)
                {
                    if (BUS_Seat_Class.Delete_Seat(flightID, seatType) == 1)
                    {
                        MessageBox.Show("Success");
                        BUS_Seat_Class.ListSeat(gVSeat);
                    }
                    else if (BUS_Seat_Class.Delete_Seat(flightID, seatType) == -1)
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
            if (txtFlightid.Text != "" && txtSeattype.Text != "" && txtSeatnumber.Text != "")
            {
                seat_class seat = new seat_class();
                seat.flight_id = txtFlightid.Text;
                seat.seat_type = int.Parse(txtSeattype.Text);
                seat.seat_number = int.Parse(txtSeatnumber.Text);

                if (BUS_Seat_Class.Update_Seat(seat) == 1)
                {
                    MessageBox.Show("Success");
                    BUS_Seat_Class.ListSeat(gVSeat);
                }
                else if (BUS_Seat_Class.Update_Seat(seat) == -1)
                {
                    MessageBox.Show("Sửa thất bại");
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
    }
}
