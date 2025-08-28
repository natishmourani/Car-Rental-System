namespace Car_rental_system
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            panel1 = new Panel();
            slogan_lbl = new Label();
            heading_lbl = new Label();
            carlogopictureBox1 = new PictureBox();
            login_btn = new Button();
            password_txtbox = new TextBox();
            username_txtbox = new TextBox();
            password_lbl = new Label();
            username_lbl = new Label();
            login_lbl = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            exit_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carlogopictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(slogan_lbl);
            panel1.Controls.Add(heading_lbl);
            panel1.Controls.Add(carlogopictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 450);
            panel1.TabIndex = 7;
            // 
            // slogan_lbl
            // 
            slogan_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            slogan_lbl.AutoSize = true;
            slogan_lbl.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            slogan_lbl.ForeColor = Color.White;
            slogan_lbl.Location = new Point(47, 325);
            slogan_lbl.Name = "slogan_lbl";
            slogan_lbl.Size = new Size(203, 20);
            slogan_lbl.TabIndex = 2;
            slogan_lbl.Text = "Your Journey, Our Wheels.";
            // 
            // heading_lbl
            // 
            heading_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            heading_lbl.AutoSize = true;
            heading_lbl.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            heading_lbl.ForeColor = Color.White;
            heading_lbl.Location = new Point(35, 55);
            heading_lbl.Name = "heading_lbl";
            heading_lbl.Size = new Size(244, 32);
            heading_lbl.TabIndex = 1;
            heading_lbl.Text = "Car Rental System";
            // 
            // carlogopictureBox1
            // 
            carlogopictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carlogopictureBox1.Image = (Image)resources.GetObject("carlogopictureBox1.Image");
            carlogopictureBox1.Location = new Point(62, 124);
            carlogopictureBox1.Name = "carlogopictureBox1";
            carlogopictureBox1.Size = new Size(194, 155);
            carlogopictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            carlogopictureBox1.TabIndex = 0;
            carlogopictureBox1.TabStop = false;
            // 
            // login_btn
            // 
            login_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login_btn.BackColor = Color.FromArgb(192, 0, 0);
            login_btn.BackgroundImageLayout = ImageLayout.Center;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Popup;
            login_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(517, 327);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(136, 28);
            login_btn.TabIndex = 13;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // password_txtbox
            // 
            password_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            password_txtbox.BackColor = Color.White;
            password_txtbox.BorderStyle = BorderStyle.None;
            password_txtbox.Cursor = Cursors.IBeam;
            password_txtbox.Font = new Font("Book Antiqua", 11.25F);
            password_txtbox.ForeColor = Color.Black;
            password_txtbox.Location = new Point(497, 207);
            password_txtbox.Name = "password_txtbox";
            password_txtbox.PasswordChar = '.';
            password_txtbox.Size = new Size(195, 19);
            password_txtbox.TabIndex = 12;
            password_txtbox.UseSystemPasswordChar = true;
            // 
            // username_txtbox
            // 
            username_txtbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username_txtbox.BackColor = Color.White;
            username_txtbox.BorderStyle = BorderStyle.None;
            username_txtbox.Cursor = Cursors.IBeam;
            username_txtbox.Font = new Font("Book Antiqua", 11.25F);
            username_txtbox.ForeColor = Color.Black;
            username_txtbox.Location = new Point(497, 151);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Size = new Size(195, 19);
            username_txtbox.TabIndex = 11;
            username_txtbox.TextChanged += username_txtbox_TextChanged;
            // 
            // password_lbl
            // 
            password_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            password_lbl.AutoSize = true;
            password_lbl.Font = new Font("Book Antiqua", 14.25F);
            password_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            password_lbl.Location = new Point(385, 210);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(93, 23);
            password_lbl.TabIndex = 10;
            password_lbl.Text = "Password";
            // 
            // username_lbl
            // 
            username_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Book Antiqua", 14.25F);
            username_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            username_lbl.Location = new Point(385, 154);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(97, 23);
            username_lbl.TabIndex = 9;
            username_lbl.Text = "Username";
            // 
            // login_lbl
            // 
            login_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login_lbl.AutoSize = true;
            login_lbl.Font = new Font("Book Antiqua", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            login_lbl.Location = new Point(532, 57);
            login_lbl.Name = "login_lbl";
            login_lbl.Size = new Size(87, 32);
            login_lbl.TabIndex = 8;
            login_lbl.Text = "Login";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Location = new Point(495, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 2);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(192, 0, 0);
            panel3.Location = new Point(494, 231);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 2);
            panel3.TabIndex = 15;
            // 
            // exit_btn
            // 
            exit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exit_btn.BackColor = Color.White;
            exit_btn.BackgroundImageLayout = ImageLayout.Center;
            exit_btn.Cursor = Cursors.Hand;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit_btn.ForeColor = Color.FromArgb(192, 0, 0);
            exit_btn.Location = new Point(777, -2);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(33, 31);
            exit_btn.TabIndex = 16;
            exit_btn.Text = "X";
            exit_btn.TextAlign = ContentAlignment.MiddleRight;
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(810, 450);
            Controls.Add(exit_btn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(login_btn);
            Controls.Add(password_txtbox);
            Controls.Add(username_txtbox);
            Controls.Add(password_lbl);
            Controls.Add(username_lbl);
            Controls.Add(login_lbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signin";
            Text = "Signin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carlogopictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label slogan_lbl;
        private Label heading_lbl;
        private PictureBox carlogopictureBox1;
        private Button login_btn;
        private TextBox password_txtbox;
        private TextBox username_txtbox;
        private Label password_lbl;
        private Label username_lbl;
        private Label login_lbl;
        private Panel panel2;
        private Panel panel3;
        private Button exit_btn;
    }
}