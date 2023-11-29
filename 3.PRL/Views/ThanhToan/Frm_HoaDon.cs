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
    public partial class Frm_HoaDon : Form
    {
        HoaDonService _hoaDonService = new HoaDonService();
        NhanVienService _nhanVienService = new NhanVienService();
        KhachHangService _khachHangService = new KhachHangService();
        VanChuyenService _vanChuyenService = new VanChuyenService();
        PtttSerivce _ptttService = new PtttSerivce();
        LichSuttService _lichSuttService = new LichSuttService();

        public Frm_HoaDon()
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

        private void LoadVanChuyen()
        {
            var lst = (from a in _vanChuyenService.GetVanChuyen()
                       select a.TongTien).ToArray();

            cmbVanChuyen.Items.AddRange(lst);
        }





        private void LoadGridHD(string input)
        {
            int stt = 1;
            dgvDSHD.ColumnCount = 8;
            dgvDSHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSHD.Columns[0].Name = "ID";
            dgvDSHD.Columns[0].Visible = false;
            dgvDSHD.Columns[1].Name = "STT";
            dgvDSHD.Columns[2].Name = "Khách Hàng";
            dgvDSHD.Columns[3].Name = "Nhân Viên";
            dgvDSHD.Columns[4].Name = "Ngày Tạo";
            dgvDSHD.Columns[5].Name = "Trạng Thái";
            dgvDSHD.Columns[6].Name = "Thanh toán";
            dgvDSHD.Columns[7].Name = "Phí vận chuyển";
            dgvDSHD.Rows.Clear();

            var lst = from a in _hoaDonService.GetHoaDon(null)
                      join b in _khachHangService.GetKhach(null) on a.IdKh equals b.IdKh
                      join c in _nhanVienService.GetNhanVien(null) on a.IdNv equals c.IdNv
                      join d in _lichSuttService.GetLichSuTt() on a.IdHoaDon equals d.IdHoaDon
                      join e in _ptttService.GetPTTT() on d.IdPttt equals e.IdPttt
                      join f in _vanChuyenService.GetVanChuyen() on a.IdVc equals f.IdVc
                      select new
                      {
                          Id = a.IdHoaDon,
                          khachHang = b.TenKh,
                          nhanVien = c.Ten,
                          ngayTao = a.NgayGd,
                          trangThai = a.TrangThai,
                          thanhToan = e.Ten,
                          vanChuyen = f.TongTien
                      };

            if (txtTimKiem.Text != null)
            {
                lst = lst.Where(a => a.khachHang.ToLower().Contains(txtTimKiem.Text.ToLower()));
            }

            foreach (var item in lst)
            {
                dgvDSHD.Rows.Add(item.Id, stt++, item.khachHang, item.nhanVien, item.ngayTao, (item.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán"), item.thanhToan, item.vanChuyen);

            }
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex > dgvDSHD.RowCount)
                return;

            var selectedHoaDon = dgvDSHD.Rows[rowIndex];
            cmbKhachHang.Text = selectedHoaDon.Cells[2].Value.ToString();
            cmbNhanVien.Text = selectedHoaDon.Cells[3].Value.ToString();
            dtpNgayTao.Text = selectedHoaDon.Cells[4].Value.ToString();
            if (selectedHoaDon.Cells[5].Value.ToString().Equals("Đã thanh toán"))
            {
                rdbDaThanhToan.Checked = true;
            }
            else
            {
                rdbChuaThanhToan.Checked = true;
            }
            cmbPTTT.Text = selectedHoaDon.Cells[6].Value.ToString();
            cmbVanChuyen.Text = selectedHoaDon.Cells[7].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
