﻿namespace GUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            tbt_TenDangNhap = new TextBox();
            panel3 = new Panel();
            tbt_MatKhau = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btn_DangNhap = new Button();
            btn_Thoat = new Button();
            llb_QuenMK = new LinkLabel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 135, 209);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 333);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 267);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(236, 30);
            label2.TabIndex = 1;
            label2.Text = "Ứng dụng bán quần áo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 219);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 30);
            label1.TabIndex = 1;
            label1.Text = "Chào mừng bạn đến với";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._7cc68991af7c0d22546d;
            pictureBox1.Location = new Point(21, -9);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(356, 29);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 1;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbt_TenDangNhap);
            panel2.Location = new Point(284, 106);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 36);
            panel2.TabIndex = 2;
            // 
            // tbt_TenDangNhap
            // 
            tbt_TenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            tbt_TenDangNhap.Font = new Font("Segoe UI", 12F);
            tbt_TenDangNhap.Location = new Point(2, 2);
            tbt_TenDangNhap.Margin = new Padding(2);
            tbt_TenDangNhap.Name = "tbt_TenDangNhap";
            tbt_TenDangNhap.PlaceholderText = "Số điện thoại hoặc email";
            tbt_TenDangNhap.Size = new Size(278, 29);
            tbt_TenDangNhap.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbt_MatKhau);
            panel3.Location = new Point(286, 165);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 41);
            panel3.TabIndex = 3;
            // 
            // tbt_MatKhau
            // 
            tbt_MatKhau.BorderStyle = BorderStyle.FixedSingle;
            tbt_MatKhau.Font = new Font("Segoe UI", 12F);
            tbt_MatKhau.Location = new Point(0, 2);
            tbt_MatKhau.Margin = new Padding(2);
            tbt_MatKhau.Name = "tbt_MatKhau";
            tbt_MatKhau.PasswordChar = '*';
            tbt_MatKhau.PlaceholderText = "Mật khẩu";
            tbt_MatKhau.Size = new Size(278, 29);
            tbt_MatKhau.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(284, 85);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 4;
            label4.Text = "Tài khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(284, 146);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 5;
            label5.Text = "Mật khẩu";
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Cursor = Cursors.Hand;
            btn_DangNhap.FlatAppearance.BorderColor = Color.FromArgb(29, 135, 209);
            btn_DangNhap.FlatStyle = FlatStyle.Flat;
            btn_DangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_DangNhap.ForeColor = Color.FromArgb(29, 135, 209);
            btn_DangNhap.Location = new Point(310, 249);
            btn_DangNhap.Margin = new Padding(2);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(94, 48);
            btn_DangNhap.TabIndex = 7;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = false;
            btn_DangNhap.Click += btn_DangNhap_Click;
            btn_DangNhap.MouseEnter += btn_DangNhap_MouseEnter;
            btn_DangNhap.MouseLeave += btn_DangNhap_MouseLeave;
            // 
            // btn_Thoat
            // 
            btn_Thoat.BackColor = Color.White;
            btn_Thoat.Cursor = Cursors.Hand;
            btn_Thoat.FlatAppearance.BorderColor = Color.FromArgb(29, 135, 209);
            btn_Thoat.FlatStyle = FlatStyle.Flat;
            btn_Thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Thoat.ForeColor = Color.FromArgb(29, 135, 209);
            btn_Thoat.Location = new Point(453, 249);
            btn_Thoat.Margin = new Padding(2);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(94, 48);
            btn_Thoat.TabIndex = 8;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = false;
            btn_Thoat.Click += button2_Click;
            btn_Thoat.MouseEnter += btn_Thoat_MouseEnter;
            btn_Thoat.MouseLeave += btn_Thoat_MouseLeave;
            // 
            // llb_QuenMK
            // 
            llb_QuenMK.ActiveLinkColor = Color.FromArgb(29, 135, 209);
            llb_QuenMK.AutoSize = true;
            llb_QuenMK.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llb_QuenMK.LinkColor = Color.Black;
            llb_QuenMK.Location = new Point(453, 208);
            llb_QuenMK.Margin = new Padding(2, 0, 2, 0);
            llb_QuenMK.Name = "llb_QuenMK";
            llb_QuenMK.Size = new Size(111, 19);
            llb_QuenMK.TabIndex = 9;
            llb_QuenMK.TabStop = true;
            llb_QuenMK.Text = "Quên mật khẩu?";
            llb_QuenMK.VisitedLinkColor = Color.FromArgb(29, 135, 209);
            llb_QuenMK.LinkClicked += llb_QuenMK_LinkClicked;
            llb_QuenMK.MouseEnter += linkLabel1_MouseEnter;
            llb_QuenMK.MouseLeave += llb_QuenMK_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.d06b29da1429b677ef38;
            pictureBox2.Location = new Point(555, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(575, 333);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(llb_QuenMK);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_DangNhap);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private TextBox tbt_TenDangNhap;
        private Label label5;
        private TextBox tbt_MatKhau;
        private Button btn_DangNhap;
        private Button btn_Thoat;
        private LinkLabel llb_QuenMK;
        private PictureBox pictureBox2;
    }
}
