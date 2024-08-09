using BUS.Services;
using DAL.Models;
using DAL.Responsitories;
using GUI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TaiKhoanControl : UserControl
    {
        private readonly NhanVienServices _nhanVienService;
        private string currentCaptcha;
        public TaiKhoanControl()
        {
            InitializeComponent();
            _nhanVienService = new NhanVienServices();
            GenerateCaptcha(); // Generate captcha on initialization
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tb_matkhaumoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_matkhaucu_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nhaplaimatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_capcha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {

            string matKhauCu = tb_matkhaucu.Text;
            string matKhauMoi = tb_matkhaumoi.Text;
            string xacNhanMatKhau = tb_nhaplaimatkhau.Text;
            string nhapCaptcha = tb_capcha.Text;

            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(matKhauCu) ||
                string.IsNullOrWhiteSpace(matKhauMoi) || string.IsNullOrWhiteSpace(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the captcha is correct
            if (nhapCaptcha != currentCaptcha)
            {
                MessageBox.Show("Mã captcha không đúng. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_capcha.Clear();
                GenerateCaptcha();
                return;
            }

            
            // Check if the new password and confirmation match
            if (matKhauMoi != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_matkhaumoi.Clear();
                tb_nhaplaimatkhau.Clear();
                tb_capcha.Clear();
                GenerateCaptcha();
                return;
            }
            string idnhanvien = TrangChu.nhanVien1.IdNhanvien.ToString();
            // Attempt to change the password
            bool isPasswordChanged = _nhanVienService.ThayDoiMatKhau(idnhanvien, matKhauCu, matKhauMoi);

            if (isPasswordChanged)
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                GenerateCaptcha();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearFields();
                GenerateCaptcha();
            }
        }

        private void tb_hiencapcha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_loadcapcha_Click(object sender, EventArgs e)
        {

            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            currentCaptcha = new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            tb_hiencapcha.Text = currentCaptcha;
        }

        private void ClearFields()
        {

            tb_matkhaucu.Clear();
            tb_matkhaumoi.Clear();
            tb_nhaplaimatkhau.Clear();
            tb_capcha.Clear();
        }

    }

}
