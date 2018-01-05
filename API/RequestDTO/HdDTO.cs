using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.RequestDTO
{
    public class HdDTO
    {
        private int id;
        private String tenHd;
        private int idKhoa;

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

        public string TenHd
        {
            get
            {
                return tenHd;
            }

            set
            {
                tenHd = value;
            }
        }

        public int IdKhoa
        {
            get
            {
                return idKhoa;
            }

            set
            {
                idKhoa = value;
            }
        }
    }
}