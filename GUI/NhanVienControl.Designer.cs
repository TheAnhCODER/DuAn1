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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            panel2 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tb_ten_NhanVien = new TextBox();
            tb_sdt_NhanVien = new TextBox();
            tb_diachi_NhanVien = new TextBox();
            tb_email_NhanVien = new TextBox();
            tb_matkhau_NhanVien = new TextBox();
            dateTime_ngaysinh_NhanVien = new DateTimePicker();
            rb_nam_NhanVien = new RadioButton();
            rb_nu_NhanVien = new RadioButton();
            groupBox1 = new GroupBox();
            cb_trangthai_NhanVien = new ComboBox();
            panel1 = new Panel();
            btn_lammoi_NhanVien = new Button();
            btn_them_NhanVien = new Button();
            btn_sua_NhanVien = new Button();
            label9 = new Label();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            dgv_danhsach_NhanVien = new DataGridView();
            panel3 = new Panel();
            tb_timkiem_NhanVien = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach_NhanVien).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(346, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 0;
            label1.Text = "Nhân Viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(821, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 135, 209);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(868, 44);
            panel2.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(120, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(626, 1);
            panel4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 33);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 25;
            label3.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(319, 33);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 25;
            label2.Text = "SĐT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(319, 149);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 25;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 89);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 25;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(319, 89);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 25;
            label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(64, 149);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 25;
            label7.Text = "Ngày sinh";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(67, 228);
            label8.Name = "label8";
            label8.Size = new Size(59, 17);
            label8.TabIndex = 25;
            label8.Text = "Giới tính";
            // 
            // tb_ten_NhanVien
            // 
            tb_ten_NhanVien.Location = new Point(67, 53);
            tb_ten_NhanVien.Name = "tb_ten_NhanVien";
            tb_ten_NhanVien.Size = new Size(172, 23);
            tb_ten_NhanVien.TabIndex = 26;
            // 
            // tb_sdt_NhanVien
            // 
            tb_sdt_NhanVien.Location = new Point(319, 53);
            tb_sdt_NhanVien.Name = "tb_sdt_NhanVien";
            tb_sdt_NhanVien.Size = new Size(172, 23);
            tb_sdt_NhanVien.TabIndex = 27;
            // 
            // tb_diachi_NhanVien
            // 
            tb_diachi_NhanVien.Location = new Point(319, 169);
            tb_diachi_NhanVien.Name = "tb_diachi_NhanVien";
            tb_diachi_NhanVien.Size = new Size(172, 23);
            tb_diachi_NhanVien.TabIndex = 28;
            // 
            // tb_email_NhanVien
            // 
            tb_email_NhanVien.Location = new Point(67, 109);
            tb_email_NhanVien.Name = "tb_email_NhanVien";
            tb_email_NhanVien.Size = new Size(172, 23);
            tb_email_NhanVien.TabIndex = 29;
            // 
            // tb_matkhau_NhanVien
            // 
            tb_matkhau_NhanVien.Location = new Point(319, 109);
            tb_matkhau_NhanVien.Name = "tb_matkhau_NhanVien";
            tb_matkhau_NhanVien.Size = new Size(172, 23);
            tb_matkhau_NhanVien.TabIndex = 30;
            // 
            // dateTime_ngaysinh_NhanVien
            // 
            dateTime_ngaysinh_NhanVien.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTime_ngaysinh_NhanVien.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTime_ngaysinh_NhanVien.Location = new Point(67, 170);
            dateTime_ngaysinh_NhanVien.Name = "dateTime_ngaysinh_NhanVien";
            dateTime_ngaysinh_NhanVien.Size = new Size(172, 22);
            dateTime_ngaysinh_NhanVien.TabIndex = 31;
            // 
            // rb_nam_NhanVien
            // 
            rb_nam_NhanVien.AutoSize = true;
            rb_nam_NhanVien.Location = new Point(132, 228);
            rb_nam_NhanVien.Name = "rb_nam_NhanVien";
            rb_nam_NhanVien.Size = new Size(51, 19);
            rb_nam_NhanVien.TabIndex = 32;
            rb_nam_NhanVien.TabStop = true;
            rb_nam_NhanVien.Text = "Nam";
            rb_nam_NhanVien.UseVisualStyleBackColor = true;
            // 
            // rb_nu_NhanVien
            // 
            rb_nu_NhanVien.AutoSize = true;
            rb_nu_NhanVien.Location = new Point(198, 228);
            rb_nu_NhanVien.Name = "rb_nu_NhanVien";
            rb_nu_NhanVien.Size = new Size(41, 19);
            rb_nu_NhanVien.TabIndex = 33;
            rb_nu_NhanVien.TabStop = true;
            rb_nu_NhanVien.Text = "Nữ";
            rb_nu_NhanVien.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_trangthai_NhanVien);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rb_nu_NhanVien);
            groupBox1.Controls.Add(tb_ten_NhanVien);
            groupBox1.Controls.Add(rb_nam_NhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTime_ngaysinh_NhanVien);
            groupBox1.Controls.Add(tb_sdt_NhanVien);
            groupBox1.Controls.Add(tb_email_NhanVien);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tb_matkhau_NhanVien);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_diachi_NhanVien);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(7, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 278);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thiết lập thông tin nhân viên";
            // 
            // cb_trangthai_NhanVien
            // 
            cb_trangthai_NhanVien.FormattingEnabled = true;
            cb_trangthai_NhanVien.Location = new Point(319, 234);
            cb_trangthai_NhanVien.Name = "cb_trangthai_NhanVien";
            cb_trangthai_NhanVien.Size = new Size(172, 23);
            cb_trangthai_NhanVien.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_lammoi_NhanVien);
            panel1.Controls.Add(btn_them_NhanVien);
            panel1.Controls.Add(btn_sua_NhanVien);
            panel1.Location = new Point(574, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 208);
            panel1.TabIndex = 34;
            // 
            // btn_lammoi_NhanVien
            // 
            btn_lammoi_NhanVien.BackColor = Color.FromArgb(29, 135, 209);
            btn_lammoi_NhanVien.FlatStyle = FlatStyle.Flat;
            btn_lammoi_NhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_lammoi_NhanVien.ForeColor = Color.White;
            btn_lammoi_NhanVien.Image = (Image)resources.GetObject("btn_lammoi_NhanVien.Image");
            btn_lammoi_NhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoi_NhanVien.Location = new Point(42, 138);
            btn_lammoi_NhanVien.Name = "btn_lammoi_NhanVien";
            btn_lammoi_NhanVien.Size = new Size(128, 39);
            btn_lammoi_NhanVien.TabIndex = 36;
            btn_lammoi_NhanVien.Text = "     Làm mới";
            btn_lammoi_NhanVien.UseVisualStyleBackColor = false;
            btn_lammoi_NhanVien.Click += btn_lammoi_NhanVien_Click;
            // 
            // btn_them_NhanVien
            // 
            btn_them_NhanVien.BackColor = Color.FromArgb(29, 135, 209);
            btn_them_NhanVien.FlatStyle = FlatStyle.Flat;
            btn_them_NhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_them_NhanVien.ForeColor = Color.White;
            btn_them_NhanVien.Image = (Image)resources.GetObject("btn_them_NhanVien.Image");
            btn_them_NhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them_NhanVien.Location = new Point(42, 19);
            btn_them_NhanVien.Name = "btn_them_NhanVien";
            btn_them_NhanVien.Size = new Size(128, 39);
            btn_them_NhanVien.TabIndex = 34;
            btn_them_NhanVien.Text = "   Thêm";
            btn_them_NhanVien.UseVisualStyleBackColor = false;
            btn_them_NhanVien.Click += btn_them_NhanVien_Click;
            // 
            // btn_sua_NhanVien
            // 
            btn_sua_NhanVien.BackColor = Color.FromArgb(29, 135, 209);
            btn_sua_NhanVien.FlatStyle = FlatStyle.Flat;
            btn_sua_NhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_sua_NhanVien.ForeColor = Color.White;
            btn_sua_NhanVien.Image = (Image)resources.GetObject("btn_sua_NhanVien.Image");
            btn_sua_NhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua_NhanVien.Location = new Point(42, 79);
            btn_sua_NhanVien.Name = "btn_sua_NhanVien";
            btn_sua_NhanVien.Size = new Size(128, 39);
            btn_sua_NhanVien.TabIndex = 35;
            btn_sua_NhanVien.Text = "   Sửa";
            btn_sua_NhanVien.UseVisualStyleBackColor = false;
            btn_sua_NhanVien.Click += btn_sua_NhanVien_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(319, 214);
            label9.Name = "label9";
            label9.Size = new Size(69, 17);
            label9.TabIndex = 25;
            label9.Text = "Trạng thái";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(dgv_danhsach_NhanVien);
            groupBox2.Controls.Add(panel3);
            groupBox2.Location = new Point(7, 348);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(858, 275);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(729, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // dgv_danhsach_NhanVien
            // 
            dgv_danhsach_NhanVien.AllowUserToAddRows = false;
            dgv_danhsach_NhanVien.AllowUserToDeleteRows = false;
            dgv_danhsach_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_danhsach_NhanVien.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_danhsach_NhanVien.Location = new Point(6, 74);
            dgv_danhsach_NhanVien.Name = "dgv_danhsach_NhanVien";
            dgv_danhsach_NhanVien.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_danhsach_NhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_danhsach_NhanVien.RowHeadersWidth = 51;
            dgv_danhsach_NhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_danhsach_NhanVien.Size = new Size(846, 195);
            dgv_danhsach_NhanVien.TabIndex = 0;
            dgv_danhsach_NhanVien.CellClick += dgv_danhsach_NhanVien_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(tb_timkiem_NhanVien);
            panel3.Location = new Point(486, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 39);
            panel3.TabIndex = 1;
            // 
            // tb_timkiem_NhanVien
            // 
            tb_timkiem_NhanVien.BorderStyle = BorderStyle.None;
            tb_timkiem_NhanVien.Location = new Point(3, 8);
            tb_timkiem_NhanVien.Multiline = true;
            tb_timkiem_NhanVien.Name = "tb_timkiem_NhanVien";
            tb_timkiem_NhanVien.PlaceholderText = "Tìm kiếm tại đây ...";
            tb_timkiem_NhanVien.Size = new Size(205, 29);
            tb_timkiem_NhanVien.TabIndex = 0;
            tb_timkiem_NhanVien.TextChanged += tb_timkiem_NhanVien_TextChanged;
            // 
            // NhanVienControl
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            ForeColor = Color.Black;
            Name = "NhanVienControl";
            Size = new Size(868, 626);
            Load += NhanVienControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach_NhanVien).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ColorDialog colorDialog1;
        private Panel panel2;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tb_ten_NhanVien;
        private TextBox tb_sdt_NhanVien;
        private TextBox tb_diachi_NhanVien;
        private TextBox tb_email_NhanVien;
        private TextBox tb_matkhau_NhanVien;
        private DateTimePicker dateTime_ngaysinh_NhanVien;
        private RadioButton rb_nam_NhanVien;
        private RadioButton rb_nu_NhanVien;
        private GroupBox groupBox1;
        private Panel panel1;
        private Button btn_lammoi_NhanVien;
        private Button btn_them_NhanVien;
        private Button btn_sua_NhanVien;
        private GroupBox groupBox2;
        private DataGridView dgv_danhsach_NhanVien;
        private Panel panel3;
        private PictureBox pictureBox2;
        private TextBox tb_timkiem_NhanVien;
        private ComboBox cb_trangthai_NhanVien;
        private Label label9;
    }
}
