namespace DatabaseEnginer.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BienBanBaoVe")]
    public partial class BienBanBaoVe
    {
        public int ID { get; set; }

        public int? IDSinhVien { get; set; }

        public int? IDDeTai { get; set; }

        public int? IDHoiDong { get; set; }

        public DateTime? NgayBaoVe { get; set; }

        public DateTime? ThoiGianVao { get; set; }

        public DateTime? ThoiGianRa { get; set; }

        public double? DiemHD1 { get; set; }

        public double? DiemHD2 { get; set; }

        public double? DiemHD3 { get; set; }

        public double? DiemHD4 { get; set; }

        public double? DiemHD5 { get; set; }

        public double? DiemPhanBien { get; set; }

        public double? DiemHuongDan { get; set; }

        public double? DiemTrungBinh { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiTao { get; set; }

        public virtual DeTai DeTai { get; set; }

        public virtual HoiDong HoiDong { get; set; }

        public virtual SinhVien SinhVien { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
