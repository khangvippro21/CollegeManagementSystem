using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data.SqlClient;
using System.Security.Principal;
using System.Data;


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
        public DataTable viewUserTble()
        {
            UserAccess a =new UserAccess(); 
            try
            {
                return a.userTble_Dal();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public bool deleteUser(UserAccount acc)
        {
            UserAccess userAccess = new UserAccess();
            return userAccess.deleteuser(acc);
        }

        public bool insertUser(UserAccount acc)
        {
            try
            {
                UserAccess userAccess = new UserAccess();
                return userAccess.insertuser(acc);
            }
            catch(SqlException e)
            {
                throw e;
            }
        }
    }
}
