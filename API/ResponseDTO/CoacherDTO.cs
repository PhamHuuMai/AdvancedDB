using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.ResponseDTO
{
    public class CoacherDTO
    {
        private int id;
        private String ten;
        private String hocHam;
        private String hocVi;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public string HocHam
        {
            get
            {
                return hocHam;
            }

            set
            {
                hocHam = value;
            }
        }

        public string HocVi
        {
            get
            {
                return hocVi;
            }

            set
            {
                hocVi = value;
            }
        }
    }
}