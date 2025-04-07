using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class StudentDTO
    {
        public string StId { get; set; }
        public string StName { get; set; }
        public string StPhone { get; set; }
        public string StEmail { get; set; }
        public string StGender  { get; set; }
        public string StAddress { get; set; }
        public string Stpath { get; set; }
        public DateTime StBirth { get; set; }

        public StudentDTO (string stId, string stName, string stPhone, string stEmail, string stGender, string stAddress, string stpath, DateTime stbirth)
        {
            StId = stId;
            StName = stName;
            StPhone = stPhone;
            StEmail = stEmail;
            StGender = stGender;
            StAddress = stAddress;
            Stpath = stpath;
            StBirth = stbirth;
        }
    }
}
