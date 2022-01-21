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
    public partial class FRegulation : Form
    {
        BUS_Regulations BUS_Regulations;
        public FRegulation()
        {
            InitializeComponent();
            BUS_Regulations = new BUS_Regulations();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRegulation_Load(object sender, EventArgs e)
        {
            BUS_Regulations.ListRegulation(gVRegu);

            gVRegu.Columns[0].Width = (int)(gVRegu.Width * 0.15);
            gVRegu.Columns[1].Width = (int)(gVRegu.Width * 0.1);
            gVRegu.Columns[2].Width = (int)(gVRegu.Width * 0.1);
            gVRegu.Columns[3].Width = (int)(gVRegu.Width * 0.1);
            gVRegu.Columns[4].Width = (int)(gVRegu.Width * 0.1);
            gVRegu.Columns[5].Width = (int)(gVRegu.Width * 0.1);
            gVRegu.Columns[6].Width = (int)(gVRegu.Width * 0.1);
            gVRegu.Columns[7].Width = (int)(gVRegu.Width * 0.1);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txtReId.Text != "" && txtNumberAirport.Text != "" && txtMinTime.Text != "" && txtMaxInterAp.Text != "" && txtMinTimeStop.Text != "" && txtMaxTimeStop.Text != "" && txtSaleTime.Text != "" && txtBookTime.Text != "")
            {
                regulation regulation = new regulation();
                regulation.regulations_id = int.Parse(txtReId.Text);
                regulation.number_of_airports = int.Parse(txtNumberAirport.Text);
                regulation.minimum_flight_time = int.Parse(txtMinTime.Text);
                regulation.maximum_number_of_intermediate_airports = int.Parse(txtMaxInterAp.Text);
                regulation.minimum_estimated_time_of_the_stop = int.Parse(txtMinTimeStop.Text);
                regulation.maximum_estimated_time_of_the_stop = int.Parse(txtMaxTimeStop.Text);
                regulation.ticket_sales_time = int.Parse(txtSaleTime.Text);
                regulation.ticket_booking_time = int.Parse(txtBookTime.Text);

                if (BUS_Regulations.Add_Regulation(regulation) == 1)
                {
                    MessageBox.Show("Success !!");
                    BUS_Regulations.ListRegulation(gVRegu);
                }
                else if (BUS_Regulations.Add_Regulation(regulation) == -1)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Regulation đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void gVRegu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex <= gVRegu.Rows.Count)
                {
                    txtReId.Text = gVRegu.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNumberAirport.Text = gVRegu.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtMinTime.Text = gVRegu.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtMaxInterAp.Text = gVRegu.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtMinTimeStop.Text = gVRegu.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtMaxTimeStop.Text = gVRegu.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtSaleTime.Text = gVRegu.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtBookTime.Text = gVRegu.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtReId.Text != "" && txtNumberAirport.Text != "" && txtMinTime.Text != "" && txtMaxInterAp.Text != "" && txtMinTimeStop.Text != "" && txtMaxTimeStop.Text != "" && txtSaleTime.Text != "" && txtBookTime.Text != "")
            {
                regulation regulation = new regulation();
                regulation.regulations_id = int.Parse(txtReId.Text);
                regulation.number_of_airports = int.Parse(txtNumberAirport.Text);
                regulation.minimum_flight_time = int.Parse(txtMinTime.Text);
                regulation.maximum_number_of_intermediate_airports = int.Parse(txtMaxInterAp.Text);
                regulation.minimum_estimated_time_of_the_stop = int.Parse(txtMinTimeStop.Text);
                regulation.maximum_estimated_time_of_the_stop = int.Parse(txtMaxTimeStop.Text);
                regulation.ticket_sales_time = int.Parse(txtSaleTime.Text);
                regulation.ticket_booking_time = int.Parse(txtBookTime.Text);

                if (BUS_Regulations.Update_Regulation(regulation) == 1)
                {
                    MessageBox.Show("Success !!");
                    BUS_Regulations.ListRegulation(gVRegu);
                }
                else if (BUS_Regulations.Update_Regulation(regulation) == -1)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Regulation đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txtReId.Text != "" && txtNumberAirport.Text != "" && txtMinTime.Text != "" && txtMaxInterAp.Text != "" && txtMinTimeStop.Text != "" && txtMaxTimeStop.Text != "" && txtSaleTime.Text != "" && txtBookTime.Text != "")
            {
                int regulationID = int.Parse(txtReId.Text);
                if (regulationID != null)
                {
                    if (BUS_Regulations.Delete_Regulation(regulationID) == 1)
                    {
                        MessageBox.Show("Success");
                        BUS_Regulations.ListRegulation(gVRegu);
                    }
                    else if (BUS_Regulations.Delete_Regulation(regulationID) == -1)
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                    else
                    {
                        MessageBox.Show(" không tồn tại");
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
