using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class PtttRepos : PTTT_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public PtttRepos()
        {

        }

        public PtttRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public List<Pttt> GetPTTT()
        {
            return _context.Pttts.ToList();
        }
    }
}
