using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace DataLayer
{
    public class Attendance:DatabaseAccess
    {
        public DataTable stdAttends()
        {
            DataTable dt = new DataTable();  
            string query = @"
                    SELECT CId, COUNT(StId) AS StudentCount 
                    FROM Students_Courses 
                    GROUP BY CId";
            MyAdapterExecute(query).Fill(dt);
            return dt;
        }
    }
}
