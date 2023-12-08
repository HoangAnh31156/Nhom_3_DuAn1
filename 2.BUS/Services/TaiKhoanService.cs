using _1.DAL.Model1s;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class TaiKhoanService : OnlyFansContext
    {
        public DbSet<TaiKhoan> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-B52SRBN\\SQLEXPRESS;Database= OnlyFans;Trusted_Connection=True;");
        }
    }
}
