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

namespace DataLayer
{
    public class StudentDAL : DatabaseAccess
    {

        public List<StudentDTO> GetAllStudents()
        {
            List<StudentDTO> list = new List<StudentDTO>();
            string sql = "SELECT * FROM Students";

            SqlConnection connection = GetConnection();

            try
            {

                if (connection.State != ConnectionState.Open)
                    connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    StudentDTO student = new StudentDTO(
                        reader["StId"].ToString(),
                        reader["StName"].ToString(),
                        reader["StPhone"].ToString(),
                        reader["StEmail"].ToString(),
                        reader["StGender"].ToString(),
                        reader["StAddress"].ToString(),
                        reader["Stpath"].ToString(),
                        Convert.ToDateTime(reader["StBirth"])
                    );
                    list.Add(student);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu: " + ex.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return list;

        }


        public List<StudentDTO> SearchStudent(string keyword)
        {
            List<StudentDTO> kq = new List<StudentDTO>();
            string sql = "select *from Students where StName like @keyword ";
            SqlConnection connection = GetConnection();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    StudentDTO student = new StudentDTO(
                        reader["StId"].ToString(),
                        reader["StName"].ToString(),
                        reader["StPhone"].ToString(),
                        reader["StEmail"].ToString(),
                        reader["StGender"].ToString(),
                        reader["StAddress"].ToString(),
                        reader["StPath"].ToString(),
                        Convert.ToDateTime(reader["StBirth"])
                    );
                    kq.Add(student);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm học viên: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return kq;
        }

        public string GetLastStudentId()
        {
            string sql = "SELECT TOP 1 StId FROM Students ORDER BY StId DESC";
            string lastStudentId = string.Empty;


            SqlConnection connection = GetConnection();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();


                SqlCommand cmd = new SqlCommand(sql, connection);
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
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return lastStudentId;
        }

        public void InsertStudent(StudentDTO student)
        {
            string sql = "INSERT INTO Students (StId,StName, StPhone, StEmail, StGender, StAddress, StPath, StBirth) " +
                         "VALUES (@StId,@StName, @StPhone, @StEmail, @StGender, @StAddress, @StPath, @StBirth)";
            SqlConnection connection = GetConnection();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);
               
                cmd.Parameters.AddWithValue("@StId", student.StId);
                cmd.Parameters.AddWithValue("@StName", student.StName);
                cmd.Parameters.AddWithValue("@StPhone", student.StPhone);
                cmd.Parameters.AddWithValue("@StEmail", student.StEmail);
                cmd.Parameters.AddWithValue("@StGender", student.StGender);
                cmd.Parameters.AddWithValue("@StAddress", student.StAddress);
                cmd.Parameters.AddWithValue("@StPath", student.Stpath);
                cmd.Parameters.AddWithValue("@StBirth", student.StBirth);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Thêm học viên thành công.");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm học viên: " + ex.Message);
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

    }
}

