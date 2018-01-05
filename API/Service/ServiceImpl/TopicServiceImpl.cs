using API.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API.DTO;
using DatabaseEnginer.DB;
using System.Collections;
using API.Constant;

namespace API.Service.ServiceImpl
{
    public class TopicServiceImpl : TopicService
    {
        QLDT qldt = new QLDT();
        public List<TopicDTO> getClassTopicCurent(int idCn)
        {
            var query = from dt in qldt.DeTais
                        where (dt.TrangThai.Equals(TopicStatus.APPROVE) && dt.Status == true)// && dt.IDChuyenNganh == idCn
                        select new TopicDTO
                        {
                            DoKho = dt.DoKho.Value,
                            IdGV = dt.IDGVDeXuat.Value,
                            IdDeTai = dt.ID,
                            MoTa = dt.MoTa,
                            NoiDung = dt.NoiDung,
                            TenDT = dt.TenDeTai,
                            TenGV = dt.GiaoVien.HoTen
                        };
            return query == null ? new List<TopicDTO>() : query.ToList();
        }

        public TopicDTO getClassTopicCurentSv(int idsv)
        {
            try
            {
                var query = from l in qldt.SinhVienDangKyDeTais
                            where l.IDSinhVien == idsv && l.TrangThai == 1
                            select new TopicDTO()
                            {
                                Id = l.ID,
                                IdGV = l.DeTai.IDGVDeXuat.Value,
                                TenGV = l.DeTai.GiaoVien.HoTen,
                                IdDeTai = l.DeTai.ID,
                                TenDT = l.DeTai.TenDeTai,
                                MoTa = l.DeTai.MoTa,
                                NoiDung = l.DeTai.NoiDung,
                                DoKho = l.DeTai.DoKho.Value
                            };
                return query.First();
            }
            catch
            {
                return null;
            }
        }

        public void registerTopic(int idSv, int idDt)
        {
            //SinhVienDangKyDeTai temp = qldt.SinhVienDangKyDeTais.SingleOrDefault(x => (x.IDLopHD == idLopHd && x.IDSinhVien == idLopHd));
            var curent = qldt.SinhVienDangKyDeTais.Where(x => x.IDSinhVien == idSv && x.TrangThai == 1);
            var last = qldt.SinhVienDangKyDeTais.Where(x => x.IDSinhVien == idSv && x.TrangThai == 0);
            if (curent != null && curent.Count(x => x.IDDeTai == idDt) <= 0)
            {
                if (curent != null && curent.Count() > 0)
                {
                    // remove
                    qldt.SinhVienDangKyDeTais.RemoveRange(curent);
                }

                // insert
                SinhVienDangKyDeTai sv = qldt.SinhVienDangKyDeTais.Create();
                //  (new SinhVienDangKyDeTai
                // {
                sv.IDSinhVien = idSv;
                sv.TrangThai = 1;
                sv.IDDeTai = idDt;
                sv.LanDangKy = last == null ? 1 : last.Count() + 1;
                sv.NgayDangKy = DateTime.Now;
                sv.ChinhThuc = true;
                // });
                qldt.SinhVienDangKyDeTais.Add(sv);
                qldt.SaveChanges();
            }
        }

        public List<ReportDTO> getReport(int idDk)
        {
            var query = from i in qldt.BaoCaoTienDoes
                        where i.IDSVDKDT == idDk
                        select new ReportDTO
                        {
                            File = i.File,
                            ID = i.ID,
                            IdDK = idDk,
                            KetQua = i.KetQua,
                            LanBaoCao = i.LanBaoCao.Value,
                            NgayBaoCao = i.NgayBaoCao.Value,
                            NoiDung = i.NoiDung,
                            TrangThai = i.TrangThai == null ? 0 : i.TrangThai.Value
                        };
            if (query != null)
            {
                return query.ToList();
            }
            return new List<ReportDTO>();
        }

        public void addReport(int idSv, int idDk, String content, String file)
        {
            var count = qldt.BaoCaoTienDoes.Count(x => x.IDSVDKDT == idDk);
            var query = qldt.SinhVienDangKyDeTais.Where(x => x.ID == idDk);
            if (query != null)
            {
                qldt.BaoCaoTienDoes.Add(new BaoCaoTienDo
                {
                    File = file,
                    IDSVDKDT = idDk,
                    LanBaoCao = count + 1,
                    NoiDung = content,
                    IDSinhVien = idSv,
                    NgayBaoCao = DateTime.Now,
                    IDDeTai = query.First().IDDeTai
                });
                qldt.SaveChanges();
            }
        }

