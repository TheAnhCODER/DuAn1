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
            txt_tenNhanvien = new TextBox();
            txt_diachiNhanvien = new TextBox();
            txt_sdtNhanvien = new TextBox();
            txt_emailNhanvien = new TextBox();
            date_pickerNhanvien = new DateTimePicker();
            txt_matkhauNhanvien = new TextBox();
            cb_chucvuNhanvien = new ComboBox();
            rb_namNhanvien = new RadioButton();
            rb_nuNhanvien = new RadioButton();
            colorDialog1 = new ColorDialog();
            btn_themNhanvien = new Button();
            btn_capnhatNhanvien = new Button();
            btn_lammoiNhanvien = new Button();
            dgv_dataNhanvien = new DataGridView();
            txt_timkiemNhanvien = new TextBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_dataNhanvien).BeginInit();
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
            label1.Location = new Point(418, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 41);
            label1.TabIndex = 0;
            label1.Text = "Nhân Viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(938, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 91);
            label2.Name = "label2";
            label2.Size = new Size(36, 23);
            label2.TabIndex = 3;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 396);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 3;
            label3.Text = "Chức Vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 300);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 197);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 197);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 3;
            label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 300);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 3;
            label7.Text = "Mật Khẩu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(341, 93);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 3;
            label8.Text = "SĐT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 417);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 3;
            label9.Text = "Giới Tính";
            // 
            // txt_tenNhanvien
            // 
            txt_tenNhanvien.BorderStyle = BorderStyle.FixedSingle;
            txt_tenNhanvien.Font = new Font("Segoe UI", 10F);
            txt_tenNhanvien.Location = new Point(49, 117);
            txt_tenNhanvien.Margin = new Padding(3, 4, 3, 4);
            txt_tenNhanvien.Multiline = true;
            txt_tenNhanvien.Name = "txt_tenNhanvien";
            txt_tenNhanvien.Size = new Size(232, 30);
            txt_tenNhanvien.TabIndex = 4;
            // 
            // txt_diachiNhanvien
            // 
            txt_diachiNhanvien.BorderStyle = BorderStyle.FixedSingle;
            txt_diachiNhanvien.Font = new Font("Segoe UI", 10F);
            txt_diachiNhanvien.Location = new Point(49, 221);
            txt_diachiNhanvien.Margin = new Padding(3, 4, 3, 4);
            txt_diachiNhanvien.Multiline = true;
            txt_diachiNhanvien.Name = "txt_diachiNhanvien";
            txt_diachiNhanvien.Size = new Size(232, 30);
            txt_diachiNhanvien.TabIndex = 5;
            // 
            // txt_sdtNhanvien
            // 
            txt_sdtNhanvien.BorderStyle = BorderStyle.FixedSingle;
            txt_sdtNhanvien.Font = new Font("Segoe UI", 10F);
            txt_sdtNhanvien.Location = new Point(341, 117);
            txt_sdtNhanvien.Margin = new Padding(3, 4, 3, 4);
            txt_sdtNhanvien.Multiline = true;
            txt_sdtNhanvien.Name = "txt_sdtNhanvien";
            txt_sdtNhanvien.Size = new Size(265, 30);
            txt_sdtNhanvien.TabIndex = 6;
            // 
            // txt_emailNhanvien
            // 
            txt_emailNhanvien.BorderStyle = BorderStyle.FixedSingle;
            txt_emailNhanvien.Font = new Font("Segoe UI", 10F);
            txt_emailNhanvien.ForeColor = Color.Black;
            txt_emailNhanvien.Location = new Point(341, 220);
            txt_emailNhanvien.Margin = new Padding(3, 4, 3, 4);
            txt_emailNhanvien.Multiline = true;
            txt_emailNhanvien.Name = "txt_emailNhanvien";
            txt_emailNhanvien.Size = new Size(265, 31);
            txt_emailNhanvien.TabIndex = 7;
            // 
            // date_pickerNhanvien
            // 
            date_pickerNhanvien.CalendarMonthBackground = Color.White;
            date_pickerNhanvien.CalendarTitleBackColor = Color.Black;
            date_pickerNhanvien.CalendarTrailingForeColor = SystemColors.Desktop;
            date_pickerNhanvien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_pickerNhanvien.Location = new Point(342, 324);
            date_pickerNhanvien.Margin = new Padding(3, 4, 3, 4);
            date_pickerNhanvien.Name = "date_pickerNhanvien";
            date_pickerNhanvien.Size = new Size(264, 34);
            date_pickerNhanvien.TabIndex = 8;
            // 
            // txt_matkhauNhanvien
            // 
            txt_matkhauNhanvien.BorderStyle = BorderStyle.FixedSingle;
            txt_matkhauNhanvien.Font = new Font("Segoe UI", 10F);
            txt_matkhauNhanvien.Location = new Point(49, 324);
            txt_matkhauNhanvien.Margin = new Padding(3, 4, 3, 4);
            txt_matkhauNhanvien.Multiline = true;
            txt_matkhauNhanvien.Name = "txt_matkhauNhanvien";
            txt_matkhauNhanvien.Size = new Size(232, 31);
            txt_matkhauNhanvien.TabIndex = 9;
            // 
            // cb_chucvuNhanvien
            // 
            cb_chucvuNhanvien.BackColor = Color.White;
            cb_chucvuNhanvien.Font = new Font("Segoe UI", 10F);
            cb_chucvuNhanvien.ForeColor = Color.Black;
            cb_chucvuNhanvien.FormattingEnabled = true;
            cb_chucvuNhanvien.Location = new Point(341, 420);
            cb_chucvuNhanvien.Margin = new Padding(3, 4, 3, 4);
            cb_chucvuNhanvien.Name = "cb_chucvuNhanvien";
            cb_chucvuNhanvien.Size = new Size(266, 31);
            cb_chucvuNhanvien.TabIndex = 10;
            // 
            // rb_namNhanvien
            // 
            rb_namNhanvien.AutoSize = true;
            rb_namNhanvien.Location = new Point(152, 415);
            rb_namNhanvien.Margin = new Padding(3, 4, 3, 4);
            rb_namNhanvien.Name = "rb_namNhanvien";
            rb_namNhanvien.Size = new Size(62, 24);
            rb_namNhanvien.TabIndex = 11;
            rb_namNhanvien.TabStop = true;
            rb_namNhanvien.Text = "Nam";
            rb_namNhanvien.UseVisualStyleBackColor = true;
            // 
            // rb_nuNhanvien
            // 
            rb_nuNhanvien.AutoSize = true;
            rb_nuNhanvien.Location = new Point(239, 415);
            rb_nuNhanvien.Margin = new Padding(3, 4, 3, 4);
            rb_nuNhanvien.Name = "rb_nuNhanvien";
            rb_nuNhanvien.Size = new Size(50, 24);
            rb_nuNhanvien.TabIndex = 12;
            rb_nuNhanvien.TabStop = true;
            rb_nuNhanvien.Text = "Nữ";
            rb_nuNhanvien.UseVisualStyleBackColor = true;
            // 
            // btn_themNhanvien
            // 
            btn_themNhanvien.BackColor = Color.FromArgb(29, 135, 209);
            btn_themNhanvien.Cursor = Cursors.Hand;
            btn_themNhanvien.FlatStyle = FlatStyle.Flat;
            btn_themNhanvien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_themNhanvien.ForeColor = Color.White;
            btn_themNhanvien.Image = (Image)resources.GetObject("btn_themNhanvien.Image");
            btn_themNhanvien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_themNhanvien.Location = new Point(730, 108);
            btn_themNhanvien.Margin = new Padding(3, 4, 3, 4);
            btn_themNhanvien.Name = "btn_themNhanvien";
            btn_themNhanvien.Size = new Size(144, 57);
            btn_themNhanvien.TabIndex = 14;
            btn_themNhanvien.Text = "Thêm";
            btn_themNhanvien.UseVisualStyleBackColor = false;
            // 
            // btn_capnhatNhanvien
            // 
            btn_capnhatNhanvien.BackColor = Color.FromArgb(29, 135, 209);
            btn_capnhatNhanvien.Cursor = Cursors.Hand;
            btn_capnhatNhanvien.FlatStyle = FlatStyle.Flat;
            btn_capnhatNhanvien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_capnhatNhanvien.ForeColor = Color.White;
            btn_capnhatNhanvien.Image = (Image)resources.GetObject("btn_capnhatNhanvien.Image");
            btn_capnhatNhanvien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_capnhatNhanvien.Location = new Point(730, 194);
            btn_capnhatNhanvien.Margin = new Padding(3, 4, 3, 4);
            btn_capnhatNhanvien.Name = "btn_capnhatNhanvien";
            btn_capnhatNhanvien.Size = new Size(144, 57);
            btn_capnhatNhanvien.TabIndex = 15;
            btn_capnhatNhanvien.Text = "      Cập Nhật";
            btn_capnhatNhanvien.UseVisualStyleBackColor = false;
            // 
            // btn_lammoiNhanvien
            // 
            btn_lammoiNhanvien.BackColor = Color.FromArgb(29, 135, 209);
            btn_lammoiNhanvien.Cursor = Cursors.Hand;
            btn_lammoiNhanvien.FlatStyle = FlatStyle.Flat;
            btn_lammoiNhanvien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_lammoiNhanvien.ForeColor = Color.White;
            btn_lammoiNhanvien.Image = (Image)resources.GetObject("btn_lammoiNhanvien.Image");
            btn_lammoiNhanvien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoiNhanvien.Location = new Point(730, 278);
            btn_lammoiNhanvien.Margin = new Padding(3, 4, 3, 4);
            btn_lammoiNhanvien.Name = "btn_lammoiNhanvien";
            btn_lammoiNhanvien.Size = new Size(144, 57);
            btn_lammoiNhanvien.TabIndex = 16;
            btn_lammoiNhanvien.Text = "     Làm Mới";
            btn_lammoiNhanvien.UseVisualStyleBackColor = false;
            // 
            // dgv_dataNhanvien
            // 
            dgv_dataNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dataNhanvien.Location = new Point(7, 29);
            dgv_dataNhanvien.Margin = new Padding(3, 4, 3, 4);
            dgv_dataNhanvien.Name = "dgv_dataNhanvien";
            dgv_dataNhanvien.RowHeadersWidth = 51;
            dgv_dataNhanvien.Size = new Size(971, 312);
            dgv_dataNhanvien.TabIndex = 18;
            // 
            // txt_timkiemNhanvien
            // 
            txt_timkiemNhanvien.BackColor = Color.White;
            txt_timkiemNhanvien.BorderStyle = BorderStyle.None;
            txt_timkiemNhanvien.Font = new Font("Segoe UI", 10F);
            txt_timkiemNhanvien.ForeColor = Color.Black;
            txt_timkiemNhanvien.Location = new Point(3, 4);
            txt_timkiemNhanvien.Margin = new Padding(3, 4, 3, 4);
            txt_timkiemNhanvien.Multiline = true;
            txt_timkiemNhanvien.Name = "txt_timkiemNhanvien";
            txt_timkiemNhanvien.PlaceholderText = "Tìm kiếm tại đây ...";
            txt_timkiemNhanvien.Size = new Size(214, 33);
            txt_timkiemNhanvien.TabIndex = 13;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(904, 409);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txt_timkiemNhanvien);
            panel1.Location = new Point(677, 409);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 41);
            panel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_dataNhanvien);
            groupBox1.Location = new Point(3, 484);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(985, 349);
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
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(992, 46);
            panel2.TabIndex = 24;
            // 
            // NhanVienControl
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(btn_lammoiNhanvien);
            Controls.Add(btn_capnhatNhanvien);
            Controls.Add(btn_themNhanvien);
            Controls.Add(rb_nuNhanvien);
            Controls.Add(rb_namNhanvien);
            Controls.Add(cb_chucvuNhanvien);
            Controls.Add(txt_matkhauNhanvien);
            Controls.Add(date_pickerNhanvien);
            Controls.Add(txt_emailNhanvien);
            Controls.Add(txt_sdtNhanvien);
            Controls.Add(txt_diachiNhanvien);
            Controls.Add(txt_tenNhanvien);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "NhanVienControl";
            Size = new Size(992, 834);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_dataNhanvien).EndInit();
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
        private TextBox txt_tenNhanvien;
        private TextBox txt_diachiNhanvien;
        private TextBox txt_sdtNhanvien;
        private TextBox txt_emailNhanvien;
        private DateTimePicker date_pickerNhanvien;
        private TextBox txt_matkhauNhanvien;
        private ComboBox cb_chucvuNhanvien;
        private RadioButton rb_namNhanvien;
        private RadioButton rb_nuNhanvien;
        private ColorDialog colorDialog1;
        private Button btn_themNhanvien;
        private Button btn_capnhatNhanvien;
        private Button btn_lammoiNhanvien;
        private DataGridView dgv_dataNhanvien;
        private TextBox txt_timkiemNhanvien;
        private PictureBox pictureBox3;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
    }
}
