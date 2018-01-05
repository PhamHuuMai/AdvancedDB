using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.RequestDTO
{
    public class TopicRequest
    {
        private String tenDT;
        private string mota;
        private String noiDung;
        private int doKho;

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

        public string Mota
        {
            get
            {
                return mota;
            }

            set
            {
                mota = value;
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
    }
}