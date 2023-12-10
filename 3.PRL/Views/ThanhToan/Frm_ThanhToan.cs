﻿using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views.ThanhToan
{
    public partial class Frm_ThanhToan : Form
    {
        HoaDonService _hoaDonService = new HoaDonService();
        NhanVienService _nhanVienService = new NhanVienService();
        KhachHangService _khachHangService = new KhachHangService();
        VanChuyenService _vanChuyenService = new VanChuyenService();
        PtttSerivce _ptttService = new PtttSerivce();
        LichSuttService _lichSuttService = new LichSuttService();
        HoaDonCTService _HDctService = new HoaDonCTService();
        BienTheService _bienTheService = new BienTheService();
        GiamGiaService _giamGiaService = new GiamGiaService();
        HoaDonCTService _hdctService = new HoaDonCTService();
        SanPhamService _sanPhamService = new SanPhamService();

        Guid _id;
        List<Guid> _idKH = new List<Guid>();
        List<Guid> _idNV = new List<Guid>();
        List<Guid> _idVC = new List<Guid>();
        List<Guid> _idBT = new List<Guid>();
        List<Guid> _idGG = new List<Guid>();
        List<Guid> _idSanPham = new List<Guid>();
        List<Guid> _idHD = new List<Guid>();
        List<Guid> _idPttt = new List<Guid>();
        public Frm_ThanhToan()
        {
            InitializeComponent();
        }

        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            LoadMaHD();
            LoadPTTT();
            LoadSPMua();

            dtpNgayTao.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayTao.Format = DateTimePickerFormat.Custom;

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_HoaDonBanHang frm_HoaDonBanHang = new Frm_HoaDonBanHang();
            frm_HoaDonBanHang.Show();
        }

        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show("Bạn muốn đăng xuất không ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                this.Hide();
                Frm_DangNhap2 frm_DangNhap = new Frm_DangNhap2();
                frm_DangNhap.Show();
            }
            else
            {
                return;
            }
        }

        private void LoadMaHD()
        {
            cmbMaHD.Items.Clear();
            foreach (var item in _hoaDonService.GetHoaDon(null))
            {
                string MaHoaDon = item.IdHoaDon.ToString().Substring(item.IdHoaDon.ToString().Length - 10).ToUpper();
                _idHD.Add(item.IdHoaDon);
                cmbMaHD.Items.Add(MaHoaDon);
            }
            cmbMaHD.SelectedIndex = -1;
        }

        private void LoadPTTT()
        {
            cmbPTTT.Items.Clear();
            foreach (var item in _ptttService.GetPTTT())
            {
                _idPttt.Add(item.IdPttt);
                cmbPTTT.Items.Add(item.Ten);
            }
            cmbPTTT.SelectedIndex = -1;
        }

        private void LoadSPMua()
        {
            dgvSPMua.ColumnCount = 10;
            dgvSPMua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSPMua.Columns[0].Name = "ID";
            dgvSPMua.Columns[0].Visible = false;
            dgvSPMua.Columns[1].Name = "STT";
            dgvSPMua.Columns[1].Width = 60;
            dgvSPMua.Columns[2].Name = "Mã HD";
            dgvSPMua.Columns[2].Width = 150;
            dgvSPMua.Columns[3].Name = "Mã Biến Thể";
            dgvSPMua.Columns[4].Name = "Tên sản phẩm";
            dgvSPMua.Columns[5].Name = "Số Lượng";
            dgvSPMua.Columns[5].Width = 80;
            dgvSPMua.Columns[6].Name = "Đơn Giá";
            dgvSPMua.Columns[7].Name = "Giảm Giá %";
            dgvSPMua.Columns[7].Width = 80;
            dgvSPMua.Columns[8].Name = "Chiết Khấu";
            dgvSPMua.Columns[9].Name = "Thành Tiền";
        }
        private void cmbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaHD = cmbMaHD.SelectedItem.ToString();
            int stt = 1;
            dgvSPMua.Rows.Clear();

            decimal tongTienPhaiThanhToan = 0;
            foreach (var item in _hdctService.GetHoaDonCts(selectedMaHD))
            {
                var HD = _hoaDonService.GetHoaDon(null).FirstOrDefault(a => a.IdHoaDon == item.IdHoaDon);
                var BT = _bienTheService.GetBienThe(null).FirstOrDefault(a => a.IdBienThe == item.IdBienThe);
                var GG = _giamGiaService.GetGiamGia(null).FirstOrDefault(a => a.IdGiamGia == item.IdGiamGia);
                var SP = _sanPhamService.GetSanPham(null).FirstOrDefault(a => a.IdSanPham == BT.IdSanPham);

                var VC = (from a in _hoaDonService.GetHoaDon(null)
                          join b in _vanChuyenService.GetVanChuyen() on a.IdVc equals b.IdVc
                          select b.TongTien).FirstOrDefault();

                string idHoaDon = item.IdHoaDon.ToString();
                string MaHD = idHoaDon.Substring(idHoaDon.Length - 10);

                var sum = item.SoLuong * BT?.GiaTien;

                var giamGia = sum * Convert.ToDecimal(GG?.GiaTri) / 100;

                var thanhTien = sum - giamGia;

                dgvSPMua.Rows.Add(item.IdHoaDonCt, stt++, MaHD.ToUpper(), BT.MaBienThe, SP.Ten, item.SoLuong,
                    Convert.ToDecimal(BT.GiaTien).ToString("N0"), GG.GiaTri,
                    Convert.ToDecimal(giamGia).ToString("N0"),
                    Convert.ToDecimal(thanhTien).ToString("N0"));

                tongTienPhaiThanhToan += thanhTien.Value;
                tongTienPhaiThanhToan += Convert.ToDecimal(VC);

                //txtTienPhaiThanhToan.Text = Convert.ToDecimal(tongTienPhaiThanhToan).ToString("N0");
                txtTienPhaiThanhToan.Text = Convert.ToDecimal(VC).ToString("N0");
            }

            foreach (var item in _hoaDonService.GetHoaDon(selectedMaHD))
            {
                var KH = _khachHangService.GetKhach(null).FirstOrDefault(a => a.IdKh == item.IdKh);
                var NV = _nhanVienService.GetNhanVien(null).FirstOrDefault(a => a.IdNv == item.IdNv);
                var VC = _vanChuyenService.GetVanChuyen().FirstOrDefault(a => a.IdVc == item.IdVc);
                var CT = _HDctService.GetHoaDonCts(null).FirstOrDefault(a => a.IdHoaDon == item.IdHoaDon);
                var hoaDonCT = _hdctService.GetHoaDonCts(null).Where(a => a.IdHoaDon == item.IdHoaDon).ToList();

                cmbNhanVien.Text = NV?.Ten;
                cmbKhachHang.Text = KH?.TenKh;
                dtpNgayTao.Text = item.NgayGd.ToString();
                cmbVanChuyen.Text = VC?.TongTien;
            }


        }
    }
}
