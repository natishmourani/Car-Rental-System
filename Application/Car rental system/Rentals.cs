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
    public partial class Rentals : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;");

        public Rentals()
        {
            InitializeComponent();
            rentalID_txtbox.KeyPress += rentalID_txtbox_KeyPress;

        }
        private void Rentals_Load(object sender, EventArgs e)
        {
            LoadAvailableCars();
            LoadCustomers();
            LoadRentals();
        }

        private void LoadAvailableCars()
        {
            carReg_comboBox.Items.Clear();
            con.Open();

            string currentSelection = carReg_comboBox.Text;

            SqlCommand cmd = new SqlCommand("SELECT regno FROM ViewAvailableCars", con);
            SqlDataReader reader = cmd.ExecuteReader();

            List<string> availableCars = new List<string>();
            while (reader.Read())
            {
                availableCars.Add(reader["regno"].ToString());
            }
            reader.Close();

            foreach (var car in availableCars)
            {
                carReg_comboBox.Items.Add(car);
            }

            if (!string.IsNullOrEmpty(currentSelection) && !availableCars.Contains(currentSelection))
            {
                carReg_comboBox.Items.Add(currentSelection);
            }

            con.Close();
        }


        private void LoadCustomers()
        {
            customerId_comboBox.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT custid FROM customers", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                customerId_comboBox.Items.Add(reader["custid"].ToString());
            }
            reader.Close();
            con.Close();
        }
        private void LoadRentals()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ViewRentalsWithCustomers", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rentals_dataGridView.DataSource = dt;
            con.Close();
        }

        private void customerId_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = customerId_comboBox.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT custname, custaddress FROM customers WHERE custid = @cust_id", con);
            cmd.Parameters.AddWithValue("@cust_id", selectedId);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                customerName_txtbox.Text = reader["custname"].ToString();
                customerAddress_txtbox.Text = reader["custaddress"].ToString();

            }
            reader.Close();
            con.Close();
        }


        private void add_btn_Click(object sender, EventArgs e)
        {
            if (rentalID_txtbox.Text != "" && carReg_comboBox.Text != "" && customerId_comboBox.Text != "")
            {
                if (!int.TryParse(rentalID_txtbox.Text, out int rentalId) || rentalId <= 0)
                {
                    MessageBox.Show("Rental ID must be a positive number.");
                    return;
                }

                con.Open();

                SqlCommand cmd = new SqlCommand("proc_AddRental", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@rentalid", rentalId);
                cmd.Parameters.AddWithValue("@carregno", carReg_comboBox.Text);
                cmd.Parameters.AddWithValue("@custid", int.Parse(customerId_comboBox.Text));
                cmd.Parameters.AddWithValue("@rentaldate", rentalDate_dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@returndate", returnDate_dateTimePicker.Value);

                SqlParameter outputAmount = new SqlParameter("@totalamount", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputAmount);

                try
                {
                    cmd.ExecuteNonQuery();
                    totalPrice_txtbox.Text = outputAmount.Value.ToString();
                    MessageBox.Show("Rental added successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                con.Close();
                LoadRentals();
                LoadAvailableCars();
            }
            else
            {
                MessageBox.Show("Please fill all required fields.");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (rentalID_txtbox.Text != "" && carReg_comboBox.Text != "" && customerId_comboBox.Text != "")
            {
                if (!int.TryParse(rentalID_txtbox.Text, out int rentalId) || rentalId <= 0)
                {
                    MessageBox.Show("Rental ID must be a positive number.");
                    return;
                }

                con.Open();

                SqlCommand cmd = new SqlCommand("proc_UpdateRental", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@rentalid", rentalId);
                cmd.Parameters.AddWithValue("@carregno", carReg_comboBox.Text);
                cmd.Parameters.AddWithValue("@custid", int.Parse(customerId_comboBox.Text));
                cmd.Parameters.AddWithValue("@rentaldate", rentalDate_dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@returndate", returnDate_dateTimePicker.Value);

                SqlParameter outputAmount = new SqlParameter("@totalamount", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputAmount);

                try
                {
                    cmd.ExecuteNonQuery();
                    totalPrice_txtbox.Text = outputAmount.Value.ToString();
                    MessageBox.Show("Rental added successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                con.Close();
                LoadRentals();
                LoadAvailableCars();
            }
            else
            {
                MessageBox.Show("Please fill all required fields.");
            }
        }



        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (rentalID_txtbox.Text != "")
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this rental?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand getCar = new SqlCommand("SELECT carregno FROM rentals WHERE rentalid = @rental_id", con);
                    getCar.Parameters.AddWithValue("@rental_id", rentalID_txtbox.Text);
                    string carReg = getCar.ExecuteScalar()?.ToString();

                    SqlCommand cmd = new SqlCommand("DELETE FROM rentals WHERE rentalid = @rental_id", con);
                    cmd.Parameters.AddWithValue("@rental_id", rentalID_txtbox.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Rental deleted successfully!");

                    rentalID_txtbox.Clear();
                    carReg_comboBox.SelectedIndex = -1;
                    customerId_comboBox.SelectedIndex = -1;
                    customerName_txtbox.Clear();
                    customerAddress_txtbox.Clear();

                    LoadRentals();
                    LoadAvailableCars();
                }
            }
            else
            {
                MessageBox.Show("Please select a rental to delete.");
            }
        }

        private string originalRentalId = "";

        private void rentals_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = rentals_dataGridView.Rows[e.RowIndex];
                rentalID_txtbox.Text = row.Cells["rentalid"].Value.ToString();
                carReg_comboBox.Text = row.Cells["carregno"].Value.ToString();
                customerId_comboBox.Text = row.Cells["custid"].Value.ToString();
                rentalDate_dateTimePicker.Value = Convert.ToDateTime(row.Cells["rentaldate"].Value);
                returnDate_dateTimePicker.Value = Convert.ToDateTime(row.Cells["returndate"].Value);
                totalPrice_txtbox.Text = row.Cells["totalamount"].Value.ToString();

                originalRentalId = rentalID_txtbox.Text; 
            }
        }

        private void rentalDate_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void returnDate_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void CalculateTotalAmount()
        {
            if (carReg_comboBox.Text != "")
            {
                con.Open();
                SqlCommand priceCmd = new SqlCommand("SELECT price FROM cars WHERE regno = @regno", con);
                priceCmd.Parameters.AddWithValue("@regno", carReg_comboBox.Text);
                object result = priceCmd.ExecuteScalar();
                con.Close();

                if (result != null)
                {
                    int pricePerDay = Convert.ToInt32(result);
                    int days = (returnDate_dateTimePicker.Value.Date - rentalDate_dateTimePicker.Value.Date).Days + 1;

                    if (days <= 0)
                    {
                        totalPrice_txtbox.Text = "0";
                        MessageBox.Show("Return date must be after rental date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int total = pricePerDay * days;
                    totalPrice_txtbox.Text = total.ToString();
                }
            }
        }

        private void rentalID_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

