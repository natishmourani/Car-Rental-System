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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Car_rental_system
{

    public partial class returns : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;");

        public returns()
        {
            InitializeComponent();
            carsReturned_dataGridView.CellClick += carsReturned_dataGridView_CellContentClick;
            this.returnid_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.returnid_txtbox_KeyPress);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            

            try
            {
                using (SqlConnection con = new SqlConnection("Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    con.Open();

                    string returnId = returnid_txtbox.Text;
                    string carId = carId_comboBox.Text;
                    DateTime actualReturnDate = returns_dateTimePicker.Value;

                    string query = @"
                SELECT r.rentalid, r.rentaldate, r.returndate, r.totalamount, r.custid, c.custname, cars.price
                FROM rentals r
                INNER JOIN customers c ON r.custid = c.custid
                INNER JOIN cars ON r.carregno = cars.regno
                WHERE r.carregno = @carId";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@carId", carId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("No active rental found for this car.");
                        return;
                    }

                    DateTime expectedReturnDate = Convert.ToDateTime(reader["returndate"]);
                    int rentalAmount = Convert.ToInt32(reader["totalamount"]); 
                    int custId = Convert.ToInt32(reader["custid"]);
                    string custName = reader["custname"].ToString();
                    int pricePerDay = Convert.ToInt32(reader["price"]);

                    name_txtbox.Text = custName;

                    reader.Close();

                    int delayDays = (actualReturnDate - expectedReturnDate).Days;
                    delayDays = delayDays > 0 ? delayDays : 0;

                    int extraRent = delayDays * pricePerDay;
                    int fine = delayDays * 1500;
                    int totalAmount = rentalAmount + extraRent + fine;

                    delay_txtbox.Text = delayDays.ToString();
                    fine_txtbox.Text = fine.ToString();
                    totalAmount_txtbox.Text = totalAmount.ToString();

                    string insertQuery = @"
                INSERT INTO returns (returnid, carid, custid, returndate, delay, fine, totalamount)
                VALUES (@returnid, @carid, @custid, @returndate, @delay, @fine, @totalamount)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@returnid", returnId);
                    insertCmd.Parameters.AddWithValue("@carid", carId);
                    insertCmd.Parameters.AddWithValue("@custid", custId);
                    insertCmd.Parameters.AddWithValue("@returndate", actualReturnDate);
                    insertCmd.Parameters.AddWithValue("@delay", delayDays);
                    insertCmd.Parameters.AddWithValue("@fine", fine);
                    insertCmd.Parameters.AddWithValue("@totalamount", totalAmount);

                    insertCmd.ExecuteNonQuery();

                    string updateCarQuery = "UPDATE cars SET available = 'Yes' WHERE regno = @carId";
                    SqlCommand updateCmd = new SqlCommand(updateCarQuery, con);
                    updateCmd.Parameters.AddWithValue("@carId", carId);
                    updateCmd.ExecuteNonQuery();

                    string deleteRentalQuery = "DELETE FROM rentals WHERE carregno = @carId";
                    SqlCommand deleteCmd = new SqlCommand(deleteRentalQuery, con);
                    deleteCmd.Parameters.AddWithValue("@carId", carId);
                    deleteCmd.ExecuteNonQuery();

                    MessageBox.Show("Return recorded successfully.");
                    LoadReturnsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void returns_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                    SELECT DISTINCT carregno FROM rentals
                    UNION
                    SELECT DISTINCT carid FROM returns WHERE carid NOT IN (SELECT carregno FROM rentals)";


                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        carId_comboBox.Items.Add(reader["carregno"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading car IDs: " + ex.Message);
            }
            LoadReturnsData();
        }
        private void LoadReturnsData()
        {
            try
            {
                string connectionString = "Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    r.returnid, 
                    r.carid, 
                    r.custid, 
                    c.custname, 
                    r.returndate, 
                    r.delay, 
                    r.fine, 
                    r.totalamount
                FROM returns r
                INNER JOIN customers c ON r.custid = c.custid";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    carsReturned_dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading return records: " + ex.Message);
            }
        }


        private void carId_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carId_comboBox.SelectedItem == null) return;

            string carId = carId_comboBox.SelectedItem.ToString();

            string connectionString = "Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"
            SELECT c.custname 
            FROM customers c
            INNER JOIN rentals r ON r.custid = c.custid
            WHERE r.carregno = @carId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@carId", carId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name_txtbox.Text = reader["custname"].ToString();
                }
                reader.Close();
            }

            DateTime actualReturnDate = returns_dateTimePicker.Value;
            RecalculateAmount(carId, actualReturnDate);
        }

        private void returns_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (carId_comboBox.SelectedItem == null) return;

            string carId = carId_comboBox.SelectedItem.ToString();
            DateTime actualReturnDate = returns_dateTimePicker.Value;

            RecalculateAmount(carId, actualReturnDate);

        }

        private void carsReturned_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carsReturned_dataGridView.Rows[e.RowIndex];

                returnid_txtbox.Text = row.Cells["returnid"].Value.ToString();
                string carId = row.Cells["carid"].Value.ToString();

                int index = carId_comboBox.FindStringExact(carId);
                if (index != -1)
                {
                    carId_comboBox.SelectedIndex = index;
                }
                else
                {
                    MessageBox.Show("Car ID not found in dropdown list.");
                    carId_comboBox.SelectedIndex = -1;
                }
