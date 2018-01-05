using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.RequestDTO
{
    public class HdRequest
    {
        private HdDTO hdInfor;
        private List<HDDetailDTO> hdDetail;

        public HdDTO HdInfor
        {
            get
            {
                return hdInfor;
            }

            set
            {
                hdInfor = value;
            }
        }

        public List<HDDetailDTO> HdDetail
        {
            get
            {
                return hdDetail;
            }

            set
            {
                hdDetail = value;
            }
        }

        public bool isInvalid()
        {
            return this.HdInfor == null || this.HdDetail == null;
        }
    }
}