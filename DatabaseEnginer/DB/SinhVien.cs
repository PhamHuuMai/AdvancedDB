namespace DatabaseEnginer.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            BaoCaoTienDoes = new HashSet<BaoCaoTienDo>();
            BienBanBaoVes = new HashSet<BienBanBaoVe>();
            SinhVienDangKyDeTais = new HashSet<SinhVienDangKyDeTai>();
        }

        public int ID { get; set; }

        [StringLength(256)]
        public string HoTen { get; set; }

        [StringLength(10)]
        public string Lop { get; set; }

        public int? IDChuyenNganh { get; set; }

        public bool? GioiTinh { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        public int? TCTL { get; set; }

        public double? DiemTBTL { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoCaoTienDo> BaoCaoTienDoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BienBanBaoVe> BienBanBaoVes { get; set; }

        public virtual ChuyenNganh ChuyenNganh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVienDangKyDeTai> SinhVienDangKyDeTais { get; set; }
    }
}
