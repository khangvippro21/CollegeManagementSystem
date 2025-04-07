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
    public class UserAccess : DatabaseAccess
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
            string role = (string)MyExecuteScalar(sql, CommandType.Text);
            if (role == "student") return 1;
            if (role == "lecturer") return -1;
            else return 0;
        }



        public string GenerateNewUserId(string prefix)
        {
            string sql = "SELECT TOP 1 UserId FROM Users WHERE UserId LIKE @Prefix + '[0-9][0-9][0-9]' ORDER BY UserId DESC";
            string lastUserId = string.Empty;
            int newIdNumber = 1;

            try
            {
                Connect();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
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
            finally
            {
                DisConnect();
            }

            if (!string.IsNullOrEmpty(lastUserId))
            {
                string lastIdNumberStr = lastUserId.Substring(1);
                int lastIdNumber = int.Parse(lastIdNumberStr);
                newIdNumber = lastIdNumber + 1;
            }

            return prefix + newIdNumber.ToString("D3");
        }


        public void CreateUser(string userId, string userPass, string userRole)
        {
            if (UserExists(userId))
            {
                throw new Exception("Tài khoản với UserId " + userId + " đã tồn tại.");
            }

            string sql = "INSERT INTO Users (UserId, UserPass, UserRole) " +
                         "VALUES (@UserId, @UserPass, @UserRole)";

            try
            {
                Connect();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
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
            finally
            {
                DisConnect();
            }

        }

        public bool UserExists(string userId)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE UserId = @UserId";
            try
            {
                Connect();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
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
            finally
            {
                DisConnect();
            }
        }

    }
}
