using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Car_rental_system
{
    public partial class Users : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;");

        public Users()
        {
            InitializeComponent();
        }

        private void LoadUsers()
        {
            con.Open();
            string query = "SELECT * FROM users";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            users_dataGridView.DataSource = dt;
            con.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            
            if (userID_txtbox.Text != "" && userName_txtbox.Text != "" && userPassword_txtbox.Text != "")
            {
                if (!int.TryParse(userID_txtbox.Text, out int userId) || userId <= 0)
                {
                    MessageBox.Show("User ID must be a positive number.");
                    return;
                }

                con.Open();

                SqlCommand cmd = new SqlCommand("proc_AddUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@userid", userId);
                cmd.Parameters.AddWithValue("@username", userName_txtbox.Text);
                cmd.Parameters.AddWithValue("@password", userPassword_txtbox.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                con.Close();
                LoadUsers(); 
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
            }
        }

        private string originalUserId = "";
        private void users_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = users_dataGridView.Rows[e.RowIndex];
                userID_txtbox.Text = row.Cells["userid"].Value.ToString();
                userName_txtbox.Text = row.Cells["username"].Value.ToString();
                userPassword_txtbox.Text = row.Cells["password"].Value.ToString();

                originalUserId = userID_txtbox.Text;
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (userID_txtbox.Text != "" && userName_txtbox.Text != "" && userPassword_txtbox.Text != "")
            {
                con.Open();

                if (userID_txtbox.Text != originalUserId)
                {
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM users WHERE userid = @user_id", con);
                    checkCmd.Parameters.AddWithValue("@user_id", userID_txtbox.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        con.Close();
                        MessageBox.Show("User ID already exists. Please enter a unique User ID.");
                        return;
                    }
                }

                string query = "UPDATE users SET userid = @new_user_id, username = @username, password = @password WHERE userid = @original_user_id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@new_user_id", userID_txtbox.Text);
                cmd.Parameters.AddWithValue("@username", userName_txtbox.Text);
                cmd.Parameters.AddWithValue("@password", userPassword_txtbox.Text);
                cmd.Parameters.AddWithValue("@original_user_id", originalUserId);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User updated successfully!");
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Please select a user and fill all fields.");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (userID_txtbox.Text != "")
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this user?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM users WHERE userid = @user_id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@user_id", userID_txtbox.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("User deleted successfully!");

                        userID_txtbox.Clear();
                        userName_txtbox.Clear();
                        userPassword_txtbox.Clear();

                        LoadUsers();
                    }
                    catch (SqlException ex)
                    {
                        con.Close();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }


        private void back_btn_Click_1(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void userID_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}

