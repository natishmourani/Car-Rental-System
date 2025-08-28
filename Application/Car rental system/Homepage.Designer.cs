namespace Car_rental_system
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            panel1 = new Panel();
            homepageSubheading_lbl = new Label();
            heading_lbl = new Label();
            panel2 = new Panel();
            carlogopictureBox1 = new PictureBox();
            cars_btn = new Button();
            customers_btn = new Button();
            rentals_btn = new Button();
            users_btn = new Button();
            Logout_btn = new Button();
            returns_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carlogopictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(homepageSubheading_lbl);
            panel1.Controls.Add(heading_lbl);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 72);
            panel1.TabIndex = 0;
            // 
            // homepageSubheading_lbl
            // 
            homepageSubheading_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homepageSubheading_lbl.AutoSize = true;
            homepageSubheading_lbl.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homepageSubheading_lbl.ForeColor = Color.White;
            homepageSubheading_lbl.Location = new Point(365, 43);
            homepageSubheading_lbl.Name = "homepageSubheading_lbl";
            homepageSubheading_lbl.Size = new Size(96, 18);
            homepageSubheading_lbl.TabIndex = 1;
            homepageSubheading_lbl.Text = "Homepage";
            // 
            // heading_lbl
            // 
            heading_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            heading_lbl.AutoSize = true;
            heading_lbl.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            heading_lbl.ForeColor = Color.White;
            heading_lbl.Location = new Point(278, 3);
            heading_lbl.Name = "heading_lbl";
            heading_lbl.Size = new Size(271, 36);
            heading_lbl.TabIndex = 0;
            heading_lbl.Text = "Car Rental System";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Location = new Point(0, 424);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 27);
            panel2.TabIndex = 2;
            // 
            // carlogopictureBox1
            // 
            carlogopictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carlogopictureBox1.Image = (Image)resources.GetObject("carlogopictureBox1.Image");
            carlogopictureBox1.Location = new Point(254, 230);
            carlogopictureBox1.Name = "carlogopictureBox1";
            carlogopictureBox1.Size = new Size(303, 159);
            carlogopictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            carlogopictureBox1.TabIndex = 3;
            carlogopictureBox1.TabStop = false;
            // 
            // cars_btn
            // 
            cars_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cars_btn.BackColor = Color.FromArgb(192, 0, 0);
            cars_btn.BackgroundImageLayout = ImageLayout.Center;
            cars_btn.Cursor = Cursors.Hand;
            cars_btn.FlatStyle = FlatStyle.Popup;
            cars_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cars_btn.ForeColor = Color.White;
            cars_btn.Location = new Point(40, 107);
            cars_btn.Name = "cars_btn";
            cars_btn.Size = new Size(96, 32);
            cars_btn.TabIndex = 14;
            cars_btn.Text = "Cars";
            cars_btn.UseVisualStyleBackColor = false;
            cars_btn.Click += cars_btn_Click;
            // 
            // customers_btn
            // 
            customers_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customers_btn.BackColor = Color.FromArgb(192, 0, 0);
            customers_btn.BackgroundImageLayout = ImageLayout.Center;
            customers_btn.Cursor = Cursors.Hand;
            customers_btn.FlatStyle = FlatStyle.Popup;
            customers_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customers_btn.ForeColor = Color.White;
            customers_btn.Location = new Point(170, 107);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(96, 32);
            customers_btn.TabIndex = 15;
            customers_btn.Text = "Customers";
            customers_btn.UseVisualStyleBackColor = false;
            customers_btn.Click += customers_btn_Click;
            // 
            // rentals_btn
            // 
            rentals_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rentals_btn.BackColor = Color.FromArgb(192, 0, 0);
            rentals_btn.BackgroundImageLayout = ImageLayout.Center;
            rentals_btn.Cursor = Cursors.Hand;
            rentals_btn.FlatStyle = FlatStyle.Popup;
            rentals_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentals_btn.ForeColor = Color.White;
            rentals_btn.Location = new Point(300, 107);
            rentals_btn.Name = "rentals_btn";
            rentals_btn.Size = new Size(96, 32);
            rentals_btn.TabIndex = 16;
            rentals_btn.Text = "Rentals";
            rentals_btn.UseVisualStyleBackColor = false;
            rentals_btn.Click += rentals_btn_Click;
            // 
            // users_btn
            // 
            users_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            users_btn.BackColor = Color.FromArgb(192, 0, 0);
            users_btn.BackgroundImageLayout = ImageLayout.Center;
            users_btn.Cursor = Cursors.Hand;
            users_btn.FlatStyle = FlatStyle.Popup;
            users_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            users_btn.ForeColor = Color.White;
            users_btn.Location = new Point(430, 107);
            users_btn.Name = "users_btn";
            users_btn.Size = new Size(96, 32);
            users_btn.TabIndex = 17;
            users_btn.Text = "Users";
            users_btn.UseVisualStyleBackColor = false;
            users_btn.Click += users_btn_Click;
            // 
            // Logout_btn
            // 
            Logout_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Logout_btn.BackColor = Color.FromArgb(192, 0, 0);
            Logout_btn.BackgroundImageLayout = ImageLayout.Center;
            Logout_btn.Cursor = Cursors.Hand;
            Logout_btn.FlatStyle = FlatStyle.Popup;
            Logout_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logout_btn.ForeColor = Color.White;
            Logout_btn.Location = new Point(687, 107);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(96, 32);
            Logout_btn.TabIndex = 18;
            Logout_btn.Text = "Logout";
            Logout_btn.UseVisualStyleBackColor = false;
            Logout_btn.Click += Logout_btn_Click;
            // 
            // returns_btn
            // 
            returns_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            returns_btn.BackColor = Color.FromArgb(192, 0, 0);
            returns_btn.BackgroundImageLayout = ImageLayout.Center;
            returns_btn.Cursor = Cursors.Hand;
            returns_btn.FlatStyle = FlatStyle.Popup;
            returns_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returns_btn.ForeColor = Color.White;
            returns_btn.Location = new Point(560, 107);
            returns_btn.Name = "returns_btn";
            returns_btn.Size = new Size(96, 32);
            returns_btn.TabIndex = 19;
            returns_btn.Text = "Returns";
            returns_btn.UseVisualStyleBackColor = false;
            returns_btn.Click += returns_btn_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(827, 451);
            Controls.Add(returns_btn);
            Controls.Add(Logout_btn);
            Controls.Add(users_btn);
            Controls.Add(rentals_btn);
            Controls.Add(customers_btn);
            Controls.Add(cars_btn);
            Controls.Add(carlogopictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homepage";
            Text = "Homepage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carlogopictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label heading_lbl;
        private Label homepageSubheading_lbl;
        private Panel panel2;
        private PictureBox carlogopictureBox1;
        private Button cars_btn;
        private Button customers_btn;
        private Button rentals_btn;
        private Button users_btn;
        private Button Logout_btn;
        private Button returns_btn;
    }
}