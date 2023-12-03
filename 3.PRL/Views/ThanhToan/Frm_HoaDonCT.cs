using _1.DAL.Model2s;
using _2.BUS.Services;
using Microsoft.EntityFrameworkCore.Storage;
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
    public partial class Frm_HoaDonCT : Form
    {
        HoaDonService _hoaDonService = new HoaDonService();
        HoaDonCTService _hoaDonCtService = new HoaDonCTService();
        BienTheService _bienTheService = new BienTheService();
        GiamGiaService _giamGiaService = new GiamGiaService();

        Guid _id;
        List<Guid> _idHd = new List<Guid>();
        List<Guid> _idBt = new List<Guid>();
        List<Guid> _idGg = new List<Guid>();

        public Frm_HoaDonCT()
        {
            InitializeComponent();
        }

        private void Frm_HoaDonCT_Load(object sender, EventArgs e)
        {
            HoaDon();
            BienThe();
            LoadGridHDCT(null);
        }

        private void HoaDon()
        {
            foreach (var item in _hoaDonService.GetHoaDon(null))
            {
                string MaHoaDon = item.IdHoaDon.ToString().Substring(item.IdHoaDon.ToString().Length - 5).ToUpper();

                _idHd.Add(item.IdHoaDon);
                cmbMaHD.Items.Add(MaHoaDon);
            }
            cmbMaHD.SelectedIndex = -1;
        }

        private void BienThe()
        {
            foreach (var item in _bienTheService.GetBienThe(null).OrderBy(a => a.MaBienThe))
            {
                _idBt.Add(item.IdBienThe);
                cmbBienThe.Items.Add(item.MaBienThe);
            }
            cmbBienThe.SelectedIndex = -1;
            //cmbBienThe.SelectedIndexChanged += CmbBienThe_SelectedIndexChanged;
        }

        private void cmbBienThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBienThe.SelectedIndex >= 0)
            {
                int selectedIndex = cmbBienThe.SelectedIndex;
                Guid selectedId = _idBt[selectedIndex];

                var lstBienThe = _bienTheService.GetBienThe(null).OrderBy(a=>a.MaBienThe).ToList();
                var bt = lstBienThe.FirstOrDefault(a => a.IdBienThe == selectedId);
                
                if(bt != null)
                {
                    if(bt.GiaTien != null)
                    {
                        txtDonGia.Text = bt.GiaTien.ToString();
                    }
                    else
                    {
                        txtDonGia.Text = string.Empty;
                    }
                }
            }
        }

        private void LoadGridHDCT(string input)
        {
            int stt = 1;
            dgvDSSP.ColumnCount = 8;
            dgvDSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSSP.Columns[0].Name = "ID";
            dgvDSSP.Columns[0].Visible = false;
            dgvDSSP.Columns[1].Name = "STT";
            dgvDSSP.Columns[1].Width = 70;
            dgvDSSP.Columns[2].Name = "Mã HD";
            dgvDSSP.Columns[2].Width = 120;
            dgvDSSP.Columns[3].Name = "Mã Biến Thể";
            dgvDSSP.Columns[4].Name = "Số Lượng";
            dgvDSSP.Columns[4].Width = 150;
            dgvDSSP.Columns[5].Name = "Đơn Giá";
            dgvDSSP.Columns[6].Name = "Giảm Giá";
            dgvDSSP.Columns[7].Name = "Thành Tiền";

            dgvDSSP.Rows.Clear();

            foreach (var item in _hoaDonCtService.GetHoaDonCts(input))
            {
                var HD = _hoaDonService.GetHoaDon(null).FirstOrDefault(a => a.IdHoaDon == item.IdHoaDon);
                var BT = _bienTheService.GetBienThe(null).FirstOrDefault(a => a.IdBienThe == item.IdBienThe);
                var GG = _giamGiaService.GetGiamGia().FirstOrDefault(a => a.IdGiamGia == item.IdGiamGia);

                string idHoaDon = item.IdHoaDon.ToString();
                string MaHD = idHoaDon.Substring(idHoaDon.Length - 5);

                var giamGia = item.SoLuong * BT?.GiaTien * Convert.ToDecimal(GG?.GiaTri) / 100;

                var thanhTien = item.SoLuong * BT?.GiaTien - giamGia;

                dgvDSSP.Rows.Add(item.IdHoaDonCt, stt++, MaHD, BT.MaBienThe, item.SoLuong, BT.GiaTien, giamGia, thanhTien);
            }
        }

        
    }
}

