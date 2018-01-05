using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.ResponseDTO
{
    public class GetProjectManage
    {
        private List<TopicRegisterDTO> curentTopicRegister;
        private List<TopicRegisterDTO> oldTopicRegister;

        public List<TopicRegisterDTO> CurentTopicRegister
        {
            get
            {
                return curentTopicRegister;
            }

            set
            {
                curentTopicRegister = value;
            }
        }

        public List<TopicRegisterDTO> OldTopicRegister
        {
            get
            {
                return oldTopicRegister;
            }

            set
            {
                oldTopicRegister = value;
            }
        }
    }
}