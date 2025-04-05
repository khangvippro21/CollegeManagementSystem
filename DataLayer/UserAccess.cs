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
            string sql = "SELECT COUNT(UserId) FROM Users WHERE UserId = '" + 
                account.UserId + "'AND UserPass = '" + account.UserPass + "'";
            try
            {
                return ((int)MyExecuteScalar(sql, CommandType.Text) > 0);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int RoleCheckDL(UserAccount acc)
        {
            string sql = "SELECT Users.UserRole FROM Users WHERE UserId = '" +
                acc.UserId + "'";
            string role = (string)MyExecuteScalar(sql,CommandType.Text);  
            if (role == "student")  return 1; 
            if (role == "lecturer") return -1;
            else return 0;
        }
    }
}
