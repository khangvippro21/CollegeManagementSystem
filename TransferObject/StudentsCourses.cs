using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class StudentsCourses
    {
        public StudentsCourses(string stId, string cId, string fee, string mark)
        {
            StId = stId;
            CId = cId;
            Fee = fee;
            Mark = mark;
        }

        public string StId { get; set; }
        public string CId { get; set; }
        public string Fee { get; set; }
        public string Mark { get; set;}
    }
}
