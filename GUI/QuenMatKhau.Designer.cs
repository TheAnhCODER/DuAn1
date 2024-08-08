namespace GUI
{
    partial class QuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhau));
            tb_emailkhoiphuc = new TextBox();
            btn_nhanotp = new Button();
            tb_xacnhanotp = new TextBox();
            button1 = new Button();
            tb_matkhaumoi = new TextBox();
            tb_xacnhanmatkhaumoi = new TextBox();
            btn_DoiMatKhau = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_emailkhoiphuc
            // 
            tb_emailkhoiphuc.BackColor = Color.White;
            tb_emailkhoiphuc.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_emailkhoiphuc.ForeColor = SystemColors.WindowText;
            tb_emailkhoiphuc.Location = new Point(67, 26);
            tb_emailkhoiphuc.Multiline = true;
            tb_emailkhoiphuc.Name = "tb_emailkhoiphuc";
            tb_emailkhoiphuc.PlaceholderText = "Nhập email đăng kí tài khoản ";
            tb_emailkhoiphuc.Size = new Size(250, 27);
            tb_emailkhoiphuc.TabIndex = 1;
            // 
            // btn_nhanotp
            // 
            btn_nhanotp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_nhanotp.BackColor = Color.White;
            btn_nhanotp.Cursor = Cursors.Hand;
            btn_nhanotp.FlatStyle = FlatStyle.Flat;
            btn_nhanotp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nhanotp.ForeColor = Color.FromArgb(29, 135, 209);
            btn_nhanotp.Image = (Image)resources.GetObject("btn_nhanotp.Image");
            btn_nhanotp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nhanotp.Location = new Point(323, 26);
            btn_nhanotp.Name = "btn_nhanotp";
            btn_nhanotp.Size = new Size(128, 27);
            btn_nhanotp.TabIndex = 2;
            btn_nhanotp.Text = "     Nhận mã ";
            btn_nhanotp.UseVisualStyleBackColor = false;
            btn_nhanotp.Click += btn_nhanotp_Click;
            // 
            // tb_xacnhanotp
            // 
            tb_xacnhanotp.BackColor = Color.White;
            tb_xacnhanotp.Location = new Point(67, 70);
            tb_xacnhanotp.Multiline = true;
            tb_xacnhanotp.Name = "tb_xacnhanotp";
            tb_xacnhanotp.PlaceholderText = "Nhập mã xác nhận";
            tb_xacnhanotp.Size = new Size(250, 28);
            tb_xacnhanotp.TabIndex = 3;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(29, 135, 209);
            button1.Location = new Point(323, 70);
            button1.Name = "button1";
            button1.Size = new Size(128, 28);
            button1.TabIndex = 4;
            button1.Text = "Xác nhận mã";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tb_matkhaumoi
            // 
            tb_matkhaumoi.BackColor = Color.White;
            tb_matkhaumoi.Location = new Point(179, 123);
            tb_matkhaumoi.Name = "tb_matkhaumoi";
            tb_matkhaumoi.PlaceholderText = "Nhập mật khẩu mới";
            tb_matkhaumoi.Size = new Size(269, 23);
            tb_matkhaumoi.TabIndex = 5;
            // 
            // tb_xacnhanmatkhaumoi
            // 
            tb_xacnhanmatkhaumoi.BackColor = Color.White;
            tb_xacnhanmatkhaumoi.Location = new Point(179, 158);
            tb_xacnhanmatkhaumoi.Name = "tb_xacnhanmatkhaumoi";
            tb_xacnhanmatkhaumoi.PlaceholderText = "Xác nhận mật khẩu mới";
            tb_xacnhanmatkhaumoi.Size = new Size(269, 23);
            tb_xacnhanmatkhaumoi.TabIndex = 6;
            // 
            // btn_DoiMatKhau
            // 
            btn_DoiMatKhau.Cursor = Cursors.Hand;
            btn_DoiMatKhau.FlatStyle = FlatStyle.Flat;
            btn_DoiMatKhau.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DoiMatKhau.ForeColor = Color.FromArgb(29, 135, 209);
            btn_DoiMatKhau.Image = (Image)resources.GetObject("btn_DoiMatKhau.Image");
            btn_DoiMatKhau.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DoiMatKhau.Location = new Point(179, 213);
            btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            btn_DoiMatKhau.Size = new Size(122, 40);
            btn_DoiMatKhau.TabIndex = 7;
            btn_DoiMatKhau.Text = "         Đổi mật khẩu";
            btn_DoiMatKhau.UseVisualStyleBackColor = true;
            btn_DoiMatKhau.Click += btn_DoiMatKhau_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 123);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 8;
            label1.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 161);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 8;
            label2.Text = "Xác nhận mật khẩu mới";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(474, 276);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_DoiMatKhau);
            Controls.Add(tb_xacnhanmatkhaumoi);
            Controls.Add(tb_matkhaumoi);
            Controls.Add(button1);
            Controls.Add(tb_xacnhanotp);
            Controls.Add(btn_nhanotp);
            Controls.Add(tb_emailkhoiphuc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QuenMatKhau";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quên mật khẩu";
            Load += QuenMatKhau_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_emailkhoiphuc;
        private Button btn_nhanotp;
        private TextBox tb_xacnhanotp;
        private Button button1;
        private TextBox tb_matkhaumoi;
        private TextBox tb_xacnhanmatkhaumoi;
        private Button btn_DoiMatKhau;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}