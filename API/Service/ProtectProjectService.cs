using API.DTO;
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
        List<HDInforDTO> getAllHD();
        List<KhoaDTO> getKhoas();
        HDInforDTO getInfoHD(int id);
        List<HDDetailDTO> getDetailHD(int id);
        void add(HoiDong hd,List<HoiDongGiaoVien> dhGv);
        void update(HoiDong hd, List<HoiDongGiaoVien> dhGv);
        void delete(int idHd);   
    }
}
