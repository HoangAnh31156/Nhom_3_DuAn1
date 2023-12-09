using _1.DAL.Model1s;
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

        List<Guid> _idSp = new List<Guid>();

        private decimal tongTien = 0;
        public Frm_ThongKe()
        {
            InitializeComponent();

        }

        private void DtpNgayThongKe_ValueChanged(object? sender, EventArgs e)
        {
            if (rbtnNgay.Checked)
            {
                ThongKeTheoNgay();
            }
            else if (rbtnThang.Checked)
            {
                ThongKeTheoThang();
            }
            else if (rbtnNam.Checked)
            {
                ThongKeTheoNam();
            }
        }

        private void rbtnNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNgay.Checked)
            {
                ThongKeTheoNgay();
            }

        }

        private void rbtnThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnThang.Checked)
            {
                ThongKeTheoThang();
            }
        }

        private void rbtnNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNam.Checked)
            {
                ThongKeTheoNam();
            }
        }
        private void UpdateTextBox()
        {
            if (tongTien != 0)
            {
                txtDoanhThu.Text = tongTien.ToString();
            }
            else
            {
                txtDoanhThu.Text = "Không có dữ liệu";
            }
        }
        private void ThongKeTheoNgay()
        {

        }

        private void ThongKeTheoThang()
        {

        }

        private void ThongKeTheoNam()
        {

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
        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            LoadSanPham();

            mtbTuNgay.Text = DateTime.Now.ToString("dd/MM/yyyy 00:01"); // Đầu ngày hiện tại
            mtbDenNgay.Text = DateTime.Now.ToString("dd/MM/yyyy 23:59"); //Thời điểm hiện tại


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
            int stt = 1;
            var result = from hd in _hoaDonService.GetHoaDon(null).Where(a => a.TrangThai == true)
                         join ct in _hdctService.GetHoaDonCts(null) on hd.IdHoaDon equals ct.IdHoaDon
                         join bt in _btService.GetBienThe(null) on ct.IdBienThe equals bt.IdBienThe
                         join sp in _spService.GetSanPham(null) on bt.IdSanPham equals sp.IdSanPham
                         select new
                         {
                             NgayGD = hd.NgayGd,
                             SanPham = sp.Ten,
                             DonGia = bt.GiaTien,
                             SoLuong = ct.SoLuong,
                             ThanhTien = 0
                         };
            dgvThongKe.ColumnCount = 6;
            dgvThongKe.Columns[0].Name = "STT";
            dgvThongKe.Columns[0].Width = 50;
            dgvThongKe.Columns[1].Name = "Ngày giao dịch";
            dgvThongKe.Columns[2].Name = "Sản phẩm";
            dgvThongKe.Columns[3].Name = "Đơn giá";
            dgvThongKe.Columns[4].Name = "Số lượng";
            dgvThongKe.Columns[5].Name = "Thành Tiền";
            dgvThongKe.Rows.Clear();
            dgvThongKe.Rows.Add(stt++, result);
        }

        private void ThongKeTatCa()
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
                DateTime tuNgay = DateTime.ParseExact(mtbTuNgay.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                DateTime denNgay = DateTime.ParseExact(mtbDenNgay.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                var ngayGD = _hoaDonService.GetHoaDon(null).Where(a => a.NgayGd >= tuNgay && a.NgayGd <= denNgay);

                var hdct = (from a in _hoaDonService.GetHoaDon(null)
                            join b in _hdctService.GetHoaDonCts(null) on a.IdHoaDon equals b.IdHoaDon
                            join c in _btService.GetBienThe(null) on b.IdBienThe equals c.IdBienThe
                            join d in _spService.GetSanPham(null) on c.IdSanPham equals d.IdSanPham
                            join e in _ggService.GetGiamGia() on b.IdGiamGia equals e.IdGiamGia
                            where a.IdHoaDon == item.IdHoaDon && a.TrangThai == true
                            select new
                            {
                                TenSp = d.Ten,
                                DonGia = c.GiaTien,
                                MaHD = a.IdHoaDon,
                                SL = b.SoLuong,
                                CK = e.GiaTri
                            }).ToList();


                foreach (var ct in hdct)
                {
                    string idHD = ct.MaHD.ToString();
                    string MaHoaDon = idHD.Substring(idHD.Length - 10);

                    var thanhTien = (ct.SL * ct.DonGia);

                    var chietKhau = Convert.ToDouble(thanhTien) * ct.CK / 100;

                    var tongThanhToan = (thanhTien - Convert.ToDecimal(chietKhau)) ?? 0;
                    dgvThongKe.Rows.Add(stt++, MaHoaDon.ToUpper(), item.NgayGd, ct.TenSp,
                        Convert.ToDecimal(ct.DonGia).ToString("N0"), ct.SL,
                        Convert.ToDecimal(thanhTien).ToString("N0"),
                        Convert.ToDecimal(chietKhau).ToString("N0"),
                        Convert.ToDecimal(tongThanhToan).ToString("N0"));

                    tongDoanhThu += tongThanhToan;
                }
            }
            txtDT.Text = tongDoanhThu.ToString("N0");
        }

    }
}


