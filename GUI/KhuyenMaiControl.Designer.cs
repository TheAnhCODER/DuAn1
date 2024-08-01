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
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dgv_DanhSachKhuyenMai = new DataGridView();
            groupBox1 = new GroupBox();
            button2 = new Button();
            rb_VND = new RadioButton();
            rb_PhanTram = new RadioButton();
            dgv_DanhSachSPKhuyenMai = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachKhuyenMai).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSPKhuyenMai).BeginInit();
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
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(dgv_DanhSachKhuyenMai);
            groupBox2.Location = new Point(3, 353);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(862, 272);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khuyến mại";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(29, 135, 209);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(435, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 7;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(220, 19);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 6;
            label8.Text = "Ngày kết thúc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 5;
            label7.Text = "Ngày bắt đầu";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(803, 37);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(572, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm tại đây...";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(220, 37);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // dgv_DanhSachKhuyenMai
            // 
            dgv_DanhSachKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachKhuyenMai.Location = new Point(6, 64);
            dgv_DanhSachKhuyenMai.Name = "dgv_DanhSachKhuyenMai";
            dgv_DanhSachKhuyenMai.Size = new Size(850, 202);
            dgv_DanhSachKhuyenMai.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(rb_VND);
            groupBox1.Controls.Add(rb_PhanTram);
            groupBox1.Controls.Add(dgv_DanhSachSPKhuyenMai);
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
            groupBox1.Size = new Size(862, 304);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khuyến mại";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(29, 135, 209);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(38, 129);
            button2.Name = "button2";
            button2.Size = new Size(90, 31);
            button2.TabIndex = 18;
            button2.Text = "Chọn tất cả";
            button2.UseVisualStyleBackColor = false;
            // 
            // rb_VND
            // 
            rb_VND.AutoSize = true;
            rb_VND.Location = new Point(484, 127);
            rb_VND.Name = "rb_VND";
            rb_VND.Size = new Size(49, 19);
            rb_VND.TabIndex = 17;
            rb_VND.Text = "VND";
            rb_VND.UseVisualStyleBackColor = true;
            // 
            // rb_PhanTram
            // 
            rb_PhanTram.AutoSize = true;
            rb_PhanTram.Location = new Point(558, 127);
            rb_PhanTram.Name = "rb_PhanTram";
            rb_PhanTram.Size = new Size(35, 19);
            rb_PhanTram.TabIndex = 17;
            rb_PhanTram.Text = "%";
            rb_PhanTram.UseVisualStyleBackColor = true;
            // 
            // dgv_DanhSachSPKhuyenMai
            // 
            dgv_DanhSachSPKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachSPKhuyenMai.Location = new Point(38, 166);
            dgv_DanhSachSPKhuyenMai.Name = "dgv_DanhSachSPKhuyenMai";
            dgv_DanhSachSPKhuyenMai.Size = new Size(562, 132);
            dgv_DanhSachSPKhuyenMai.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 78);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 15;
            label5.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 129);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 15;
            label6.Text = "Hình thức giảm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 78);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 15;
            label4.Text = "Giá trị giảm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 26);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 15;
            label3.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 26);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 15;
            label2.Text = "Tên khuyến mãi";
            // 
            // tb_GiaTriGiam
            // 
            tb_GiaTriGiam.Location = new Point(369, 96);
            tb_GiaTriGiam.Name = "tb_GiaTriGiam";
            tb_GiaTriGiam.Size = new Size(199, 23);
            tb_GiaTriGiam.TabIndex = 14;
            // 
            // dtp_NgayBatDau
            // 
            dtp_NgayBatDau.Location = new Point(369, 44);
            dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            dtp_NgayBatDau.Size = new Size(199, 23);
            dtp_NgayBatDau.TabIndex = 13;
            // 
            // dtp_NgayKetThuc
            // 
            dtp_NgayKetThuc.Location = new Point(38, 96);
            dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            dtp_NgayKetThuc.Size = new Size(199, 23);
            dtp_NgayKetThuc.TabIndex = 12;
            // 
            // tb_TenKhuyenMai
            // 
            tb_TenKhuyenMai.Location = new Point(38, 44);
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
            btn_lammoiKhuyenMai.Location = new Point(669, 211);
            btn_lammoiKhuyenMai.Name = "btn_lammoiKhuyenMai";
            btn_lammoiKhuyenMai.Size = new Size(128, 57);
            btn_lammoiKhuyenMai.TabIndex = 10;
            btn_lammoiKhuyenMai.Text = "     Làm mới";
            btn_lammoiKhuyenMai.UseVisualStyleBackColor = false;
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
            btn_suaKhuyenMai.Location = new Point(669, 127);
            btn_suaKhuyenMai.Name = "btn_suaKhuyenMai";
            btn_suaKhuyenMai.Size = new Size(128, 57);
            btn_suaKhuyenMai.TabIndex = 9;
            btn_suaKhuyenMai.Text = "  Sửa";
            btn_suaKhuyenMai.UseVisualStyleBackColor = false;
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
            btn_themKhuyenMai.Location = new Point(669, 44);
            btn_themKhuyenMai.Name = "btn_themKhuyenMai";
            btn_themKhuyenMai.Size = new Size(128, 57);
            btn_themKhuyenMai.TabIndex = 8;
            btn_themKhuyenMai.Text = "  Thêm";
            btn_themKhuyenMai.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachKhuyenMai).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSPKhuyenMai).EndInit();
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
        private DataGridView dgv_DanhSachSPKhuyenMai;
        private Label label6;
        private Button button1;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgv_DanhSachKhuyenMai;
        private Button button2;
    }
}
