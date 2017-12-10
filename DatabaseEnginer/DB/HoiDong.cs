namespace DatabaseEnginer.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoiDong")]
    public partial class HoiDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoiDong()
        {
            BienBanBaoVes = new HashSet<BienBanBaoVe>();
            HoiDongGiaoViens = new HashSet<HoiDongGiaoVien>();
            SinhVienDangKyDeTais = new HashSet<SinhVienDangKyDeTai>();
        }

        public int ID { get; set; }

        [StringLength(256)]
        public string TenHD { get; set; }

        public int? IDKhoa { get; set; }

        public DateTime? NgayThanhLap { get; set; }

        [StringLength(15)]
        public string NamHoc { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BienBanBaoVe> BienBanBaoVes { get; set; }

        public virtual Khoa Khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoiDongGiaoVien> HoiDongGiaoViens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVienDangKyDeTai> SinhVienDangKyDeTais { get; set; }
    }
}
