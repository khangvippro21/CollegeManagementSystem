using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class GiangVien
    {
        public string LeId { get; set; }
        public string LeName { get; set; }
        public string LePhone { get; set; }
        public string LeEmail { get; set; }
        public string LeGender { get; set; }
        public string LeAddress { get; set; }
        public string LePath { get; set; }
        public DateTime LeBirth { get; set; }
        public string LeQRCodePath {  get; set; }

        public GiangVien(string leId, string leName, string lePhone, string leEmail, string leGender, string leAddress, string lePath, DateTime leBirth, string leQRCodePath)
        {
            LeId = leId;
            LeName = leName;
            LePhone = lePhone;
            LeEmail = leEmail;
            LeGender = leGender;
            LeAddress = leAddress;
            LePath = lePath;
            LeBirth = leBirth;
            LeQRCodePath = leQRCodePath;
        }
        public GiangVien(string leId, string leName, string lePhone, string leEmail, string leGender, string leAddress, string lePath, DateTime leBirth)
        {
            LeId = leId;
            LeName = leName;
            LePhone = lePhone;
            LeEmail = leEmail;
            LeGender = leGender;
            LeAddress = leAddress;
            LePath = lePath;
            LeBirth = leBirth;
        }
        public GiangVien() { }
    }

}
   