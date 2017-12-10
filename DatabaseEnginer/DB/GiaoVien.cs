namespace DatabaseEnginer.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoVien")]
    public partial class GiaoVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoVien()
        {
            DeTais = new HashSet<DeTai>();
            HoiDongGiaoViens = new HashSet<HoiDongGiaoVien>();
        }

        public int ID { get; set; }

        public long MaHienThi { get; set; }

        [StringLength(256)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(256)]
        public string HocVi { get; set; }

        [StringLength(256)]
        public string HocHam { get; set; }

        public int? IDKhoa { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeTai> DeTais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoiDongGiaoVien> HoiDongGiaoViens { get; set; }

        public virtual Khoa Khoa { get; set; }
    }
}
