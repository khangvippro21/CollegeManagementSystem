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
            
            public int Fee { get; set; }
            public int FeePerCredit { get; set; }

        public MonHocDTO(string cId, string cName, string cDescription, int cCredits, DateTime startDate, DateTime endDate, int fee, int feePerCredit)
        {
            CId = cId;
            CName = cName;
            CDescription = cDescription;
            CCredits = cCredits;
            StartDate = startDate;
            EndDate = endDate;
            Fee = fee;
            FeePerCredit = feePerCredit;
        }
        public MonHocDTO() 
        { }
    }
}
