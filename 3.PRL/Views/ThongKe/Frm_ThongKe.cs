﻿using _1.DAL.Model1s;
using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views.ThongKe
{
    public partial class Frm_ThongKe : Form
    {
        HoaDonService _hoaDonsv = new HoaDonService();
        SanPhamService _spService = new SanPhamService();
        HoaDonService _hoaDonService = new HoaDonService();
        HoaDonCTService _hdctService = new HoaDonCTService();
        BienTheService _btService = new BienTheService();
        GiamGiaService _ggService = new GiamGiaService();
        KhachHangService _kkService = new KhachHangService();
        NhanVienService _nvService = new NhanVienService();

        List<Guid> _idSp = new List<Guid>();


        public Frm_ThongKe()
        {
            InitializeComponent();

        }


        private void pbBack_Click(object sender, EventArgs e)
        {
            Frm_TrangChu frm = new Frm_TrangChu();
            this.Hide();
            frm.Show();
        }

        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            Frm_DangNhap2 frm = new Frm_DangNhap2();
            this.Hide();
            frm.Show();
        }


        private void rdbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTatCa.Checked)
            {
                cmbItems.Enabled = false;

            }
            else
            {
                cmbItems.Enabled = true;
            }
            cmbItems.SelectedIndex = -1;
        }

        private void LoadSanPham()
        {
            foreach (var item in _spService.GetSanPham(null))
            {
                _idSp.Add(item.IdSanPham);
                cmbItems.Items.Add(item.Ten);
            }
        }

        private DateTime fromDate;
        private DateTime toDate;
        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            LoadSanPham();

            dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;

            dtpDenNgay.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;

           fromDate = DateTime.Now.Date;
           toDate = DateTime.Now.Date.AddDays(1).AddMinutes(-1);

            dtpDenNgay.Value = toDate;
            dtpTuNgay.MinDate = DateTime.MinValue;
            dtpTuNgay.MaxDate = toDate;
            dtpTuNgay.Value = fromDate.AddMinutes(1);

           
        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (rdbSanPham.Checked)
            {
                ThongKeSanPham();
                return;
            }
            if (rdbTatCa.Checked)
            {
                ThongKeTatCa();
                return;
            }
        }
        private void ThongKeSanPham()
        {
            decimal tongDoanhThu = 0;
            int stt = 1;
            dgvThongKe.ColumnCount = 9;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.Columns[0].Name = "STT";
            dgvThongKe.Columns[0].Width = 50;
            dgvThongKe.Columns[1].Name = "Mã Hóa Đơn";
            dgvThongKe.Columns[1].Width = 120;
            dgvThongKe.Columns[2].Name = "Ngày Giao Dịch";
            dgvThongKe.Columns[2].Width = 200;
            
            dgvThongKe.Columns[3].Name = "Sản Phẩm";
            dgvThongKe.Columns[3].Width = 200;
            dgvThongKe.Columns[4].Name = "Đơn Giá";
            dgvThongKe.Columns[5].Name = "Số Lượng";
            dgvThongKe.Columns[6].Name = "Thành Tiền";
            dgvThongKe.Columns[7].Name = "Chiết khấu";
            dgvThongKe.Columns[8].Name = "Tổng Thanh Toán";
            dgvThongKe.Rows.Clear();

            foreach (var item in _hoaDonService.GetHoaDon(null))
            {
                DateTime tuNgay = dtpTuNgay.Value;
                DateTime denNgay = dtpDenNgay.Value;             

                var hdct = (from a in _hoaDonService.GetHoaDon(null)
                            join b in _hdctService.GetHoaDonCts(null) on a.IdHoaDon equals b.IdHoaDon
                            join c in _btService.GetBienThe(null) on b.IdBienThe equals c.IdBienThe
                            join d in _spService.GetSanPham(null) on c.IdSanPham equals d.IdSanPham
                            join e in _ggService.GetGiamGia() on b.IdGiamGia equals e.IdGiamGia
                            
                            where a.IdHoaDon == item.IdHoaDon && a.TrangThai == true && (a.NgayGd >= tuNgay && a.NgayGd <= denNgay)
                            select new
                            {
                                TenSp = d.Ten,
                                DonGia = c.GiaTien,
                                MaHD = a.IdHoaDon,
                                SL = b.SoLuong,
                                CK = e.GiaTri,
                                
                            }).ToList();


                foreach (var ct in hdct)
                {
                    string idHD = ct.MaHD.ToString();
                    string MaHoaDon = idHD.Substring(idHD.Length - 10);

                    var thanhTien = (ct.SL * ct.DonGia);

                    var chietKhau = Convert.ToDouble(thanhTien) * ct.CK / 100;

                    var tongThanhToan = (thanhTien - Convert.ToDecimal(chietKhau)) ?? 0;
                    dgvThongKe.Rows.Add(stt++, MaHoaDon.ToUpper(), item.NgayGd,ct.TenSp,
                        Convert.ToDecimal(ct.DonGia).ToString("N0"), ct.SL,
                        Convert.ToDecimal(thanhTien).ToString("N0"),
                        Convert.ToDecimal(chietKhau).ToString("N0"),
                        Convert.ToDecimal(tongThanhToan).ToString("N0"));

                    tongDoanhThu += tongThanhToan;
                }
            }
            txtDT.Text = tongDoanhThu.ToString("N0");
        }

        private void ThongKeTatCa()
        {
            decimal tongDoanhThu = 0;
            int stt = 1;
            dgvThongKe.ColumnCount = 11;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.Columns[0].Name = "STT";
            dgvThongKe.Columns[0].Width = 50;
            dgvThongKe.Columns[1].Name = "Mã Hóa Đơn";
            dgvThongKe.Columns[1].Width = 120;
            dgvThongKe.Columns[2].Name = "Ngày Giao Dịch";
            dgvThongKe.Columns[2].Width = 200;
            dgvThongKe.Columns[3].Name = "Sản Phẩm";
            dgvThongKe.Columns[3].Width = 200;
            dgvThongKe.Columns[4].Name = "Khách Hàng";
            dgvThongKe.Columns[4].Width = 200;
            dgvThongKe.Columns[5].Name = "Nhân Viên";
            dgvThongKe.Columns[5].Width = 200;
            dgvThongKe.Columns[6].Name = "Đơn Giá";
            dgvThongKe.Columns[7].Name = "Số Lượng";
            dgvThongKe.Columns[7].Width = 100;
            dgvThongKe.Columns[8].Name = "Thành Tiền";
            dgvThongKe.Columns[9].Name = "Chiết khấu";
            dgvThongKe.Columns[10].Name = "Tổng Thanh Toán";
            dgvThongKe.Rows.Clear();

            foreach (var item in _hoaDonService.GetHoaDon(null))
            {
                DateTime tuNgay = dtpTuNgay.Value;
                DateTime denNgay = dtpDenNgay.Value;

                //var ngayGD = _hoaDonService.GetHoaDon(null).Where(a => a.NgayGd >= tuNgay && a.NgayGd <= denNgay);

                var hdct = (from a in _hoaDonService.GetHoaDon(null)
                            join b in _hdctService.GetHoaDonCts(null) on a.IdHoaDon equals b.IdHoaDon
                            join c in _btService.GetBienThe(null) on b.IdBienThe equals c.IdBienThe
                            join d in _spService.GetSanPham(null) on c.IdSanPham equals d.IdSanPham
                            join e in _ggService.GetGiamGia() on b.IdGiamGia equals e.IdGiamGia
                            join f in _kkService.GetKhach(null) on a.IdKh equals f.IdKh
                            join g in _nvService.GetNhanVien(null) on a.IdNv equals g.IdNv
                            where a.IdHoaDon == item.IdHoaDon && a.TrangThai == true && (a.NgayGd >= tuNgay &&  a.NgayGd <= denNgay)
                            select new
                            {
                                TenSp = d.Ten,
                                DonGia = c.GiaTien,
                                MaHD = a.IdHoaDon,
                                SL = b.SoLuong,
                                CK = e.GiaTri,
                                TenKH = f.TenKh,
                                TenNV = g.Ten
                            }).ToList();


                foreach (var ct in hdct)
                {
                    string idHD = ct.MaHD.ToString();
                    string MaHoaDon = idHD.Substring(idHD.Length - 10);

                    var thanhTien = (ct.SL * ct.DonGia);

                    var chietKhau = Convert.ToDouble(thanhTien) * ct.CK / 100;

                    var tongThanhToan = (thanhTien - Convert.ToDecimal(chietKhau)) ?? 0;
                    dgvThongKe.Rows.Add(stt++, MaHoaDon.ToUpper(), item.NgayGd, ct.TenSp, ct.TenKH, ct.TenNV,
                        Convert.ToDecimal(ct.DonGia).ToString("N0"), ct.SL,
                        Convert.ToDecimal(thanhTien).ToString("N0"),
                        Convert.ToDecimal(chietKhau).ToString("N0"),
                        Convert.ToDecimal(tongThanhToan).ToString("N0"));

                    tongDoanhThu += tongThanhToan;
                }
            }
            txtDT.Text = tongDoanhThu.ToString("N0");
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            fromDate = dtpTuNgay.Value;
            //MessageBox.Show($"Bạn chọn từ ngày : {dtpTuNgay.Text}");
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            toDate = dtpDenNgay.Value;
            //MessageBox.Show($"Bạn chọn đến ngày : {dtpDenNgay.Text}");
        }
    }
}


