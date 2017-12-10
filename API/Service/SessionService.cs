using API.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Service
{
    interface SessionService
    {
        LoginResponse login(String username, String password);
    }
}
