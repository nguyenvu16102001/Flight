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
    public partial class FSchedule : Form
    {
        BUS_Schedule BUS_Schedule;
        public FSchedule()
        {
            InitializeComponent();
            BUS_Schedule = new BUS_Schedule();
        }

        private void FSchedule_Load(object sender, EventArgs e)
        {
            BUS_Schedule.ListSchedule(gVSchedule);

            gVSchedule.Columns[0].Width = (int)(gVSchedule.Width * 0.2);
            gVSchedule.Columns[1].Width = (int)(gVSchedule.Width * 0.2);
            gVSchedule.Columns[2].Width = (int)(gVSchedule.Width * 0.2);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txtScheduleid.Text != "" && txtdeparture.Text != "" && txtArrival.Text != "")
            {
                schedule schedule = new schedule();
                schedule.schedule_id = int.Parse(txtScheduleid.Text);
                schedule.departure_airport = txtdeparture.Text;
                schedule.arrival_airport = txtArrival.Text;

                if (BUS_Schedule.Add_Schedule(schedule) == 1)
                {
                    MessageBox.Show("Success");
                    BUS_Schedule.ListSchedule(gVSchedule);
                }
                else if (BUS_Schedule.Add_Schedule(schedule) == -1)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Lịch trình đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtScheduleid.Text != "" && txtdeparture.Text != "" && txtArrival.Text != "")
            {
                schedule schedule = new schedule();
                schedule.schedule_id = int.Parse(txtScheduleid.Text);
                schedule.departure_airport = txtdeparture.Text;
                schedule.arrival_airport = txtArrival.Text;

                if (BUS_Schedule.Update_Schedule(schedule) == 1)
                {
                    MessageBox.Show("Success");
                    BUS_Schedule.ListSchedule(gVSchedule);
                }
                else if (BUS_Schedule.Update_Schedule(schedule) == -1)
                {
                    MessageBox.Show("Sửa thất bại");
                }
                else
                {
                    MessageBox.Show("Lịch trình đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void gVSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex <= gVSchedule.Rows.Count)
                {
                    txtScheduleid.Text = gVSchedule.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtdeparture.Text = gVSchedule.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtArrival.Text = gVSchedule.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txtScheduleid.Text != "" && txtdeparture.Text != "" && txtArrival.Text != "")
            {
                int scheduleID = int.Parse(txtScheduleid.Text);
                if (scheduleID != null)
                {
                    if (BUS_Schedule.Delete_Schedule(scheduleID) == 1)
                    {
                        MessageBox.Show("Success");
                        BUS_Schedule.ListSchedule(gVSchedule);
                    }
                    else if (BUS_Schedule.Delete_Schedule(scheduleID) == -1)
                    {
                        MessageBox.Show("XóA thất bại");
                    }
                    else
                    {
                        MessageBox.Show("không tồn tại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }
    }
}
