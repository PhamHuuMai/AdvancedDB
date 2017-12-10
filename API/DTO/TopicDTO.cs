using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DTO
{
    public class TopicDTO
    {
        private int id;
        private int idDeTai;
        private String tenDT;
        private String moTa;
        private String noiDung;
        private int doKho;
        private int idGV;
        private String tenGV;

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

        public string TenDT
        {
            get
            {
                return tenDT;
            }

            set
            {
                tenDT = value;
            }
        }

        public string MoTa
        {
            get
            {
                return moTa;
            }

            set
            {
                moTa = value;
            }
        }

        public string NoiDung
        {
            get
            {
                return noiDung;
            }

            set
            {
                noiDung = value;
            }
        }

        public int DoKho
        {
            get
            {
                return doKho;
            }

            set
            {
                doKho = value;
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
    }
}