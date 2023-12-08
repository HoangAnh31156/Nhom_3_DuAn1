using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class LichSuttRepos : LichSutt_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public LichSuttRepos()
        {

        }

        public LichSuttRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public List<LichSuTt> GetLichSuTt()
        {
            return _context.LichSuTts.ToList();
        }
    }
}
