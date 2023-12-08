using _1.DAL.Model1s;
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

namespace _3.PRL.Views.ThongKe
{
    public partial class Frm_ThongKe : Form
    {
        HoaDonService _hoaDonsv = new HoaDonService();
        private decimal tongTien = 0;
        public Frm_ThongKe()
        {
            InitializeComponent();
            dtpNgayThongKe.ValueChanged += DtpNgayThongKe_ValueChanged;
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
            var tien = from hoaDon in _hoaDonsv.GetHoaDon(null)
                       where hoaDon.NgayGd != null &&
                             hoaDon.NgayGd.Value.Date == dtpNgayThongKe.Value.Date
                       group hoaDon by hoaDon.NgayGd.Value.Date into grouped
                       select new
                       {
                           Ngay = grouped.Key,
                           TongTien = grouped.Sum(t => t.TongTien)
                       };
            MessageBox.Show("Dữ liệu trả về: " + string.Join(", ", tien.Select(item => $"{item.Ngay}-{item.TongTien}")));

            MessageBox.Show("Giá trị ngày được chọn: " + dtpNgayThongKe.Value.Date.ToString());

            Dictionary<DateTime, decimal> tongTienTheoNgay = tien.ToDictionary(item => item.Ngay, item => (decimal)item.TongTien);

            if (rbtnNgay.Checked)
            {
                tongTien = tongTienTheoNgay.GetValueOrDefault(dtpNgayThongKe.Value.Date);
            }

            UpdateTextBox();
        }

        private void ThongKeTheoThang()
        {
            var tien = from hoaDon in _hoaDonsv.GetHoaDon(null)
                       where hoaDon.NgayGd != null &&
                             hoaDon.NgayGd.Value.Year == dtpNgayThongKe.Value.Year &&
                             hoaDon.NgayGd.Value.Month == dtpNgayThongKe.Value.Month
                       group hoaDon by new { hoaDon.NgayGd.Value.Year, hoaDon.NgayGd.Value.Month } into grouped
                       select new
                       {
                           Thang = grouped.Key,
                           TongTien = grouped.Sum(t => t.TongTien)
                       };

            MessageBox.Show("Dữ liệu trả về: " + string.Join(", ", tien.Select(item => $"{item.Thang}-{item.TongTien}")));

            MessageBox.Show("Giá trị của tháng được chọn: " + dtpNgayThongKe.Value.Month.ToString());


            Dictionary<(int Year, int Month), decimal> tongTienTheoThang = tien.ToDictionary(item => (item.Thang.Year, item.Thang.Month), item => (decimal)item.TongTien);

            if (rbtnThang.Checked)
            {
                tongTien = tongTienTheoThang.GetValueOrDefault((dtpNgayThongKe.Value.Year, dtpNgayThongKe.Value.Month));
            }

            UpdateTextBox();
        }

        private void ThongKeTheoNam()
        {
            var tien = from hoaDon in _hoaDonsv.GetHoaDon(null)
                       where hoaDon.NgayGd != null &&
                             hoaDon.NgayGd.Value.Year == dtpNgayThongKe.Value.Year
                       group hoaDon by hoaDon.NgayGd.Value.Year into grouped
                       select new
                       {
                           Nam = grouped.Key,
                           TongTien = grouped.Sum(t => t.TongTien)
                       };

            MessageBox.Show("Dữ liệu trả về: " + string.Join(", ", tien.Select(item => $"{item.Nam}-{item.TongTien}")));

            MessageBox.Show("Giá trị của năm được chọn: " + dtpNgayThongKe.Value.Year.ToString());

            tongTien = tien.Sum(item => (decimal)item.TongTien);

            UpdateTextBox();
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
    }
}


