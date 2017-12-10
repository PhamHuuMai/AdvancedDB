namespace DatabaseEnginer.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLDT : DbContext
    {
        public QLDT()
            : base("name=QLDT3")
        {
        }

        public virtual DbSet<BaoCaoTienDo> BaoCaoTienDoes { get; set; }
        public virtual DbSet<BienBanBaoVe> BienBanBaoVes { get; set; }
        public virtual DbSet<BoMon> BoMons { get; set; }
        public virtual DbSet<ChuyenNganh> ChuyenNganhs { get; set; }
        public virtual DbSet<DeTai> DeTais { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<HoiDong> HoiDongs { get; set; }
        public virtual DbSet<HoiDongGiaoVien> HoiDongGiaoViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<SinhVienDangKyDeTai> SinhVienDangKyDeTais { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoCaoTienDo>()
                .Property(e => e.File)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenNganh>()
                .HasMany(e => e.DeTais)
                .WithOptional(e => e.ChuyenNganh)
                .HasForeignKey(e => e.IDChuyenNganh);

            modelBuilder.Entity<ChuyenNganh>()
                .HasMany(e => e.SinhViens)
                .WithOptional(e => e.ChuyenNganh)
                .HasForeignKey(e => e.IDChuyenNganh);

            modelBuilder.Entity<DeTai>()
                .HasMany(e => e.BaoCaoTienDoes)
                .WithOptional(e => e.DeTai)
                .HasForeignKey(e => e.IDDeTai);

            modelBuilder.Entity<DeTai>()
                .HasMany(e => e.BienBanBaoVes)
                .WithOptional(e => e.DeTai)
                .HasForeignKey(e => e.IDDeTai);

            modelBuilder.Entity<DeTai>()
                .HasMany(e => e.SinhVienDangKyDeTais)
                .WithOptional(e => e.DeTai)
                .HasForeignKey(e => e.IDDeTai);

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.DeTais)
                .WithOptional(e => e.GiaoVien)
                .HasForeignKey(e => e.IDGVDeXuat);

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.HoiDongGiaoViens)
                .WithRequired(e => e.GiaoVien)
                .HasForeignKey(e => e.MaGV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoiDong>()
                .Property(e => e.NamHoc)
                .IsUnicode(false);

            modelBuilder.Entity<HoiDong>()
                .HasMany(e => e.BienBanBaoVes)
                .WithOptional(e => e.HoiDong)
                .HasForeignKey(e => e.IDHoiDong);

            modelBuilder.Entity<HoiDong>()
                .HasMany(e => e.HoiDongGiaoViens)
                .WithRequired(e => e.HoiDong)
                .HasForeignKey(e => e.MaHD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoiDong>()
                .HasMany(e => e.SinhVienDangKyDeTais)
                .WithOptional(e => e.HoiDong)
                .HasForeignKey(e => e.IDHoiDong);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.ChuyenNganhs)
                .WithOptional(e => e.Khoa)
                .HasForeignKey(e => e.IDKhoa);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.GiaoViens)
                .WithOptional(e => e.Khoa)
                .HasForeignKey(e => e.IDKhoa);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.HoiDongs)
                .WithOptional(e => e.Khoa)
                .HasForeignKey(e => e.IDKhoa);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.Lop)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.BaoCaoTienDoes)
                .WithOptional(e => e.SinhVien)
                .HasForeignKey(e => e.IDSinhVien);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.BienBanBaoVes)
                .WithOptional(e => e.SinhVien)
                .HasForeignKey(e => e.IDSinhVien);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.SinhVienDangKyDeTais)
                .WithOptional(e => e.SinhVien)
                .HasForeignKey(e => e.IDSinhVien);

            modelBuilder.Entity<SinhVienDangKyDeTai>()
                .HasMany(e => e.BaoCaoTienDoes)
                .WithOptional(e => e.SinhVienDangKyDeTai)
                .HasForeignKey(e => e.IDSVDKDT);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.BienBanBaoVes)
                .WithOptional(e => e.TaiKhoan)
                .HasForeignKey(e => e.IDNguoiTao);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.DeTais)
                .WithOptional(e => e.TaiKhoan)
                .HasForeignKey(e => e.IDNguoiTao);
        }
    }
}
