using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.RequestDTO
{
    public class HDDetailDTO
    {
        private int idGV;
        private String viTri;

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