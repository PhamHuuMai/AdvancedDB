using DatabaseEnginer.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Service
{
    interface ProtectProjectService
    {
        void getAllHD();
        void getInfoHD(int id);
        void getDetailHD(int id);
        void add(HoiDong hd,List<HoiDongGiaoVien> dhGv);
        void update(HoiDong hd, List<HoiDongGiaoVien> dhGv);
        void delete(int idHd);
         
    }
}
