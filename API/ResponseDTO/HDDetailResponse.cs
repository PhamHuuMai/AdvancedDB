using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.ResponseDTO
{
    public class HDDetailResponse
    {
        private HDInforDTO hDInfor;
        private List<HDDetailDTO> hDDetai;

        public HDInforDTO HDInfor
        {
            get
            {
                return hDInfor;
            }

            set
            {
                hDInfor = value;
            }
        }

        public List<HDDetailDTO> HDDetai
        {
            get
            {
                return hDDetai;
            }

            set
            {
                hDDetai = value;
            }
        }
    }
}