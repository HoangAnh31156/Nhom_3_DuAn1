using _2.BUS.Services;
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

namespace _3.PRL.Views.KhachHang
{
    public partial class Frm_ThemKH : Form
    {
        KhachHangService _khachService;
        public Frm_ThemKH()
        {
            _khachService = new KhachHangService();
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

        private void btnDSKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_KhachHang frm_KhachHang = new Frm_KhachHang();
            frm_KhachHang.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenKH.Text;
            string ngaySinh = txtNgaySinh.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            bool gioiTinh = rbtnNam.Checked;
            string diaChi = txtDiaChi.Text;
            bool add = _khachService.AddKhach(ten, Convert.ToDateTime(ngaySinh), sdt, email, gioiTinh, diaChi);
            if (add)
            {
                MessageBox.Show("Thêm khách thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!!!!!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //string ten = txtTenKH.Text;
            //string ngaySinh = txtNgaySinh.Text;
            //string sdt = txtSDT.Text;
            //string email = txtEmail.Text;
            //bool gioiTinh = rbtnNam.Checked;
            //string diaChi = txtDiaChi.Text;
            //bool add = _khachService.UpdateKhach(ten, Convert.ToDateTime(ngaySinh), sdt, email, gioiTinh, diaChi);
            //if (add)
            //{
            //    MessageBox.Show("Sửa khách thành công");
            //}
            //else
            //{
            //    MessageBox.Show("Sửa thất bại!!!!!!!");
            //}
            
        }
    }
}
