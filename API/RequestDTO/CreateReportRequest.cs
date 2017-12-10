using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.RequestDTO
{
    public class CreateReportRequest
    {
        private int idDk;
        private String content;
        private String file;

        public int IdDk
        {
            get
            {
                return idDk;
            }

            set
            {
                idDk = value;
            }
        }

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