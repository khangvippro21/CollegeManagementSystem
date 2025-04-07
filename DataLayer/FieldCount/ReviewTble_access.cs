using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.FieldCount
{
    public class ReviewTble_access:DatabaseAccess
    {
        public int NumofReview()
        {
            string sql = "select count(LeId) as NumofLecturer from Lecturers";
            return ((int)MyExecuteScalar(sql, CommandType.Text));
        }
    }
}
