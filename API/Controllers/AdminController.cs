using API.ResponseDTO;
using API.Service;
using API.Service.ServiceImpl;
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

                response.Data = new HDDetailResponse {
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

    }
}
