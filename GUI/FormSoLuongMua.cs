﻿using System;
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
    public partial class FormSoLuongMua : Form
    {
        public int SoLuongMua { get; set; }
        public FormSoLuongMua()
        {
            InitializeComponent();
        }

        

        private void FormSoLuongMua_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    SoLuongMua = int.Parse(textBox1.Text);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ!");
                }
            }
        }
    }
}
