using BUS.Services;
using DAL.Models;
using System.Data;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private NhanVienServices nhanVienBUS = new NhanVienServices();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            llb_QuenMK.LinkColor = Color.FromArgb(29, 135, 209); // Màu khi hover chuột vào link
        }

        private void llb_QuenMK_MouseLeave(object sender, EventArgs e)
        {
            llb_QuenMK.LinkColor = Color.FromArgb(0, 0, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {

            var username = tbt_TenDangNhap.Text;
            var password = tbt_MatKhau.Text;

            var nhanVien = nhanVienBUS.DangNhap(username, password);
            this.Hide();
            
            TrangChu trangChu = new TrangChu(nhanVien);
            TrangChu.nhanVien1 = nhanVien;
            trangChu.Show();
        }

        


        private void btn_DangNhap_MouseLeave(object sender, EventArgs e)
        {

            btn_DangNhap.BackColor = Color.White;
            btn_DangNhap.ForeColor = Color.FromArgb(29, 135, 209);
            btn_DangNhap.FlatAppearance.BorderColor = Color.FromArgb(29, 135, 209);

        }

        private void btn_DangNhap_MouseEnter(object sender, EventArgs e)
        {
            btn_DangNhap.BackColor = Color.FromArgb(29, 135, 209);
            btn_DangNhap.ForeColor = Color.White;
        }

        private void btn_Thoat_MouseEnter(object sender, EventArgs e)
        {
            btn_Thoat.BackColor = Color.FromArgb(29, 135, 209);
            btn_Thoat.ForeColor = Color.White;
        }

        private void btn_Thoat_MouseLeave(object sender, EventArgs e)
        {
            btn_Thoat.BackColor = Color.White;
            btn_Thoat.ForeColor = Color.FromArgb(29, 135, 209);
            btn_Thoat.FlatAppearance.BorderColor = Color.FromArgb(29, 135, 209);
        }

    }
}
