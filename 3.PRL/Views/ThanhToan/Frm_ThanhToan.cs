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

namespace _3.PRL.Views
{
    public partial class Frm_ThanhToan : Form
    {
        HoaDonService _hoaDonService = new HoaDonService();
        NhanVienService _nhanVienService = new NhanVienService();
        KhachHangService _khachHangService = new KhachHangService();
        BienTheService _bienTheService = new BienTheService();
        HoaDonCTService _hoaDonCTService = new HoaDonCTService();
        SanPhamService _sanPhamService = new SanPhamService();

        public Frm_ThanhToan()
        {
            InitializeComponent();
        }

        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap2 frm_DangNhap = new Frm_DangNhap2();
            frm_DangNhap.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TrangChu frm_TrangChu = new Frm_TrangChu();
            frm_TrangChu.Show();
        }

        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            LoadGridHD(null);
            LoadNhanVien();
            LoadKhachHang();
            LoadSanPham();
        }

        private void LoadNhanVien()
        {
            var lst = (from a in _nhanVienService.GetNhanVien(null)
                       select a.Ten).ToArray();

            cmbNhanVien.Items.AddRange(lst);
        }

        private void LoadKhachHang()
        {
            var lst = (from a in _khachHangService.GetKhach(null)
                       select a.TenKh).ToArray();

            cmbKhachHang.Items.AddRange(lst);
        }

        private void LoadBienThe()
        {
            //var lst = (from a in _bienTheService.GetBienThe(null)
            //           select a.MaBienThe).ToArray();

            //cmbBienThe.Items.AddRange(lst);

            cmbBienThe.Items.Clear();

            if (cmbSanPham.SelectedItem != null)
            {
                string selectedSanPham = cmbSanPham.SelectedItem.ToString();

                var bienTheList = _bienTheService.GetBienThe(selectedSanPham);
                var maBienTheList = bienTheList.Select(b => b.MaBienThe).ToArray();

                cmbBienThe.Items.AddRange(maBienTheList);
            }
        }

        private void LoadSanPham()
        {
            //var lst = (from a in _sanPhamService.GetSanPham(null)
            //           select a.MaSanPham).ToArray();

            //cmbSanPham.Items.AddRange(lst);

            var sanPhamList = _sanPhamService.GetSanPham(null);

            cmbSanPham.Items.AddRange(sanPhamList.Select(s => s.MaSanPham).ToArray());

            cmbSanPham.SelectedIndexChanged += CmbSanPham_SelectedIndexChanged;
        }

        private void CmbSanPham_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadBienThe();
        }

        private void LoadGridHD(string input)
        {
            //int stt = 1;
            dgvHoaDonCT.ColumnCount = 7;
            dgvHoaDonCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDonCT.Columns[0].Name = "ID";
            dgvHoaDonCT.Columns[0].Visible = false;
            //dgvHoaDonCT.Columns[1].Name = "STT";
            dgvHoaDonCT.Columns[1].Name = "Mã Sản phẩm";
            dgvHoaDonCT.Columns[2].Name = "Mã Biến thể";
            dgvHoaDonCT.Columns[3].Name = "Tên";
            dgvHoaDonCT.Columns[4].Name = "Số lượng";
            dgvHoaDonCT.Columns[5].Name = "Giảm giá";
            dgvHoaDonCT.Columns[6].Name = "Thành tiền";
            dgvHoaDonCT.Rows.Clear();

            foreach (var item in _hoaDonService.GetHoaDon(input))
            {

            }
        }






    }
}
