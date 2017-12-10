namespace DatabaseEnginer.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoMon")]
    public partial class BoMon
    {
        public int ID { get; set; }

        public int? IDKhoa { get; set; }

        [StringLength(256)]
        public string TenBoMon { get; set; }

        public bool? Status { get; set; }

        public int? IDcc { get; set; }
    }
}
