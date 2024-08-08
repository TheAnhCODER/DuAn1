namespace GUI
{
    partial class KhuyenMaiControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMaiControl));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dtp_NgayKetThuc_TimKiem = new DateTimePicker();
            button1 = new Button();
            dtk_NgayBatDau_TimKiem = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            dgv_DanhSachKhuyenMai = new DataGridView();
            groupBox1 = new GroupBox();
            tb_makhuyenmai = new TextBox();
            rb_VND = new RadioButton();
            rb_PhanTram = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tb_GiaTriGiam = new TextBox();
            dtp_NgayBatDau = new DateTimePicker();
            dtp_NgayKetThuc = new DateTimePicker();
            tb_TenKhuyenMai = new TextBox();
            btn_lammoiKhuyenMai = new Button();
            btn_suaKhuyenMai = new Button();
            btn_themKhuyenMai = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachKhuyenMai).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(821, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 135, 209);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 44);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(118, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(626, 1);
            panel4.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(821, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(349, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 0;
            label1.Text = "Khuyến Mãi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(dgv_DanhSachKhuyenMai);
            groupBox2.Location = new Point(3, 273);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(862, 352);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khuyến mại";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtp_NgayKetThuc_TimKiem);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(dtk_NgayBatDau_TimKiem);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(277, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(579, 66);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm theo khoảng";
            // 
            // dtp_NgayKetThuc_TimKiem
            // 
            dtp_NgayKetThuc_TimKiem.Location = new Point(249, 38);
            dtp_NgayKetThuc_TimKiem.Name = "dtp_NgayKetThuc_TimKiem";
            dtp_NgayKetThuc_TimKiem.Size = new Size(200, 23);
            dtp_NgayKetThuc_TimKiem.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(29, 135, 209);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(464, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 7;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtk_NgayBatDau_TimKiem
            // 
            dtk_NgayBatDau_TimKiem.Location = new Point(35, 38);
            dtk_NgayBatDau_TimKiem.Name = "dtk_NgayBatDau_TimKiem";
            dtk_NgayBatDau_TimKiem.Size = new Size(200, 23);
            dtk_NgayBatDau_TimKiem.TabIndex = 1;
            dtk_NgayBatDau_TimKiem.ValueChanged += dtk_NgayBatDau_TimKiem_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(249, 20);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 6;
            label8.Text = "Ngày kết thúc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 20);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 5;
            label7.Text = "Ngày bắt đầu";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(237, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm tại đây...";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dgv_DanhSachKhuyenMai
            // 
            dgv_DanhSachKhuyenMai.AllowUserToAddRows = false;
            dgv_DanhSachKhuyenMai.BackgroundColor = Color.White;
            dgv_DanhSachKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachKhuyenMai.Location = new Point(6, 96);
            dgv_DanhSachKhuyenMai.Name = "dgv_DanhSachKhuyenMai";
            dgv_DanhSachKhuyenMai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSachKhuyenMai.Size = new Size(850, 250);
            dgv_DanhSachKhuyenMai.TabIndex = 0;
            dgv_DanhSachKhuyenMai.CellClick += dgv_DanhSachKhuyenMai_CellClick;
            dgv_DanhSachKhuyenMai.CellDoubleClick += dgv_DanhSachKhuyenMai_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_makhuyenmai);
            groupBox1.Controls.Add(rb_VND);
            groupBox1.Controls.Add(rb_PhanTram);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_GiaTriGiam);
            groupBox1.Controls.Add(dtp_NgayBatDau);
            groupBox1.Controls.Add(dtp_NgayKetThuc);
            groupBox1.Controls.Add(tb_TenKhuyenMai);
            groupBox1.Controls.Add(btn_lammoiKhuyenMai);
            groupBox1.Controls.Add(btn_suaKhuyenMai);
            groupBox1.Controls.Add(btn_themKhuyenMai);
            groupBox1.Location = new Point(3, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(862, 218);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khuyến mại";
            // 
            // tb_makhuyenmai
            // 
            tb_makhuyenmai.Location = new Point(32, 168);
            tb_makhuyenmai.Name = "tb_makhuyenmai";
            tb_makhuyenmai.Size = new Size(199, 23);
            tb_makhuyenmai.TabIndex = 18;
            tb_makhuyenmai.Visible = false;
            // 
            // rb_VND
            // 
            rb_VND.AutoSize = true;
            rb_VND.Checked = true;
            rb_VND.Location = new Point(478, 148);
            rb_VND.Name = "rb_VND";
            rb_VND.Size = new Size(49, 19);
            rb_VND.TabIndex = 17;
            rb_VND.TabStop = true;
            rb_VND.Text = "VND";
            rb_VND.UseVisualStyleBackColor = true;
            // 
            // rb_PhanTram
            // 
            rb_PhanTram.AutoSize = true;
            rb_PhanTram.Location = new Point(552, 148);
            rb_PhanTram.Name = "rb_PhanTram";
            rb_PhanTram.Size = new Size(35, 19);
            rb_PhanTram.TabIndex = 17;
            rb_PhanTram.Text = "%";
            rb_PhanTram.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 99);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 15;
            label5.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 150);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 15;
            label6.Text = "Hình thức giảm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 99);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 15;
            label4.Text = "Giá trị giảm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 47);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 15;
            label3.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 47);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 15;
            label2.Text = "Tên khuyến mãi";
            // 
            // tb_GiaTriGiam
            // 
            tb_GiaTriGiam.Location = new Point(363, 117);
            tb_GiaTriGiam.Name = "tb_GiaTriGiam";
            tb_GiaTriGiam.Size = new Size(199, 23);
            tb_GiaTriGiam.TabIndex = 14;
            // 
            // dtp_NgayBatDau
            // 
            dtp_NgayBatDau.Location = new Point(363, 65);
            dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            dtp_NgayBatDau.Size = new Size(199, 23);
            dtp_NgayBatDau.TabIndex = 13;
            dtp_NgayBatDau.ValueChanged += dtp_NgayBatDau_ValueChanged;
            // 
            // dtp_NgayKetThuc
            // 
            dtp_NgayKetThuc.Location = new Point(32, 117);
            dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            dtp_NgayKetThuc.Size = new Size(199, 23);
            dtp_NgayKetThuc.TabIndex = 12;
            dtp_NgayKetThuc.ValueChanged += dtp_NgayKetThuc_ValueChanged;
            // 
            // tb_TenKhuyenMai
            // 
            tb_TenKhuyenMai.Location = new Point(32, 65);
            tb_TenKhuyenMai.Name = "tb_TenKhuyenMai";
            tb_TenKhuyenMai.Size = new Size(199, 23);
            tb_TenKhuyenMai.TabIndex = 11;
            // 
            // btn_lammoiKhuyenMai
            // 
            btn_lammoiKhuyenMai.BackColor = Color.FromArgb(29, 135, 209);
            btn_lammoiKhuyenMai.Cursor = Cursors.Hand;
            btn_lammoiKhuyenMai.FlatStyle = FlatStyle.Flat;
            btn_lammoiKhuyenMai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_lammoiKhuyenMai.ForeColor = Color.White;
            btn_lammoiKhuyenMai.Image = (Image)resources.GetObject("btn_lammoiKhuyenMai.Image");
            btn_lammoiKhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoiKhuyenMai.Location = new Point(670, 148);
            btn_lammoiKhuyenMai.Name = "btn_lammoiKhuyenMai";
            btn_lammoiKhuyenMai.Size = new Size(128, 57);
            btn_lammoiKhuyenMai.TabIndex = 10;
            btn_lammoiKhuyenMai.Text = "     Làm mới";
            btn_lammoiKhuyenMai.UseVisualStyleBackColor = false;
            btn_lammoiKhuyenMai.Click += btn_lammoiKhuyenMai_Click;
            // 
            // btn_suaKhuyenMai
            // 
            btn_suaKhuyenMai.BackColor = Color.FromArgb(29, 135, 209);
            btn_suaKhuyenMai.Cursor = Cursors.Hand;
            btn_suaKhuyenMai.FlatStyle = FlatStyle.Flat;
            btn_suaKhuyenMai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_suaKhuyenMai.ForeColor = Color.White;
            btn_suaKhuyenMai.Image = (Image)resources.GetObject("btn_suaKhuyenMai.Image");
            btn_suaKhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btn_suaKhuyenMai.Location = new Point(670, 85);
            btn_suaKhuyenMai.Name = "btn_suaKhuyenMai";
            btn_suaKhuyenMai.Size = new Size(128, 57);
            btn_suaKhuyenMai.TabIndex = 9;
            btn_suaKhuyenMai.Text = "    Cập nhật";
            btn_suaKhuyenMai.UseVisualStyleBackColor = false;
            btn_suaKhuyenMai.Click += btn_suaKhuyenMai_Click;
            // 
            // btn_themKhuyenMai
            // 
            btn_themKhuyenMai.BackColor = Color.FromArgb(29, 135, 209);
            btn_themKhuyenMai.Cursor = Cursors.Hand;
            btn_themKhuyenMai.FlatStyle = FlatStyle.Flat;
            btn_themKhuyenMai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_themKhuyenMai.ForeColor = Color.White;
            btn_themKhuyenMai.Image = (Image)resources.GetObject("btn_themKhuyenMai.Image");
            btn_themKhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btn_themKhuyenMai.Location = new Point(670, 22);
            btn_themKhuyenMai.Name = "btn_themKhuyenMai";
            btn_themKhuyenMai.Size = new Size(128, 57);
            btn_themKhuyenMai.TabIndex = 8;
            btn_themKhuyenMai.Text = "  Thêm";
            btn_themKhuyenMai.UseVisualStyleBackColor = false;
            btn_themKhuyenMai.Click += btn_themKhuyenMai_Click;
            // 
            // KhuyenMaiControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "KhuyenMaiControl";
            Size = new Size(868, 628);
            Load += KhuyenMaiControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachKhuyenMai).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tb_GiaTriGiam;
        private DateTimePicker dtp_NgayBatDau;
        private DateTimePicker dtp_NgayKetThuc;
        private TextBox tb_TenKhuyenMai;
        private Button btn_lammoiKhuyenMai;
        private Button btn_suaKhuyenMai;
        private Button btn_themKhuyenMai;
        private RadioButton rb_VND;
        private RadioButton rb_PhanTram;
        private Label label6;
        private Button button1;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private DateTimePicker dtp_NgayKetThuc_TimKiem;
        private DateTimePicker dtk_NgayBatDau_TimKiem;
        private DataGridView dgv_DanhSachKhuyenMai;
        private GroupBox groupBox3;
        private TextBox tb_makhuyenmai;
    }
}
