using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.RequestDTO
{
    public class MarkPointRequest
    {
        private int idReport;
        private int point;

        public int IdReport
        {
            get
            {
                return idReport;
            }

            set
            {
                idReport = value;
            }
        }

        public int Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }
    }
}