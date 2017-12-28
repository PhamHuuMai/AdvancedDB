using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.ResponseDTO
{
    public class GetTopicCoacherResponse
    {
        private List<TopicDTO> allTopics;
        private List<TopicDTO> topicsOfCoacher;

        public List<TopicDTO> AllTopics
        {
            get
            {
                return allTopics;
            }

            set
            {
                allTopics = value;
            }
        }

        public List<TopicDTO> TopicsOfCoacher
        {
            get
            {
                return topicsOfCoacher;
            }

            set
            {
                topicsOfCoacher = value;
            }
        }
    }
}