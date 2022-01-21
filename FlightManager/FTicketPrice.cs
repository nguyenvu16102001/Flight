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
    public partial class FTicketPrice : Form
    {
        BUS_Price bus_Price;
        public FTicketPrice()
        {
            InitializeComponent();
            bus_Price = new BUS_Price();
        }

        private void FTicketPrice_Load(object sender, EventArgs e)
        {
            bus_Price.ListPrice(gVPrice);

            gVPrice.Columns[0].Width = (int)(gVPrice.Width * 0.15);
            gVPrice.Columns[1].Width = (int)(gVPrice.Width * 0.2);
            gVPrice.Columns[2].Width = (int)(gVPrice.Width * 0.2);
            gVPrice.Columns[3].Width = (int)(gVPrice.Width * 0.2);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && txtPrice.Text != "" && txtType.Text != "")
            {
                ticket_price price = new ticket_price();
                price.quantity = int.Parse(txtQuantity.Text);
                price.price = decimal.Parse(txtPrice.Text);
                price.ticket_type = int.Parse(txtType.Text);

                if (bus_Price.Add_Price(price) == 1)
                {
                    MessageBox.Show("Thêm giá vé thành công !!");
                    bus_Price.ListPrice(gVPrice);
                }
                else if (bus_Price.Add_Price(price) == -1)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Gía vé đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txtFlightid.Text != "" && txtQuantity.Text != "" && txtPrice.Text != "" && txtType.Text != "")
            {
                string flightID = txtFlightid.Text;
                int ticketType = int.Parse(txtType.Text);
                if (flightID != null && ticketType > 0)
                {
                    if (bus_Price.Delete_Price(flightID, ticketType) == 1)
                    {
                        MessageBox.Show("Xóa giá vé thành công");
                        bus_Price.ListPrice(gVPrice);
                    }
                    else if (bus_Price.Delete_Price(flightID, ticketType) == -1)
                    {
                        MessageBox.Show("Xóa giá vé thất bại");
                    }
                    else
                    {
                        MessageBox.Show("giá vé không tồn tại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void gVPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex <= gVPrice.Rows.Count)
                {
                    txtFlightid.Text = gVPrice.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtQuantity.Text = gVPrice.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtPrice.Text = gVPrice.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtType.Text = gVPrice.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtFlightid.Text != "" && txtQuantity.Text != "" && txtPrice.Text != "" && txtType.Text != "")
            {
                ticket_price price = new ticket_price();
                price.flight_id = txtFlightid.Text;
                price.quantity = int.Parse(txtQuantity.Text);
                price.price = decimal.Parse(txtPrice.Text); 
                price.ticket_type = int.Parse(txtType.Text);

                if (bus_Price.Update_Price(price) == 1)
                {
                    MessageBox.Show("Sưả giá vé thành công !!");
                    bus_Price.ListPrice(gVPrice);
                }
                else if (bus_Price.Update_Price(price) == -1)
                {
                    MessageBox.Show("Sửa thất bại");
                }
                else
                {
                    MessageBox.Show("Gía vé đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }
    }
}
