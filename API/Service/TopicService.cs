using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Service.Service
{
    interface TopicService
    {
        List<TopicDTO> getClassTopicCurent(int idCn);
        List<TopicDTO> getAllTopicByFaculty(int idKhoa);
        List<TopicDTO> getAllTopicByCoacher(int idGv);
        TopicDTO getClassTopicCurentSv(int idsv);
        void registerTopic(int idSv, int idLopHd);
        List<ReportDTO> getReport(int idDk);
        void addReport(int idSv, int idDk, String content, String file);
        void removeReport(int idReport);
        void updateReport(int idReport, String content, String file);
    }
}
