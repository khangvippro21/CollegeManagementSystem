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


        public string GenerateNewUserId(string prefix)
        {
            string sql = @"
                SELECT TOP 1 UserId 
                FROM Users 
                WHERE UserId LIKE @Prefix + '[0-9][0-9][0-9]' 
                ORDER BY UserId DESC";

            string lastUserId = string.Empty;
            int newIdNumber = 1;

            SqlConnection connection = GetConnection();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Prefix", prefix);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lastUserId = reader["UserId"].ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi lấy mã người dùng cuối cùng: " + ex.Message);
            }

            if (!string.IsNullOrEmpty(lastUserId))
            {
                string lastIdNumberStr = lastUserId.Substring(prefix.Length);
                if (int.TryParse(lastIdNumberStr, out int lastIdNumber))
                {
                    newIdNumber = lastIdNumber + 1;
                }
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
            SqlConnection connection = GetConnection();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@UserPass", userPass);
                    cmd.Parameters.AddWithValue("@UserRole", userRole);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi tạo tài khoản: " + ex.Message);
            }
        }


        public bool UserExists(string userId)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE UserId = @UserId";
            SqlConnection connection = GetConnection();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi kiểm tra UserId: " + ex.Message);
            }
        }
    }

}

