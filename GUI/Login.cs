namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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
    }
}
