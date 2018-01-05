using API.JWT;
using API.Models;
using API.RequestDTO;
using API.ResponseDTO;
using API.Service;
using API.Service.Service;
using API.Service.ServiceImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ProjectManageController : ApiController
    {
        TokenService tokenService = new TokenService();
        CoacherService coacherService = new CoacherServiceImpl();
        TopicService topicService = new TopicServiceImpl();
        ReportService reportService = new ReportServiceImpl();

        [HttpGet]
        [Route("coacher/getstudentmanaged")]
        public IHttpActionResult loadData()
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);

                response.Data = new GetProjectManage
                {
                    CurentTopicRegister = coacherService.getCurentTopicRegisterByGV(tokenData.UserId),
                    OldTopicRegister = coacherService.getOldTopicRegisterByGV(tokenData.UserId)
                };
                response.Msg = "Succsess";
                response.Code = 0;
            }
            catch (Exception e)
            {
                response.Code = 1;
            }
            return Ok<Response>(response);
        }
        [HttpGet]
        [Route("coacher/report/{idDk}")]
        public IHttpActionResult getReport(int idDk)
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);
                response.Data = topicService.getReport(idDk);
                response.Msg = "Succsess";
                response.Code = 0;
            }
            catch (Exception e)
            {
                response.Code = 1;
            }
            return Ok<Response>(response);
        }
        [HttpPost]
        [Route("coacher/report")]
        public IHttpActionResult markReport([FromBody] MarkPointRequest request)
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);
                reportService.update(request.IdReport, request.Point);
                response.Msg = "Succsess";
                response.Code = 0;
            }
            catch (Exception e)
            {
                response.Code = 1;
            }
            return Ok<Response>(response);
        }
    }
}
