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
using System.Security.Cryptography;

namespace FlightManager
{
    public partial class FAccount : Form
    {
        BUS_Account BUS_Account;
        public FAccount()
        {
            InitializeComponent();
            BUS_Account = new BUS_Account();
        }
        
        private void FAccount_Load(object sender, EventArgs e)
        {
            BUS_Account.ListAccount(gVAccount);

            gVAccount.Columns[0].Width = (int)(gVAccount.Width * 0.15);
            gVAccount.Columns[1].Width = (int)(gVAccount.Width * 0.1);
            gVAccount.Columns[2].Width = (int)(gVAccount.Width * 0.1);
            gVAccount.Columns[3].Width = (int)(gVAccount.Width * 0.1);
            gVAccount.Columns[4].Width = (int)(gVAccount.Width * 0.2);
            gVAccount.Columns[5].Width = (int)(gVAccount.Width * 0.2);
            gVAccount.Columns[6].Width = (int)(gVAccount.Width * 0.2);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txtAccountid.Text != "" && txtUserid.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && cbActive.SelectedValue != null && dtbJointdate.Value != null && cb_UserRole.SelectedValue != null)
            {
                account acc = new account();
                acc.account_id = int.Parse(txtAccountid.Text);
                acc.user_id = int.Parse(txtUserid.Text);
                acc.username = txtUsername.Text;
                acc.password = txtPassword.Text;
                acc.active = short.Parse(cbActive.Text);
                acc.join_date = dtbJointdate.Value;
                acc.user_role = int.Parse(cb_UserRole.SelectedValue.ToString());
                if (BUS_Account.Add_Account(acc) == 1)
                {
                    MessageBox.Show("Thêm account thành công !!");
                    BUS_Account.ListAccount(gVAccount);
                }
                else if (BUS_Account.Add_Account(acc) == -1)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Account đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void gVAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex <= gVAccount.Rows.Count)
                {
                    txtAccountid.Text = gVAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtUserid.Text = gVAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtUsername.Text = gVAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtPassword.Text = gVAccount.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cbActive.Text = gVAccount.Rows[e.RowIndex].Cells[4].Value.ToString();
                    dtbJointdate.Text = gVAccount.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cb_UserRole.Text = gVAccount.Rows[e.RowIndex].Cells[6].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txtAccountid.Text != "" && txtUserid.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && cbActive.Text != null && dtbJointdate.Value != null && cb_UserRole.Text != null)
            {

                int accountID = int.Parse(txtAccountid.Text);
                if (accountID > 0)
                {
                    if (BUS_Account.Delete_Account(accountID) == 1)
                    {
                        MessageBox.Show("Xóa tài khoản thành công");
                        BUS_Account.ListAccount(gVAccount);
                    }
                    else if (BUS_Account.Delete_Account(accountID) == -1)
                    {
                        MessageBox.Show("Xóa tài khoản thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại");
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
            if (txtAccountid.Text != "" && txtUserid.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && cbActive.Text != null && dtbJointdate.Value != null && cb_UserRole.Text != null)
            {
                account acc = new account();
                acc.account_id = int.Parse(txtAccountid.Text);
                acc.user_id = int.Parse(txtUserid.Text);
                acc.username = txtUsername.Text;
                acc.password = txtPassword.Text;
                acc.active = short.Parse(cbActive.Text);
                acc.join_date = dtbJointdate.Value;
                acc.user_role = int.Parse(cb_UserRole.Text);
                if (BUS_Account.Update_Account(acc) == 1)
                {
                    MessageBox.Show("Sửa account thành công !!");
                    BUS_Account.ListAccount(gVAccount);
                }
                else if (BUS_Account.Update_Account(acc) == -1)
                {
                    MessageBox.Show("Sửa thất bại");
                }
                else
                {
                    MessageBox.Show("Account đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            if (txtAccountid.Text != "" && txtUserid.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && cbActive.SelectedValue != null && dtbJointdate.Value != null && cb_UserRole.SelectedValue != null)
            {
                account acc = new account();
                acc.account_id = int.Parse(txtAccountid.Text);
                acc.user_id = int.Parse(txtUserid.Text);
                acc.username = txtUsername.Text;
                acc.password = txtPassword.Text;
                acc.active = short.Parse(cbActive.Text);
                acc.join_date = dtbJointdate.Value;
                acc.user_role = int.Parse(cb_UserRole.SelectedValue.ToString());
                if (BUS_Account.Add_Account(acc) == 1)
                {
                    MessageBox.Show("Thêm account thành công !!");
                    BUS_Account.ListAccount(gVAccount);
                }
                else if (BUS_Account.Add_Account(acc) == -1)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Account đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }
    }
}
