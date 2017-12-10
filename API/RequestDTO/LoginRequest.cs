using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.RequestDTO
{
    public class LoginRequest
    {
        private String userName;
        private String password;

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

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}