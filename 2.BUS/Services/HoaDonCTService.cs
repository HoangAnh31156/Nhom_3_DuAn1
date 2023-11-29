using _1.DAL.Model2s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class HoaDonCTService
    {
        HoaDonCTRepos _hoaDonCTRepos = new HoaDonCTRepos();
        public HoaDonCTService()
        {

        }

        public HoaDonCTService(HoaDonCTRepos hoaDonRepos)
        {
            _hoaDonCTRepos = hoaDonRepos;
        }

        public List<HoaDonCt> GetHoaDonCts(string input)
        {
            return _hoaDonCTRepos.GetHoaDonCts(input);
        }

        public bool AddHoaDonCT(Guid id_bienThe, Guid id_giamGia, Guid id_hoaDon, decimal gia, int soLuong)
        {
            var obj = new HoaDonCt()
            {
                IdBienThe = id_bienThe,
                IdGiamGia = id_giamGia,
                IdHoaDon = id_hoaDon,
                Gia = gia,
                SoLuong = soLuong
            };

            return _hoaDonCTRepos.CreateHoaDonCT(obj);
        }

        public bool AddHoaDonCT(Guid id, Guid id_bienThe, Guid id_giamGia, Guid id_hoaDon, decimal gia, int soLuong)
        {
            var obj = new HoaDonCt()
            {
                IdHoaDonCt = id,
                IdBienThe = id_bienThe,
                IdGiamGia = id_giamGia,
                IdHoaDon = id_hoaDon,
                Gia = gia,
                SoLuong = soLuong
            };

            return _hoaDonCTRepos.UpdateHoaDonCT(obj);
        }
    }
}
