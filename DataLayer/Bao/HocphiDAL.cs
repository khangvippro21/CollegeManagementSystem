using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataLayer
{
    public class HocphiDAL : DatabaseAccess
    {

        public DataTable GetTotalFeeByCourse()
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            c.CName AS CourseName,
            SUM(sc.Fee) AS TotalFee
        FROM Courses c
        JOIN Students_Courses sc ON c.CId = sc.CId
        GROUP BY c.CName";
            MyAdapterExecute(query).Fill(dt);
            return dt;
        }

        public DataTable gethocphi()
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                s.StName,
                c.CName,
                sc.Fee
            FROM Students s
            JOIN Students_Courses sc ON s.StId = sc.StId
            JOIN Courses c ON sc.CId = c.CId";
            MyAdapterExecute(query).Fill(dt);
            return dt;
        }

        public decimal tonghpsinhvien(string studentId)
        {

            string query = @"
                SELECT 
                    SUM(sc.Fee) AS TotalFee
                FROM Students s
                JOIN Students_Courses sc ON s.StId = sc.StId
                JOIN Courses c ON sc.CId = c.CId
                WHERE s.StId = @StId";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@StId", studentId);

            object result = MyExecuteScalar(cmd);
            return Convert.ToDecimal(result);
        }
    }
}
