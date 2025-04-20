using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;
using System.Linq.Expressions;

namespace DataLayer
{
    public class getGiangVien : DatabaseAccess
    {

        public string GetLastLecturerId()
        {
            string sql = "SELECT TOP 1 LeId FROM Lecturers ORDER BY LeId DESC";
            string lastLecturerId = string.Empty;
            SqlConnection connection = cn;
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lastLecturerId = reader["LeId"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy mã giảng viên cuối cùng: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return lastLecturerId;
        }
        public bool UpdateLecturer(GiangVien giangvien)
        {
            string sql = @"Update Lecturers SET 
                            LeName= @LeName,  
                            LePhone=@LePhone, 
                            LeEmail=@LeEmail, 
                            LeGender=@LeGender, 
                            LeAddress=@LeAddress, 
                            LePath=@LePath, 
                            LeBirth=@LeBirth
                            WHERE LeId=@LeId";
            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@LeName", giangvien.LeName);
                cmd.Parameters.AddWithValue("@LePhone", giangvien.LePhone);
                cmd.Parameters.AddWithValue("@LeEmail", giangvien.LeEmail);
                cmd.Parameters.AddWithValue("@LeGender", giangvien.LeGender);
                cmd.Parameters.AddWithValue("@LeAddress", giangvien.LeAddress);
                cmd.Parameters.AddWithValue("@LePath", giangvien.LePath);
                cmd.Parameters.AddWithValue("@LeBirth", giangvien.LeBirth);
                cmd.Parameters.AddWithValue("@LeId", giangvien.LeId);
                return MyExecuteNonQuery(cmd) > 0;
    
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi chỉnh sửa thông tin giảng viên: " + ex.Message);
            }
           
        }

        public void InsertLecturer(GiangVien giangvien)
        {
            string sql = "INSERT INTO Lecturers (LeId,LeName, LePhone, LeEmail, LeGender, LeAddress, LePath, LeBirth) " +
                         "VALUES (@LeId,@LeName, @LePhone, @LeEmail, @LeGender, @LeAddress, @LePath, @LeBirth)";
            SqlConnection connection = cn;
            SqlCommand cmd = null;

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@LeId", giangvien.LeId);
                cmd.Parameters.AddWithValue("@LeName", giangvien.LeName);
                cmd.Parameters.AddWithValue("@LePhone", giangvien.LePhone);
                cmd.Parameters.AddWithValue("@LeEmail", giangvien.LeEmail);
                cmd.Parameters.AddWithValue("@LeGender", giangvien.LeGender);
                cmd.Parameters.AddWithValue("@LeAddress", giangvien.LeAddress);
                cmd.Parameters.AddWithValue("@LePath", giangvien.LePath);
                cmd.Parameters.AddWithValue("@LeBirth", giangvien.LeBirth);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Thêm giảng viên thành công.");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm giảng viên: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) ;
                connection.Close();
            }

        }
        public DataTable lecTable()
        {
            string sql = "Select * from Lecturers";
            DataTable dt = new DataTable();
            MyAdapterExecute(sql).Fill(dt);
            return dt;
        }
        public DataTable SearchLecturer(string keyword)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Lecturers WHERE LeName LIKE @keyword";

            try
            {
                Connect();

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm giảng viên: " + ex.Message);
            }
            finally
            {
                DisConnect();
            }
            return dt;
        }
        public void DeleteLecturer(string LeId)
        {
            string sql = "DELETE FROM Lecturers WHERE LeId = @LeId";
            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@LeId", LeId);
                MyExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa giảng viên: " + ex.Message);
            }
        }
        public void UpdateGiangVien(GiangVien giangvien)
        {
            int rows;
            string sql = @"UPDATE Lecturers SET
                            LeName = @LeName, 
                            LePhone = @LePhone, 
                            LeEmail = @LeEmail, 
                            LeGender = @LeGender,
                            LeAddress=@LeAddress,
                            LeBirth=@LeBirth,
                            LePath=@LePath
                            WHERE LeId = @LeId";
            SqlConnection connection = cn;
            SqlCommand cmd = null;

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@LeId", giangvien.LeId);  
                cmd.Parameters.AddWithValue("@LeName", giangvien.LeName);
                cmd.Parameters.AddWithValue("@LePhone", giangvien.LePhone);
                cmd.Parameters.AddWithValue("@LeEmail", giangvien.LeEmail);
                cmd.Parameters.AddWithValue("@LeGender", giangvien.LeGender);
                cmd.Parameters.AddWithValue("@LeAddress", giangvien.LeAddress);
                cmd.Parameters.AddWithValue("@LePath", giangvien.LePath);
                cmd.Parameters.AddWithValue("@LeBirth", giangvien.LeBirth);

                rows=MyExecuteNonQuery(cmd);
                if (rows > 0)
                {
                    Console.WriteLine("Chỉnh sửa thông tin giảng viên thành công.");
                }
                else
                {
                    Console.WriteLine("Không có giảng viên nào được chỉnh sửa.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi chỉnh sửa thông tin giảng viên: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) ;
                connection.Close();
            }

        }
    }
}
