using System.Web.Http;
using API.ResponseDTO;
using API.RequestDTO;
using System;
using API.Service;
using API.Service.ServiceImpl;
using API.JWT;
using API.Models;

namespace API.Controllers
{
    public class UserController : ApiController
    {
        SessionService sessionService = new SessionServiceImpl();
        TokenService tokenService = new TokenService();

        [HttpPost]
        [Route("login")]
        public IHttpActionResult login([FromBody] LoginRequest request)
        {
            Response response = new Response();
            try
            {
                LoginResponse loginResponse = sessionService.login(request.UserName, request.Password);
                TokenData tokenData = new TokenData();
                tokenData.UserId = loginResponse.IdRef;
                tokenData.Role = loginResponse.Role;
                String token = tokenService.createToken(tokenData);
                loginResponse.Token = token;
                response.Data = loginResponse;
                response.Code = 0;
            }  catch(Exception e)
            {
                
                response.Code = 1;
            }
            return Ok<Response>(response);
        }
 
    }
}
