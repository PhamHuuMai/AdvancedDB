using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DTO
{
    public class HDInforDTO
    {
        private int id;
        private String tenHd;
        private int idKhoa;
        private String tenKhoa;
        private DateTime ngayTL;
        private int status;

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

        public DateTime NgayTL
        {
            get
            {
                return ngayTL;
            }

            set
            {
                ngayTL = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}