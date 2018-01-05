using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseEnginer.DB;

namespace API.Service.ServiceImpl
{
    public class ProtectProjectImpl : ProtectProjectService
    {
        QLDT qldt = new QLDT();
        public void add(HoiDong hd, List<HoiDongGiaoVien> dhGv)
        {
            
        }

        public void delete(int idHd)
        {
            HoiDong hd = qldt.HoiDongs.Find(idHd);
            if(hd != null)
            {
                hd.Status = true;
            }
        }

        public void getAllHD()
        {
            throw new NotImplementedException();
        }

        public void getDetailHD(int id)
        {
            throw new NotImplementedException();
        }

        public void getInfoHD(int id)
        {
            throw new NotImplementedException();
        }

        public void update(HoiDong hd, List<HoiDongGiaoVien> dhGv)
        {
            throw new NotImplementedException();
        }
    }
}