namespace Camera
{
    partial class FormCamera
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Tat = new System.Windows.Forms.Button();
            this.btn_Bat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Tat
            // 
            this.btn_Tat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btn_Tat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tat.ForeColor = System.Drawing.Color.White;
            this.btn_Tat.Location = new System.Drawing.Point(12, 97);
            this.btn_Tat.Name = "btn_Tat";
            this.btn_Tat.Size = new System.Drawing.Size(65, 21);
            this.btn_Tat.TabIndex = 6;
            this.btn_Tat.Text = "Tắt camera";
            this.btn_Tat.UseVisualStyleBackColor = false;
            this.btn_Tat.Click += new System.EventHandler(this.btn_Tat_Click);
            // 
            // btn_Bat
            // 
            this.btn_Bat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btn_Bat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bat.ForeColor = System.Drawing.Color.White;
            this.btn_Bat.Location = new System.Drawing.Point(82, 97);
            this.btn_Bat.Name = "btn_Bat";
            this.btn_Bat.Size = new System.Drawing.Size(65, 21);
            this.btn_Bat.TabIndex = 5;
            this.btn_Bat.Text = "Bật camera";
            this.btn_Bat.UseVisualStyleBackColor = false;
            this.btn_Bat.Click += new System.EventHandler(this.btn_Bat_Click);
            // 
            // FormCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(159, 145);
            this.Controls.Add(this.btn_Tat);
            this.Controls.Add(this.btn_Bat);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Camera_FormClosing);
            this.Load += new System.EventHandler(this.Camera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Tat;
        private System.Windows.Forms.Button btn_Bat;
    }
}