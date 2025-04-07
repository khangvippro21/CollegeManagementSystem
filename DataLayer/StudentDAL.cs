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
           
                try
                {
                Connect();

                SqlCommand cmd = new SqlCommand(sql, cn);
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
                    DisConnect();
                }
                return list;
            
        }


        public List<StudentDTO> SearchStudent(string keyword)
        {
            List <StudentDTO> kq = new List<StudentDTO>();
           
            string sql = "select *from Students where StName like @keyword ";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            try
            {
                Connect();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    StudentDTO student = new StudentDTO(
                        dataReader["StId"].ToString(),
                        dataReader["StName"].ToString(),
                        dataReader["StPhone"].ToString(),
                        dataReader["StEmail"].ToString(),
                        dataReader["StGender"].ToString(),
                        dataReader["StAddress"].ToString(),
                        dataReader["StPath"].ToString(),
                        Convert.ToDateTime(dataReader["StBirth"])
                    );
                    kq.Add(student);
                }
                dataReader.Close();
            }

            finally
            {
                DisConnect();
            }
            return kq;
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
            
            return lastStudentId;
        }

        public void InsertStudent(StudentDTO student)
        {
            string sql = "INSERT INTO Students (StId,StName, StPhone, StEmail, StGender, StAddress, StPath, StBirth) " +
                         "VALUES (@StId,@StName, @StPhone, @StEmail, @StGender, @StAddress, @StPath, @StBirth)";
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                Connect();
                cmd = new SqlCommand(sql, cn);
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
                DisConnect();
            }

        }

    }
}

