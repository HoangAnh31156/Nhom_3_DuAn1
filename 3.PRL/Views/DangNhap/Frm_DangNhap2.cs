using _1.DAL.Model2s;
using _2.BUS.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views.DangNhap
{
    public partial class Frm_DangNhap2 : Form
    {
        private readonly OnlyFansContext _taikhoansv;
        public Frm_DangNhap2()
        {
            InitializeComponent();
            _taikhoansv = new();
        }

        private void linkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Frm_QuenMK frm_QuenMK = new Frm_QuenMK();
            frm_QuenMK.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;

            var user = _taikhoansv.TaiKhoans.Include(u => u.IdVaiTroNavigation)
                .FirstOrDefault(u => u.TaiKhoan1 == username && u.MatKhau == password);

            if (user != null)
            {
                this.Hide();

                if (user.IdVaiTroNavigation != null && user.IdVaiTroNavigation.Ten == "Quản lý")
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Admin!");
                    Frm_TrangChu frm_TrangChuAdmin = new Frm_TrangChu(user, true);
                    frm_TrangChuAdmin.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Nhân viên!");
                    Frm_TrangChu frm_TrangChuNhanVien = new Frm_TrangChu(user, false);
                    frm_TrangChuNhanVien.Show();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!!!!!!!!!!!!!");
            }
        }
    }
}
