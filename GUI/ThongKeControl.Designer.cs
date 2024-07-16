namespace GUI
{
    partial class ThongKeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeControl));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            btn_DoanhThu_ThongKe = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            button2 = new Button();
            panel5 = new Panel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(368, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 0;
            label1.Text = "Thống Kê";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(821, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 135, 209);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 44);
            panel1.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(117, 35);
            panel6.Name = "panel6";
            panel6.Size = new Size(626, 1);
            panel6.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(102, 204, 255);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btn_DoanhThu_ThongKe);
            panel2.Location = new Point(21, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 159);
            panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(102, 204, 255);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(36, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 23);
            textBox1.TabIndex = 6;
            // 
            // btn_DoanhThu_ThongKe
            // 
            btn_DoanhThu_ThongKe.Cursor = Cursors.Hand;
            btn_DoanhThu_ThongKe.Dock = DockStyle.Top;
            btn_DoanhThu_ThongKe.Enabled = false;
            btn_DoanhThu_ThongKe.FlatAppearance.BorderSize = 0;
            btn_DoanhThu_ThongKe.FlatStyle = FlatStyle.Flat;
            btn_DoanhThu_ThongKe.Font = new Font("Calibri", 16.25F);
            btn_DoanhThu_ThongKe.ForeColor = Color.White;
            btn_DoanhThu_ThongKe.Image = (Image)resources.GetObject("btn_DoanhThu_ThongKe.Image");
            btn_DoanhThu_ThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DoanhThu_ThongKe.Location = new Point(0, 0);
            btn_DoanhThu_ThongKe.Name = "btn_DoanhThu_ThongKe";
            btn_DoanhThu_ThongKe.Size = new Size(200, 57);
            btn_DoanhThu_ThongKe.TabIndex = 5;
            btn_DoanhThu_ThongKe.Text = " Sản Phẩm";
            btn_DoanhThu_ThongKe.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(102, 204, 255);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(227, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 159);
            panel3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 16.25F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 57);
            button1.TabIndex = 5;
            button1.Text = " Sản Phẩm";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(102, 204, 255);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(433, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 159);
            panel4.TabIndex = 6;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 16.25F);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(200, 57);
            button2.TabIndex = 5;
            button2.Text = " Sản Phẩm";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(102, 204, 255);
            panel5.Controls.Add(button3);
            panel5.Location = new Point(639, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 159);
            panel5.TabIndex = 6;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 16.25F);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(200, 57);
            button3.TabIndex = 5;
            button3.Text = " Sản Phẩm";
            button3.UseVisualStyleBackColor = true;
            // 
            // ThongKeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ThongKeControl";
            Size = new Size(868, 628);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Button btn_DoanhThu_ThongKe;
        private Panel panel3;
        private Button button1;
        private Panel panel4;
        private Button button2;
        private Panel panel5;
        private Button button3;
        private TextBox textBox1;
        private Panel panel6;
    }
}
