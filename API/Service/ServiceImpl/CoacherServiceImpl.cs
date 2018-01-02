using DatabaseEnginer.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API.DTO;

namespace API.Service.ServiceImpl
{
    public class CoacherServiceImpl : CoacherService
    {

        QLDT qldt = new QLDT();

        public List<TopicRegisterDTO> getCurentTopicRegisterByGV(int idGv)
        {
            throw new NotImplementedException();
        }

        public int getFalcultuOfCoacher(int idGv)
        {
            var rs = (from gv in qldt.GiaoViens
                      where gv.ID == idGv
                      select gv).First();
            if (rs == null)
                throw new Exception("Giao vien ko hop le");
            int a = rs.IDKhoa.Value;
            return a;
        }

        public List<TopicRegisterDTO> getOldTopicRegisterByGV(int idGv)
        {
            throw new NotImplementedException();
        }
    }
}