using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API.ResponseDTO;
using DatabaseEnginer.DB;
using API.Constant;

namespace API.Service.ServiceImpl
{
    public class SessionServiceImpl : SessionService
    {
        QLDT qldt = new QLDT();

        public LoginResponse login(string username, string password)
        {
            LoginResponse res = new LoginResponse();
            var query = from acc in qldt.TaiKhoans
                        where acc.TenTaiKhoan.Equals(username) && acc.MatKhau.Equals(password)
                        select acc;
            if (query.Count() == 0)
            {
                throw new Exception("Invalid account !");
            }
            else {
                TaiKhoan tk = query.First();
                if (tk.Role.Value == null)
                {
                    throw new Exception("Invalid account !");
                }
                int role = tk.Role.Value;
                if (role == UserType.ADMIN){
                    res.IdRef = -1;
                    res.Role = UserType.ADMIN;
                    res.UserName = username;
                }
                else
                {
                    res.IdRef = tk.IDRef.Value;
                    res.Role = role;
                    res.UserName = username;
                }
            }
           
            return res;
        }
    }
}