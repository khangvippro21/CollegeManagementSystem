using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class UserAccount
    {
        public string UserId { get; set; }
        public string UserPass { get; set; }   
        public string UserRole { get; set; }

        public UserAccount(string userId, string userPass, string userRole)
        {
            UserId = userId;
            UserPass = userPass;
            UserRole = userRole;
        }
        public UserAccount(string userId, string userPass)
        {
            UserId = userId;
            UserPass = userPass;
        }
        public UserAccount()
        {
        }
    }
}
