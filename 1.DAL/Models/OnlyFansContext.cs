using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _1.DAL.Models
{
    public partial class OnlyFansContext : DbContext
    {
        public OnlyFansContext()
        {
        }

        public OnlyFansContext(DbContextOptions<OnlyFansContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaoHanh> BaoHanhs { get; set; } = null!;
        public virtual DbSet<BienThe> BienThes { get; set; } = null!;
        public virtual DbSet<ChatLieu> ChatLieus { get; set; } = null!;
        public virtual DbSet<DoiTra> DoiTras { get; set; } = null!;
        public virtual DbSet<GiamGium> GiamGia { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonCt> HoaDonCts { get; set; } = null!;
        public virtual DbSet<KhachHanh> KhachHanhs { get; set; } = null!;
        public virtual DbSet<LichSuBaoHanh> LichSuBaoHanhs { get; set; } = null!;
        public virtual DbSet<LichSuDoiTra> LichSuDoiTras { get; set; } = null!;
        public virtual DbSet<LichSuTt> LichSuTts { get; set; } = null!;
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; } = null!;
        public virtual DbSet<Mau> Maus { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<PhuongThucDoiTra> PhuongThucDoiTras { get; set; } = null!;
        public virtual DbSet<Pttt> Pttts { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<SoCanh> SoCanhs { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<VaiTro> VaiTros { get; set; } = null!;
        public virtual DbSet<VanChuyen> VanChuyens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-B52SRBN\\SQLEXPRESS;Database= OnlyFans;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoHanh>(entity =>
            {
                entity.HasKey(e => e.IdBaoHanh)
                    .HasName("PK__BaoHanh__55EC312300DD7C87");

                entity.ToTable("BaoHanh");

                entity.Property(e => e.IdBaoHanh)
                    .HasColumnName("ID_BaoHanh")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdNv).HasColumnName("ID_NV");

                entity.HasOne(d => d.IdNvNavigation)
                    .WithMany(p => p.BaoHanhs)
                    .HasForeignKey(d => d.IdNv)
                    .HasConstraintName("fk_BaoHanh_NhanVienT");
            });

            modelBuilder.Entity<BienThe>(entity =>
            {
                entity.HasKey(e => e.IdBienThe)
                    .HasName("PK__BienThe__64C29E10B4064D4B");

                entity.ToTable("BienThe");

                entity.Property(e => e.IdBienThe)
                    .HasColumnName("ID_BienThe")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CongSuat).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GiaTien).HasColumnType("money");

                entity.Property(e => e.HinhAnh).HasColumnType("image");

                entity.Property(e => e.IdCanh).HasColumnName("ID_Canh");

                entity.Property(e => e.IdChatLieu).HasColumnName("ID_ChatLieu");

                entity.Property(e => e.IdMau).HasColumnName("ID_Mau");

                entity.Property(e => e.IdSanPham).HasColumnName("ID_SanPham");

                entity.Property(e => e.MaBienThe).HasMaxLength(50);

                entity.Property(e => e.TgbaoHanh)
                    .HasColumnType("date")
                    .HasColumnName("TGBaoHanh");

                entity.HasOne(d => d.IdCanhNavigation)
                    .WithMany(p => p.BienThes)
                    .HasForeignKey(d => d.IdCanh)
                    .HasConstraintName("fk_BienThe_Canh");

                entity.HasOne(d => d.IdChatLieuNavigation)
                    .WithMany(p => p.BienThes)
                    .HasForeignKey(d => d.IdChatLieu)
                    .HasConstraintName("fk_BienThe_ChatLieu");

                entity.HasOne(d => d.IdMauNavigation)
                    .WithMany(p => p.BienThes)
                    .HasForeignKey(d => d.IdMau)
                    .HasConstraintName("fk_BienThe_Mau");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.BienThes)
                    .HasForeignKey(d => d.IdSanPham)
                    .HasConstraintName("fk_BienThe_SanPham");
            });

            modelBuilder.Entity<ChatLieu>(entity =>
            {
                entity.HasKey(e => e.IdChatLieu)
                    .HasName("PK__ChatLieu__A6F7CC1397A051EB");

                entity.ToTable("ChatLieu");

                entity.Property(e => e.IdChatLieu)
                    .HasColumnName("ID_ChatLieu")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TenChatLieu).HasMaxLength(100);
            });

            modelBuilder.Entity<DoiTra>(entity =>
            {
                entity.HasKey(e => e.IdDoiTra)
                    .HasName("PK__DoiTra__B5AA9A7355B4C41C");

                entity.ToTable("DoiTra");

                entity.Property(e => e.IdDoiTra)
                    .HasColumnName("ID_DoiTra")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ThanhTien).HasColumnType("money");
            });

            modelBuilder.Entity<GiamGium>(entity =>
            {
                entity.HasKey(e => e.IdGiamGia)
                    .HasName("PK__GiamGia__051008E1B3B61010");

                entity.Property(e => e.IdGiamGia)
                    .HasColumnName("ID_GiamGia")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DieuKien).HasMaxLength(100);

                entity.Property(e => e.GiaTri).HasColumnType("money");

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.IdHoaDon)
                    .HasName("PK__HoaDon__14AFCFC52929A8EE");

                entity.ToTable("HoaDon");

                entity.Property(e => e.IdHoaDon)
                    .HasColumnName("ID_HoaDon")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdKh).HasColumnName("ID_KH");

                entity.Property(e => e.IdNv).HasColumnName("ID_NV");

                entity.Property(e => e.IdVc).HasColumnName("ID_VC");

                entity.Property(e => e.NgayGd)
                    .HasColumnType("date")
                    .HasColumnName("NgayGD");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("fk_HoaDon_KhachHanh");

                entity.HasOne(d => d.IdNvNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNv)
                    .HasConstraintName("fk_HoaDon_NhanVien");

                entity.HasOne(d => d.IdVcNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdVc)
                    .HasConstraintName("fk_HoaDon_VanChuyen");
            });

            modelBuilder.Entity<HoaDonCt>(entity =>
            {
                entity.HasKey(e => e.IdHoaDonCt)
                    .HasName("PK__HoaDonCT__0FDD1C416476D709");

                entity.ToTable("HoaDonCT");

                entity.Property(e => e.IdHoaDonCt)
                    .HasColumnName("ID_HoaDonCT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Gia).HasColumnType("money");

                entity.Property(e => e.IdBienThe).HasColumnName("ID_BienThe");

                entity.Property(e => e.IdGiamGia).HasColumnName("ID_GiamGia");

                entity.Property(e => e.IdHoaDon).HasColumnName("ID_HoaDon");

                entity.HasOne(d => d.IdBienTheNavigation)
                    .WithMany(p => p.HoaDonCts)
                    .HasForeignKey(d => d.IdBienThe)
                    .HasConstraintName("fk_HoaDonCT_BienThe");

                entity.HasOne(d => d.IdGiamGiaNavigation)
                    .WithMany(p => p.HoaDonCts)
                    .HasForeignKey(d => d.IdGiamGia)
                    .HasConstraintName("fk_HoaDonCT_GiamGia");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.HoaDonCts)
                    .HasForeignKey(d => d.IdHoaDon)
                    .HasConstraintName("fk_HoaDonCT_HoaDon");
            });

            modelBuilder.Entity<KhachHanh>(entity =>
            {
                entity.HasKey(e => e.IdKh)
                    .HasName("PK__KhachHan__8B62EC89EC69FAC9");

                entity.ToTable("KhachHanh");

                entity.Property(e => e.IdKh)
                    .HasColumnName("ID_KH")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(100)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<LichSuBaoHanh>(entity =>
            {
                entity.HasKey(e => e.IdLsbaoHanh)
                    .HasName("PK__LichSuBa__74CE66F917DD756C");

                entity.ToTable("LichSuBaoHanh");

                entity.Property(e => e.IdLsbaoHanh)
                    .HasColumnName("ID_LSBaoHanh")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdBaoHanh).HasColumnName("ID_BaoHanh");

                entity.Property(e => e.IdHoaDonCt).HasColumnName("ID_HoaDonCT");

                entity.Property(e => e.LyDo).HasMaxLength(500);

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.Property(e => e.ThoiGian).HasColumnType("date");

                entity.HasOne(d => d.IdBaoHanhNavigation)
                    .WithMany(p => p.LichSuBaoHanhs)
                    .HasForeignKey(d => d.IdBaoHanh)
                    .HasConstraintName("fk_LichSuBaoHanh_BaoHanh");

                entity.HasOne(d => d.IdHoaDonCtNavigation)
                    .WithMany(p => p.LichSuBaoHanhs)
                    .HasForeignKey(d => d.IdHoaDonCt)
                    .HasConstraintName("fk_LichSuBaoHanh_HoaDonCT");
            });

            modelBuilder.Entity<LichSuDoiTra>(entity =>
            {
                entity.HasKey(e => e.IdLsdoiTra)
                    .HasName("PK__LichSuDo__449F7F0724ADADC8");

                entity.ToTable("LichSuDoiTra");

                entity.Property(e => e.IdLsdoiTra)
                    .HasColumnName("ID_LSDoiTra")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdDoiTra).HasColumnName("ID_DoiTra");

                entity.Property(e => e.IdHoaDonCt).HasColumnName("ID_HoaDonCT");

                entity.Property(e => e.IdPtdoiTra).HasColumnName("ID_PTDoiTra");

                entity.Property(e => e.LyDo).HasMaxLength(500);

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.Property(e => e.ThoiGian).HasColumnType("date");

                entity.HasOne(d => d.IdDoiTraNavigation)
                    .WithMany(p => p.LichSuDoiTras)
                    .HasForeignKey(d => d.IdDoiTra)
                    .HasConstraintName("fk_LichSuDoiTra_DoiTra");

                entity.HasOne(d => d.IdHoaDonCtNavigation)
                    .WithMany(p => p.LichSuDoiTras)
                    .HasForeignKey(d => d.IdHoaDonCt)
                    .HasConstraintName("fk_LichSuDoiTra_HoaDonCT");

                entity.HasOne(d => d.IdPtdoiTraNavigation)
                    .WithMany(p => p.LichSuDoiTras)
                    .HasForeignKey(d => d.IdPtdoiTra)
                    .HasConstraintName("fk_LichSuDoiTra_PhuongThucDoiTra");
            });

            modelBuilder.Entity<LichSuTt>(entity =>
            {
                entity.HasKey(e => e.IdLstt)
                    .HasName("PK__LichSuTT__9E50130332244731");

                entity.ToTable("LichSuTT");

                entity.Property(e => e.IdLstt)
                    .HasColumnName("ID_LSTT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdHoaDon).HasColumnName("ID_HoaDon");

                entity.Property(e => e.IdPttt).HasColumnName("ID_PTTT");

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.LichSuTts)
                    .HasForeignKey(d => d.IdHoaDon)
                    .HasConstraintName("fk_LichSuTT_HoaDon");

                entity.HasOne(d => d.IdPtttNavigation)
                    .WithMany(p => p.LichSuTts)
                    .HasForeignKey(d => d.IdPttt)
                    .HasConstraintName("fk_LichSuTT_PTTT");
            });

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.IdLoaiSanPham)
                    .HasName("PK__LoaiSanP__5A10EDD8DD7330F3");

                entity.ToTable("LoaiSanPham");

                entity.Property(e => e.IdLoaiSanPham)
                    .HasColumnName("ID_LoaiSanPham")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MoTa).HasMaxLength(500);

                entity.Property(e => e.TenLoai).HasMaxLength(100);
            });

            modelBuilder.Entity<Mau>(entity =>
            {
                entity.HasKey(e => e.IdMau)
                    .HasName("PK__Mau__276C3D25E41C4ABE");

                entity.ToTable("Mau");

                entity.Property(e => e.IdMau)
                    .HasColumnName("ID_Mau")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TenMau).HasMaxLength(100);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.IdNv)
                    .HasName("PK__NhanVien__8B63E063E852B78E");

                entity.ToTable("NhanVien");

                entity.Property(e => e.IdNv)
                    .HasColumnName("ID_NV")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.IdTk).HasColumnName("ID_TK");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("SDT");

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.HasOne(d => d.IdTkNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdTk)
                    .HasConstraintName("fk_NhanVien_TaiKhoan");
            });

            modelBuilder.Entity<PhuongThucDoiTra>(entity =>
            {
                entity.HasKey(e => e.IdPtdoiTra)
                    .HasName("PK__PhuongTh__963D97C264DE00EF");

                entity.ToTable("PhuongThucDoiTra");

                entity.Property(e => e.IdPtdoiTra)
                    .HasColumnName("ID_PTDoiTra")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MoTa).HasMaxLength(500);

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            modelBuilder.Entity<Pttt>(entity =>
            {
                entity.HasKey(e => e.IdPttt)
                    .HasName("PK__PTTT__BAC96B38CEC30D38");

                entity.ToTable("PTTT");

                entity.Property(e => e.IdPttt)
                    .HasColumnName("ID_PTTT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.IdSanPham)
                    .HasName("PK__SanPham__617EA3926EFDDC92");

                entity.ToTable("SanPham");

                entity.Property(e => e.IdSanPham)
                    .HasColumnName("ID_SanPham")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdLoaiSanPham).HasColumnName("ID_LoaiSanPham");

                entity.Property(e => e.MaSanPham).HasMaxLength(100);

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.HasOne(d => d.IdLoaiSanPhamNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdLoaiSanPham)
                    .HasConstraintName("fk_SanPham_LoaiSanPham");
            });

            modelBuilder.Entity<SoCanh>(entity =>
            {
                entity.HasKey(e => e.IdCanh)
                    .HasName("PK__SoCanh__72142E5E4949FF5F");

                entity.ToTable("SoCanh");

                entity.Property(e => e.IdCanh)
                    .HasColumnName("ID_Canh")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SoCanh1).HasColumnName("SoCanh");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.IdTk)
                    .HasName("PK__TaiKhoan__8B63B1A9965C6CF1");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.IdTk)
                    .HasColumnName("ID_TK")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdNv).HasColumnName("ID_NV");

                entity.Property(e => e.IdVaiTro).HasColumnName("ID_VaiTro");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaiKhoan1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TaiKhoan");

                entity.HasOne(d => d.IdVaiTroNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.IdVaiTro)
                    .HasConstraintName("fk_TaiKhoan_VaiTro");
            });

            modelBuilder.Entity<VaiTro>(entity =>
            {
                entity.HasKey(e => e.IdVaiTro)
                    .HasName("PK__VaiTro__6A43AA5A7F3DF6AA");

                entity.ToTable("VaiTro");

                entity.Property(e => e.IdVaiTro)
                    .HasColumnName("ID_VaiTro")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            modelBuilder.Entity<VanChuyen>(entity =>
            {
                entity.HasKey(e => e.IdVc)
                    .HasName("PK__VanChuye__8B63A17E965AB0E3");

                entity.ToTable("VanChuyen");

                entity.Property(e => e.IdVc)
                    .HasColumnName("ID_VC")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TongTien).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
