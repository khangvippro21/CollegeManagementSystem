using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer.Khang
{
    public class StudentsCoursesDL:DatabaseAccess
    {
        public DataTable getStudInCourse(string coID)
        {
            string sql = "select s.StId, s.StName, s.StGender, s.StEmail, s.StGender, s.StBirth, s.StPhone, sc.Mark\r\n" +
                "from Students s join Students_Courses sc \r\non s.StId = sc.StId join Courses c on sc.CId = c.CId\r\n" +
                "where c.CId = '" + coID +"'";
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
    }
}
