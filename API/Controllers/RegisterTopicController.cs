using API.JWT;
using API.Models;
using API.Service.ServiceImpl;
using API.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Service.Service;
using API.Service;
using API.DTO;
using API.RequestDTO;

namespace API.Controllers
{
    public class RegisterTopicController : ApiController
    {
        TokenService tokenService = new TokenService();
        TopicService topicService = new TopicServiceImpl();
        StudentService studentService = new StudentServiceImpl();

        [HttpGet]
        [Route("student/register")]
        public IHttpActionResult loadData()
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);
                int idSv = tokenData.UserId;
                StudentInforDTO stInfor = studentService.getStudentInfo(idSv);
                List<TopicDTO> topics = topicService.getClassTopicCurent(stInfor.MaChuyenNganh);
                TopicDTO topicRegisted = topicService.getClassTopicCurentSv(idSv);
                RegisterTopicResponse result = new RegisterTopicResponse()
                {
                    StudentInfor = stInfor,
                    ListTopic = topics,
                    TopicRegisted = topicRegisted
                };
                response.Data = result;
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
        [Route("student/report")]
        public IHttpActionResult getCurrent()
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);
                int idSv = tokenData.UserId;
                TopicDTO topicRegisted = topicService.getClassTopicCurentSv(idSv);
                List<ReportDTO> reports = topicRegisted==null? new List<ReportDTO>() : topicService.getReport(topicRegisted.Id);
                ReportTopicResponse result = new ReportTopicResponse
                {
                    TopicRegisted = topicRegisted,
                    Reports = reports              
                };
                response.Data = result;
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
        [Route("student/report")]
        public IHttpActionResult createReport([FromBody] CreateReportRequest request)
        {
            Response response = new Response();
            try
            {
                if (!request.isValid())
                    throw new Exception("Param is valid ?");
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);
                int idSv = tokenData.UserId;
                topicService.addReport(idSv, request.IdDk, request.Content, request.File);
                response.Msg = "Succsess";
                response.Code = 0;
            }
            catch (Exception e)
            {
                response.Code = 1;
            }
            return Ok<Response>(response);
        }

        [HttpPut]
        [Route("student/report/{idreport}")]
        public IHttpActionResult updateReport(int idreport,[FromBody] UpdateReportRequest request)
        {
            Response response = new Response();
            try
            {
                if (!request.isValid())
                    throw new Exception("Param is valid ?");
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);
                int idSv = tokenData.UserId;
                topicService.updateReport(idreport, request.Content, request.File);
                response.Msg = "Succsess";
                response.Code = 0;
            }
            catch (Exception e)
            {
                response.Code = 1;
            }
            return Ok<Response>(response);
        }
        [HttpDelete]
        [Route("student/report/{idreport}")]
        public IHttpActionResult removeReport(int idreport)
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);
                int idSv = tokenData.UserId;
                topicService.removeReport(idreport);
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
        [Route("student/register/{idClassTopic}")]
        public IHttpActionResult registerTopic(int idClassTopic)
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);
                int idSv = tokenData.UserId;
                topicService.registerTopic(idSv, idClassTopic);
                response.Msg = "Succsess";
                response.Code = 0;
            }
            catch (Exception e)
            {
                response.Msg = e.Message;
                response.Code = 1;
            }
            return Ok<Response>(response);
        }


    }
}
