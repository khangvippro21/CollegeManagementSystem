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
    }
}
