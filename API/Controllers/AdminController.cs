using API.RequestDTO;
using API.ResponseDTO;
using API.Service;
using API.Service.Service;
using API.Service.ServiceImpl;
using DatabaseEnginer.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AdminController : ApiController
    {

        ProtectProjectService protectProjectService = new ProtectProjectImpl();
        CoacherService coacherService = new CoacherServiceImpl();
        TopicService topicService = new TopicServiceImpl();
        [HttpGet]
        [Route("admin/khoas")]
        public IHttpActionResult GetKhoa()
        {
            Response response = new Response();
            try
            {
                response.Data = protectProjectService.getKhoas();
                response.Code = 0;
                response.Msg = "OK OK";
            }
            catch (Exception e)
            {
                response.Code = 1;
                response.Msg = e.Message;
            }
            return Ok<Response>(response);
        }

        [Route("admin/khoas/{idKhoa}/topic")]
        public IHttpActionResult GetTopicByFal(int idKhoa)
        {
            Response response = new Response();
            try
            {
                response.Data = topicService.getAllTopicByFaculty(idKhoa);
                response.Code = 0;
                response.Msg = "OK OK";
            }
            catch (Exception e)
            {
                response.Code = 1;
                response.Msg = e.Message;
            }
            return Ok<Response>(response);
        }


        [HttpGet]
        [Route("admin/getallhd")]
        public IHttpActionResult GetAllHd()
        {
            Response response = new Response();
            try
            {
                response.Data = protectProjectService.getAllHD();
                response.Code = 0;
                response.Msg = "OK OK";
            }
            catch (Exception e)
            {
                response.Code = 1;
                response.Msg = e.Message;
            }
            return Ok<Response>(response);
        }

        [HttpPost]
        [Route("admin/hd")]
        public IHttpActionResult addHd([FromBody] HdRequest request)
        {
            Response response = new Response();
            try
            {
                if (request.isInvalid())
                {
                    response.Code = 1;
                    response.Msg = " Format paramerter invalid !!!!";
                    return Ok<Response>(response);
                }
                HoiDong hd = new HoiDong
                {
                    IDKhoa = request.HdInfor.IdKhoa,
                    TenHD = request.HdInfor.TenHd
                };
                List<HoiDongGiaoVien> sssss = (from i in request.HdDetail
                                               select new HoiDongGiaoVien
                                               {
                                                   ViTri = i.ViTri,
                                                   MaGV = i.IdGV
                                               }).ToList();
                protectProjectService.add(hd, sssss);
                response.Code = 0;
                response.Msg = "OK OK";
            }
            catch (Exception e)
            {
                response.Code = 1;
                response.Msg = e.Message;
            }
            return Ok<Response>(response);
        }

        [HttpPut]
        [Route("admin/hd")]
        public IHttpActionResult updateHd([FromBody] HdRequest request)
        {
            Response response = new Response();
            try
            {
                //     response.Data = protectProjectService.add();
                if (request.isInvalid())
                {
                    response.Code = 1;
                    response.Msg = " Format paramerter invalid !!!!";
                    return Ok<Response>(response);
                }
                HoiDong hd = new HoiDong
                {
                    ID = request.HdInfor.Id,
                    IDKhoa = request.HdInfor.IdKhoa,
                    TenHD = request.HdInfor.TenHd
                };
                List<HoiDongGiaoVien> sssss = (from i in request.HdDetail
                                               select new HoiDongGiaoVien
                                               {
                                                   ViTri = i.ViTri,
                                                   MaGV = i.IdGV
                                               }).ToList();
                protectProjectService.update(hd, sssss);
                response.Code = 0;
                response.Msg = "OK OK";
            }
            catch (Exception e)
            {
                response.Code = 1;
                response.Msg = e.Message;
            }
            return Ok<Response>(response);
        }
        [HttpDelete]
        [Route("admin/hd/{id}")]
        public IHttpActionResult deleteHd(int id)
        {
            Response response = new Response();
            try
            {
                protectProjectService.delete(id);
                response.Code = 0;
                response.Msg = "OK OK";
            }
            catch (Exception e)
            {
                response.Code = 1;
                response.Msg = e.Message;
            }
            return Ok<Response>(response);
        }

        [HttpGet]
        [Route("admin/gethddetail/{id}")]
        public IHttpActionResult GetHdDetail(int? id)
        {
            Response response = new Response();
            try
            {
                // validate  
                if (id == null)
                {
                    response.Code = 1;
                    response.Msg = "Param invalid";
                }

                response.Data = new HDDetailResponse
                {
                    HDInfor = protectProjectService.getInfoHD(id.Value),
                    HDDetai = protectProjectService.getDetailHD(id.Value)
                };
                response.Code = 0;
                response.Msg = "OK OK";
            }
            catch (Exception e)
            {
                response.Code = 1;
                response.Msg = e.Message;
            }
            return Ok<Response>(response);
        }

        [HttpGet]
        [Route("admin/khoa/{id}/giaovien")]
        public IHttpActionResult GetGV(int? id)
        {
            Response response = new Response();
            try
            {
                // validate  
                if (id == null)
                {
                    response.Code = 1;
                    response.Msg = "Param invalid";
                }

                response.Data = coacherService.getCoacherByFal(id.Value);
                response.Code = 0;
                response.Msg = "OK OK";
            }
            catch (Exception e)
            {
                response.Code = 1;
                response.Msg = e.Message;
            }
            return Ok<Response>(response);
        }
        [HttpPut]
        [Route("admin/topic/{idDt}/status/{status}")]
        public IHttpActionResult changeStatus(int? idDt, int? status)
        {
            Response response = new Response();
            try
            {
                // validate  
                if (status == null || idDt == null)
                {
                    response.Code = 1;
                    response.Msg = "Param invalid";
                }
                topicService.changeStatusTopic(idDt.Value, status.Value);
                response.Code = 0;
                response.Msg = "OK OK";
            }
            catch (Exception e)
            {
                response.Code = 1;
                response.Msg = e.Message;
            }
            return Ok<Response>(response);
        }


    }
}
