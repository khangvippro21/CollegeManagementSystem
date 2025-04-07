using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class StudentTble_access:DatabaseAccess
    {
        public int NumofStudent()   
        {
            string sql = "select count(StId) as NumofStd from Students";
            return ((int)MyExecuteScalar(sql, CommandType.Text));
        }
    }
}
