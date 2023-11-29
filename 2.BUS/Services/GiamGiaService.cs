﻿using _1.DAL.Model2s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class GiamGiaService
    {
        GiamGiaRepos _giamGiaRepos = new GiamGiaRepos();
        public GiamGiaService()
        {

        }

        public GiamGiaService(GiamGiaRepos giamGiaRepos)
        {
            _giamGiaRepos = giamGiaRepos;
        }

        public List<GiamGium> GetGiamGia()
        {
            return _giamGiaRepos.GetGiamGia();
        }

        public bool AddGiamGia(DateTime ngayBD, DateTime ngayKT, double giaTri, string dieuKien)
        {
            var obj = new GiamGium()
            {
               NgayBatDau = ngayBD,
               NgayKetThuc = ngayKT,
               GiaTri = giaTri,
               DieuKien = dieuKien
            };

            return _giamGiaRepos.CreateGiamGia(obj);
        }

        public bool UpdateGiamGia(Guid id,DateTime ngayBD, DateTime ngayKT, double giaTri, string dieuKien)
        {
            var obj = new GiamGium()
            {
                IdGiamGia = id,
                NgayBatDau = ngayBD,
                NgayKetThuc = ngayKT,
                GiaTri = giaTri,
                DieuKien = dieuKien
            };

            return _giamGiaRepos.UpdateGiamGia(obj);
        }


    }
}