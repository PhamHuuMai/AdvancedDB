using DatabaseEnginer.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API.DTO;
using API.ResponseDTO;

namespace API.Service.ServiceImpl
{
    public class CoacherServiceImpl : CoacherService
    {

        QLDT qldt = new QLDT();

        public List<CoacherDTO> getCoacherByFal(int idKhoa)
        {
            var query = from gv in qldt.GiaoViens
                        where gv.IDKhoa == idKhoa
                        select new CoacherDTO {
                            Id = gv.ID,
                            Ten = gv.HoTen,
                            HocHam = gv.HocHam,
                            HocVi = gv.HocVi
                        };
            return query.ToList();
        }

        public List<TopicRegisterDTO> getCurentTopicRegisterByGV(int idGv)
        {
            var rs = (from svdk in qldt.SinhVienDangKyDeTais
                      join sv in qldt.SinhViens on svdk.IDSinhVien equals sv.ID
                      join dt in qldt.DeTais on svdk.IDDeTai equals dt.ID
                      where svdk.DeTai.GiaoVien.ID == idGv && svdk.TrangThai == 1 && dt.Status == true
                      select new TopicRegisterDTO()
                      {
                          Id = svdk.ID,
                          IdDeTai = svdk.IDDeTai.Value,
                          TenDeTai = dt.TenDeTai,
                          IdSinhVien = svdk.IDSinhVien.Value,
                          TenSinhVien = sv.HoTen,
                          LanDangKy = svdk.LanDangKy.Value,
                          NgayDangKy = svdk.NgayDangKy.Value
                      });
            return rs.ToList();
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
            var rs = (from svdk in qldt.SinhVienDangKyDeTais
                      join sv in qldt.SinhViens on svdk.IDSinhVien equals sv.ID
                      join dt in qldt.DeTais on svdk.IDDeTai equals dt.ID
                      where svdk.DeTai.GiaoVien.ID == idGv && svdk.TrangThai == 0 && dt.Status == true
                      select new TopicRegisterDTO()
                      {
                          Id = svdk.ID,
                          IdDeTai = svdk.IDDeTai.Value,
                          TenDeTai = dt.TenDeTai,
                          IdSinhVien = svdk.IDSinhVien.Value,
                          TenSinhVien = sv.HoTen,
                          LanDangKy = svdk.LanDangKy.Value,
                          NgayDangKy = svdk.NgayDangKy.Value
                      });
            return rs.ToList();
        }
    }
}