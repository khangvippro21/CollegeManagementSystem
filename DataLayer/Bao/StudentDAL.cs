using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;
using System.Collections;

namespace DataLayer
{
    public class StudentDAL : DatabaseAccess
    {
        public DataTable getallstd()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Students";
            MyAdapterExecute(query).Fill(dt);
            return dt;
        }

        public DataTable SearchStudent(string keyword)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Students WHERE StName LIKE @keyword OR StId LIKE @keyword";

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
                throw new Exception("Lỗi khi tìm kiếm học viên: " + ex.Message);
            }
            finally
            {
                DisConnect();
            }
            return dt;
        }

        public string GetLastStudentId()
        {
            string sql = "SELECT TOP 1 StId FROM Students ORDER BY StId DESC";
            string lastStudentId = string.Empty;


            try
            {
                Connect();


                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lastStudentId = reader["StId"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy mã học viên cuối cùng: " + ex.Message);
            }
            finally
            {
                DisConnect();
            }

            return lastStudentId;
        }

        public int InsertStudent(StudentDTO student)
        {
            string sql = "INSERT INTO Students (StId,StName, StPhone, StEmail, StGender, StAddress, StPath, StBirth, StQRCodePath) " +
                         "VALUES (@StId,@StName, @StPhone, @StEmail, @StGender, @StAddress, @StPath, @StBirth, @StQRCodePath)";

            try
            {
                //Connect();

                SqlCommand cmd = new SqlCommand(sql);
               
                cmd.Parameters.AddWithValue("@StId", student.StId);
                cmd.Parameters.AddWithValue("@StName", student.StName);
                cmd.Parameters.AddWithValue("@StPhone", student.StPhone);
                cmd.Parameters.AddWithValue("@StEmail", student.StEmail);
                cmd.Parameters.AddWithValue("@StGender", student.StGender);
                cmd.Parameters.AddWithValue("@StAddress", student.StAddress);
                cmd.Parameters.AddWithValue("@StPath", student.Stpath);
                cmd.Parameters.AddWithValue("@StBirth", student.StBirth);
                cmd.Parameters.AddWithValue("@StQRCodePath", student.StQRCodePath);    

                int rows = MyExecuteNonQuery(cmd);
                
                if (rows > 0)
                {
                    Console.WriteLine("Thêm học viên thành công.");
                }
                else
                {
                    Console.WriteLine("Không có học viên nào được thêm.");
                }
                return rows;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm học viên: " + ex.Message);
            }
            finally
            {
                DisConnect();
            }
        }


        public int DeleteStudent(string studentId)
        {
            string sql = "DELETE FROM Students WHERE StId = @StId";
            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@StId", studentId);
                int rowsAffected = MyExecuteNonQuery(cmd);
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa học viên: " + ex.Message);
            }
        }

        public int UpdateStudent(StudentDTO student)
        {
            string sql = @"UPDATE Students 
                   SET StName = @StName,
                       StPhone = @StPhone,
                       StEmail = @StEmail,
                       StGender = @StGender,
                       StAddress = @StAddress,
                       StPath = @StPath,
                       StBirth = @StBirth
                   WHERE StId = @StId"; 

            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@StName", student.StName);
                cmd.Parameters.AddWithValue("@StPhone", student.StPhone);
                cmd.Parameters.AddWithValue("@StEmail", student.StEmail);
                cmd.Parameters.AddWithValue("@StGender", student.StGender);
                cmd.Parameters.AddWithValue("@StAddress", student.StAddress);
                cmd.Parameters.AddWithValue("@StPath", student.Stpath);
                cmd.Parameters.AddWithValue("@StBirth", student.StBirth);
                cmd.Parameters.AddWithValue("@StId", student.StId);

                int rowsAffected = MyExecuteNonQuery(cmd); 
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật học viên: " + ex.Message);
            }
        }

    }
}

