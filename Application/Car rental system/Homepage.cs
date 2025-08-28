using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_rental_system
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void cars_btn_Click(object sender, EventArgs e)
        {
            Cars carsPage = new Cars();
            carsPage.Show();
            this.Hide();
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            customers customersPage = new customers();
            customersPage.Show();
            this.Hide();
        }

        private void rentals_btn_Click(object sender, EventArgs e)
        {
            Rentals rentalsPage = new Rentals();
            rentalsPage.Show();
            this.Hide();
        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            Users userspage = new Users();
            userspage.Show();
            this.Hide();
        }

        private void returns_btn_Click(object sender, EventArgs e)
        {
            returns returnspage = new returns();
            returnspage.Show();
            this.Hide();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Signin signinpage = new Signin();
            signinpage.Show();
            this.Hide();
        }
    }
}
