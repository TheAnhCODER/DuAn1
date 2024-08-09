namespace GUI
{
    partial class TaiKhoanControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoanControl));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_matkhaumoi = new TextBox();
            tb_matkhaucu = new TextBox();
            tb_nhaplaimatkhau = new TextBox();
            tb_capcha = new TextBox();
            tb_hiencapcha = new TextBox();
            btn_doimatkhau = new Button();
            tb_loadcapcha = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tb_loadcapcha).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(821, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 135, 209);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 44);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(121, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(626, 1);
            panel4.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(361, 4);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 10;
            label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(204, 255);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(214, 188);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 5;
            label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(173, 313);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 6;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(223, 377);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 7;
            label5.Text = "Mã Capcha";
            // 
            // tb_matkhaumoi
            // 
            tb_matkhaumoi.Location = new Point(348, 252);
            tb_matkhaumoi.Name = "tb_matkhaumoi";
            tb_matkhaumoi.Size = new Size(201, 23);
            tb_matkhaumoi.TabIndex = 8;
            tb_matkhaumoi.TextChanged += tb_matkhaumoi_TextChanged;
            // 
            // tb_matkhaucu
            // 
            tb_matkhaucu.Location = new Point(348, 185);
            tb_matkhaucu.Name = "tb_matkhaucu";
            tb_matkhaucu.Size = new Size(201, 23);
            tb_matkhaucu.TabIndex = 9;
            tb_matkhaucu.TextChanged += tb_matkhaucu_TextChanged;
            // 
            // tb_nhaplaimatkhau
            // 
            tb_nhaplaimatkhau.Location = new Point(348, 314);
            tb_nhaplaimatkhau.Name = "tb_nhaplaimatkhau";
            tb_nhaplaimatkhau.Size = new Size(201, 23);
            tb_nhaplaimatkhau.TabIndex = 10;
            tb_nhaplaimatkhau.TextChanged += tb_nhaplaimatkhau_TextChanged;
            // 
            // tb_capcha
            // 
            tb_capcha.Location = new Point(348, 377);
            tb_capcha.Name = "tb_capcha";
            tb_capcha.Size = new Size(201, 23);
            tb_capcha.TabIndex = 11;
            tb_capcha.TextChanged += tb_capcha_TextChanged;
            // 
            // tb_hiencapcha
            // 
            tb_hiencapcha.BackColor = Color.FromArgb(29, 135, 209);
            tb_hiencapcha.BorderStyle = BorderStyle.None;
            tb_hiencapcha.Location = new Point(602, 377);
            tb_hiencapcha.Multiline = true;
            tb_hiencapcha.Name = "tb_hiencapcha";
            tb_hiencapcha.ReadOnly = true;
            tb_hiencapcha.Size = new Size(61, 20);
            tb_hiencapcha.TabIndex = 12;
            tb_hiencapcha.TextChanged += tb_hiencapcha_TextChanged;
            // 
            // btn_doimatkhau
            // 
            btn_doimatkhau.BackColor = Color.FromArgb(29, 135, 209);
            btn_doimatkhau.FlatStyle = FlatStyle.Flat;
            btn_doimatkhau.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_doimatkhau.ForeColor = Color.White;
            btn_doimatkhau.Location = new Point(378, 436);
            btn_doimatkhau.Name = "btn_doimatkhau";
            btn_doimatkhau.Size = new Size(122, 43);
            btn_doimatkhau.TabIndex = 13;
            btn_doimatkhau.Text = "Đổi mật khẩu";
            btn_doimatkhau.UseVisualStyleBackColor = false;
            btn_doimatkhau.Click += btn_doimatkhau_Click;
            // 
            // tb_loadcapcha
            // 
            tb_loadcapcha.Image = (Image)resources.GetObject("tb_loadcapcha.Image");
            tb_loadcapcha.Location = new Point(693, 377);
            tb_loadcapcha.Name = "tb_loadcapcha";
            tb_loadcapcha.Size = new Size(45, 39);
            tb_loadcapcha.SizeMode = PictureBoxSizeMode.CenterImage;
            tb_loadcapcha.TabIndex = 14;
            tb_loadcapcha.TabStop = false;
            tb_loadcapcha.Click += tb_loadcapcha_Click;
            // 
            // TaiKhoanControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tb_loadcapcha);
            Controls.Add(btn_doimatkhau);
            Controls.Add(tb_hiencapcha);
            Controls.Add(tb_capcha);
            Controls.Add(tb_nhaplaimatkhau);
            Controls.Add(tb_matkhaucu);
            Controls.Add(tb_matkhaumoi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "TaiKhoanControl";
            Size = new Size(868, 628);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tb_loadcapcha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_matkhaumoi;
        private TextBox tb_matkhaucu;
        private TextBox tb_nhaplaimatkhau;
        private TextBox tb_capcha;
        private TextBox tb_hiencapcha;
        private Button btn_doimatkhau;
        private PictureBox tb_loadcapcha;
    }
}
