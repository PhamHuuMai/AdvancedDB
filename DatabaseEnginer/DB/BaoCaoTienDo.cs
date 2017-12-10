namespace DatabaseEnginer.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoCaoTienDo")]
    public partial class BaoCaoTienDo
    {
        public int ID { get; set; }

        public int? IDDeTai { get; set; }

        public int? IDSinhVien { get; set; }

        public int? LanBaoCao { get; set; }

        public DateTime? NgayBaoCao { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        [StringLength(256)]
        public string KetQua { get; set; }

        [StringLength(50)]
        public string File { get; set; }

        public int? IDSVDKDT { get; set; }

        public int? TrangThai { get; set; }

        public virtual DeTai DeTai { get; set; }

        public virtual SinhVien SinhVien { get; set; }

        public virtual SinhVienDangKyDeTai SinhVienDangKyDeTai { get; set; }
    }
}
