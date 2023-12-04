using _3.PRL.Views.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views.ThanhToan
{
    public partial class Frm_HoaDonBanHang : Form
    {
        public Frm_HoaDonBanHang()
        {
            InitializeComponent();
        }

        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            Frm_DangNhap2 frm = new();
            this.Hide();
            frm.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Frm_TrangChu frm = new();
            this.Hide();
            frm.Show();
        }
    }
}
