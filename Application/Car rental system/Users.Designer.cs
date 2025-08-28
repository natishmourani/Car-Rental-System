namespace Car_rental_system
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel1 = new Panel();
            back_btn = new Button();
            UsersSubheading_lbl = new Label();
            heading_lbl = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            userName_txtbox = new TextBox();
            userID_txtbox = new TextBox();
            name_lbl = new Label();
            ID_lbl = new Label();
            panel5 = new Panel();
            userPassword_txtbox = new TextBox();
            password_lbl = new Label();
            add_btn = new Button();
            edit_btn = new Button();
            delete_btn = new Button();
            label1 = new Label();
            users_dataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)users_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 439);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 26);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(back_btn);
            panel1.Controls.Add(UsersSubheading_lbl);
            panel1.Controls.Add(heading_lbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 71);
            panel1.TabIndex = 3;
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
            back_btn.Location = new Point(-2, 0);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(24, 19);
            back_btn.TabIndex = 16;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click_1;
            // 
            // UsersSubheading_lbl
            // 
            UsersSubheading_lbl.AutoSize = true;
            UsersSubheading_lbl.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsersSubheading_lbl.ForeColor = Color.White;
            UsersSubheading_lbl.Location = new Point(339, 43);
            UsersSubheading_lbl.Name = "UsersSubheading_lbl";
            UsersSubheading_lbl.Size = new Size(122, 18);
            UsersSubheading_lbl.TabIndex = 1;
            UsersSubheading_lbl.Text = "Manage Users";
            // 
            // heading_lbl
            // 
            heading_lbl.AutoSize = true;
            heading_lbl.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            heading_lbl.ForeColor = Color.White;
            heading_lbl.Location = new Point(265, 3);
            heading_lbl.Name = "heading_lbl";
            heading_lbl.Size = new Size(271, 36);
            heading_lbl.TabIndex = 0;
            heading_lbl.Text = "Car Rental System";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 0, 0);
            panel3.Location = new Point(140, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 2);
            panel3.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 0, 0);
            panel4.Location = new Point(141, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(167, 2);
            panel4.TabIndex = 20;
            // 
            // userName_txtbox
            // 
            userName_txtbox.BackColor = Color.White;
            userName_txtbox.BorderStyle = BorderStyle.None;
            userName_txtbox.Cursor = Cursors.IBeam;
            userName_txtbox.Font = new Font("Book Antiqua", 11.25F);
            userName_txtbox.ForeColor = Color.Black;
            userName_txtbox.Location = new Point(143, 161);
            userName_txtbox.Name = "userName_txtbox";
            userName_txtbox.Size = new Size(164, 19);
            userName_txtbox.TabIndex = 19;
            // 
            // userID_txtbox
            // 
            userID_txtbox.BackColor = Color.White;
            userID_txtbox.BorderStyle = BorderStyle.None;
            userID_txtbox.Cursor = Cursors.IBeam;
            userID_txtbox.Font = new Font("Book Antiqua", 11.25F);
            userID_txtbox.ForeColor = Color.Black;
            userID_txtbox.Location = new Point(143, 129);
            userID_txtbox.Name = "userID_txtbox";
            userID_txtbox.Size = new Size(164, 19);
            userID_txtbox.TabIndex = 18;
            userID_txtbox.KeyPress += userID_txtbox_KeyPress;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Book Antiqua", 14.25F);
            name_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            name_lbl.Location = new Point(31, 161);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(62, 23);
            name_lbl.TabIndex = 17;
            name_lbl.Text = "Name";
            // 
            // ID_lbl
            // 
            ID_lbl.AutoSize = true;
            ID_lbl.Font = new Font("Book Antiqua", 14.25F);
            ID_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            ID_lbl.Location = new Point(31, 129);
            ID_lbl.Name = "ID_lbl";
            ID_lbl.Size = new Size(31, 23);
            ID_lbl.TabIndex = 16;
            ID_lbl.Text = "ID";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 0, 0);
            panel5.Location = new Point(140, 210);
            panel5.Name = "panel5";
            panel5.Size = new Size(166, 2);
            panel5.TabIndex = 27;
            // 
            // userPassword_txtbox
            // 
            userPassword_txtbox.BackColor = Color.White;
            userPassword_txtbox.BorderStyle = BorderStyle.None;
            userPassword_txtbox.Cursor = Cursors.IBeam;
            userPassword_txtbox.Font = new Font("Book Antiqua", 11.25F);
            userPassword_txtbox.ForeColor = Color.Black;
            userPassword_txtbox.Location = new Point(143, 192);
            userPassword_txtbox.Name = "userPassword_txtbox";
            userPassword_txtbox.Size = new Size(163, 19);
            userPassword_txtbox.TabIndex = 25;
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.Font = new Font("Book Antiqua", 14.25F);
            password_lbl.ForeColor = Color.FromArgb(192, 0, 0);
            password_lbl.Location = new Point(31, 192);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(93, 23);
            password_lbl.TabIndex = 23;
            password_lbl.Text = "Password";
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(192, 0, 0);
            add_btn.BackgroundImageLayout = ImageLayout.Center;
            add_btn.Cursor = Cursors.Hand;
            add_btn.FlatStyle = FlatStyle.Popup;
            add_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(34, 270);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(78, 31);
            add_btn.TabIndex = 28;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.FromArgb(192, 0, 0);
            edit_btn.BackgroundImageLayout = ImageLayout.Center;
            edit_btn.Cursor = Cursors.Hand;
            edit_btn.FlatStyle = FlatStyle.Popup;
            edit_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_btn.ForeColor = Color.White;
            edit_btn.Location = new Point(124, 270);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(78, 31);
            edit_btn.TabIndex = 29;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.FromArgb(192, 0, 0);
            delete_btn.BackgroundImageLayout = ImageLayout.Center;
            delete_btn.Cursor = Cursors.Hand;
            delete_btn.FlatStyle = FlatStyle.Popup;
            delete_btn.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(217, 270);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(78, 31);
            delete_btn.TabIndex = 30;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 14.25F);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(525, 88);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 32;
            label1.Text = "Users";
            // 
            // users_dataGridView
            // 
            users_dataGridView.BackgroundColor = SystemColors.Control;
            users_dataGridView.BorderStyle = BorderStyle.None;
            users_dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            users_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            users_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            users_dataGridView.Cursor = Cursors.Hand;
            users_dataGridView.EnableHeadersVisualStyles = false;
            users_dataGridView.GridColor = SystemColors.Window;
            users_dataGridView.Location = new Point(381, 117);
            users_dataGridView.Name = "users_dataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle2.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            users_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            users_dataGridView.RowHeadersVisible = false;
            users_dataGridView.RowTemplate.DividerHeight = 1;
            users_dataGridView.RowTemplate.Resizable = DataGridViewTriState.True;
            users_dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            users_dataGridView.Size = new Size(345, 293);
            users_dataGridView.TabIndex = 52;
            users_dataGridView.CellContentClick += users_dataGridView_CellContentClick;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(767, 465);
            Controls.Add(users_dataGridView);
            Controls.Add(label1);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(add_btn);
            Controls.Add(panel5);
            Controls.Add(userPassword_txtbox);
            Controls.Add(password_lbl);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(userName_txtbox);
            Controls.Add(userID_txtbox);
            Controls.Add(name_lbl);
            Controls.Add(ID_lbl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)users_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label UsersSubheading_lbl;
        private Label heading_lbl;
        private Panel panel3;
        private Panel panel4;
        private TextBox userName_txtbox;
        private TextBox userID_txtbox;
        private Label name_lbl;
        private Label ID_lbl;
        private Panel panel5;
        private TextBox userPassword_txtbox;
        private Label password_lbl;
        private Button add_btn;
        private Button edit_btn;
        private Button delete_btn;
        private Button back_btn;
        private Label label1;
        private DataGridView users_dataGridView;
    }
}