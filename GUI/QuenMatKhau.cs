
using BUS.Services;
using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace GUI
{
    public partial class QuenMatKhau : Form
    {
        NhanVienServices nhanVienServices;
        private string generatedOtp;
        public QuenMatKhau()
        {
            InitializeComponent();
            nhanVienServices = new NhanVienServices();
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {
            tb_matkhaumoi.Visible = false;
            tb_xacnhanmatkhaumoi.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            btn_DoiMatKhau.Visible = false;
            tb_xacnhanotp.Visible = false;
            button1.Visible = false;
        }

        private void btn_nhanotp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_emailkhoiphuc.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!IsValidEmail(tb_emailkhoiphuc.Text))
            {
                MessageBox.Show("Email không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!nhanVienServices.GetNhanVienByEmail(tb_emailkhoiphuc.Text))
            {
                MessageBox.Show("Email không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string userEmail = tb_emailkhoiphuc.Text.Trim();
            generatedOtp = GenerateOtp();
            SendOtpToEmail(userEmail, generatedOtp);
            MessageBox.Show("OTP đã được gửi tới email của bạn.");
            tb_xacnhanotp.Visible = true;
            button1.Visible = true;
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        private string GenerateOtp()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString();
        }
        private void SendOtpToEmail(string userEmail, string otp)
        {
            try
            {
                MailMessage mail = new MailMessage("advstoreshop@gmail.com", userEmail);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new NetworkCredential("advstoreshop@gmail.com", "dioy xdjj runl kikq");
                client.EnableSsl = true;

                mail.Subject = "Your OTP Code";
                mail.Body = $"Your OTP code is {otp}";

                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_xacnhanotp.Text))
            {
                MessageBox.Show("Vui lòng nhập mã OTP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (tb_xacnhanotp.Text == generatedOtp)
            {
                label1.Visible = true;
                label2.Visible = true;
                tb_matkhaumoi.Visible = true;
                tb_xacnhanmatkhaumoi.Visible = true;
                btn_DoiMatKhau.Visible = true;
            }
            else
            {
                MessageBox.Show("Mã OTP không đúng vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_matkhaumoi.Text) || string.IsNullOrEmpty(tb_xacnhanmatkhaumoi.Text))
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if(tb_matkhaumoi.Text == tb_xacnhanmatkhaumoi.Text)
            {
                if(nhanVienServices.UpdateMatKhau(tb_emailkhoiphuc.Text, tb_matkhaumoi.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới không khớp. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
