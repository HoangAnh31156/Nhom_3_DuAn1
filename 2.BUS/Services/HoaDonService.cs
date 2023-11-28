using _1.DAL.Model2s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class HoaDonService
    {
        HoaDonRepos _hoaDonRepos = new HoaDonRepos();

        public HoaDonService()
        {

        }

        public HoaDonService(HoaDonRepos hoaDonRepos)
        {
            _hoaDonRepos = hoaDonRepos;
        }

        public List<HoaDon> GetHoaDon(string inptut)
        {
            return _hoaDonRepos.GetHoaDon(inptut);
        }

        public bool AddHoaDon(Guid id_KH, Guid id_NV, Guid id_VC, decimal tongTien, DateTime ngayGD, bool trangThai)
        {
            var hoaDon = new HoaDon()
            {
                IdKh = id_KH,
                IdNv = id_NV,
                IdVc = id_VC,
                TongTien = tongTien,
                NgayGd = ngayGD,
                TrangThai = trangThai
            };

            return _hoaDonRepos.UpdateHoaDon(hoaDon);
        }

        public bool UpdateHoaDon(Guid id_HD, bool trangThai)
        {
            var hoaDon = new HoaDon()
            {
                IdHoaDon = id_HD,
                TrangThai = trangThai
            };

            return _hoaDonRepos.UpdateHoaDon(hoaDon);
        }
    }
}
