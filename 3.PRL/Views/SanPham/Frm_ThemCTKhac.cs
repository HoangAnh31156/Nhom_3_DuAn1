﻿using _1.DAL.Model2s;
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

namespace _3.PRL.Views.SanPham
{
    public partial class Frm_ThemCTKhac : Form
    {
        private ChatLieuService _chatLieuService;
        private MauSacService _mauSacService;
        private SoCanhService _soCanhService;
        private LoaiSPService _LoaiSPService;
        Dictionary<string, string> lstloai = new Dictionary<string, string>();
        public Frm_ThemCTKhac()
        {
            InitializeComponent();
            _chatLieuService = new ChatLieuService();
            _mauSacService = new MauSacService();
            _soCanhService = new SoCanhService();
            _LoaiSPService = new LoaiSPService();
            LoadAttributes();
        }
        private void LoadAttributes()
        {
            cboChatLieu.Items.Clear();
            cboLoaiSP.Items.Clear();
            cboMau.Items.Clear();
            cboSoCanh.Items.Clear();
            lstloai.Clear();
            cboSoCanh.Text = string.Empty;
            cboMau.Text = string.Empty;
            cboLoaiSP.Text = string.Empty;
            cboChatLieu.Text = string.Empty;
            rtxtMoTa.Text = string.Empty;
            var chatlieu = (from i in _chatLieuService.GetChatLieu(null)
                            select i.TenChatLieu).ToArray();
            cboChatLieu.Items.AddRange(chatlieu);

            var Mau = (from i in _mauSacService.GetMau(null)
                       select i.TenMau).ToArray();
            cboMau.Items.AddRange(Mau);

            var Socanh = (from i in _soCanhService.GetSoCanh(null)
                          select i.SoCanh1.ToString()).ToArray();
            cboSoCanh.Items.AddRange(Socanh);
            var loaisp = _LoaiSPService.GetLoaiSanPham(null);
            foreach (var i in loaisp)
            {
                lstloai.Add(i.TenLoai, i.MoTa);
            }
            var lstTen = lstloai.Keys.ToArray();
            cboLoaiSP.Items.AddRange(lstTen);
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TrangChu frm_TrangChu = new Frm_TrangChu();
            frm_TrangChu.Show();
        }

        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap2 frm_DangNhap = new Frm_DangNhap2();
            frm_DangNhap.Show();
        }

        private void btnTCSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_SanPham frm_SanPham = new Frm_SanPham();
            frm_SanPham.Show();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemSP frm_ThemSP = new Frm_ThemSP();
            frm_ThemSP.Show();
        }

        private void btnThemBienThe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemBienThe frm_ThemBienThe = new Frm_ThemBienThe();
            frm_ThemBienThe.Show();
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxtMoTa.Text = lstloai.FirstOrDefault(x => x.Key == cboLoaiSP.Text).Value;
        }
        private void AddChatLieu()
        {
            ChatLieu chatLieu = new ChatLieu()
            {
                IdChatLieu = Guid.NewGuid(),
                TenChatLieu = cboChatLieu.Text,
            };
            if (Xacnhan())
            {
                bool result = _chatLieuService.CreateChatLieu(chatLieu);
                ThongBao(result);
            }
            LoadAttributes();
        }

        private void AddMau()
        {
            Mau chatMau = new Mau()
            {
                IdMau = Guid.NewGuid(),
                TenMau = cboMau.Text,
            };
            if (Xacnhan())
            {
                bool result = _mauSacService.CreateMau(chatMau);
                ThongBao(result);
            }
            LoadAttributes();
        }

        private void AddSoCanh()
        {
            SoCanh chatSoCanh = new SoCanh()
            {
                IdCanh = Guid.NewGuid(),
                SoCanh1 = int.Parse(cboSoCanh.Text)
            };
            if (Xacnhan())
            {
                bool result = _soCanhService.CreateSoCanh(chatSoCanh);
                ThongBao(result);
            }
            LoadAttributes();
        }

        private void AddLoaiSP()
        {
            LoaiSanPham loaiSanPham = new LoaiSanPham()
            {
                IdLoaiSanPham = Guid.NewGuid(),
                TenLoai = cboLoaiSP.Text,
                MoTa = rtxtMoTa.Text
            };
            if (Xacnhan())
            {
                bool result = _LoaiSPService.CreateLoaiSanPham(loaiSanPham);
                ThongBao(result);
            }
            LoadAttributes();
        }

        private bool Xacnhan()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void ThongBao(bool result)
        {
            if (result == true)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }


        private void changeBG()
        {
            grbCL.BackColor = Color.White;
            grbSC.BackColor = Color.White;
            grbMS.BackColor = Color.White;
            grbLSP.BackColor = Color.White;
        }

        private void grbCL_Enter(object sender, EventArgs e)
        {
            changeBG();
            grbCL.BackColor = Color.LightBlue;
        }

        private void grbMS_Enter(object sender, EventArgs e)
        {
            changeBG();
            grbMS.BackColor = Color.LightBlue;
        }

        private void grbSC_Enter(object sender, EventArgs e)
        {
            changeBG();
            grbSC.BackColor = Color.LightBlue;
        }

        private void grbLSP_Enter(object sender, EventArgs e)
        {
            changeBG();
            grbLSP.BackColor = Color.LightBlue;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(grbLSP.BackColor == Color.LightBlue)
            {
                AddLoaiSP();
            }
            if(grbSC.BackColor == Color.LightBlue)
            {
                AddSoCanh();
            }
            if(grbMS.BackColor == Color.LightBlue)
            {
                AddMau();
            }
            if(grbCL.BackColor == Color.LightBlue)
            {
                AddChatLieu();
            }
        }
    }
}
