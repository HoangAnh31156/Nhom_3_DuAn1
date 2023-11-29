using _1.DAL.IRepositories;
using _1.DAL.Model2s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonCTRepos : HoaDonCT_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public HoaDonCTRepos()
        {

        }

        public HoaDonCTRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public bool CreateHoaDonCT(HoaDonCt hoaDonCt)
        {
            try
            {
                _context.HoaDonCts.Add(hoaDonCt);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<HoaDonCt> GetHoaDonCts(string input)
        {
            if (input == null)
            {
                return _context.HoaDonCts.ToList();
            }
            var hoaDonCT = from a in _context.HoaDonCts
                           join b in _context.BienThes on a.IdBienThe equals b.IdBienThe
                           where a.IdBienTheNavigation.MaBienThe.Contains(input)
                           select a;

            return hoaDonCT.ToList();
        }

        public bool UpdateHoaDonCT(HoaDonCt hoaDonCt)
        {
            try
            {
                var updateHoaDonCT = _context.HoaDonCts.Find(hoaDonCt.IdHoaDonCt);

                updateHoaDonCT.IdBienThe = hoaDonCt.IdBienThe;
                updateHoaDonCT.IdGiamGia = hoaDonCt.IdGiamGia;
                updateHoaDonCT.SoLuong = hoaDonCt.SoLuong;
                updateHoaDonCT.Gia = hoaDonCt.Gia;
                updateHoaDonCT.IdHoaDon = hoaDonCt.IdHoaDon;

                _context.HoaDonCts.Update(updateHoaDonCT);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
