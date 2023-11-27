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

namespace _3.PRL.Views.SanPham
{
    public partial class Frm_ThemSP : Form
    {
        private SanPhamService _SanPhamService;
        private LoaiSPService _LoaiSPService;
        public Frm_ThemSP()
        {
            InitializeComponent();
            _SanPhamService = new SanPhamService();
            _LoaiSPService = new LoaiSPService();
            LoadGridviewSp(null);
            LoadAttribute();
        }
        private void LoadAttribute()
        {
            var lst = (from i in _LoaiSPService.GetLoaiSanPham(null)
                       select i.TenLoai).ToArray();
            cboLoaiSp.Items.AddRange(lst);
        }
        private void LoadGridviewSp(string name)
        {
            GirdSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int stt = 1;
            GirdSp.Rows.Clear();
            GirdSp.ColumnCount = 5;
            GirdSp.Columns[0].Name = "STT";
            GirdSp.Columns[1].Name = "Mã Sản Phẩm";
            GirdSp.Columns[2].Name = "Tên";
            GirdSp.Columns[3].Name = "Số Lượng";
            GirdSp.Columns[4].Name = "Loại Sản Phẩm";
            var lst = from i in _SanPhamService.GetSanPham(null)
                      join y in _LoaiSPService.GetLoaiSanPham(null)
                      on i.IdLoaiSanPham equals y.IdLoaiSanPham
                      select new
                      {
                          MaSp = i.MaSanPham,
                          ten = i.Ten,
                          soluong = i.SoLuong,
                          Loai = y.TenLoai
                      };
            foreach (var i in lst)
            {
                GirdSp.Rows.Add(stt, i.MaSp, i.ten, i.soluong, i.Loai);
                stt++;
            }
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

        private void btnThemCTKhac_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemCTKhac frm_ThemCTKhac = new Frm_ThemCTKhac();
            frm_ThemCTKhac.Show();
        }

        private void btnThemBienThe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemBienThe frm_ThemBien = new Frm_ThemBienThe();
            frm_ThemBien.Show();
        }
    }
}
