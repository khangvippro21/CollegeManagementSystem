using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace DataLayer.Khang
{
    public class LecturerTble_access:DatabaseAccess
    {
        public int NumofLecturer()
        {
            string sql = "select count(LeId) as NumofLecturer from Lecturers";
            return ((int)MyExecuteScalar(sql, CommandType.Text));
        }
    }
}
