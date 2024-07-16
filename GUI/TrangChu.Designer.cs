namespace GUI
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            panel1 = new Panel();
            tbt_TenUser = new TextBox();
            lb_Ten = new Label();
            SidePanel = new Panel();
            btn_TaiKhoan = new Button();
            btn_KhuyenMai = new Button();
            btn_ThongKe = new Button();
            btn_HoaDon = new Button();
            btn_NhanVien = new Button();
            btn_KhachHang = new Button();
            btn_SanPham = new Button();
            btn_BanHang = new Button();
            pictureBox1 = new PictureBox();
            panel9 = new Panel();
            hoaDonControl1 = new HoaDonControl();
            nhanVienControl1 = new NhanVienControl();
            taiKhoanControl1 = new TaiKhoanControl();
            thongKeControl1 = new ThongKeControl();
            khuyenMaiControl1 = new KhuyenMaiControl();
            khachHangControl1 = new KhachHangControl();
            sanPhamControl1 = new SanPhamControl();
            banHangControl1 = new BanHangControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 135, 209);
            panel1.Controls.Add(tbt_TenUser);
            panel1.Controls.Add(lb_Ten);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(btn_TaiKhoan);
            panel1.Controls.Add(btn_KhuyenMai);
            panel1.Controls.Add(btn_ThongKe);
            panel1.Controls.Add(btn_HoaDon);
            panel1.Controls.Add(btn_NhanVien);
            panel1.Controls.Add(btn_KhachHang);
            panel1.Controls.Add(btn_SanPham);
            panel1.Controls.Add(btn_BanHang);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 628);
            panel1.TabIndex = 0;
            // 
            // tbt_TenUser
            // 
            tbt_TenUser.BackColor = Color.FromArgb(29, 135, 209);
            tbt_TenUser.BorderStyle = BorderStyle.None;
            tbt_TenUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tbt_TenUser.ForeColor = Color.White;
            tbt_TenUser.Location = new Point(3, 102);
            tbt_TenUser.Name = "tbt_TenUser";
            tbt_TenUser.ReadOnly = true;
            tbt_TenUser.Size = new Size(209, 18);
            tbt_TenUser.TabIndex = 2;
            tbt_TenUser.TextAlign = HorizontalAlignment.Center;
            // 
            // lb_Ten
            // 
            lb_Ten.AutoSize = true;
            lb_Ten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Ten.Location = new Point(3, 102);
            lb_Ten.Name = "lb_Ten";
            lb_Ten.Size = new Size(0, 21);
            lb_Ten.TabIndex = 1;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.White;
            SidePanel.Location = new Point(0, 129);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(8, 57);
            SidePanel.TabIndex = 1;
            // 
            // btn_TaiKhoan
            // 
            btn_TaiKhoan.Cursor = Cursors.Hand;
            btn_TaiKhoan.FlatAppearance.BorderSize = 0;
            btn_TaiKhoan.FlatStyle = FlatStyle.Flat;
            btn_TaiKhoan.Font = new Font("Calibri", 16.25F);
            btn_TaiKhoan.ForeColor = Color.White;
            btn_TaiKhoan.Image = (Image)resources.GetObject("btn_TaiKhoan.Image");
            btn_TaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TaiKhoan.Location = new Point(10, 570);
            btn_TaiKhoan.Name = "btn_TaiKhoan";
            btn_TaiKhoan.Size = new Size(205, 57);
            btn_TaiKhoan.TabIndex = 1;
            btn_TaiKhoan.Text = "Tài Khoản";
            btn_TaiKhoan.UseVisualStyleBackColor = true;
            btn_TaiKhoan.Click += btn_TaiKhoan_Click_1;
            // 
            // btn_KhuyenMai
            // 
            btn_KhuyenMai.Cursor = Cursors.Hand;
            btn_KhuyenMai.FlatAppearance.BorderSize = 0;
            btn_KhuyenMai.FlatStyle = FlatStyle.Flat;
            btn_KhuyenMai.Font = new Font("Calibri", 16.25F);
            btn_KhuyenMai.ForeColor = Color.White;
            btn_KhuyenMai.Image = (Image)resources.GetObject("btn_KhuyenMai.Image");
            btn_KhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KhuyenMai.Location = new Point(10, 507);
            btn_KhuyenMai.Name = "btn_KhuyenMai";
            btn_KhuyenMai.Size = new Size(205, 57);
            btn_KhuyenMai.TabIndex = 1;
            btn_KhuyenMai.Text = "    Khuyến Mãi";
            btn_KhuyenMai.UseVisualStyleBackColor = true;
            btn_KhuyenMai.Click += btn_KhuyenMai_Click_1;
            // 
            // btn_ThongKe
            // 
            btn_ThongKe.Cursor = Cursors.Hand;
            btn_ThongKe.FlatAppearance.BorderSize = 0;
            btn_ThongKe.FlatStyle = FlatStyle.Flat;
            btn_ThongKe.Font = new Font("Calibri", 16.25F);
            btn_ThongKe.ForeColor = Color.White;
            btn_ThongKe.Image = (Image)resources.GetObject("btn_ThongKe.Image");
            btn_ThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ThongKe.Location = new Point(10, 444);
            btn_ThongKe.Name = "btn_ThongKe";
            btn_ThongKe.Size = new Size(205, 57);
            btn_ThongKe.TabIndex = 1;
            btn_ThongKe.Text = "Thống Kê";
            btn_ThongKe.UseVisualStyleBackColor = true;
            btn_ThongKe.Click += btn_ThongKe_Click_1;
            // 
            // btn_HoaDon
            // 
            btn_HoaDon.Cursor = Cursors.Hand;
            btn_HoaDon.FlatAppearance.BorderSize = 0;
            btn_HoaDon.FlatStyle = FlatStyle.Flat;
            btn_HoaDon.Font = new Font("Calibri", 16.25F);
            btn_HoaDon.ForeColor = Color.White;
            btn_HoaDon.Image = (Image)resources.GetObject("btn_HoaDon.Image");
            btn_HoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_HoaDon.Location = new Point(10, 318);
            btn_HoaDon.Name = "btn_HoaDon";
            btn_HoaDon.Size = new Size(205, 57);
            btn_HoaDon.TabIndex = 1;
            btn_HoaDon.Text = "Hóa Đơn";
            btn_HoaDon.UseVisualStyleBackColor = true;
            btn_HoaDon.Click += btn_HoaDon_Click_1;
            // 
            // btn_NhanVien
            // 
            btn_NhanVien.Cursor = Cursors.Hand;
            btn_NhanVien.FlatAppearance.BorderSize = 0;
            btn_NhanVien.FlatStyle = FlatStyle.Flat;
            btn_NhanVien.Font = new Font("Calibri", 16.25F);
            btn_NhanVien.ForeColor = Color.White;
            btn_NhanVien.Image = (Image)resources.GetObject("btn_NhanVien.Image");
            btn_NhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NhanVien.Location = new Point(10, 381);
            btn_NhanVien.Name = "btn_NhanVien";
            btn_NhanVien.Size = new Size(205, 57);
            btn_NhanVien.TabIndex = 1;
            btn_NhanVien.Text = "  Nhân Viên";
            btn_NhanVien.UseVisualStyleBackColor = true;
            btn_NhanVien.Click += btn_NhanVien_Click_1;
            // 
            // btn_KhachHang
            // 
            btn_KhachHang.Cursor = Cursors.Hand;
            btn_KhachHang.FlatAppearance.BorderSize = 0;
            btn_KhachHang.FlatStyle = FlatStyle.Flat;
            btn_KhachHang.Font = new Font("Calibri", 16.25F);
            btn_KhachHang.ForeColor = Color.White;
            btn_KhachHang.Image = (Image)resources.GetObject("btn_KhachHang.Image");
            btn_KhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KhachHang.Location = new Point(10, 255);
            btn_KhachHang.Name = "btn_KhachHang";
            btn_KhachHang.Size = new Size(205, 57);
            btn_KhachHang.TabIndex = 1;
            btn_KhachHang.Text = "    Khách Hàng";
            btn_KhachHang.UseVisualStyleBackColor = true;
            btn_KhachHang.Click += btn_KhachHang_Click;
            // 
            // btn_SanPham
            // 
            btn_SanPham.Cursor = Cursors.Hand;
            btn_SanPham.FlatAppearance.BorderSize = 0;
            btn_SanPham.FlatStyle = FlatStyle.Flat;
            btn_SanPham.Font = new Font("Calibri", 16.25F);
            btn_SanPham.ForeColor = Color.White;
            btn_SanPham.Image = (Image)resources.GetObject("btn_SanPham.Image");
            btn_SanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btn_SanPham.Location = new Point(10, 192);
            btn_SanPham.Name = "btn_SanPham";
            btn_SanPham.Size = new Size(205, 57);
            btn_SanPham.TabIndex = 1;
            btn_SanPham.Text = " Sản Phẩm";
            btn_SanPham.UseVisualStyleBackColor = true;
            btn_SanPham.Click += btn_SanPham_Click;
            // 
            // btn_BanHang
            // 
            btn_BanHang.Cursor = Cursors.Hand;
            btn_BanHang.FlatAppearance.BorderSize = 0;
            btn_BanHang.FlatStyle = FlatStyle.Flat;
            btn_BanHang.Font = new Font("Calibri", 16.25F);
            btn_BanHang.ForeColor = Color.White;
            btn_BanHang.Image = Properties.Resources.icon_giohang;
            btn_BanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_BanHang.Location = new Point(10, 129);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.Size = new Size(205, 57);
            btn_BanHang.TabIndex = 1;
            btn_BanHang.Text = "Bán Hàng";
            btn_BanHang.UseVisualStyleBackColor = true;
            btn_BanHang.Click += btn_BanHang_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._7cc68991af7c0d22546d;
            pictureBox1.Location = new Point(0, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(hoaDonControl1);
            panel9.Controls.Add(nhanVienControl1);
            panel9.Controls.Add(taiKhoanControl1);
            panel9.Controls.Add(thongKeControl1);
            panel9.Controls.Add(khuyenMaiControl1);
            panel9.Controls.Add(khachHangControl1);
            panel9.Controls.Add(sanPhamControl1);
            panel9.Controls.Add(banHangControl1);
            panel9.Location = new Point(216, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(868, 628);
            panel9.TabIndex = 1;
            // 
            // hoaDonControl1
            // 
            hoaDonControl1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            hoaDonControl1.Location = new Point(0, 0);
            hoaDonControl1.Margin = new Padding(4, 5, 4, 5);
            hoaDonControl1.Name = "hoaDonControl1";
            hoaDonControl1.Size = new Size(868, 628);
            hoaDonControl1.TabIndex = 8;
            // 
            // nhanVienControl1
            // 
            nhanVienControl1.AccessibleName = "";
            nhanVienControl1.BackColor = Color.White;
            nhanVienControl1.BackgroundImageLayout = ImageLayout.Stretch;
            nhanVienControl1.ForeColor = Color.Black;
            nhanVienControl1.Location = new Point(0, 0);
            nhanVienControl1.Margin = new Padding(4, 5, 4, 5);
            nhanVienControl1.Name = "nhanVienControl1";
            nhanVienControl1.Size = new Size(868, 628);
            nhanVienControl1.TabIndex = 7;
            // 
            // taiKhoanControl1
            // 
            taiKhoanControl1.Location = new Point(0, 0);
            taiKhoanControl1.Margin = new Padding(4, 5, 4, 5);
            taiKhoanControl1.Name = "taiKhoanControl1";
            taiKhoanControl1.Size = new Size(868, 628);
            taiKhoanControl1.TabIndex = 6;
            // 
            // thongKeControl1
            // 
            thongKeControl1.Location = new Point(0, 0);
            thongKeControl1.Margin = new Padding(4, 5, 4, 5);
            thongKeControl1.Name = "thongKeControl1";
            thongKeControl1.Size = new Size(868, 628);
            thongKeControl1.TabIndex = 5;
            // 
            // khuyenMaiControl1
            // 
            khuyenMaiControl1.Location = new Point(0, 0);
            khuyenMaiControl1.Margin = new Padding(4, 5, 4, 5);
            khuyenMaiControl1.Name = "khuyenMaiControl1";
            khuyenMaiControl1.Size = new Size(868, 628);
            khuyenMaiControl1.TabIndex = 4;
            // 
            // khachHangControl1
            // 
            khachHangControl1.BackColor = Color.White;
            khachHangControl1.Location = new Point(0, 0);
            khachHangControl1.Margin = new Padding(4, 5, 4, 5);
            khachHangControl1.Name = "khachHangControl1";
            khachHangControl1.Size = new Size(868, 628);
            khachHangControl1.TabIndex = 3;
            // 
            // sanPhamControl1
            // 
            sanPhamControl1.Location = new Point(0, 0);
            sanPhamControl1.Margin = new Padding(4, 5, 4, 5);
            sanPhamControl1.Name = "sanPhamControl1";
            sanPhamControl1.Size = new Size(868, 628);
            sanPhamControl1.TabIndex = 2;
            // 
            // banHangControl1
            // 
            banHangControl1.Location = new Point(0, 0);
            banHangControl1.Margin = new Padding(4, 5, 4, 5);
            banHangControl1.Name = "banHangControl1";
            banHangControl1.Size = new Size(875, 628);
            banHangControl1.TabIndex = 0;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 628);
            ControlBox = false;
            Controls.Add(panel9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_KhuyenMai;
        private Button btn_ThongKe;
        private Button btn_HoaDon;
        private Button btn_NhanVien;
        private Button btn_KhachHang;
        private Button btn_SanPham;
        private Button btn_BanHang;
        private Panel SidePanel;
        private Button btn_TaiKhoan;
        private Label lb_Ten;
        private Panel panel9;
        private BanHangControl banHang1;
        private BanHangControl banHangControl1;
        private SanPhamControl sanPhamControl1;
        private TaiKhoanControl taiKhoanControl1;
        private ThongKeControl thongKeControl1;
        private KhuyenMaiControl khuyenMaiControl1;
        private KhachHangControl khachHangControl1;
        private NhanVienControl nhanVienControl1;
        private HoaDonControl hoaDonControl1;
        private PictureBox pictureBox2;
        private TextBox tbt_TenUser;
    }
}