using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1.DAL.DomainClass;

namespace _1.DAL.Context
{
    public partial class FpolyDBContext : DbContext
    {
        public FpolyDBContext()
        {
        }

        public FpolyDBContext(DbContextOptions<FpolyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietSp> ChiTietSps { get; set; } = null!;
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<CuaHang> CuaHangs { get; set; } = null!;
        public virtual DbSet<DongSp> DongSps { get; set; } = null!;
        public virtual DbSet<GioHang> GioHangs { get; set; } = null!;
        public virtual DbSet<GioHangChiTiet> GioHangChiTiets { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<MauSac> MauSacs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<Nsx> Nsxes { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-38A8E8P\\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041;Persist Security Info=True;User ID=thesun;Password=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietSp>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaNhap).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdDongSpNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdDongSp)
                    .HasConstraintName("FK__ChiTietSP__IdDon__17036CC0");

                entity.HasOne(d => d.IdMauSacNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdMauSac)
                    .HasConstraintName("FK__ChiTietSP__IdMau__160F4887");

                entity.HasOne(d => d.IdNsxNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdNsx)
                    .HasConstraintName("FK__ChiTietSP__IdNsx__151B244E");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdSp)
                    .HasConstraintName("FK__ChiTietSP__IdSP__14270015");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<CuaHang>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<DongSp>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TinhTrang).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.GioHangs)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__GioHang__IdKH__123EB7A3");
            });

            modelBuilder.Entity<GioHangChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.IdGioHang, e.IdChiTietSp })
                    .HasName("PK_GioHangCT");

                entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");

                entity.Property(e => e.DonGiaKhiGiam).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.GioHangChiTiets)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_IdChiTietSP");

                entity.HasOne(d => d.IdGioHangNavigation)
                    .WithMany(p => p.GioHangChiTiets)
                    .HasForeignKey(d => d.IdGioHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_IdGioHang");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TinhTrang).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__HoaDon__IdKH__114A936A");

                entity.HasOne(d => d.IdNvNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNv)
                    .HasConstraintName("FK__HoaDon__IdNV__1332DBDC");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.IdHoaDon, e.IdChiTietSp })
                    .HasName("PK_HoaDonCT");

                entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdCh)
                    .HasConstraintName("FK__NhanVien__IdCH__0E6E26BF");

                entity.HasOne(d => d.IdCvNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdCv)
                    .HasConstraintName("FK__NhanVien__IdCV__0F624AF8");

                entity.HasOne(d => d.IdGuiBcNavigation)
                    .WithMany(p => p.InverseIdGuiBcNavigation)
                    .HasForeignKey(d => d.IdGuiBc)
                    .HasConstraintName("FK__NhanVien__IdGuiB__10566F31");
            });

            modelBuilder.Entity<Nsx>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
