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
    public partial class Cars : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;");

        public Cars()
        {
            InitializeComponent();
        }

        private void LoadCars()
        {
            con.Open();
            string query = "SELECT * FROM cars";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cars_dataGridView.DataSource = dt;  
            con.Close();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            LoadCars();
        }


        private void add_btn_Click(object sender, EventArgs e)
        {
            if (regno_txtbox.Text != "" && brand_txtbox.Text != "" && model_txtbox.Text != "" && price_txtbox.Text != "" && availability_comboBox.Text != "")
            {
                con.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM cars WHERE regno = @regno", con);
                checkCmd.Parameters.AddWithValue("@regno", regno_txtbox.Text);
                int count = (int)checkCmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("A car with this registration number already exists. Please use a unique registration number.");
                    return;
                }

                con.Open();
                string query = "INSERT INTO cars (regno, brand, model, price, available) VALUES (@regno, @brand, @model, @price, @available)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@regno", regno_txtbox.Text);
                cmd.Parameters.AddWithValue("@brand", brand_txtbox.Text);
                cmd.Parameters.AddWithValue("@model", model_txtbox.Text);
                cmd.Parameters.AddWithValue("@price", price_txtbox.Text);
                cmd.Parameters.AddWithValue("@available", availability_comboBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Car added successfully!");
                LoadCars();
            }
            else
            {
                MessageBox.Show("Please fill all fields!");
            }
        }

        private string originalRegNo = "";

        private void cars_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = cars_dataGridView.Rows[e.RowIndex];
                regno_txtbox.Text = row.Cells["regno"].Value.ToString();
                brand_txtbox.Text = row.Cells["brand"].Value.ToString();
                model_txtbox.Text = row.Cells["model"].Value.ToString();
                price_txtbox.Text = row.Cells["price"].Value.ToString();
                availability_comboBox.Text = row.Cells["available"].Value.ToString();

                originalRegNo = regno_txtbox.Text;
            }

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (regno_txtbox.Text == "" || brand_txtbox.Text == "" || model_txtbox.Text == "" || price_txtbox.Text == "" || availability_comboBox.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (regno_txtbox.Text != originalRegNo)
            {
                con.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM cars WHERE regno = @regno", con);
                checkCmd.Parameters.AddWithValue("@regno", regno_txtbox.Text);
                int count = (int)checkCmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Another car with this registration number already exists. Please use a unique one.");
                    return;
                }
            }

            con.Open();
            string query = "UPDATE cars SET regno=@newRegno, brand=@brand, model=@model, price=@price, available=@available WHERE regno=@originalRegno";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@newRegno", regno_txtbox.Text);
            cmd.Parameters.AddWithValue("@brand", brand_txtbox.Text);
            cmd.Parameters.AddWithValue("@model", model_txtbox.Text);
            cmd.Parameters.AddWithValue("@price", price_txtbox.Text);
            cmd.Parameters.AddWithValue("@available", availability_comboBox.Text);
            cmd.Parameters.AddWithValue("@originalRegno", originalRegNo);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Car updated successfully!");
            LoadCars();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (regno_txtbox.Text != "")
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this car?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    con.Open();
                    string query = "DELETE FROM cars WHERE regno = @regno";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@regno", regno_txtbox.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Car deleted successfully!");
                    regno_txtbox.Clear();
                    brand_txtbox.Clear();
                    model_txtbox.Clear();
                    price_txtbox.Clear();
                    availability_comboBox.SelectedIndex = -1;

                    LoadCars(); 
                }
            }
            else
            {
                MessageBox.Show("Please select a car to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Close();
        }
    }
}
