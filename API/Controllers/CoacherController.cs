using API.DTO;
using API.JWT;
using API.Models;
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
    public class CoacherController : ApiController
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
    }
}
