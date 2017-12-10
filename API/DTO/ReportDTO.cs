using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DTO
{
    public class ReportDTO
    {
        public int ID { get; set; }

        public int LanBaoCao { get; set; }

        public DateTime NgayBaoCao { get; set; }

        public String NoiDung { get; set; }

        public String KetQua { get; set; }

        public String File { get; set; }

        public int IdDK { get; set; }

        public int TrangThai { get; set; }

    }
}