using BUS.Services;
using System.Data;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private NhanVienBus nhanVienBUS = new NhanVienBus();
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
            string email = tbt_TenDangNhap.Text;
            string matKhau = tbt_MatKhau.Text;
            DataTable userInfo;

            if (nhanVienBUS.CheckLogin(email, matKhau, out userInfo))
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Chuyển hướng đến giao diện chính của ứng dụng và truyền thông tin người dùng

                TrangChu trangChu = new TrangChu(userInfo);
                trangChu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản và mật khẩu.");
            }
        }
    }
}
