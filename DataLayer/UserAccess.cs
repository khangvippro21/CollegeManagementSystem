using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.IO;
namespace DataLayer
{
    public class UserAccess : DatabaseAccess
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
                if (exist > 0)
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
        public DataTable userTble_Dal()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Users";
            MyAdapterExecute(query).Fill(dt);
            return dt;
        }

        public bool deleteuser(UserAccount a)
        {
            string sql = "Delete from Users where UserId = '" + a.UserId + "'";
            string checkuser = "SELECT COUNT(UserId) FROM Users WHERE UserId = '" +
                a + "'AND UserPass = '" + a.UserPass + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                MyExecuteNonQuery(cmd);

                int exist = (int)MyExecuteScalar(checkuser, CommandType.Text);
                return (exist > 0);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool insertuser(UserAccount a)
        {
            string insertUs = "INSERT INTO Users (UserId, UserPass, UserRole) VALUES ('" + a.UserId + "','" + a.UserPass + "','Admin')";
            string checkuser = "SELECT COUNT(UserId) FROM Users WHERE UserId = '" + a.UserId + "'";

            int exist = (int)MyExecuteScalar(checkuser, CommandType.Text);
            if (exist > 0)
            {
                return false;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(insertUs, cn);

                if (MyExecuteNonQuery(cmd) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }



        }

    }
}
