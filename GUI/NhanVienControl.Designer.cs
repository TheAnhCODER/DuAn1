namespace GUI
{
    partial class NhanVienControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienControl));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_ten = new TextBox();
            txt_diachi = new TextBox();
            txt_sdt = new TextBox();
            txt_email = new TextBox();
            date_picker = new DateTimePicker();
            txt_matkhau = new TextBox();
            cb_chucvu = new ComboBox();
            rb_nam = new RadioButton();
            rb_nu = new RadioButton();
            colorDialog1 = new ColorDialog();
            btn_them = new Button();
            btn_capnhat = new Button();
            btn_lammoi = new Button();
            dgv_data = new DataGridView();
            txt_timkiem = new TextBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(522, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 48);
            label1.TabIndex = 0;
            label1.Text = "Nhân Viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1172, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 28);
            label2.TabIndex = 3;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 495);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 3;
            label3.Text = "Chức Vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 375);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 246);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 246);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 3;
            label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 375);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 3;
            label7.Text = "Mật Khẩu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 116);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(44, 25);
            label8.TabIndex = 3;
            label8.Text = "SĐT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 521);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(81, 25);
            label9.TabIndex = 3;
            label9.Text = "Giới Tính";
            // 
            // txt_ten
            // 
            txt_ten.BorderStyle = BorderStyle.FixedSingle;
            txt_ten.Font = new Font("Segoe UI", 10F);
            txt_ten.Location = new Point(61, 146);
            txt_ten.Margin = new Padding(4, 5, 4, 5);
            txt_ten.Multiline = true;
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(290, 37);
            txt_ten.TabIndex = 4;
            // 
            // txt_diachi
            // 
            txt_diachi.BorderStyle = BorderStyle.FixedSingle;
            txt_diachi.Font = new Font("Segoe UI", 10F);
            txt_diachi.Location = new Point(61, 276);
            txt_diachi.Margin = new Padding(4, 5, 4, 5);
            txt_diachi.Multiline = true;
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(290, 37);
            txt_diachi.TabIndex = 5;
            // 
            // txt_sdt
            // 
            txt_sdt.BorderStyle = BorderStyle.FixedSingle;
            txt_sdt.Font = new Font("Segoe UI", 10F);
            txt_sdt.Location = new Point(426, 146);
            txt_sdt.Margin = new Padding(4, 5, 4, 5);
            txt_sdt.Multiline = true;
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(331, 37);
            txt_sdt.TabIndex = 6;
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Font = new Font("Segoe UI", 10F);
            txt_email.ForeColor = Color.Black;
            txt_email.Location = new Point(426, 275);
            txt_email.Margin = new Padding(4, 5, 4, 5);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(331, 38);
            txt_email.TabIndex = 7;
            // 
            // date_picker
            // 
            date_picker.CalendarMonthBackground = Color.White;
            date_picker.CalendarTitleBackColor = Color.Black;
            date_picker.CalendarTrailingForeColor = SystemColors.Desktop;
            date_picker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_picker.Location = new Point(428, 405);
            date_picker.Margin = new Padding(4, 5, 4, 5);
            date_picker.Name = "date_picker";
            date_picker.Size = new Size(329, 39);
            date_picker.TabIndex = 8;
            // 
            // txt_matkhau
            // 
            txt_matkhau.BorderStyle = BorderStyle.FixedSingle;
            txt_matkhau.Font = new Font("Segoe UI", 10F);
            txt_matkhau.Location = new Point(61, 405);
            txt_matkhau.Margin = new Padding(4, 5, 4, 5);
            txt_matkhau.Multiline = true;
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(290, 38);
            txt_matkhau.TabIndex = 9;
            // 
            // cb_chucvu
            // 
            cb_chucvu.BackColor = Color.White;
            cb_chucvu.Font = new Font("Segoe UI", 10F);
            cb_chucvu.ForeColor = Color.Black;
            cb_chucvu.FormattingEnabled = true;
            cb_chucvu.Location = new Point(426, 525);
            cb_chucvu.Margin = new Padding(4, 5, 4, 5);
            cb_chucvu.Name = "cb_chucvu";
            cb_chucvu.Size = new Size(331, 36);
            cb_chucvu.TabIndex = 10;
            // 
            // rb_nam
            // 
            rb_nam.AutoSize = true;
            rb_nam.Location = new Point(190, 519);
            rb_nam.Margin = new Padding(4, 5, 4, 5);
            rb_nam.Name = "rb_nam";
            rb_nam.Size = new Size(75, 29);
            rb_nam.TabIndex = 11;
            rb_nam.TabStop = true;
            rb_nam.Text = "Nam";
            rb_nam.UseVisualStyleBackColor = true;
            // 
            // rb_nu
            // 
            rb_nu.AutoSize = true;
            rb_nu.Location = new Point(299, 519);
            rb_nu.Margin = new Padding(4, 5, 4, 5);
            rb_nu.Name = "rb_nu";
            rb_nu.Size = new Size(61, 29);
            rb_nu.TabIndex = 12;
            rb_nu.TabStop = true;
            rb_nu.Text = "Nữ";
            rb_nu.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.BackColor = Color.FromArgb(29, 135, 209);
            btn_them.Cursor = Cursors.Hand;
            btn_them.FlatStyle = FlatStyle.Flat;
            btn_them.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_them.ForeColor = Color.White;
            btn_them.Image = (Image)resources.GetObject("btn_them.Image");
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(913, 135);
            btn_them.Margin = new Padding(4, 5, 4, 5);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(180, 71);
            btn_them.TabIndex = 14;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            // 
            // btn_capnhat
            // 
            btn_capnhat.BackColor = Color.FromArgb(29, 135, 209);
            btn_capnhat.Cursor = Cursors.Hand;
            btn_capnhat.FlatStyle = FlatStyle.Flat;
            btn_capnhat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_capnhat.ForeColor = Color.White;
            btn_capnhat.Image = (Image)resources.GetObject("btn_capnhat.Image");
            btn_capnhat.ImageAlign = ContentAlignment.MiddleLeft;
            btn_capnhat.Location = new Point(913, 243);
            btn_capnhat.Margin = new Padding(4, 5, 4, 5);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(180, 71);
            btn_capnhat.TabIndex = 15;
            btn_capnhat.Text = "      Cập Nhật";
            btn_capnhat.UseVisualStyleBackColor = false;
            // 
            // btn_lammoi
            // 
            btn_lammoi.BackColor = Color.FromArgb(29, 135, 209);
            btn_lammoi.Cursor = Cursors.Hand;
            btn_lammoi.FlatStyle = FlatStyle.Flat;
            btn_lammoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_lammoi.ForeColor = Color.White;
            btn_lammoi.Image = (Image)resources.GetObject("btn_lammoi.Image");
            btn_lammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoi.Location = new Point(913, 348);
            btn_lammoi.Margin = new Padding(4, 5, 4, 5);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(180, 71);
            btn_lammoi.TabIndex = 16;
            btn_lammoi.Text = "     Làm Mới";
            btn_lammoi.UseVisualStyleBackColor = false;
            // 
            // dgv_data
            // 
            dgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_data.Location = new Point(9, 36);
            dgv_data.Margin = new Padding(4, 5, 4, 5);
            dgv_data.Name = "dgv_data";
            dgv_data.RowHeadersWidth = 51;
            dgv_data.Size = new Size(1214, 390);
            dgv_data.TabIndex = 18;
            // 
            // txt_timkiem
            // 
            txt_timkiem.BackColor = Color.White;
            txt_timkiem.BorderStyle = BorderStyle.None;
            txt_timkiem.Font = new Font("Segoe UI", 10F);
            txt_timkiem.ForeColor = Color.Black;
            txt_timkiem.Location = new Point(4, 5);
            txt_timkiem.Margin = new Padding(4, 5, 4, 5);
            txt_timkiem.Multiline = true;
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.PlaceholderText = "Tìm kiếm tại đây ...";
            txt_timkiem.Size = new Size(268, 41);
            txt_timkiem.TabIndex = 13;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1130, 511);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txt_timkiem);
            panel1.Location = new Point(846, 511);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 50);
            panel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_data);
            groupBox1.Location = new Point(4, 605);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1231, 436);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 135, 209);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1240, 57);
            panel2.TabIndex = 24;
            // 
            // NhanVienControl
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(btn_lammoi);
            Controls.Add(btn_capnhat);
            Controls.Add(btn_them);
            Controls.Add(rb_nu);
            Controls.Add(rb_nam);
            Controls.Add(cb_chucvu);
            Controls.Add(txt_matkhau);
            Controls.Add(date_picker);
            Controls.Add(txt_email);
            Controls.Add(txt_sdt);
            Controls.Add(txt_diachi);
            Controls.Add(txt_ten);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = Color.Black;
            Margin = new Padding(4, 5, 4, 5);
            Name = "NhanVienControl";
            Size = new Size(1240, 1042);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_data).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_ten;
        private TextBox txt_diachi;
        private TextBox txt_sdt;
        private TextBox txt_email;
        private DateTimePicker date_picker;
        private TextBox txt_matkhau;
        private ComboBox cb_chucvu;
        private RadioButton rb_nam;
        private RadioButton rb_nu;
        private ColorDialog colorDialog1;
        private Button btn_them;
        private Button btn_capnhat;
        private Button btn_lammoi;
        private DataGridView dgv_data;
        private TextBox txt_timkiem;
        private PictureBox pictureBox3;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
    }
}
