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
    public partial class FBill : Form
    {
        BUS_Bill BUS_Bill;
        public FBill()
        {
            InitializeComponent();
            BUS_Bill = new BUS_Bill();
        }

        private void FBill_Load(object sender, EventArgs e)
        {
            BUS_Bill.ListBill(gVBill);

            gVBill.Columns[0].Width = (int)(gVBill.Width * 0.15);
            gVBill.Columns[1].Width = (int)(gVBill.Width * 0.1);
            gVBill.Columns[2].Width = (int)(gVBill.Width * 0.1);
            gVBill.Columns[3].Width = (int)(gVBill.Width * 0.1);
            gVBill.Columns[4].Width = (int)(gVBill.Width * 0.2);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txtBillid.Text != "" && txtEmpId.Text != "" && dtbPayment.Value != null &&  txtAmount.Text != "" && cbStatus.SelectedValue != null)
            {
                bill b = new bill();
                b.bill_id = txtBillid.Text;
                b.employee_id = int.Parse(txtEmpId.Text);
                b.date_of_payment = dtbPayment.Value;
                b.amount = decimal.Parse(txtAmount.Text);
                b.status = short.Parse(cbStatus.SelectedValue.ToString());

                if (BUS_Bill.Add_Bill(b) == 1)
                {
                    MessageBox.Show("Thêm hóa đơn thành công !!");
                    BUS_Bill.ListBill(gVBill);
                }
                else if (BUS_Bill.Add_Bill(b) == -1)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Hóa đơn đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void gVBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex <= gVBill.Rows.Count)
                {
                    txtBillid.Text = gVBill.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtEmpId.Text = gVBill.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtAmount.Text = gVBill.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cbStatus.Text = gVBill.Rows[e.RowIndex].Cells[4].Value.ToString();
                    dtbPayment.Text = gVBill.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtBillid.Text != "" && txtEmpId.Text != "" && dtbPayment.Value != null && txtAmount.Text != "" && cbStatus.SelectedValue != null)
            {
                bill b = new bill ();
                b.bill_id = txtBillid.Text;
                b.employee_id = int.Parse(txtEmpId.Text);
                b.date_of_payment = dtbPayment.Value;
                b.amount = decimal.Parse(txtAmount.Text);
                b.status = short.Parse(cbStatus.SelectedValue.ToString());
                
                if (BUS_Bill.Update_Bill(b) == 1)
                {
                    MessageBox.Show("Sửa hóa đơn thành công");
                    BUS_Bill.ListBill(gVBill);
                }
                else if (BUS_Bill.Update_Bill(b) == -1)
                {
                    MessageBox.Show("Sửa hóa đơn thất bại");
                }
                else
                {
                    MessageBox.Show("Hóa đơn không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txtBillid.Text != "" && txtEmpId.Text != "" && dtbPayment.Value != null && txtAmount.Text != "" && cbStatus.SelectedValue != null)
            {
                string billID = txtBillid.Text;
                if (billID != null)
                {
                    if (BUS_Bill.Delete_Bill(billID) == 1)
                    {
                        MessageBox.Show("Xóa hóa đơn thành công");
                        BUS_Bill.ListBill(gVBill);
                    }
                    else if (BUS_Bill.Delete_Bill(billID) == -1)
                    {
                        MessageBox.Show("Xóa hóa đơn thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn không tồn tại");
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
