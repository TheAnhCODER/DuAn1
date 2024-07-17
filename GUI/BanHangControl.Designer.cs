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
            pictureBox3 = new PictureBox();
            tb_TimKiem_SanPham = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgv_TatCaSanPham = new DataGridView();
            tabPage2 = new TabPage();
            dgv_DangGiamGia = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TatCaSanPham).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DangGiamGia).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1173, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 57);
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
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1240, 73);
            panel3.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(167, 58);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(894, 2);
            panel4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(526, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(185, 48);
            label4.TabIndex = 0;
            label4.Text = "Bán Hàng";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1173, 0);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_HoaDonCho_BanHang);
            groupBox1.Location = new Point(4, 83);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(889, 275);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn chờ";
            // 
            // dgv_HoaDonCho_BanHang
            // 
            dgv_HoaDonCho_BanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDonCho_BanHang.Location = new Point(9, 25);
            dgv_HoaDonCho_BanHang.Margin = new Padding(4, 5, 4, 5);
            dgv_HoaDonCho_BanHang.Name = "dgv_HoaDonCho_BanHang";
            dgv_HoaDonCho_BanHang.RowHeadersWidth = 62;
            dgv_HoaDonCho_BanHang.Size = new Size(871, 240);
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
            groupBox2.Location = new Point(901, 368);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(334, 673);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn";
            // 
            // btn_HuyHoaDon_BanHang
            // 
            btn_HuyHoaDon_BanHang.Location = new Point(170, 580);
            btn_HuyHoaDon_BanHang.Margin = new Padding(4, 5, 4, 5);
            btn_HuyHoaDon_BanHang.Name = "btn_HuyHoaDon_BanHang";
            btn_HuyHoaDon_BanHang.Size = new Size(126, 78);
            btn_HuyHoaDon_BanHang.TabIndex = 19;
            btn_HuyHoaDon_BanHang.Text = "Hủy hóa đơn";
            btn_HuyHoaDon_BanHang.UseVisualStyleBackColor = true;
            // 
            // btn_TaoHoaDon_BanHang
            // 
            btn_TaoHoaDon_BanHang.Location = new Point(36, 580);
            btn_TaoHoaDon_BanHang.Margin = new Padding(4, 5, 4, 5);
            btn_TaoHoaDon_BanHang.Name = "btn_TaoHoaDon_BanHang";
            btn_TaoHoaDon_BanHang.Size = new Size(123, 78);
            btn_TaoHoaDon_BanHang.TabIndex = 18;
            btn_TaoHoaDon_BanHang.Text = "Tạo hóa đơn";
            btn_TaoHoaDon_BanHang.UseVisualStyleBackColor = true;
            // 
            // btn_ThanhToan_BanHang
            // 
            btn_ThanhToan_BanHang.Location = new Point(36, 492);
            btn_ThanhToan_BanHang.Margin = new Padding(4, 5, 4, 5);
            btn_ThanhToan_BanHang.Name = "btn_ThanhToan_BanHang";
            btn_ThanhToan_BanHang.Size = new Size(260, 78);
            btn_ThanhToan_BanHang.TabIndex = 17;
            btn_ThanhToan_BanHang.Text = "Thanh toán";
            btn_ThanhToan_BanHang.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(0, 463);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 2);
            panel2.TabIndex = 9;
            // 
            // tb_TienThua_BanHang
            // 
            tb_TienThua_BanHang.Location = new Point(146, 393);
            tb_TienThua_BanHang.Margin = new Padding(4, 5, 4, 5);
            tb_TienThua_BanHang.Name = "tb_TienThua_BanHang";
            tb_TienThua_BanHang.Size = new Size(178, 31);
            tb_TienThua_BanHang.TabIndex = 16;
            // 
            // tb_TienKhachTra_BanHang
            // 
            tb_TienKhachTra_BanHang.Location = new Point(146, 327);
            tb_TienKhachTra_BanHang.Margin = new Padding(4, 5, 4, 5);
            tb_TienKhachTra_BanHang.Name = "tb_TienKhachTra_BanHang";
            tb_TienKhachTra_BanHang.Size = new Size(178, 31);
            tb_TienKhachTra_BanHang.TabIndex = 15;
            // 
            // cb_HTTT_BanHang
            // 
            cb_HTTT_BanHang.FormattingEnabled = true;
            cb_HTTT_BanHang.Location = new Point(146, 265);
            cb_HTTT_BanHang.Margin = new Padding(4, 5, 4, 5);
            cb_HTTT_BanHang.Name = "cb_HTTT_BanHang";
            cb_HTTT_BanHang.Size = new Size(178, 33);
            cb_HTTT_BanHang.TabIndex = 14;
            // 
            // tb_TongTien_BanHang
            // 
            tb_TongTien_BanHang.Location = new Point(146, 202);
            tb_TongTien_BanHang.Margin = new Padding(4, 5, 4, 5);
            tb_TongTien_BanHang.Name = "tb_TongTien_BanHang";
            tb_TongTien_BanHang.Size = new Size(178, 31);
            tb_TongTien_BanHang.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 398);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 12;
            label7.Text = "Tiền thừa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 332);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 11;
            label6.Text = "Tiền khách trả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 270);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 10;
            label5.Text = "HT thanh toán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 9;
            label3.Text = "Tổng tiền hàng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(0, 172);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 2);
            panel1.TabIndex = 8;
            // 
            // tb_SoDienThoai_BanHang
            // 
            tb_SoDienThoai_BanHang.Location = new Point(146, 105);
            tb_SoDienThoai_BanHang.Margin = new Padding(4, 5, 4, 5);
            tb_SoDienThoai_BanHang.Name = "tb_SoDienThoai_BanHang";
            tb_SoDienThoai_BanHang.Size = new Size(178, 31);
            tb_SoDienThoai_BanHang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên khách hàng";
            // 
            // tb_TenKhachHang_BanHang
            // 
            tb_TenKhachHang_BanHang.Location = new Point(146, 42);
            tb_TenKhachHang_BanHang.Margin = new Padding(4, 5, 4, 5);
            tb_TenKhachHang_BanHang.Name = "tb_TenKhachHang_BanHang";
            tb_TenKhachHang_BanHang.Size = new Size(178, 31);
            tb_TenKhachHang_BanHang.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_HoaDonChiTiet_BanHang);
            groupBox3.Location = new Point(4, 368);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(889, 297);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn chi tiết";
            // 
            // dgv_HoaDonChiTiet_BanHang
            // 
            dgv_HoaDonChiTiet_BanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDonChiTiet_BanHang.Location = new Point(9, 23);
            dgv_HoaDonChiTiet_BanHang.Margin = new Padding(4, 5, 4, 5);
            dgv_HoaDonChiTiet_BanHang.Name = "dgv_HoaDonChiTiet_BanHang";
            dgv_HoaDonChiTiet_BanHang.RowHeadersWidth = 62;
            dgv_HoaDonChiTiet_BanHang.Size = new Size(871, 263);
            dgv_HoaDonChiTiet_BanHang.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox3);
            groupBox4.Controls.Add(tb_TimKiem_SanPham);
            groupBox4.Controls.Add(tabControl1);
            groupBox4.Location = new Point(4, 675);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(889, 367);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách sản phẩm";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(790, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // tb_TimKiem_SanPham
            // 
            tb_TimKiem_SanPham.Location = new Point(455, 17);
            tb_TimKiem_SanPham.Name = "tb_TimKiem_SanPham";
            tb_TimKiem_SanPham.PlaceholderText = "Tìm kiếm tại đây...";
            tb_TimKiem_SanPham.Size = new Size(329, 31);
            tb_TimKiem_SanPham.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(7, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(875, 334);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgv_TatCaSanPham);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(867, 296);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tất cả sản phẩm";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_TatCaSanPham
            // 
            dgv_TatCaSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_TatCaSanPham.Location = new Point(6, 6);
            dgv_TatCaSanPham.Name = "dgv_TatCaSanPham";
            dgv_TatCaSanPham.RowHeadersWidth = 62;
            dgv_TatCaSanPham.Size = new Size(855, 284);
            dgv_TatCaSanPham.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgv_DangGiamGia);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(867, 296);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sản phẩm đang giảm giá";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_DangGiamGia
            // 
            dgv_DangGiamGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DangGiamGia.Location = new Point(6, 6);
            dgv_DangGiamGia.Name = "dgv_DangGiamGia";
            dgv_DangGiamGia.RowHeadersWidth = 62;
            dgv_DangGiamGia.Size = new Size(855, 286);
            dgv_DangGiamGia.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(901, 83);
            groupBox5.Margin = new Padding(4, 5, 4, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 5, 4, 5);
            groupBox5.Size = new Size(334, 275);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            groupBox5.Text = "Quét QR sản phẩm";
            // 
            // BanHangControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BanHangControl";
            Size = new Size(1240, 1047);
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
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_TatCaSanPham).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DangGiamGia).EndInit();
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
        private PictureBox pictureBox3;
        private TextBox tb_TimKiem_SanPham;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgv_TatCaSanPham;
        private TabPage tabPage2;
        private DataGridView dgv_DangGiamGia;
    }
}
