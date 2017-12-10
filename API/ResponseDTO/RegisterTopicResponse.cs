using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.ResponseDTO
{
    public class RegisterTopicResponse
    {
        private StudentInforDTO studentInfor;
        private List<TopicDTO> listTopic;
        private TopicDTO topicRegisted;

        public StudentInforDTO StudentInfor
        {
            get
            {
                return studentInfor;
            }

            set
            {
                studentInfor = value;
            }
        }

        public List<TopicDTO> ListTopic
        {
            get
            {
                return listTopic;
            }

            set
            {
                listTopic = value;
            }
        }

        public TopicDTO TopicRegisted
        {
            get
            {
                return topicRegisted;
            }

            set
            {
                topicRegisted = value;
            }
        }
    }
}