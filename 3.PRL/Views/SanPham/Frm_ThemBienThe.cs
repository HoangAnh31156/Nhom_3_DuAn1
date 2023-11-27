﻿using _1.DAL.Model2s;
using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views.SanPham
{
    public partial class Frm_ThemBienThe : Form
    {
        private ChatLieuService _chatLieuService;
        private MauSacService _mauSacService;
        private SoCanhService _soCanhService;
        private SanPhamService _SanPhamService;
        private BienTheService _BienTheService;
        private LoaiSPService _LoaiSPService;
        Guid MaChatLieu = Guid.Empty;
        Guid Mamau = Guid.Empty;
        Guid SoCanh = Guid.Empty;
        Guid MaSanPham = Guid.Empty;
        byte[] images;
        string MaBT = null;
        public Frm_ThemBienThe()
        {
            InitializeComponent();
            _chatLieuService = new ChatLieuService();
            _mauSacService = new MauSacService();
            _soCanhService = new SoCanhService();
            _SanPhamService = new SanPhamService();
            _BienTheService = new BienTheService();
            _LoaiSPService = new LoaiSPService();
            LoadAttributes();
            LoadgridVariant(null);
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
        private void LoadAttributes()
        {
            var chatlieu = (from i in _chatLieuService.GetChatLieu(null)
                            select i.TenChatLieu).ToArray();
            cboChatLieu.Items.AddRange(chatlieu);

            var Mau = (from i in _mauSacService.GetMau(null)
                       select i.TenMau).ToArray();
            cboMau.Items.AddRange(Mau);

            var Socanh = (from i in _soCanhService.GetSoCanh(null)
                          select i.SoCanh1.ToString()).ToArray();
            cboSoCanh.Items.AddRange(Socanh);

            var sp = (from i in _SanPhamService.GetSanPham(null)
                      select i.MaSanPham).ToArray();
            cboMaSp.Items.AddRange(sp);
        }

        private void LoadgridVariant(string name)
        {
            GridVariant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int stt = 1;
            GridVariant.Rows.Clear();
            GridVariant.ColumnCount = 12;
            GridVariant.Columns[0].Name = "STT";
            GridVariant.Columns[1].Name = "Mã Biến Thể";
            GridVariant.Columns[2].Name = "Tên";
            GridVariant.Columns[3].Name = "TG Bảo Hành";
            GridVariant.Columns[4].Name = "Công Suất";
            GridVariant.Columns[5].Name = "Số lượng";
            GridVariant.Columns[6].Name = "Chiều Cao";
            GridVariant.Columns[7].Name = "Bán Kính";
            GridVariant.Columns[8].Name = "Chất Liệu";
            GridVariant.Columns[9].Name = "Màu Sắc";
            GridVariant.Columns[10].Name = "Số Cánh";
            GridVariant.Columns[11].Name = "Giá Tiền";

            var lst = from i in _BienTheService.GetBienThe(null)
                      join y in _SanPhamService.GetSanPham(null)
                      on i.IdSanPham equals y.IdSanPham
                      join a in _chatLieuService.GetChatLieu(null)
                      on i.IdChatLieu equals a.IdChatLieu
                      join b in _mauSacService.GetMau(null)
                      on i.IdMau equals b.IdMau
                      join c in _soCanhService.GetSoCanh(null)
                      on i.IdCanh equals c.IdCanh
                      select new
                      {
                          MaBienThe = i.MaBienThe,
                          ten = y.Ten,
                          Gia = i.GiaTien,
                          TG = i.TgbaoHanh,
                          CS = i.CongSuat,
                          SL = i.SoLuong,
                          CC = i.ChieuCao,
                          BK = i.BanKinh,
                          Hinh = i.HinhAnh,
                          CL = a.TenChatLieu,
                          M = b.TenMau,
                          SC = c.SoCanh1
                      };
            foreach (var i in lst)
            {
                GridVariant.Rows.Add(stt, i.MaBienThe, i.ten, i.TG, i.CS, i.SL, i.CC, i.BK, i.CL, i.M, i.SC, i.Gia);
                stt++;
            }
        }
        private string GetMa()
        {
            int CurrentRow = GridVariant.CurrentRow.Index;
            if (CurrentRow >= 0 && CurrentRow <= GridVariant.Rows.Count - 2)
            {
                return GridVariant.CurrentRow.Cells[1].Value.ToString();
            }
            return null;
        }
        private void GetInfor()
        {
            if (!string.IsNullOrEmpty(GetMa()))
            {

                var lst = from i in _BienTheService.GetBienThe(null)
                          join y in _SanPhamService.GetSanPham(null)
                          on i.IdSanPham equals y.IdSanPham
                          join a in _chatLieuService.GetChatLieu(null)
                          on i.IdChatLieu equals a.IdChatLieu
                          join b in _mauSacService.GetMau(null)
                          on i.IdMau equals b.IdMau
                          join c in _soCanhService.GetSoCanh(null)
                          on i.IdCanh equals c.IdCanh
                          select new
                          {
                              MaBienThe = i.MaBienThe,
                              ten = y.MaSanPham,
                              Gia = i.GiaTien,
                              TG = i.TgbaoHanh,
                              CS = i.CongSuat,
                              SL = i.SoLuong,
                              CC = i.ChieuCao,
                              BK = i.BanKinh,
                              Hinh = i.HinhAnh,
                              CL = a.TenChatLieu,
                              M = b.TenMau,
                              SC = c.SoCanh1
                          };
                var bienThe = lst.FirstOrDefault(x => x.MaBienThe == GetMa());
                cboChatLieu.Text = bienThe.CL;
                cboMau.Text = bienThe.M;
                cboSoCanh.Text = bienThe.SC.ToString();
                cboMaSp.Text = bienThe.M.ToString();
                txtGiaTien.Text = bienThe.Gia.ToString();
                txtchieucao.Text = bienThe.CC.ToString();
                txtCongSuat.Text = bienThe.CS.ToString();
                txtSoluong.Text = bienThe.SL.ToString();
                txtBankinh.Text = bienThe.BK.ToString();
                txtTGBaoHanh.Text = bienThe.TG.ToString();
                if (bienThe.Hinh != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream(bienThe.Hinh))
                    {
                        Image img = Image.FromStream(memoryStream);
                        picImage.Image = img;
                    }
                }
            }
        }
        private void AddVariant()
        {

            var obj = new BienThe()
            {
                IdBienThe = Guid.NewGuid(),
                MaBienThe = $"{cboMaSp.Text}_{txtCongSuat.Text}_{cboMau.Text}",
                GiaTien = decimal.Parse(txtGiaTien.Text),
                TgbaoHanh = int.Parse(txtTGBaoHanh.Text),
                CongSuat = decimal.Parse(txtCongSuat.Text),
                SoLuong = int.Parse(txtSoluong.Text),
                ChieuCao = float.Parse(txtchieucao.Text),
                BanKinh = float.Parse(txtBankinh.Text),
                HinhAnh = images,
                IdMau = Mamau,
                IdSanPham = MaSanPham,
                IdCanh = SoCanh,
                IdChatLieu = MaChatLieu
            };
            var result = _BienTheService.CreateBienThe(obj);
            if (result)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemSP frm_ThemSP = new Frm_ThemSP();
            frm_ThemSP.Show();
        }

        private void cboChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lst = (from i in _chatLieuService.GetChatLieu(null) select i.IdChatLieu).ToList();
            MaChatLieu = lst[cboChatLieu.SelectedIndex];
            txtMaBT.Text = $"{cboMaSp.Text}_{txtCongSuat.Text}_{cboMau.Text}";
        }

        private void cboMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lst = (from i in _mauSacService.GetMau(null) select i.IdMau).ToList();
            Mamau = lst[cboMau.SelectedIndex];
            txtMaBT.Text = $"{cboMaSp.Text}_{txtCongSuat.Text}_{cboMau.Text}";
        }

        private void cboSoCanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lst = (from i in _soCanhService.GetSoCanh(null) select i.IdCanh).ToList();
            SoCanh = lst[cboSoCanh.SelectedIndex];
            txtMaBT.Text = $"{cboMaSp.Text}_{txtCongSuat.Text}_{cboMau.Text}";
        }

        private void cboMaSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lst = (from i in _SanPhamService.GetSanPham(null) select i.IdSanPham).ToList();
            MaSanPham = lst[cboMaSp.SelectedIndex];
            txtMaBT.Text = $"{cboMaSp.Text}_{txtCongSuat.Text}_{cboMau.Text}";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddVariant();
        }

        private void txtpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images files(*.jpg,*png,*bmp)|*.jpg;*.png;*.bmp";
            openFileDialog.Title = "Chọn hình ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = openFileDialog.FileName;
                Image img = Image.FromFile(openFileDialog.FileName);
                picImage.Image = img;
                using (MemoryStream ms = new MemoryStream())
                {
                    ImageFormat format;
                    int lastDotIndex = openFileDialog.FileName.LastIndexOf(".");
                    string duoi = openFileDialog.FileName.Substring(lastDotIndex + 1);
                    switch (duoi.ToLower())
                    {
                        case "jpg":
                        case "jpeg":
                            format = ImageFormat.Jpeg;
                            break;
                        case "png":
                            format = ImageFormat.Png;
                            break;
                        case "bmp":
                            format = ImageFormat.Bmp;
                            break;
                        default:
                            MessageBox.Show("Định dạng ảnh không được hỗ trợ");
                            return;
                    }
                    img.Save(ms, format);
                    images = ms.ToArray();
                }
            }
        }

        private void txtCongSuat_TextChanged(object sender, EventArgs e)
        {
            txtMaBT.Text = $"{cboMaSp.Text}_{txtCongSuat.Text}_{cboMau.Text}";
        }

        private void GridVariant_SelectionChanged(object sender, EventArgs e)
        {
            GetInfor();
        }
    }
}
