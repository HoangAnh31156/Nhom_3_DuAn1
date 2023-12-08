using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class PtttSerivce
    {
        PtttRepos _ptttRepos = new PtttRepos();
        public PtttSerivce()
        {
            
        }

        public PtttSerivce(PtttRepos ptttRepos)
        {
            _ptttRepos = ptttRepos;
        }

        public List<Pttt> GetPTTT()
        {
            return _ptttRepos.GetPTTT();
        }
    }
}
