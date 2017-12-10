using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.ResponseDTO
{
    public class LoginResponse
    {
        private String userName;
        private int role;
        private String token;
        private int idRef;

        public int IdRef
        {
            get
            {
                return idRef;
            }

            set
            {
                idRef = value;
            }
        }

        public string Token
        {
            get
            {
                return token;
            }

            set
            {
                token = value;
            }
        }

        public int Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }
    }
}