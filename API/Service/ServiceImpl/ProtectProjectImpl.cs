using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API.DTO;
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
            if (hd != null)
            {
                hd.Status = true;
            }
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
            var hoidong = qldt.HoiDongs.Where(s => s.ID == hd.ID).FirstOrDefault();
            hoidong.IDKhoa = hd.IDKhoa;
            hoidong.NgayThanhLap = hd.NgayThanhLap;
            hoidong.NamHoc = hd.NamHoc;
            hoidong.TenHD = hd.TenHD;
            hoidong.Status = hd.Status;

            var giaovienhoidong = qldt.HoiDongGiaoViens.Where(s => s.MaHD == hd.ID).AsQueryable();
            if(giaovienhoidong!=null)
            {
                qldt.HoiDongGiaoViens.RemoveRange(giaovienhoidong);
            }
           
            foreach(var item in dhGv)
            {
                qldt.HoiDongGiaoViens.Add(item);
            }
            qldt.SaveChanges();
        }

        List<HDInforDTO> ProtectProjectService.getAllHD()
        {
            var query = from s in qldt.HoiDongs
                        join k in qldt.Khoas on s.IDKhoa equals k.ID
                        where s.Status == false
                        select new HDInforDTO()
                        {
                            Id = s.ID,
                            TenHd = s.TenHD,
                            IdKhoa = s.IDKhoa.HasValue ? s.IDKhoa.Value : 1,
                            TenKhoa = s.IDKhoa.HasValue ? s.Khoa.TenKhoa : "null",
                            NgayTL = s.NgayThanhLap.HasValue ? s.NgayThanhLap.Value : DateTime.Now
                        };
            return query.ToList();
        }

        List<HDDetailDTO> ProtectProjectService.getDetailHD(int id)
        {
            throw new NotImplementedException();
        }

        HDInforDTO ProtectProjectService.getInfoHD(int id)
        {
            throw new NotImplementedException();
        }
    }
}