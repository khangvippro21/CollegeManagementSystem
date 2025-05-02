using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public  class DKKHDAL:DatabaseAccess
    {

        
        

            public DataTable laydsmonhoc(string studentId)
            {

                string query = @"
        SELECT 
            c.CId,
            c.CName AS CourseName,
            l.LeName AS LecturerName,
            c.StartDate,
            c.EndDate,
            c.CCredits,
            c.FeePerCredit,
            (c.CCredits * c.FeePerCredit) AS TotalFee
        FROM Courses c
        INNER JOIN Lecturers_Courses lc ON c.CId = lc.CId
        INNER JOIN Lecturers l ON lc.LeId = l.LeId
        WHERE c.CId NOT IN (
            SELECT sc.CId FROM Students_Courses sc WHERE sc.StId = @StId)";


            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@StId", studentId);

            DataTable dt = new DataTable();
            try
            {
                MyAdapterExecute(cmd).Fill(dt);  // MyAdapterExecute nên hỗ trợ SqlCommand
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi lấy danh sách môn học chưa đăng ký", ex);
            }
        }
            public int Dangkimonhoc(string studentId, string courseId, decimal fee)
            {
                {
                    string sql = "INSERT INTO Students_Courses (StId, CId, Fee, Mark) " +
                                 "VALUES (@StId, @CId, @Fee, 0);";

                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.AddWithValue("@StId", studentId);
                    cmd.Parameters.AddWithValue("@CId", courseId);
                    cmd.Parameters.AddWithValue("@Fee", fee);

                    try
                    {
                        return MyExecuteNonQuery(cmd);
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception($"Lỗi khi đăng ký môn học: {ex.Message}", ex);
                    }
                }
            }
            public bool kiemtratrungmon(string studentId, string courseId)
            {


                string query = @"
                SELECT COUNT(*) 
                FROM Students_Courses 
                WHERE StId = @StId AND CId = @CId";


                SqlCommand cmd = new SqlCommand(query);

                cmd.Parameters.AddWithValue("@StId", studentId);
                cmd.Parameters.AddWithValue("@CId", courseId);
                object result = MyExecuteScalar(cmd);
                int count = Convert.ToInt32(result);
                return count > 0;
            }

            public DataTable layMonHocDaDangKy(string studentId)
            {

                string query = @"
        SELECT 
            c.CId,
            c.CName AS CourseName,
            l.LeName AS LecturerName,
            c.StartDate,
            c.EndDate,
            c.CCredits,
            c.FeePerCredit,
            sc.Fee AS TotalFee
        FROM Students_Courses sc
        INNER JOIN Courses c ON sc.CId = c.CId
        INNER JOIN Lecturers_Courses lc ON c.CId = lc.CId
        INNER JOIN Lecturers l ON lc.LeId = l.LeId
        WHERE sc.StId = '" + studentId + "'";

                DataTable dt = new DataTable();
                try
                {
                    MyAdapterExecute(query).Fill(dt);
                    return dt;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }


            public int HuyDangKyMonHoc(string studentId, string courseId)
            {
                string sql = "DELETE FROM Students_Courses WHERE StId = '" + studentId + "' AND CId = '" + courseId + "';";

                try
                {
                    return MyExecuteNonQuery(sql, CommandType.Text);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
    }
