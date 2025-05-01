using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
using System.Threading.Tasks;
using DataLayer.Khang;

namespace BusinessLayer.Khang
{
    public class StudentsCoursesBL
    {
        private StudentsCoursesDL scDL;
        public StudentsCoursesBL()
        {
            scDL = new StudentsCoursesDL();
        }
        public DataTable getStudInCourse(string coID)
        {
            DataTable dt = new DataTable();
            try
            {
                return scDL.getStudInCourse(coID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
