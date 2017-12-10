namespace DatabaseEnginer.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            BienBanBaoVes = new HashSet<BienBanBaoVe>();
            DeTais = new HashSet<DeTai>();
        }

        public int ID { get; set; }

        public long? MaHienThi { get; set; }

        [StringLength(20)]
        public string MatKhau { get; set; }

        [StringLength(256)]
        public string TenTaiKhoan { get; set; }

        public int? Role { get; set; }

        public int? IDRef { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BienBanBaoVe> BienBanBaoVes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeTai> DeTais { get; set; }
    }
}
