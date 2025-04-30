using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TransferObject;


namespace DataLayer.Khang
{
    public class LecturersCoursesDL:DatabaseAccess
    {
        public DataTable getData(string leId) 
        {
            string sql = "SELECT C.Cid, C.CName,C.CDescription,C.CCredits, C.StartDate, C.EndDate\r\n" +
                "FROM Courses C LEFT JOIN Lecturers_Courses LC \r\nON C.Cid = LC.Cid " +
                "LEFT JOIN Lecturers L \r\nON LC.LeId = L.LeId\r\n WHERE LC.LeId = '" + leId +"';";
            DataTable dt = new DataTable();
            try
            {
                MyAdapterExecute(sql).Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable getData_AllCourses()
        {
            string sql = "SELECT C.Cid, C.CName,C.CDescription,C.CCredits, C.StartDate, " +
                "C.EndDate, L.LeName AS LecturerName\r\n" +
                "FROM Courses C LEFT JOIN Lecturers_Courses LC \r\n" +
                "ON C.Cid = LC.Cid LEFT JOIN Lecturers L \r\n" +
                "ON LC.LeId = L.LeId;";
            DataTable dt = new DataTable();
            try
            {
                MyAdapterExecute(sql).Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int enrollLecturerToCourse(LecturersCourses lc)
        {
            string sql = "INSERT INTO Lecturers_Courses (LeId, CId) " +
                "VALUES ('" + lc.LeId + "','" + lc.CId + "')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int removeLecFromCourse(string cid)
        {
            string sql = "DELETE FROM Lecturers_Courses " +
                         "WHERE CId = '" + cid + "';";
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
