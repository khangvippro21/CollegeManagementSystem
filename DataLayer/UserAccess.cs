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

        public bool changePass(UserAccount a)
        {
            string changePass = @"UPDATE Users
                                SET UserPass = '" + a.UserPass + "'" +
                                "WHERE UserId = '" + a.UserId + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(changePass, cn);

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

        public string GenerateNewUserId(string prefix)
        {
            string sql = @"
            SELECT TOP 1 UserId 
            FROM Users 
            WHERE UserId LIKE @Prefix + '[0-9][0-9][0-9]' 
            ORDER BY UserId DESC";

            string lastUserId = string.Empty;
            int newIdNumber = 1;

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Prefix", prefix);

            try
            {
                object result = MyExecuteScalar(cmd);
                if (result != null && result != DBNull.Value)
                {
                    lastUserId = result.ToString();
                    string lastIdNumberStr = lastUserId.Substring(prefix.Length);
                    if (int.TryParse(lastIdNumberStr, out int lastIdNumber))
                    {
                        newIdNumber = lastIdNumber + 1;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi lấy mã người dùng cuối cùng: " + ex.Message, ex);
            }

            return prefix + newIdNumber.ToString("D3");
        }

        public void CreateUser(string userId, string userPass, string userRole)
        {
            if (UserExists(userId))
            {
                throw new Exception("Tài khoản với UserId " + userId + " đã tồn tại.");
            }

            string sql = "INSERT INTO Users (UserId, UserPass, UserRole) VALUES (@UserId, @UserPass, @UserRole)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@UserId", userId);
            cmd.Parameters.AddWithValue("@UserPass", userPass);
            cmd.Parameters.AddWithValue("@UserRole", userRole);

            try
            {
                MyExecuteNonQuery(cmd);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi tạo tài khoản: " + ex.Message, ex);
            }
        }

        public bool UserExists(string userId)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@UserId", userId);

            try
            {
                object result = MyExecuteScalar(cmd);
                int count = Convert.ToInt32(result);
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi kiểm tra UserId: " + ex.Message, ex);
            }
        }

    }
}

