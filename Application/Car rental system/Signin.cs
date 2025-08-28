using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Car_rental_system
{
    public partial class Signin : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;");

        public Signin()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void username_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txtbox.Text.Trim() != "" && password_txtbox.Text.Trim() != "")
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username_txtbox.Text.Trim());
                cmd.Parameters.AddWithValue("@password", password_txtbox.Text.Trim());

                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    Form f2 = new Homepage();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
