using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DTO
{
    public class TopicRegisterDTO
    {
        private int id;
        private int idDeTai;
        private String tenDeTai;
        private String idSinhVien;
        private String tenSinhVien;
        private int lanDangKy;
        private DateTime ngayDangKy;

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

        public int IdDeTai
        {
            get
            {
                return idDeTai;
            }

            set
            {
                idDeTai = value;
            }
        }

        public string TenDeTai
        {
            get
            {
                return tenDeTai;
            }

            set
            {
                tenDeTai = value;
            }
        }

        public string IdSinhVien
        {
            get
            {
                return idSinhVien;
            }

            set
            {
                idSinhVien = value;
            }
        }

        public string TenSinhVien
        {
            get
            {
                return tenSinhVien;
            }

            set
            {
                tenSinhVien = value;
            }
        }

        public int LanDangKy
        {
            get
            {
                return lanDangKy;
            }

            set
            {
                lanDangKy = value;
            }
        }

        public DateTime NgayDangKy
        {
            get
            {
                return ngayDangKy;
            }

            set
            {
                ngayDangKy = value;
            }
        }
    }
}