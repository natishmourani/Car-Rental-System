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
    public partial class customers : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;");

        public customers()
        {
            InitializeComponent();
        }
        private void LoadCustomers()
        {
            con.Open();
            string query = "SELECT * FROM customers";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            customers_dataGridView.DataSource = dt;
            con.Close();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (custID_txtbox.Text == "" || custName_txtbox.Text == "" || address_txtbox.Text == "" || phone_txtbox.Text == "") 
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!int.TryParse(custID_txtbox.Text, out int custID) || custID <= 0)
            {
                MessageBox.Show("Customer ID must be a positive number.");
                return;
            }

            con.Open();
            SqlCommand checkIdCmd = new SqlCommand("SELECT COUNT(*) FROM customers WHERE custid = @custID", con);
            checkIdCmd.Parameters.AddWithValue("@custID", custID);
            int count = (int)checkIdCmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Customer ID already exists. Please enter a unique ID.");
                return;
            }

            con.Open();
            string query = "INSERT INTO customers (custid, custname, custaddress, custphone) VALUES (@cust_id, @name, @address, @phone)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@cust_id", custID);
            cmd.Parameters.AddWithValue("@name", custName_txtbox.Text);
            cmd.Parameters.AddWithValue("@address", address_txtbox.Text);
            cmd.Parameters.AddWithValue("@phone", phone_txtbox.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Customer added successfully!");
            LoadCustomers();

        }

        private string originalCustomerId = "";

        private void customers_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customers_dataGridView.Rows[e.RowIndex];
                custID_txtbox.Text = row.Cells["custid"].Value.ToString();
                custName_txtbox.Text = row.Cells["custname"].Value.ToString();
                address_txtbox.Text = row.Cells["custaddress"].Value.ToString();
                phone_txtbox.Text = row.Cells["custphone"].Value.ToString();

                originalCustomerId = custID_txtbox.Text;
            }
        }

         private void edit_btn_Click(object sender, EventArgs e)
        {
            if (custID_txtbox.Text == "" || custName_txtbox.Text == "" || address_txtbox.Text == "" || phone_txtbox.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!int.TryParse(custID_txtbox.Text, out int newID) || newID <= 0)
            {
                MessageBox.Show("Customer ID must be a positive number.");
                return;
            }

            if (custID_txtbox.Text != originalCustomerId)
            {
                con.Open();
                SqlCommand checkIdCmd = new SqlCommand("SELECT COUNT(*) FROM customers WHERE custid = @custID", con);
                checkIdCmd.Parameters.AddWithValue("@custID", newID);
                int count = (int)checkIdCmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Another customer with this ID already exists. Please use a different ID.");
                    return;
                }
            }

            con.Open();
            SqlCommand updateCmd = new SqlCommand("UPDATE customers SET custid = @newID, custname = @name, custaddress = @address, custphone = @phone WHERE custid = @originalID", con);
            updateCmd.Parameters.AddWithValue("@newID", newID);
            updateCmd.Parameters.AddWithValue("@name", custName_txtbox.Text);
            updateCmd.Parameters.AddWithValue("@address", address_txtbox.Text);
            updateCmd.Parameters.AddWithValue("@phone", phone_txtbox.Text);
            updateCmd.Parameters.AddWithValue("@originalID", originalCustomerId);
            updateCmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Customer updated successfully!");
            LoadCustomers();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (custID_txtbox.Text != "")
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this customer?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    con.Open();
                    string query = "DELETE FROM customers WHERE custid = @cust_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cust_id", custID_txtbox.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Customer deleted successfully!");

                    custID_txtbox.Clear();
                    custName_txtbox.Clear();
                    address_txtbox.Clear();
                    phone_txtbox.Clear();

                    LoadCustomers();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void backButton_btn_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void custID_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phone_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

