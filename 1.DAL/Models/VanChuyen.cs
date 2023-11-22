using System;
using System.Collections.Generic;

namespace _1.DAL.Models
{
    public partial class VanChuyen
    {
        public VanChuyen()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public Guid IdVc { get; set; }
        public string? TongTien { get; set; }
        public bool? TrangThai { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
