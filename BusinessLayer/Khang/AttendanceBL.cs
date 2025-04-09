using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AttendanceBL
    {
        Attendance a = new Attendance();
        public DataTable getData()
        {
            return a.stdAttends();
        }
    }
}
