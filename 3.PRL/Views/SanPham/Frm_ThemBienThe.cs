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
            if(txtSearch.Text != null)
            {
                lst = lst.Where(x => x.ten.ToLower().Contains(txtSearch.Text.ToLower()));
            }
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
                cboMaSp.Text = bienThe.ten.ToString();
                txtGiaTien.Text = bienThe.Gia.ToString();
                txtchieucao.Text = bienThe.CC.ToString();
                txtCongSuat.Text = bienThe.CS.ToString();
                txtSoluong.Text = bienThe.SL.ToString();
                txtBankinh.Text = bienThe.BK.ToString();
                txtTGBaoHanh.Text = bienThe.TG.ToString();
                txtMaBT.Text = bienThe.MaBienThe.ToString();
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
            GridVariant.ClearSelection();
            var obj = new BienThe()
            {
                IdBienThe = Guid.NewGuid(),
                MaBienThe = $"{cboMaSp.Text}_{cboChatLieu.Text}_{cboSoCanh.Text}_{txtCongSuat.Text}",
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
                LoadgridVariant(null);
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


        private void btnThem_Click(object sender, EventArgs e)
        {
            if(checkEmpty() && checkExists())
            {
                AddVariant();
            }
        }


        private void GridVariant_SelectionChanged(object sender, EventArgs e)
        {
            GetInfor();
        }

        private void cboMau_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var lst = (from i in _mauSacService.GetMau(null) select i.IdMau).ToArray();
            Mamau = lst[cboMau.SelectedIndex];
            txtMaBT.Text = $"{cboMaSp.Text}_{cboChatLieu.Text}_{cboSoCanh.Text}_{txtCongSuat.Text}";
        }

        private void cboChatLieu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var lst = (from i in _chatLieuService.GetChatLieu(null) select i.IdChatLieu).ToArray();
            MaChatLieu = lst[cboChatLieu.SelectedIndex];
            txtMaBT.Text = $"{cboMaSp.Text}_{cboChatLieu.Text}_{cboSoCanh.Text}_{txtCongSuat.Text}";
        }

        private void cboSoCanh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var lst = (from i in _soCanhService.GetSoCanh(null) select i.IdCanh).ToArray();
            SoCanh = lst[cboSoCanh.SelectedIndex];
            txtMaBT.Text = $"{cboMaSp.Text}_{cboChatLieu.Text}_{cboSoCanh.Text}_{txtCongSuat.Text}";
        }

        private void cboMaSp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var lst = (from i in _SanPhamService.GetSanPham(null) select i.IdSanPham).ToArray();
            MaSanPham = lst[cboMaSp.SelectedIndex];
            txtMaBT.Text = $"{cboMaSp.Text}_{cboChatLieu.Text}_{cboSoCanh.Text}_{txtCongSuat.Text}";
        }

        private void txtCongSuat_TextChanged_1(object sender, EventArgs e)
        {
            txtMaBT.Text = $"{cboMaSp.Text}_{cboChatLieu.Text}_{cboSoCanh.Text}_{txtCongSuat.Text}";
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images files(*.jpg,*png,*bmp)|*.jpg;*.png;*.bmp";
            openFileDialog.Title = "Chọn hình ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btnAnh.Text = openFileDialog.FileName;
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
        private void UpdateVariant()
        {
            GridVariant.ClearSelection();
            var lst = _BienTheService.GetBienThe(null);
            var obj = lst.FirstOrDefault(x => x.MaBienThe == (GetMa()));
            if (obj != null)
            {
                obj.MaBienThe = $"{cboMaSp.Text}_{cboChatLieu.Text}_{cboSoCanh.Text}_{txtCongSuat.Text}";
                obj.GiaTien = decimal.Parse(txtGiaTien.Text);
                obj.TgbaoHanh = int.Parse(txtTGBaoHanh.Text);
                obj.CongSuat = decimal.Parse(txtCongSuat.Text);
                obj.SoLuong = int.Parse(txtSoluong.Text);
                obj.ChieuCao = float.Parse(txtchieucao.Text);
                obj.BanKinh = float.Parse(txtBankinh.Text);
                obj.HinhAnh = images;
                obj.IdMau = Mamau;
                obj.IdSanPham = MaSanPham;
                obj.IdCanh = SoCanh;
                obj.IdChatLieu = MaChatLieu;
                var result = _BienTheService.UpdateBienThe(obj);
                if (result)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Noooo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            LoadgridVariant(null);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkEmpty() && checkExists())
            {
                UpdateVariant();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadgridVariant(txtSearch.Text);
        }

        private bool checkEmpty()
        {
            if (cboMau.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn màu");
                return false;
            }
            if (cboChatLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn chất liệu");
                return false;
            }
            if (cboSoCanh.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn số cánh");
                return false;
            }
            if (cboMaSp.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn mã sản phẩm");
                return false;
            }
            if (string.IsNullOrEmpty(txtGiaTien.Text))
            {
                MessageBox.Show("Chưa nhập giá tiền");
                return false;
            }
            if (string.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Chưa nhập số lượng");
                return false;
            }
            if (string.IsNullOrEmpty(txtCongSuat.Text))
            {
                MessageBox.Show("Chưa nhập công suất");
                return false;
            }
            if (string.IsNullOrEmpty(txtchieucao.Text))
            {
                MessageBox.Show("Chưa nhập chiều");
                return false;
            }
            if (string.IsNullOrEmpty(txtBankinh.Text))
            {
                MessageBox.Show("Chưa nhập bán kính");
                return false;
            }
            if (string.IsNullOrEmpty(txtTGBaoHanh.Text))
            {
                MessageBox.Show("Chưa nhập TG bảo hành");
                return false;
            }
            if (picImage.Image == null)
            {
                MessageBox.Show("Chưa chọn hình ảnh");
                return false;
            }
            return true;
        }

        private bool checkExists()
        {
            var lst = _BienTheService.GetBienThe(null);
            if (txtMaBT.Text != null)
            {
                if (lst.FirstOrDefault(x => x.MaBienThe == txtMaBT.Text) == null)
                {
                    return true;
                }
                MessageBox.Show("Biến thể đã tồn tại");
                return false;
            }
            return false;
        }
    }
}
