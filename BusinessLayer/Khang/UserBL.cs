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
            try
            {
                return userAccess.deleteuser(acc);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }


        public bool insertUser(UserAccount acc)
        {
            UserAccess userAccess = new UserAccess();
            try
            {
                return userAccess.insertuser(acc);
            }
            catch(SqlException e)
            {
                throw e;
            }
        }

        public bool changePass(UserAccount acc)
        {
            UserAccess userAccess = new UserAccess();
            try
            {
                return userAccess.changePass(acc);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
