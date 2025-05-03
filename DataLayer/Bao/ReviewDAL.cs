using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Bao
{
    public class ReviewDAL:DatabaseAccess
    {
        public DataTable getReview()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM ReviewLecturers";
            MyAdapterExecute(query).Fill(dt);
            return dt;
        }
        public DataTable laythongtingv(string courseId)
        {

            string query = @"
                SELECT 
                    l.LeId,
                    l.LeName,
                    l.LeEmail,
                    l.LePhone
                FROM Courses c
                INNER JOIN Lecturers_Courses lc ON c.CId = lc.CId
                INNER JOIN Lecturers l ON lc.LeId = l.LeId
                WHERE c.CId = @CId";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@CId", courseId);

            DataTable dt = new DataTable();
            try
            {
                MyAdapterExecute(cmd).Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(@"Lỗi khi lấy thông tin giảng viên", ex);
            }
        }


        public int guidanhgia(string studentId, string lecturerId, string courseId, string comment)
        {
            

            string query = @"
        INSERT INTO ReviewLecturers (StId, LeId, CId, Comment)
        VALUES (@StId, @LeId, @CId, @Comment)";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@StId", studentId);
            cmd.Parameters.AddWithValue("@LeId", lecturerId);
            cmd.Parameters.AddWithValue("@CId", courseId);
            cmd.Parameters.AddWithValue("@Comment", comment);

            try
            {
                object result = MyExecuteScalar(cmd);
                return Convert.ToInt32(result);
            }
            catch (SqlException ex)
            {
                throw new Exception(@"Lỗi khi lưu đánh giá giảng viên", ex);
            }
        }
    }
}
