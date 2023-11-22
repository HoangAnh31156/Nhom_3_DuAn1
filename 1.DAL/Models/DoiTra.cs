using System;
using System.Collections.Generic;

namespace _1.DAL.Models
{
    public partial class DoiTra
    {
        public DoiTra()
        {
            LichSuDoiTras = new HashSet<LichSuDoiTra>();
        }

        public Guid IdDoiTra { get; set; }
        public decimal? ThanhTien { get; set; }

        public virtual ICollection<LichSuDoiTra> LichSuDoiTras { get; set; }
    }
}
