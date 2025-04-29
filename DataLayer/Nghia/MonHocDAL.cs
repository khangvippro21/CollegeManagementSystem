using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;
using System.Linq.Expressions;
using System.Collections;


namespace DataLayer
{
    public class MonHocDAL : DatabaseAccess
    {
        public DataTable MonHocTable()
        {
            string sql = "Select * from Courses";
            DataTable dt = new DataTable();
            MyAdapterExecute(sql).Fill(dt);
            return dt;
        }
        public DataTable SearchMH(string keyword)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Courses WHERE CName LIKE @keyword";

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
                throw new Exception("Lỗi khi tìm kiếm môn học: " + ex.Message);
            }
            finally
            {
                DisConnect();
            }
            return dt;
        }
        public void DeleteMH(string CId)
        {
            string sql = "DELETE FROM Courses WHERE CId = @CId";
            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@CId", CId);
                MyExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa môn học: " + ex.Message);
            }
        }
        public void InsertMH(MonHocDTO monHoc)
        {
            string sql = "INSERT INTO Courses (CId, CName, CDescription, CCredits, StartDate, EndDate, Fee, FeePerCredit) " +
                         "VALUES (@CId,@CName, @CDescription, @CCredits, @StartDate, @EndDate, @Fee, @FeePerCredit)";
            SqlConnection connection = cn;
            SqlCommand cmd = null;

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@CId", monHoc.CId);
                cmd.Parameters.AddWithValue("@CName", monHoc.CName);
                cmd.Parameters.AddWithValue("@CDescription", monHoc.CDescription);
                cmd.Parameters.AddWithValue("@CCredits", monHoc.CCredits);
                cmd.Parameters.AddWithValue("@StartDate", monHoc.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", monHoc.EndDate);
                cmd.Parameters.AddWithValue("@Fee", monHoc.Fee);
                cmd.Parameters.AddWithValue("@FeePerCredit", monHoc.FeePerCredit);


                cmd.ExecuteNonQuery();
                Console.WriteLine("Thêm môn học thành công.");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm môn học: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) ;
                connection.Close();
            }

        }
        public void UpdateCourse(MonHocDTO course)
        {
            int rows;
            string sql = @"UPDATE Courses SET
                            CId=@CId,
                            CName = @CName, 
                            CDescription = @CDescription, 
                            CCredits = @CCredits, 
                            StartDate = @StartDate, 
                            EndDate = @EndDate,
                            Fee=@Fee,
                            FeePerCredit=@FeePerCredit
                            WHERE CId = @CId";
            SqlConnection connection = cn;
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cmd.Parameters.AddWithValue("@CId", course.CId);
                cmd.Parameters.AddWithValue("@CName", course.CName);
                cmd.Parameters.AddWithValue("@CDescription", course.CDescription);
                cmd.Parameters.AddWithValue("@CCredits", course.CCredits);
                cmd.Parameters.AddWithValue("@StartDate", course.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", course.EndDate);
                cmd.Parameters.AddWithValue("@Fee", course.Fee);
                cmd.Parameters.AddWithValue("@FeePerCredit", course.FeePerCredit);


                rows = MyExecuteNonQuery(cmd);
                if (rows > 0)
                {
                    Console.WriteLine("Chỉnh sửa môn học thành công.");
                }
                else
                {
                    Console.WriteLine("Không có môn học nào được chỉnh sửa.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi chỉnh sửa môn học" + ex.Message);
            }
            finally
            {
                DisConnect();
            }
        }
    }
}
