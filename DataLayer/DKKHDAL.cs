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

        public DataTable laydsmonhoc()
        {
            DataTable dt = new DataTable();
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
        INNER JOIN Lecturers l ON lc.LeId = l.LeId";

            MyAdapterExecute(query).Fill(dt);
            return dt;
        }
        public bool Dangkimonhoc(string studentId, string courseId, decimal fee)
        {
            string query = @"
        INSERT INTO Students_Courses (StId, CId, Fee, Mark)
        VALUES (@StId, @CId, @Fee, 0)"; 

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@StId", studentId);
            cmd.Parameters.AddWithValue("@CId", courseId);
            cmd.Parameters.AddWithValue("@Fee", fee);

             return MyExecuteNonQuery(cmd) >0; 
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

            return MyExecuteNonQuery(cmd) > 0;
        }
    }
}
