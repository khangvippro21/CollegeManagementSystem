using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
   public class BaocaoDTO
    {
        public string ProId { get; set; }
        public string CourseId { get; set; }
        public string StuId { get; set; }
        public string Detail { get; set; }
        public DateTime ReportedDate { get; set; }

        public BaocaoDTO(string courseId, string stuId, string detail)
        {
            ProId = null;
            CourseId = courseId;
            StuId = stuId;
            Detail = detail;
            ReportedDate = DateTime.Now;
        }

        public BaocaoDTO(string proId, string courseId, string stuId, string detail, DateTime reportedDate)
        {
            ProId = proId;
            CourseId = courseId;
            StuId = stuId;
            Detail = detail;
            ReportedDate = reportedDate;
        }
    }
}
