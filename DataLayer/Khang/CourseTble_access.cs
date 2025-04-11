using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace DataLayer.Khang
{
    public class CourseTble_access:DatabaseAccess
    {
        public int NumofCourse()
        {
            string sql = "select count(CId) as NumofCourse from Courses";
            return ((int)MyExecuteScalar(sql, CommandType.Text));
        }
    }
}
