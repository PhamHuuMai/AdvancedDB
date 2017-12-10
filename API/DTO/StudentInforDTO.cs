using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DTO
{
    public class StudentInforDTO
    {
        private int id;
        private String ten;
        private String tenLop;
        private String tenKhoa;
        private int maKhoa;
        private int maChuyenNganh;
        private String tenChuyenNganh;

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

        public string TenLop
        {
            get
            {
                return tenLop;
            }

            set
            {
                tenLop = value;
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

        public int MaChuyenNganh
        {
            get
            {
                return maChuyenNganh;
            }

            set
            {
                maChuyenNganh = value;
            }
        }

        public string TenChuyenNganh
        {
            get
            {
                return tenChuyenNganh;
            }

            set
            {
                tenChuyenNganh = value;
            }
        }
    }
}