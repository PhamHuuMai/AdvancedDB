using API.DTO;
using API.ResponseDTO;
using DatabaseEnginer.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Service
{
    interface CoacherService
    {
        int getFalcultuOfCoacher(int idGv);

        List<TopicRegisterDTO> getOldTopicRegisterByGV(int idGv);

        List<TopicRegisterDTO> getCurentTopicRegisterByGV(int idGv);

        List<CoacherDTO> getCoacherByFal(int idKhoa);

    }

}
