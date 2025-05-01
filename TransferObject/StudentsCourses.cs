using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class StudentsCourses
    {
        public StudentsCourses(string stId, string cId, decimal fee, decimal mark)
        {
            StId = stId;
            CId = cId;
            Fee = fee;
            Mark = mark;
        }

        public string StId { get; set; }
        public string CId { get; set; }
        public decimal Fee { get; set; }
        public decimal Mark { get; set;}
    }
}
