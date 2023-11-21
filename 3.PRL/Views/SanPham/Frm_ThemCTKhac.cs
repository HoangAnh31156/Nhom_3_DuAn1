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

namespace _3.PRL.Views.SanPham
{
    public partial class Frm_ThemCTKhac : Form
    {
        public Frm_ThemCTKhac()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TrangChu frm_TrangChu = new Frm_TrangChu();
            frm_TrangChu.Show();
        }

        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap2 frm_DangNhap = new Frm_DangNhap2();
            frm_DangNhap.Show();
        }

        private void btnTCSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_SanPham frm_SanPham = new Frm_SanPham();
            frm_SanPham.Show();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemSP frm_ThemSP = new Frm_ThemSP();
            frm_ThemSP.Show();
        }

        private void btnThemBienThe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemBienThe frm_ThemBienThe = new Frm_ThemBienThe();
            frm_ThemBienThe.Show();
        }
    }
}
