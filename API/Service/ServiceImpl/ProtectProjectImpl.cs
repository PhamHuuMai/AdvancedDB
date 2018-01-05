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
            hda.NgayThanhLap = DateTime.UtcNow;
            hda.NamHoc = DateTime.UtcNow.Year + "-" + (DateTime.UtcNow.Year + 1);
            hda.Status = false;
            qldt.HoiDongs.Add(hda);
            qldt.SaveChanges();
            return hda.ID;
        }

        public void add(HoiDong hd, List<HoiDongGiaoVien> dhGv)
        {
            int id = addHD(hd);
            for (int i = 0; i < dhGv.Count(); i++)
            {
                dhGv.ElementAt(i).MaHD = id;
            }
            qldt.HoiDongGiaoViens.AddRange(dhGv);
            qldt.SaveChanges();
        }

        public void delete(int idHd)
        {
            //List<HoiDongGiaoVien> ddc = qldt.HoiDongGiaoViens.Where(x => x.MaHD == idHd).ToList();
            //qldt.HoiDongGiaoViens.RemoveRange(ddc);
            //qldt.SaveChanges();
            HoiDong hd = qldt.HoiDongs.Find(idHd);
            if (hd != null)
            {
                hd.Status = true;
            }
            qldt.SaveChanges();
        }

        public List<HDDetailDTO> getDetailHD(int id)
        {
            var rs = (from hdgv in qldt.HoiDongGiaoViens
                      join gv in qldt.GiaoViens on hdgv.MaGV equals gv.ID
                      where hdgv.MaHD == id
                      select new HDDetailDTO()
                      {
                          IdHd = hdgv.MaHD,
                          IdGV = hdgv.MaGV,
                          TenGV = gv.HoTen,
                          ViTri = hdgv.ViTri
                      });
            return rs.ToList();
        }

        public void update(HoiDong hd, List<HoiDongGiaoVien> dhGv)
        {
            var hoidong = qldt.HoiDongs.Where(s => s.ID == hd.ID).FirstOrDefault();
            //       hoidong.IDKhoa = hd.IDKhoa;
            //       hoidong.NgayThanhLap = hd.NgayThanhLap;
            //       hoidong.NamHoc = hd.NamHoc;
            hoidong.TenHD = hd.TenHD;
            //       hoidong.Status = hd.Status;

            var giaovienhoidong = qldt.HoiDongGiaoViens.Where(s => s.MaHD == hd.ID).AsQueryable();
            if (giaovienhoidong != null)
            {
                qldt.HoiDongGiaoViens.RemoveRange(giaovienhoidong);
            }

            foreach (var item in dhGv)
            {
                item.MaHD = hd.ID;
                qldt.HoiDongGiaoViens.Add(item);
            }
            qldt.SaveChanges();
        }

        public List<HDInforDTO> getAllHD()
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

        public HDInforDTO getInfoHD(int id)
        {
            var rs = (from hd in qldt.HoiDongs
                      join k in qldt.Khoas on hd.IDKhoa equals k.ID
                      where hd.ID == id
                      select new HDInforDTO()
                      {
                          Id = hd.ID,
                          TenHd = hd.TenHD,
                          IdKhoa = k.ID,
                          TenKhoa = k.TenKhoa,
                          NgayTL = DateTime.Now,
                          Status = 0
                      });
            return rs.First();
        }

        public List<KhoaDTO> getKhoas()
        {
            return (from k in qldt.Khoas
                    select new KhoaDTO
                    {
                        MaKhoa = k.ID,
                        TenKhoa = k.TenKhoa
                    }).ToList();
        }
    }
}