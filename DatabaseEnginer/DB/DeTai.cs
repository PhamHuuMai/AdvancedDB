namespace DatabaseEnginer.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeTai")]
    public partial class DeTai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeTai()
        {
            BaoCaoTienDoes = new HashSet<BaoCaoTienDo>();
            BienBanBaoVes = new HashSet<BienBanBaoVe>();
            SinhVienDangKyDeTais = new HashSet<SinhVienDangKyDeTai>();
        }

        public int ID { get; set; }

        [StringLength(256)]
        public string TenDeTai { get; set; }

        public int? IDChuyenNganh { get; set; }

        public int? IDGVDeXuat { get; set; }

        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public int? DoKho { get; set; }

        [StringLength(256)]
        public string TrangThai { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiTao { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoCaoTienDo> BaoCaoTienDoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BienBanBaoVe> BienBanBaoVes { get; set; }

        public virtual ChuyenNganh ChuyenNganh { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVienDangKyDeTai> SinhVienDangKyDeTais { get; set; }
    }
}