        public void removeReport(int idReport)
        {
            var temp = qldt.BaoCaoTienDoes.Where(x => x.ID == idReport);
            qldt.BaoCaoTienDoes.RemoveRange(temp);
            qldt.SaveChanges();
        }

        public void updateReport(int idReport, string content, string file)
        {
            BaoCaoTienDo result = qldt.BaoCaoTienDoes.Where(x => x.ID == idReport).FirstOrDefault();
            if (result == null)
            {
                throw new Exception("Report not found !");
            }
            else
            {
                result.NoiDung = content;
                result.File = file;
                result.NgayBaoCao = DateTime.Now;
                qldt.SaveChanges();
            }
        }

        public List<TopicDTO> getAllTopicByFaculty(int idKhoa)
        {
            var rs = (from dt in qldt.DeTais
                      join gv in qldt.GiaoViens on dt.IDGVDeXuat equals gv.ID
                      where dt.ChuyenNganh.IDKhoa == idKhoa && dt.Status == true
                      select new TopicDTO()
                      {
                          IdDeTai = dt.ID,
                          TenDT = dt.TenDeTai,
                          MoTa = dt.MoTa,
                          NoiDung = dt.NoiDung,
                          DoKho = dt.DoKho.Value,
                          TrangThai = dt.TrangThai,
                          IdGV = dt.IDGVDeXuat.Value,
                          TenGV = gv.HoTen
                      });
            return rs.ToList();
        }

        public List<TopicDTO> getAllTopicByCoacher(int idGv)
        {
            var rs = (from dt in qldt.DeTais
                      join gv in qldt.GiaoViens on dt.IDGVDeXuat equals gv.ID
                      where gv.ID == idGv && dt.Status == true
                      select new TopicDTO()
                      {
                          IdDeTai = dt.ID,
                          TenDT = dt.TenDeTai,
                          MoTa = dt.MoTa,
                          NoiDung = dt.NoiDung,
                          DoKho = dt.DoKho.Value,
                          TrangThai = dt.TrangThai,
                          IdGV = dt.IDGVDeXuat.Value,
                          TenGV = gv.HoTen
                      });
            return rs.ToList();
        }

        public void addTopic(DeTai detai)
        {
            DeTai dt = new DeTai();
            dt.TenDeTai = detai.TenDeTai;
            dt.IDGVDeXuat = detai.IDGVDeXuat;
            dt.IDChuyenNganh = detai.IDChuyenNganh;
            dt.MoTa = detai.MoTa;
            dt.NoiDung = detai.NoiDung;
            dt.DoKho = detai.DoKho;
            dt.NgayTao = DateTime.Now;
            dt.TrangThai = TopicStatus.PENDING;
            dt.Status = true;
            qldt.DeTais.Add(dt);
            qldt.SaveChanges();
        }

        public void updateTopic(DeTai detai)
        {
            DeTai dt = qldt.DeTais.Find(detai.ID);
            if (dt != null)
            {
                dt.TenDeTai = detai.TenDeTai;
                //dt.IDGVDeXuat = detai.IDGVDeXuat;
                //dt.IDChuyenNganh = detai.IDChuyenNganh;
                dt.MoTa = detai.MoTa;
                dt.NoiDung = detai.NoiDung;
                dt.DoKho = detai.DoKho;
                dt.NgayTao = DateTime.Now;
                dt.TrangThai = TopicStatus.PENDING;
            }
            qldt.SaveChanges();
        }

        public void deleteTopic(int id)
        {
            DeTai dt = qldt.DeTais.Find(id);
            dt.Status = false;
            qldt.SaveChanges();
        }

        public void changeStatusTopic(int idDetai, int status)
        {
            DeTai dt = qldt.DeTais.Where(x => x.ID == idDetai).FirstOrDefault();
            if (dt != null)
            {
                dt.TrangThai = status + "";
            }
            qldt.SaveChanges();
        }
    }
}