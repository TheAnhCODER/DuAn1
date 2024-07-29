namespace GUI
{
    partial class FormBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBank));
            pictureBox1 = new PictureBox();
            btn_xacNhanThanhToan = new Button();
            btn_ThanhToanThaiBai = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 319);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_xacNhanThanhToan
            // 
            btn_xacNhanThanhToan.BackColor = Color.FromArgb(29, 135, 209);
            btn_xacNhanThanhToan.Cursor = Cursors.Hand;
            btn_xacNhanThanhToan.FlatStyle = FlatStyle.Flat;
            btn_xacNhanThanhToan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xacNhanThanhToan.ForeColor = Color.White;
            btn_xacNhanThanhToan.Location = new Point(164, 356);
            btn_xacNhanThanhToan.Name = "btn_xacNhanThanhToan";
            btn_xacNhanThanhToan.Size = new Size(120, 45);
            btn_xacNhanThanhToan.TabIndex = 1;
            btn_xacNhanThanhToan.Text = "Xác nhận thanh toán";
            btn_xacNhanThanhToan.UseVisualStyleBackColor = false;
            btn_xacNhanThanhToan.Click += btn_xacNhanThanhToan_Click;
            // 
            // btn_ThanhToanThaiBai
            // 
            btn_ThanhToanThaiBai.BackColor = Color.FromArgb(29, 135, 209);
            btn_ThanhToanThaiBai.Cursor = Cursors.Hand;
            btn_ThanhToanThaiBai.FlatStyle = FlatStyle.Flat;
            btn_ThanhToanThaiBai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThanhToanThaiBai.ForeColor = Color.White;
            btn_ThanhToanThaiBai.Location = new Point(12, 356);
            btn_ThanhToanThaiBai.Name = "btn_ThanhToanThaiBai";
            btn_ThanhToanThaiBai.Size = new Size(120, 45);
            btn_ThanhToanThaiBai.TabIndex = 1;
            btn_ThanhToanThaiBai.Text = "Thanh toán chưa thành công";
            btn_ThanhToanThaiBai.UseVisualStyleBackColor = false;
            btn_ThanhToanThaiBai.Click += btn_ThanhToanThaiBai_Click;
            // 
            // FormBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(307, 413);
            Controls.Add(btn_ThanhToanThaiBai);
            Controls.Add(btn_xacNhanThanhToan);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBank";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chuyển khoản";
            Load += FormBank_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_xacNhanThanhToan;
        private Button btn_ThanhToanThaiBai;
    }
}