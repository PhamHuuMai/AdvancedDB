using API.DTO;
using API.JWT;
using API.Models;
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
    public class TopicManageController : ApiController
    {
        TokenService tokenService = new TokenService();
        TopicService topicService = new TopicServiceImpl();
        CoacherService coacherService = new CoacherServiceImpl();

        [HttpGet]
        [Route("coacher/gettopic")]
        public IHttpActionResult loadData()
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);
                int idSv = tokenData.UserId;
                int idFaculty = coacherService.getFalcultuOfCoacher(tokenData.UserId);
                List<TopicDTO> topics = topicService.getAllTopicByFaculty(idFaculty);
                List<TopicDTO> topicOfCoacher = topicService.getAllTopicByCoacher(tokenData.UserId);
                response.Data = new GetTopicCoacherResponse {
                    AllTopics=topics,
                    TopicsOfCoacher = topicOfCoacher
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

        [HttpPost]
        [Route("coacher/addtopic")]
        public IHttpActionResult addTopic([FromBody] TopicRequest request)
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);

                // them de tai
                topicService.addTopic(new DeTai
                {
                    IDGVDeXuat = tokenData.UserId,
                    DoKho = request.DoKho,
                    MoTa = request.Mota,
                    NoiDung = request.NoiDung,
                    TenDeTai = request.TenDT,
                    IDChuyenNganh = 1
                });
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
        [Route("coacher/updatetopic/{idTopic}")]
        public IHttpActionResult updateTopic(int idTopic,[FromBody] TopicRequest request )
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);
                
                // Cạp nhật de tai
                topicService.updateTopic(new DeTai
                {
                    ID = idTopic,
                    DoKho = request.DoKho,
                    MoTa = request.Mota,
                    NoiDung = request.NoiDung,
                    TenDeTai = request.TenDT
                });
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
        [Route("coacher/deletetopic/{idTopic}")]
        public IHttpActionResult removeTopic(int idTopic)
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);
                // xóa de tai
                topicService.deleteTopic(idTopic);
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

        [HttpPut]
        [Route("admin/updatetopic/{idTopic}/status/{status}")]
        public IHttpActionResult changeStatus(int idTopic,int status)
        {
            Response response = new Response();
            try
            {
                String token = Request.Headers.Authorization.Scheme;
                TokenData tokenData = tokenService.verifyToken(token);

                // Cạp nhật de tai
                topicService.changeStatusTopic(idTopic,status);
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
