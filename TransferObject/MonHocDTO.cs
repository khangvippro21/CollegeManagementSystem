using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class MonHocDTO
    {
            public string CId { get; set; }
            public string CName { get; set; }
            public string CDescription { get; set; }
            public int CCredits { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }

        public MonHocDTO(string cId, string cName, string cDescription, int cCredits, DateTime startDate, DateTime endDate)
        {
            CId = cId;
            CName = cName;
            CDescription = cDescription;
            CCredits = cCredits;
            StartDate = startDate;
            EndDate = endDate;
        }
        public MonHocDTO() 
        { }
    }
}
