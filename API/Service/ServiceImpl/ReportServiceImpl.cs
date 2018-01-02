using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseEnginer.DB;

namespace API.Service.ServiceImpl
{
    public class ReportServiceImpl : ReportService
    {
        QLDT qldt = new QLDT();
        public List<BaoCaoTienDo> getAllReportByIdDk(int idDk)
        {
            var rs = (from bc in qldt.BaoCaoTienDoes
                      where bc.IDSVDKDT == idDk
                      select bc);
            return rs.ToList();
        }

        public void update(int idReport, int point)
        {
            BaoCaoTienDo bc = qldt.BaoCaoTienDoes.Find(idReport);
            if(bc != null)
            {
                bc.KetQua = point.ToString();
            }
            qldt.SaveChanges();
        }
    }
}