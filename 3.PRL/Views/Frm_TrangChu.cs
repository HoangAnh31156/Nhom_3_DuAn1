using _1.DAL.Model2s;
using _3.PRL.Views.DangNhap;
using _3.PRL.Views.GiamGia;
using _3.PRL.Views.ThanhToan;
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

        public Frm_TrangChu(TaiKhoan user, bool isAdmin)
        {
            InitializeComponent();
            this.user = user;
            this.isAdmin = isAdmin;
        }

        private TaiKhoan user;
        private bool isAdmin;
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
            // Kiểm tra xem Users có null hay không trước khi truy cập các thuộc tính
            if (user != null && user.IdVaiTroNavigation != null)
            {
                var roleTen = user.IdVaiTroNavigation.Ten;

                // Kiểm tra xem Ten có null hay không trước khi so sánh giá trị
                if (roleTen != null && roleTen.Equals("Quản lý", StringComparison.OrdinalIgnoreCase))
                {
                    this.Hide();
                    Frm_NhanVien frm_NhanVien = new Frm_NhanVien();
                    frm_NhanVien.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
                }
            }
            //else
            //{
            //    MessageBox.Show("Dữ liệu người dùng không hợp lệ.");
            //}
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
            Frm_HoaDonBanHang frm = new();
            frm.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TaiKhoan frm_TaiKhoan = new Frm_TaiKhoan();
            frm_TaiKhoan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_GiamGia frm_GiamGia = new Frm_GiamGia();
            frm_GiamGia.Show();
        }
    }
}
