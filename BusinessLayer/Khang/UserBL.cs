using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data.SqlClient;
using System.Security.Principal;


namespace BusinessLayer
{
    public class UserBL
    {
        public bool LoginBL(UserAccount acc)
        {
            UserAccess a = new UserAccess();
            try
            {
                return a.LoginDL(acc);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
