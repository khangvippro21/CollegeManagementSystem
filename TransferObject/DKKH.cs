using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    internal class DKKH
    {

        public string CId { get; set; }
        public string CName { get; set; }
        public string LeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Credits { get; set; }
        public decimal FeePerCredit { get; set; }
        public decimal Fee => Credits * FeePerCredit;

        public bool IsSelected { get; set; } 
    }
}
