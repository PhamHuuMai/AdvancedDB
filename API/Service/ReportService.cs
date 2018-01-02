using DatabaseEnginer.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Service
{
    interface ReportService
    {
        List<BaoCaoTienDo> getAllReportByIdDk(int idDk);

        void update(int idReport, int point);

    }
}
