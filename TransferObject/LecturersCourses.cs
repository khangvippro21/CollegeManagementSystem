using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class LecturersCourses
    {
        public string LeId {  get; set; }
        public string CId { get; set; }
        public LecturersCourses(string leid, string cid)
        {
            LeId = leid;
            CId = cid;
        }
    }
}
