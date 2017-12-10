namespace DatabaseEnginer.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVienDangKyDeTai")]
    public partial class SinhVienDangKyDeTai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVienDangKyDeTai()
        {
            BaoCaoTienDoes = new HashSet<BaoCaoTienDo>();
        }

        public int ID { get; set; }

        public int? IDSinhVien { get; set; }

        public int? LanDangKy { get; set; }

        public int? IDDeTai { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public bool? ChinhThuc { get; set; }

        public int? IDHoiDong { get; set; }

        public int? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoCaoTienDo> BaoCaoTienDoes { get; set; }

        public virtual DeTai DeTai { get; set; }

        public virtual HoiDong HoiDong { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
