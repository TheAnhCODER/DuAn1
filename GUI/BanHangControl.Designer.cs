namespace GUI
{
    partial class BanHangControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHangControl));
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            dgv_HoaDonCho_BanHang = new DataGridView();
            groupBox2 = new GroupBox();
            btn_HuyHoaDon_BanHang = new Button();
            btn_TaoHoaDon_BanHang = new Button();
            btn_ThanhToan_BanHang = new Button();
            panel2 = new Panel();
            tb_TienThua_BanHang = new TextBox();
            tb_TienKhachTra_BanHang = new TextBox();
            cb_HTTT_BanHang = new ComboBox();
            tb_TongTien_BanHang = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            tb_SoDienThoai_BanHang = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tb_TenKhachHang_BanHang = new TextBox();
            groupBox3 = new GroupBox();
            dgv_HoaDonChiTiet_BanHang = new DataGridView();
            groupBox4 = new GroupBox();
            dgv_DanhSachSanPham_BanHang = new DataGridView();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonCho_BanHang).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonChiTiet_BanHang).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSanPham_BanHang).BeginInit();
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(29, 135, 209);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(868, 44);
            panel3.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(117, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(626, 1);
            panel4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(368, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 32);
            label4.TabIndex = 0;
            label4.Text = "Bán Hàng";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(821, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_HoaDonCho_BanHang);
            groupBox1.Location = new Point(3, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 165);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn chờ";
            // 
            // dgv_HoaDonCho_BanHang
            // 
            dgv_HoaDonCho_BanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDonCho_BanHang.Location = new Point(6, 15);
            dgv_HoaDonCho_BanHang.Name = "dgv_HoaDonCho_BanHang";
            dgv_HoaDonCho_BanHang.Size = new Size(610, 144);
            dgv_HoaDonCho_BanHang.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_HuyHoaDon_BanHang);
            groupBox2.Controls.Add(btn_TaoHoaDon_BanHang);
            groupBox2.Controls.Add(btn_ThanhToan_BanHang);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(tb_TienThua_BanHang);
            groupBox2.Controls.Add(tb_TienKhachTra_BanHang);
            groupBox2.Controls.Add(cb_HTTT_BanHang);
            groupBox2.Controls.Add(tb_TongTien_BanHang);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(tb_SoDienThoai_BanHang);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tb_TenKhachHang_BanHang);
            groupBox2.Location = new Point(631, 221);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 404);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn";
            // 
            // btn_HuyHoaDon_BanHang
            // 
            btn_HuyHoaDon_BanHang.Location = new Point(119, 348);
            btn_HuyHoaDon_BanHang.Name = "btn_HuyHoaDon_BanHang";
            btn_HuyHoaDon_BanHang.Size = new Size(88, 47);
            btn_HuyHoaDon_BanHang.TabIndex = 19;
            btn_HuyHoaDon_BanHang.Text = "Hủy hóa đơn";
            btn_HuyHoaDon_BanHang.UseVisualStyleBackColor = true;
            // 
            // btn_TaoHoaDon_BanHang
            // 
            btn_TaoHoaDon_BanHang.Location = new Point(25, 348);
            btn_TaoHoaDon_BanHang.Name = "btn_TaoHoaDon_BanHang";
            btn_TaoHoaDon_BanHang.Size = new Size(86, 47);
            btn_TaoHoaDon_BanHang.TabIndex = 18;
            btn_TaoHoaDon_BanHang.Text = "Tạo hóa đơn";
            btn_TaoHoaDon_BanHang.UseVisualStyleBackColor = true;
            // 
            // btn_ThanhToan_BanHang
            // 
            btn_ThanhToan_BanHang.Location = new Point(25, 295);
            btn_ThanhToan_BanHang.Name = "btn_ThanhToan_BanHang";
            btn_ThanhToan_BanHang.Size = new Size(182, 47);
            btn_ThanhToan_BanHang.TabIndex = 17;
            btn_ThanhToan_BanHang.Text = "Thanh toán";
            btn_ThanhToan_BanHang.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(0, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 1);
            panel2.TabIndex = 9;
            // 
            // tb_TienThua_BanHang
            // 
            tb_TienThua_BanHang.Location = new Point(102, 236);
            tb_TienThua_BanHang.Name = "tb_TienThua_BanHang";
            tb_TienThua_BanHang.Size = new Size(126, 23);
            tb_TienThua_BanHang.TabIndex = 16;
            // 
            // tb_TienKhachTra_BanHang
            // 
            tb_TienKhachTra_BanHang.Location = new Point(102, 196);
            tb_TienKhachTra_BanHang.Name = "tb_TienKhachTra_BanHang";
            tb_TienKhachTra_BanHang.Size = new Size(126, 23);
            tb_TienKhachTra_BanHang.TabIndex = 15;
            // 
            // cb_HTTT_BanHang
            // 
            cb_HTTT_BanHang.FormattingEnabled = true;
            cb_HTTT_BanHang.Location = new Point(102, 159);
            cb_HTTT_BanHang.Name = "cb_HTTT_BanHang";
            cb_HTTT_BanHang.Size = new Size(126, 23);
            cb_HTTT_BanHang.TabIndex = 14;
            // 
            // tb_TongTien_BanHang
            // 
            tb_TongTien_BanHang.Location = new Point(102, 121);
            tb_TongTien_BanHang.Name = "tb_TongTien_BanHang";
            tb_TongTien_BanHang.Size = new Size(126, 23);
            tb_TongTien_BanHang.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 239);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 12;
            label7.Text = "Tiền thừa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 199);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 11;
            label6.Text = "Tiền khách trả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 162);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 10;
            label5.Text = "HT thanh toán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 124);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 9;
            label3.Text = "Tổng tiền hàng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(0, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 1);
            panel1.TabIndex = 8;
            // 
            // tb_SoDienThoai_BanHang
            // 
            tb_SoDienThoai_BanHang.Location = new Point(102, 63);
            tb_SoDienThoai_BanHang.Name = "tb_SoDienThoai_BanHang";
            tb_SoDienThoai_BanHang.Size = new Size(126, 23);
            tb_SoDienThoai_BanHang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên khách hàng";
            // 
            // tb_TenKhachHang_BanHang
            // 
            tb_TenKhachHang_BanHang.Location = new Point(102, 25);
            tb_TenKhachHang_BanHang.Name = "tb_TenKhachHang_BanHang";
            tb_TenKhachHang_BanHang.Size = new Size(126, 23);
            tb_TenKhachHang_BanHang.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_HoaDonChiTiet_BanHang);
            groupBox3.Location = new Point(3, 221);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(622, 178);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn chi tiết";
            // 
            // dgv_HoaDonChiTiet_BanHang
            // 
            dgv_HoaDonChiTiet_BanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDonChiTiet_BanHang.Location = new Point(6, 14);
            dgv_HoaDonChiTiet_BanHang.Name = "dgv_HoaDonChiTiet_BanHang";
            dgv_HoaDonChiTiet_BanHang.Size = new Size(610, 158);
            dgv_HoaDonChiTiet_BanHang.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgv_DanhSachSanPham_BanHang);
            groupBox4.Location = new Point(3, 405);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(622, 220);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách sản phẩm";
            // 
            // dgv_DanhSachSanPham_BanHang
            // 
            dgv_DanhSachSanPham_BanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachSanPham_BanHang.Location = new Point(6, 22);
            dgv_DanhSachSanPham_BanHang.Name = "dgv_DanhSachSanPham_BanHang";
            dgv_DanhSachSanPham_BanHang.Size = new Size(610, 192);
            dgv_DanhSachSanPham_BanHang.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(631, 50);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(234, 165);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            groupBox5.Text = "Quét QR sản phẩm";
            // 
            // BanHangControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Name = "BanHangControl";
            Size = new Size(868, 628);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonCho_BanHang).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonChiTiet_BanHang).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSanPham_BanHang).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dgv_HoaDonChiTiet_BanHang;
        private DataGridView dgv_DanhSachSanPham_BanHang;
        private DataGridView dgv_HoaDonCho_BanHang;
        private GroupBox groupBox5;
        private TextBox tb_SoDienThoai_BanHang;
        private Label label2;
        private Label label1;
        private TextBox tb_TenKhachHang_BanHang;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private Button btn_TaoHoaDon_BanHang;
        private Button btn_ThanhToan_BanHang;
        private Panel panel2;
        private TextBox tb_TienThua_BanHang;
        private TextBox tb_TienKhachTra_BanHang;
        private ComboBox cb_HTTT_BanHang;
        private TextBox tb_TongTien_BanHang;
        private Label label7;
        private Label label6;
        private Button btn_HuyHoaDon_BanHang;
    }
}
