using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Service
{
    interface StudentService
    {
        StudentInforDTO getStudentInfo(int id);

    }
}
