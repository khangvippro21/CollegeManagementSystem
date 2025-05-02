using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;


namespace DataLayer
{
    public class BaocaoDAL:DatabaseAccess
    {
        public DataTable dsmonhocdadk(string studentId)
        {


            string query = @"
                SELECT 
                    c.CId,
                    c.CName AS CourseName
                FROM Students_Courses sc
                INNER JOIN Courses c ON sc.CId = c.CId
                WHERE sc.StId = @StId";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@StId", studentId);

            DataTable dt = new DataTable();
            try
            {
                MyAdapterExecute(cmd).Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool kiemtramonhoc(string studentId, string courseId)
        {


            string query = @"
                SELECT COUNT(*) 
                FROM Students_Courses 
                WHERE StId = @StId AND CId = @CId";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@StId", studentId);
            cmd.Parameters.AddWithValue("@CId", courseId);

            try
            {
                object result = MyExecuteScalar(cmd);
                int count = Convert.ToInt32(result);
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Lỗi khi kiểm tra môn học đã đăng ký: {ex.Message}", ex);
            }
        }

        public string taobaocao(string studentId, string courseId, string detail)
        {



            string getMaxIdQuery = "SELECT MAX(ProId) FROM Problems";
            string maxId = null;
            try
            {
                object result = MyExecuteScalar(getMaxIdQuery, CommandType.Text);
                if (result != null && result != DBNull.Value)
                {
                    maxId = result.ToString();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(@"Lỗi khi lấy ProId lớn nhất: {ex.Message}", ex);
            }

            
            string proId;
            if (string.IsNullOrEmpty(maxId) || !maxId.StartsWith("P"))
            {
                proId = "P001"; 
            }
            else
            {
                int currentNumber = int.Parse(maxId.Substring(1)); 
                proId = $"P{(currentNumber + 1):D3}"; 
            }

         
            string insertQuery = @"
                INSERT INTO Problems (ProId, CourseId, StuId, Detail, ReportedDate)
                VALUES (@ProId, @CourseId, @StuId, @Detail, GETDATE())";

            SqlCommand cmd = new SqlCommand(insertQuery);
            cmd.Parameters.AddWithValue("@ProId", proId);
            cmd.Parameters.AddWithValue("@CourseId", courseId);
            cmd.Parameters.AddWithValue("@StuId", studentId);
            cmd.Parameters.AddWithValue("@Detail", detail);

            try
            {
                MyExecuteNonQuery(cmd);
                return proId;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Lỗi khi lưu báo cáo sự cố: {ex.Message}", ex);
            }
        }




    }
}
