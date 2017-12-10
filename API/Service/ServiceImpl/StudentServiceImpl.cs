using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API.DTO;
using DatabaseEnginer.DB;

namespace API.Service.ServiceImpl
{
    public class StudentServiceImpl : StudentService
    {
        QLDT qldt = new QLDT();
        public StudentInforDTO getStudentInfo(int id)
        {
            try
            {
                var query = from sv in qldt.SinhViens
                            join cn in qldt.ChuyenNganhs on sv.IDChuyenNganh equals cn.ID
                            select new StudentInforDTO()
                            {
                                Id = sv.ID,
                                Ten = sv.HoTen,
                                TenLop = sv.Lop,
                                MaKhoa = cn.IDKhoa.Value,
                                TenKhoa = cn.Khoa.TenKhoa,
                                MaChuyenNganh = cn.ID,
                                TenChuyenNganh = cn.TenChuyenNganh
                            };
                return query.First();
            }
            catch
            {
                throw new Exception("Id Sinhvien not found !");
            }
        }
    }
}