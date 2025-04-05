using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class UserAccess:DatabaseAccess
    {
        public bool LoginDL(UserAccount account) 
        {
            string checkuser = "SELECT COUNT(UserId) FROM Users WHERE UserId = '" + 
                account.UserId + "'AND UserPass = '" + account.UserPass + "'";
            string checkRole = "SELECT Users.UserRole FROM Users WHERE UserId = '" +
                account.UserId + "'";
            try
            {
                int exist = (int)MyExecuteScalar(checkuser, CommandType.Text);
                if(exist > 0)
                {
                    account.UserRole = (string)MyExecuteScalar(checkRole, CommandType.Text);
                }
                return (exist > 0);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
