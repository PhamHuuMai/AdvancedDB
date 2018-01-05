using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DTO
{
    public class KhoaDTO
    {
        private int maKhoa;
        private String tenKhoa;

        public int MaKhoa
        {
            get
            {
                return maKhoa;
            }

            set
            {
                maKhoa = value;
            }
        }

        public string TenKhoa
        {
            get
            {
                return tenKhoa;
            }

            set
            {
                tenKhoa = value;
            }
        }
    }
}