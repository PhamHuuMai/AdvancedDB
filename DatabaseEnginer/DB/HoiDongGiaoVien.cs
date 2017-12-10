namespace DatabaseEnginer.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoiDongGiaoVien")]
    public partial class HoiDongGiaoVien
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGV { get; set; }

        [StringLength(256)]
        public string ViTri { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual HoiDong HoiDong { get; set; }
    }
}
