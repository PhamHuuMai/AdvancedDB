using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.ResponseDTO
{
    public class ReportTopicResponse
    {
        private TopicDTO topicRegisted;
        private List<ReportDTO> reports;

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

        public List<ReportDTO> Reports
        {
            get
            {
                return reports;
            }

            set
            {
                reports = value;
            }
        }
    }
}