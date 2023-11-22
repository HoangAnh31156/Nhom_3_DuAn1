using System;
using System.Collections.Generic;

namespace _1.DAL.Models
{
    public partial class GiamGium
    {
        public GiamGium()
        {
            HoaDonCts = new HashSet<HoaDonCt>();
        }

        public Guid IdGiamGia { get; set; }
        public decimal? GiaTri { get; set; }
        public string? DieuKien { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }

        public virtual ICollection<HoaDonCt> HoaDonCts { get; set; }
    }
}
