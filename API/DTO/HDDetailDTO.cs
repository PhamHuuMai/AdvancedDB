using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DTO
{
    public class HDDetailDTO
    {
        private int idHd;
        private int idGV;
        private String tenGV;
        private String viTri;

        public int IdHd
        {
            get
            {
                return idHd;
            }

            set
            {
                idHd = value;
            }
        }

        public int IdGV
        {
            get
            {
                return idGV;
            }

            set
            {
                idGV = value;
            }
        }

        public string TenGV
        {
            get
            {
                return tenGV;
            }

            set
            {
                tenGV = value;
            }
        }

        public string ViTri
        {
            get
            {
                return viTri;
            }

            set
            {
                viTri = value;
            }
        }
    }
}