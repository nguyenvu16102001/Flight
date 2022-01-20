using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManager.BUS;

namespace FlightManager
{
    public partial class FPassengers : Form
    {
        public static user user;
        BUS_User bUS_User;
        public FPassengers()
        {
            InitializeComponent();
            user = new user();
            bUS_User = new BUS_User();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(txtLastName.Text != null && txtFirstName.Text != null && cbGender.Text != null && txtNationality.Text != null && dTPDateOfBirth.Value != null && txtIdentity_Card.Text != null && txtPhone.Text != null && txtEmail.Text != null)
            {
                user u = new user();
                u.last_name = txtLastName.Text;
                u.first_name = txtFirstName.Text;
                u.gender = cbGender.Text;
                u.nationality = txtNationality.Text;
                u.date_of_birth = dTPDateOfBirth.Value;
                u.identity_card = txtIdentity_Card.Text;
                u.phone = txtPhone.Text;
                u.email = txtEmail.Text;
                user = bUS_User.Passengers(u);
                FPayment fPayment = new FPayment();
                this.Hide();
                fPayment.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
        }
    }
}
