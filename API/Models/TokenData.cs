using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class TokenData
    {
        private int userId;
        private int role;

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

        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }
    }
}