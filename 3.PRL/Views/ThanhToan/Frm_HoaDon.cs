using _1.DAL.Model2s;
using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        HoaDonCTService _HDctService = new HoaDonCTService();
        Guid _id;

        List<Guid> _idKH = new List<Guid>();
        List<Guid> _idNV = new List<Guid>();
        List<Guid> _idVC = new List<Guid>();
        List<Guid> _idPttt = new List<Guid>();

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
            LoadVanChuyen();
            //LoadPttt();
        }

        private void LoadNhanVien()
        {
            foreach (var item in _nhanVienService.GetNhanVien(null))
            {
                _idNV.Add(item.IdNv);
                cmbNhanVien.Items.Add(item.Ten);
            }
            cmbNhanVien.SelectedIndex = -1;
        }

        private void LoadKhachHang()
        {
            foreach (var item in _khachHangService.GetKhach(null))
            {
                _idKH.Add(item.IdKh);
                cmbKhachHang.Items.Add(item.TenKh);
            }
            cmbKhachHang.SelectedIndex = -1;
        }

        private void LoadVanChuyen()
        {
            foreach (var item in _vanChuyenService.GetVanChuyen().OrderBy(a => a.TongTien.Length).ThenBy(b => b.TongTien))
            {
                _idVC.Add(item.IdVc);
                cmbVanChuyen.Items.Add(item.TongTien);
            }
            cmbKhachHang.SelectedIndex = -1;
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

            dgvDSHD.Columns[6].Name = "Phí vận chuyển";
            dgvDSHD.Columns[7].Name = "Thanh Toan";
            dgvDSHD.Rows.Clear();
            /*
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
                          vanChuyen = f.TongTien,
                          TinhTien = a.TongTien
                      };
            
            if (txtTimKiem.Text != null)
            {
                lst = lst.Where(a => a.khachHang.ToLower().Contains(txtTimKiem.Text.ToLower()));
            }

            foreach (var item in lst)
            {
                dgvDSHD.Rows.Add(item.Id, stt++, item.khachHang, item.nhanVien, item.ngayTao,
                    (item.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán"), item.vanChuyen,
                    item.TinhTien);
            }
            */

            foreach (var item in _hoaDonService.GetHoaDon(null))
            {
                var KH = _khachHangService.GetKhach(null).FirstOrDefault(a => a.IdKh == item.IdKh);
                var NV = _nhanVienService.GetNhanVien(null).FirstOrDefault(a => a.IdNv == item.IdNv);
                var VC = _vanChuyenService.GetVanChuyen().FirstOrDefault(a => a.IdVc == item.IdVc);
                var CT = _HDctService.GetHoaDonCts(null).FirstOrDefault(a => a.IdHoaDon == item.IdHoaDon);

                item.TongTien = CT?.SoLuong * CT?.Gia + Convert.ToDecimal(VC?.TongTien);

                dgvDSHD.Rows.Add(item.IdHoaDon, stt++, KH?.TenKh, NV?.Ten,
                    item.NgayGd, item.TrangThai == true ? "Đã thanh toán" : "Chưa thanh toán",
                    VC?.TongTien, item?.TongTien);
            }
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex > dgvDSHD.RowCount)
                return;

            var selectedHoaDon = dgvDSHD.Rows[rowIndex];
            _id = Guid.Parse(selectedHoaDon.Cells[0].Value.ToString());
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
            
            cmbVanChuyen.Text = selectedHoaDon.Cells[6].Value.ToString();
        }

        private void ThemHD()
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();         
            hd.IdHoaDon = new Guid();
            hd.NgayGd = dtpNgayTao.Value;
            hd.IdKh = _idKH[cmbKhachHang.SelectedIndex];
            hd.IdNv = _idNV[cmbNhanVien.SelectedIndex];
            hd.IdVc = _idVC[cmbVanChuyen.SelectedIndex];

            if (rdbChuaThanhToan.Checked)
            {
                hd.TrangThai = false;
            }
            else
            {
                hd.TrangThai = true;
            }
            hd.TongTien = 0;

            if (_hoaDonService.AddHoaDon(hd))
            {
                MessageBox.Show("Tạo Hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Tạo Hóa đơn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadGridHD(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HoaDon updateHD = new HoaDon();
            updateHD.NgayGd = dtpNgayTao.Value;
            updateHD.IdKh = _idKH[cmbKhachHang.SelectedIndex];
            updateHD.IdNv = _idNV[cmbNhanVien.SelectedIndex];
            updateHD.IdVc = _idVC[cmbVanChuyen.SelectedIndex];

            if (rdbChuaThanhToan.Checked)
            {
                updateHD.TrangThai = false;
            }
            else
            {
                updateHD.TrangThai = true;
            }

            if (_hoaDonService.UpdateHoaDon(_id,updateHD))
            {
                MessageBox.Show("Sửa Hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Sửa Hóa đơn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadGridHD(null);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpNgayTao.Value = DateTime.Today;
            cmbNhanVien.SelectedIndex = -1;
            cmbKhachHang.SelectedIndex = -1;
            
            cmbVanChuyen.SelectedIndex = -1;
            rdbChuaThanhToan.Checked = true;
        }
    }
}
