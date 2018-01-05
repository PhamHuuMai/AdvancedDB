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
        public int addHD(HoiDong hd)
        {
            HoiDong hda = new HoiDong();
            hda.TenHD = hd.TenHD;
            hda.IDKhoa = hd.IDKhoa;
            hda.NgayThanhLap = hd.NgayThanhLap;
            hda.NamHoc = hd.NamHoc;
            hda.Status = hd.Status;
            qldt.HoiDongs.Add(hda);
            qldt.SaveChanges();
            return hda.ID;
        }
        public void add(HoiDong hd, List<HoiDongGiaoVien> dhGv)
        {
            int id = addHD(hd);
            for(int i=0; i<dhGv.Count(); i++)
            {
                dhGv.ElementAt(i).MaHD = id;
            }
            qldt.HoiDongGiaoViens.AddRange(dhGv);
            qldt.SaveChanges();
        }

        public void delete(int idHd)
        {
            HoiDong hd = qldt.HoiDongs.Find(idHd);
            if(hd != null)
            {
                hd.Status = true;
            }
            qldt.SaveChanges();
        }

        public void update(HoiDong hd, List<HoiDongGiaoVien> dhGv)
        {
            throw new NotImplementedException();
        }

        List<HDInforDTO> ProtectProjectService.getAllHD()
        {
            throw new NotImplementedException();
        }

        List<HDDetailDTO> ProtectProjectService.getDetailHD(int id)
        {
            var rs = (from hdgv in qldt.HoiDongGiaoViens
                      join gv in qldt.GiaoViens on hdgv.MaGV equals gv.ID
                      select new HDDetailDTO()
                      {
                          IdHd = hdgv.MaHD,
                          IdGV = hdgv.MaGV,
                          TenGV = gv.HoTen,
                          ViTri = hdgv.ViTri
                      });
            return rs.ToList();
        }

        HDInforDTO ProtectProjectService.getInfoHD(int id)
        {
            var rs = (from hd in qldt.HoiDongs
                      join k in qldt.Khoas on hd.IDKhoa equals k.ID
                      select new HDInforDTO()
                      {
                          Id = hd.ID,
                          TenHd = hd.TenHD,
                          IdKhoa = k.ID,
                          TenKhoa = k.TenKhoa,
                          NgayTL = DateTime.Now,
                          Status = Convert.ToInt16(hd.Status)
                      });
            return rs.First();
        }
    }
}