using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.RequestDTO
{
    public class UpdateReportRequest
    {
        private String content;
        private String file;

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public string File
        {
            get
            {
                return file;
            }

            set
            {
                file = value;
            }
        }

        public bool isValid()
        {
            return file != null && !file.Trim().Equals("")  
                && content != null&& !content.Trim().Equals("");
        }
    }
}