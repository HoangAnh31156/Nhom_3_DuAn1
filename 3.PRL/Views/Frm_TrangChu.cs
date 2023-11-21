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

namespace _3.PRL.Views
{
    public partial class Frm_TrangChu : Form
    {
        public Frm_TrangChu()
        {
            InitializeComponent();
        }


        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap2 frm_DangNhap = new Frm_DangNhap2();
            frm_DangNhap.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_SanPham frm_SanPham = new Frm_SanPham();
            frm_SanPham.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_KhachHang frm_KhachHang = new Frm_KhachHang();
            frm_KhachHang.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_NhanVien frm_NhanVien = new Frm_NhanVien();
            frm_NhanVien.Show();
        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BaoHanh frm_BaoHanh = new Frm_BaoHanh();
            frm_BaoHanh.Show();
        }

        private void btnDoiTra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DoiTra frm_DoiTra = new Frm_DoiTra();
            frm_DoiTra.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThanhToan frm_ThanhToan = new Frm_ThanhToan();
            frm_ThanhToan.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TaiKhoan frm_TaiKhoan = new Frm_TaiKhoan();
            frm_TaiKhoan.Show();
        }
    }
}
