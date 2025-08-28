namespace Car_rental_system
{
    partial class Rentals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rentals));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel6 = new Panel();
            customerName_txtbox = new TextBox();
            name_lbl = new Label();
            button1 = new Button();
            label1 = new Label();
            rentalID_lbl = new Label();
            carReg_lbl = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            back_btn = new Button();
            rentalsSubheading_lbl = new Label();
            heading_lbl = new Label();
            delete_btn = new Button();
            edit_btn = new Button();
            add_btn = new Button();
            panel5 = new Panel();
            customerId_lbl = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            rentalID_txtbox = new TextBox();
            panel7 = new Panel();
            customerAddress_txtbox = new TextBox();
            address_lbl = new Label();
            rentals_dataGridView = new DataGridView();
            carReg_comboBox = new ComboBox();
            customerId_comboBox = new ComboBox();
            returnDate_dateTimePicker = new DateTimePicker();
            returnDate_lbl = new Label();
            rentalDate_dateTimePicker = new DateTimePicker();
            rentalDate_lbl = new Label();
            panel8 = new Panel();
            totalPrice_txtbox = new TextBox();
            totalPrice_lbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rentals_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 0, 0);
            panel6.Location = new Point(145, 228);
            panel6.Name = "panel6";
            panel6.Size = new Size(189, 2);
            panel6.TabIndex = 66;
            // 
            // customerName_txtbox
            // 
            customerName_txtbox.BackColor = Color.White;
            customerName_txtbox.BorderStyle = BorderStyle.None;
            customerName_txtbox.Cursor = Cursors.IBeam;
            customerName_txtbox.Font = new Font("Book Antiqua", 11.25F);
            customerName_txtbox.ForeColor = Color.Black;
            customerName_txtbox.Location = new Point(149, 210);
            customerName_txtbox.Name = "customerName_txtbox";
            customerName_txtbox.Size = new Size(185, 19);
            customerName_txtbox.TabIndex = 65;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Book Antiqua", 14.25F);
            name_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            name_lbl.Location = new Point(25, 210);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(62, 23);
            name_lbl.TabIndex = 64;
            name_lbl.Text = "Name";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(759, 0);
            button1.TabIndex = 45;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 14.25F);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(604, 88);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 68;
            label1.Text = "Rentals";
            // 
            // rentalID_lbl
            // 
            rentalID_lbl.AutoSize = true;
            rentalID_lbl.Font = new Font("Book Antiqua", 14.25F);
            rentalID_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            rentalID_lbl.Location = new Point(25, 114);
            rentalID_lbl.Name = "rentalID_lbl";
            rentalID_lbl.Size = new Size(91, 23);
            rentalID_lbl.TabIndex = 52;
            rentalID_lbl.Text = "Rental ID";
            // 
            // carReg_lbl
            // 
            carReg_lbl.AutoSize = true;
            carReg_lbl.Font = new Font("Book Antiqua", 14.25F);
            carReg_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            carReg_lbl.Location = new Point(25, 146);
            carReg_lbl.Name = "carReg_lbl";
            carReg_lbl.Size = new Size(100, 23);
            carReg_lbl.TabIndex = 53;
            carReg_lbl.Text = "CarRegNo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 476);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 26);
            panel2.TabIndex = 51;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(back_btn);
            panel1.Controls.Add(rentalsSubheading_lbl);
            panel1.Controls.Add(heading_lbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 71);
            panel1.TabIndex = 50;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(23, 20);
            button2.TabIndex = 69;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // back_btn
            // 
            back_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            back_btn.BackColor = Color.FromArgb(192, 0, 0);
            back_btn.BackgroundImage = (Image)resources.GetObject("back_btn.BackgroundImage");
            back_btn.BackgroundImageLayout = ImageLayout.Stretch;
            back_btn.Cursor = Cursors.Hand;
            back_btn.FlatAppearance.BorderSize = 0;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn.ForeColor = Color.White;
            back_btn.Location = new Point(0, 0);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(1359, 0);
            back_btn.TabIndex = 16;
            back_btn.UseVisualStyleBackColor = false;
            // 
            // rentalsSubheading_lbl
            // 
            rentalsSubheading_lbl.AutoSize = true;
            rentalsSubheading_lbl.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentalsSubheading_lbl.ForeColor = Color.White;
            rentalsSubheading_lbl.Location = new Point(385, 43);
            rentalsSubheading_lbl.Name = "rentalsSubheading_lbl";
            rentalsSubheading_lbl.Size = new Size(139, 18);
            rentalsSubheading_lbl.TabIndex = 1;
            rentalsSubheading_lbl.Text = "Manage Rentals";
            // 
            // heading_lbl
            // 
            heading_lbl.AutoSize = true;
            heading_lbl.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            heading_lbl.ForeColor = Color.White;
            heading_lbl.Location = new Point(332, 3);
            heading_lbl.Name = "heading_lbl";
            heading_lbl.Size = new Size(271, 36);
            heading_lbl.TabIndex = 0;
            heading_lbl.Text = "Car Rental System";
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.FromArgb(192, 0, 0);
            delete_btn.BackgroundImageLayout = ImageLayout.Center;
            delete_btn.Cursor = Cursors.Hand;
            delete_btn.FlatStyle = FlatStyle.Popup;
            delete_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(210, 386);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(78, 31);
            delete_btn.TabIndex = 63;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.FromArgb(192, 0, 0);
            edit_btn.BackgroundImageLayout = ImageLayout.Center;
            edit_btn.Cursor = Cursors.Hand;
            edit_btn.FlatStyle = FlatStyle.Popup;
            edit_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_btn.ForeColor = Color.White;
            edit_btn.Location = new Point(117, 386);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(78, 31);
            edit_btn.TabIndex = 62;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(192, 0, 0);
            add_btn.BackgroundImageLayout = ImageLayout.Center;
            add_btn.Cursor = Cursors.Hand;
            add_btn.FlatStyle = FlatStyle.Popup;
            add_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(27, 386);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(78, 31);
            add_btn.TabIndex = 61;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 0, 0);
            panel5.Location = new Point(145, 195);
            panel5.Name = "panel5";
            panel5.Size = new Size(189, 2);
            panel5.TabIndex = 60;
            // 
            // customerId_lbl
            // 
            customerId_lbl.AutoSize = true;
            customerId_lbl.Font = new Font("Book Antiqua", 14.25F);
            customerId_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            customerId_lbl.Location = new Point(25, 177);
            customerId_lbl.Name = "customerId_lbl";
            customerId_lbl.Size = new Size(118, 23);
            customerId_lbl.TabIndex = 58;
            customerId_lbl.Text = "Customer ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 0, 0);
            panel3.Location = new Point(145, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 2);
            panel3.TabIndex = 57;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 0, 0);
            panel4.Location = new Point(146, 131);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 2);
            panel4.TabIndex = 56;
            // 
            // rentalID_txtbox
            // 
            rentalID_txtbox.BackColor = Color.White;
            rentalID_txtbox.BorderStyle = BorderStyle.None;
            rentalID_txtbox.Cursor = Cursors.IBeam;
            rentalID_txtbox.Font = new Font("Book Antiqua", 11.25F);
            rentalID_txtbox.ForeColor = Color.Black;
            rentalID_txtbox.Location = new Point(149, 114);
            rentalID_txtbox.Name = "rentalID_txtbox";
            rentalID_txtbox.Size = new Size(186, 19);
            rentalID_txtbox.TabIndex = 54;
            rentalID_txtbox.KeyPress += rentalID_txtbox_KeyPress;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(192, 0, 0);
            panel7.Location = new Point(145, 258);
            panel7.Name = "panel7";
            panel7.Size = new Size(189, 2);
            panel7.TabIndex = 75;
            // 
            // customerAddress_txtbox
            // 
            customerAddress_txtbox.BackColor = Color.White;
            customerAddress_txtbox.BorderStyle = BorderStyle.None;
            customerAddress_txtbox.Cursor = Cursors.IBeam;
            customerAddress_txtbox.Font = new Font("Book Antiqua", 11.25F);
            customerAddress_txtbox.ForeColor = Color.Black;
            customerAddress_txtbox.Location = new Point(149, 240);
            customerAddress_txtbox.Name = "customerAddress_txtbox";
            customerAddress_txtbox.Size = new Size(185, 19);
            customerAddress_txtbox.TabIndex = 74;
            // 
            // address_lbl
            // 
            address_lbl.AutoSize = true;
            address_lbl.Font = new Font("Book Antiqua", 14.25F);
            address_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            address_lbl.Location = new Point(24, 240);
            address_lbl.Name = "address_lbl";
            address_lbl.Size = new Size(82, 23);
            address_lbl.TabIndex = 73;
            address_lbl.Text = "Address";
            // 
            // rentals_dataGridView
            // 
            rentals_dataGridView.BackgroundColor = SystemColors.Control;
            rentals_dataGridView.BorderStyle = BorderStyle.None;
            rentals_dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            rentals_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            rentals_dataGridView.ColumnHeadersHeight = 30;
            rentals_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            rentals_dataGridView.Cursor = Cursors.Hand;
            rentals_dataGridView.EnableHeadersVisualStyles = false;
            rentals_dataGridView.GridColor = SystemColors.Window;
            rentals_dataGridView.Location = new Point(359, 114);
            rentals_dataGridView.Name = "rentals_dataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle2.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            rentals_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            rentals_dataGridView.RowHeadersVisible = false;
            rentals_dataGridView.RowTemplate.DividerHeight = 1;
            rentals_dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            rentals_dataGridView.Size = new Size(548, 305);
            rentals_dataGridView.TabIndex = 76;
            rentals_dataGridView.CellContentClick += rentals_dataGridView_CellContentClick;
            // 
            // carReg_comboBox
            // 
            carReg_comboBox.FlatStyle = FlatStyle.Flat;
            carReg_comboBox.Font = new Font("Book Antiqua", 11.25F);
            carReg_comboBox.FormattingEnabled = true;
            carReg_comboBox.Location = new Point(145, 135);
            carReg_comboBox.Name = "carReg_comboBox";
            carReg_comboBox.Size = new Size(189, 28);
            carReg_comboBox.TabIndex = 77;
            // 
            // customerId_comboBox
            // 
            customerId_comboBox.FlatStyle = FlatStyle.Flat;
            customerId_comboBox.Font = new Font("Book Antiqua", 11.25F);
            customerId_comboBox.FormattingEnabled = true;
            customerId_comboBox.Location = new Point(145, 167);
            customerId_comboBox.Name = "customerId_comboBox";
            customerId_comboBox.Size = new Size(189, 28);
            customerId_comboBox.TabIndex = 78;
            customerId_comboBox.SelectedIndexChanged += customerId_comboBox_SelectedIndexChanged;
            // 
            // returnDate_dateTimePicker
            // 
            returnDate_dateTimePicker.CalendarFont = new Font("Book Antiqua", 9F);
            returnDate_dateTimePicker.CalendarMonthBackground = Color.FromArgb(192, 0, 0);
            returnDate_dateTimePicker.CalendarTitleBackColor = Color.FromArgb(192, 0, 0);
            returnDate_dateTimePicker.Location = new Point(144, 306);
            returnDate_dateTimePicker.Name = "returnDate_dateTimePicker";
            returnDate_dateTimePicker.Size = new Size(190, 23);
            returnDate_dateTimePicker.TabIndex = 82;
            returnDate_dateTimePicker.ValueChanged += returnDate_dateTimePicker_ValueChanged;
            // 
            // returnDate_lbl
            // 
            returnDate_lbl.AutoSize = true;
            returnDate_lbl.Font = new Font("Book Antiqua", 14.25F);
            returnDate_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            returnDate_lbl.Location = new Point(24, 306);
            returnDate_lbl.Name = "returnDate_lbl";
            returnDate_lbl.Size = new Size(113, 23);
            returnDate_lbl.TabIndex = 81;
            returnDate_lbl.Text = "Return Date";
            // 
            // rentalDate_dateTimePicker
            // 
            rentalDate_dateTimePicker.CalendarFont = new Font("Book Antiqua", 9F);
            rentalDate_dateTimePicker.CalendarMonthBackground = Color.FromArgb(192, 0, 0);
            rentalDate_dateTimePicker.CalendarTitleBackColor = Color.FromArgb(192, 0, 0);
            rentalDate_dateTimePicker.Location = new Point(144, 273);
            rentalDate_dateTimePicker.Name = "rentalDate_dateTimePicker";
            rentalDate_dateTimePicker.Size = new Size(190, 23);
            rentalDate_dateTimePicker.TabIndex = 80;
            rentalDate_dateTimePicker.ValueChanged += rentalDate_dateTimePicker_ValueChanged;
            // 
            // rentalDate_lbl
            // 
            rentalDate_lbl.AutoSize = true;
            rentalDate_lbl.Font = new Font("Book Antiqua", 14.25F);
            rentalDate_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            rentalDate_lbl.Location = new Point(24, 273);
            rentalDate_lbl.Name = "rentalDate_lbl";
            rentalDate_lbl.Size = new Size(110, 23);
            rentalDate_lbl.TabIndex = 79;
            rentalDate_lbl.Text = "Rental Date";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(192, 0, 0);
            panel8.Location = new Point(147, 353);
            panel8.Name = "panel8";
            panel8.Size = new Size(189, 2);
            panel8.TabIndex = 85;
            // 
            // totalPrice_txtbox
            // 
            totalPrice_txtbox.BackColor = Color.White;
            totalPrice_txtbox.BorderStyle = BorderStyle.None;
            totalPrice_txtbox.Cursor = Cursors.IBeam;
            totalPrice_txtbox.Font = new Font("Book Antiqua", 11.25F);
            totalPrice_txtbox.ForeColor = Color.Black;
            totalPrice_txtbox.Location = new Point(150, 335);
            totalPrice_txtbox.Name = "totalPrice_txtbox";
            totalPrice_txtbox.Size = new Size(185, 19);
            totalPrice_txtbox.TabIndex = 84;
            // 
            // totalPrice_lbl
            // 
            totalPrice_lbl.AutoSize = true;
            totalPrice_lbl.Font = new Font("Book Antiqua", 14.25F);
            totalPrice_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            totalPrice_lbl.Location = new Point(25, 335);
            totalPrice_lbl.Name = "totalPrice_lbl";
            totalPrice_lbl.Size = new Size(101, 23);
            totalPrice_lbl.TabIndex = 83;
            totalPrice_lbl.Text = "Total Price";
            // 
            // Rentals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 502);
            Controls.Add(panel8);
            Controls.Add(totalPrice_txtbox);
            Controls.Add(totalPrice_lbl);
            Controls.Add(returnDate_dateTimePicker);
            Controls.Add(returnDate_lbl);
            Controls.Add(rentalDate_dateTimePicker);
            Controls.Add(rentalDate_lbl);
            Controls.Add(customerId_comboBox);
            Controls.Add(carReg_comboBox);
            Controls.Add(rentals_dataGridView);
            Controls.Add(panel7);
            Controls.Add(customerAddress_txtbox);
            Controls.Add(address_lbl);
            Controls.Add(panel6);
            Controls.Add(customerName_txtbox);
            Controls.Add(name_lbl);
            Controls.Add(label1);
            Controls.Add(rentalID_lbl);
            Controls.Add(carReg_lbl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(add_btn);
            Controls.Add(panel5);
            Controls.Add(customerId_lbl);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(rentalID_txtbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rentals";
            Text = "Rentals";
            Load += Rentals_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rentals_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel6;
        private TextBox customerName_txtbox;
        private Label name_lbl;
        private Button button1;
        private Label label1;
        private Label rentalID_lbl;
        private Label carReg_lbl;
        private Panel panel2;
        private Panel panel1;
        private Button back_btn;
        private Label rentalsSubheading_lbl;
        private Label heading_lbl;
        private Button delete_btn;
        private Button edit_btn;
        private Button add_btn;
        private Panel panel5;
        private Label customerId_lbl;
        private Panel panel3;
        private Panel panel4;
        private TextBox rentalID_txtbox;
        private Button button2;
        private Panel panel7;
        private TextBox customerAddress_txtbox;
        private Label address_lbl;
        private DataGridView rentals_dataGridView;
        private ComboBox carReg_comboBox;
        private ComboBox customerId_comboBox;
        private DateTimePicker returnDate_dateTimePicker;
        private Label returnDate_lbl;
        private DateTimePicker rentalDate_dateTimePicker;
        private Label rentalDate_lbl;
        private Panel panel8;
        private TextBox totalPrice_txtbox;
        private Label totalPrice_lbl;
    }
}