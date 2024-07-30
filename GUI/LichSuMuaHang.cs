using DAL.Models;
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
    public partial class LichSuMuaHang : Form
    {

        Khach khachHang;
        HoaDon HoaDon;
        HoaDonChiTiet HoaDonChiTiet;

        public LichSuMuaHang()
        {
            InitializeComponent();
        }
        public LichSuMuaHang(string sdt)
        {
            InitializeComponent();
        }
    }

}
