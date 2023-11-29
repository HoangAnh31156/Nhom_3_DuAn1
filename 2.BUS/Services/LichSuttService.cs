using _1.DAL.Model2s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class LichSuttService
    {
        LichSuttRepos _lichSuttRepos = new LichSuttRepos();

        public LichSuttService()
        {

        }
        public LichSuttService(LichSuttRepos lichSuttRepos)
        {
            _lichSuttRepos = lichSuttRepos;
        }

        public List<LichSuTt> GetLichSuTt()
        {
            return _lichSuttRepos.GetLichSuTt();
        }
    }
}