;
                name_txtbox.Text = row.Cells["custname"].Value.ToString();
                returns_dateTimePicker.Value = Convert.ToDateTime(row.Cells["returndate"].Value);
                delay_txtbox.Text = row.Cells["delay"].Value.ToString();
                fine_txtbox.Text = row.Cells["fine"].Value.ToString();
                totalAmount_txtbox.Text = row.Cells["totalamount"].Value.ToString();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string carId = carId_comboBox.Text.Trim();
                if (string.IsNullOrEmpty(carId))
                {
                    MessageBox.Show("Please select a car.");
                    return;
                }


                DateTime actualReturnDate = returns_dateTimePicker.Value;

                RecalculateAmount(carId, actualReturnDate);

                using (SqlConnection con = new SqlConnection("Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    con.Open();

                    string query = @"
                UPDATE returns 
                SET carid = @carid, 
                    returndate = @returndate, 
                    delay = @delay, 
                    fine = @fine, 
                    totalamount = @totalamount 
                WHERE returnid = @returnid";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@returnid", returnid_txtbox.Text);
                    cmd.Parameters.AddWithValue("@carid", carId);
                    cmd.Parameters.AddWithValue("@returndate", actualReturnDate);
                    cmd.Parameters.AddWithValue("@delay", delay_txtbox.Text);
                    cmd.Parameters.AddWithValue("@fine", fine_txtbox.Text);
                    cmd.Parameters.AddWithValue("@totalamount", totalAmount_txtbox.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Return record updated successfully.");
                    LoadReturnsData(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating return record: " + ex.Message);
            }


        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string carId = carId_comboBox.Text.Trim();
            if (string.IsNullOrEmpty(carId))
            {
                MessageBox.Show("Please select a car.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this return record?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;"))
                    {
                        con.Open();

                        string query = "DELETE FROM returns WHERE returnid = @returnid";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@returnid", returnid_txtbox.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Return record deleted successfully.");
                        LoadReturnsData(); 
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting return record: " + ex.Message);
                }
            }
        }

        private void RecalculateAmount(string carId, DateTime actualReturnDate)
        {
            string connectionString = "Server=DESKTOP-TUK47GF\\SQLEXPRESS;Database=CarRentalSystem;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
            SELECT r.rentaldate, r.returndate, c.price
            FROM rentals r
            INNER JOIN cars c ON r.carregno = c.regno
            WHERE r.carregno = @carId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@carId", carId);

                SqlDataReader reader = cmd.ExecuteReader();

                DateTime rentDate, expectedReturnDate;
                int pricePerDay;

                if (reader.Read())
                {
                    rentDate = Convert.ToDateTime(reader["rentaldate"]);
                    expectedReturnDate = Convert.ToDateTime(reader["returndate"]);
                    pricePerDay = Convert.ToInt32(reader["price"]);
                }
                else
                {
                    reader.Close();

                    string fallbackQuery = @"
                SELECT r.returndate AS expectedreturndate, r.returndate, r.delay, c.price
                FROM returns r
                INNER JOIN cars c ON r.carid = c.regno
                WHERE r.carid = @carId";

                    cmd = new SqlCommand(fallbackQuery, con);
                    cmd.Parameters.AddWithValue("@carId", carId);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        expectedReturnDate = Convert.ToDateTime(reader["expectedreturndate"]);
                        rentDate = expectedReturnDate.AddDays(-1); 
                        pricePerDay = Convert.ToInt32(reader["price"]);
                    }
                    else
                    {
                        reader.Close();
                        return;
                    }
                }

                reader.Close();

                int originalDays = (expectedReturnDate - rentDate).Days + 1;
                if (originalDays <= 0) originalDays = 1;

                int delayDays = (actualReturnDate - expectedReturnDate).Days;
                delayDays = delayDays > 0 ? delayDays : 0;

                int fine = delayDays * 1500;
                int totalRent = (originalDays + delayDays) * pricePerDay;
                int totalAmount = totalRent + fine;

                delay_txtbox.Text = delayDays.ToString();
                fine_txtbox.Text = fine.ToString();
                totalAmount_txtbox.Text = totalAmount.ToString();
            }
        }



        private void ClearForm()
        {
            returnid_txtbox.Clear();
            carId_comboBox.SelectedIndex = -1;
            name_txtbox.Clear();
            returns_dateTimePicker.Value = DateTime.Today;
            delay_txtbox.Clear();
            fine_txtbox.Clear();
            totalAmount_txtbox.Clear();
        }

        private void returnid_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
