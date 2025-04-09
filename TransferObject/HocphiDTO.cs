using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
   public class HocphiDTO
    {
            public string StudentName { get; set; }
            public string CourseName { get; set; }
            public decimal Fee { get; set; }

            public HocphiDTO(string studentName, string courseName, decimal fee)
            {
                StudentName = studentName;
                CourseName = courseName;
                Fee = fee;
            }
    }
}
