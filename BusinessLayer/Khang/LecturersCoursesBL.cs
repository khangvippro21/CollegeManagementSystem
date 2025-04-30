using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;
using System.Data;
using System.Data.SqlClient;
using DataLayer.Khang;


namespace BusinessLayer.Khang
{
    public class LecturersCoursesBL
    {
        private LecturersCoursesDL lcDL;
        public LecturersCoursesBL()
        {
            lcDL = new LecturersCoursesDL();
        }
        public DataTable getData(string leId)
        {
            DataTable dt = new DataTable();
            try
            {
                return lcDL.getData(leId);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable getData_AllCourses()
        {
            DataTable dt = new DataTable();
            try
            {
                return lcDL.getData_AllCourses();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int enrollLecturerToCourse(LecturersCourses lc)
        {
            try
            {
                return lcDL.enrollLecturerToCourse(lc);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int removeLecFromCourse(string cid) 
        {
            try
            {
                return lcDL.removeLecFromCourse(cid);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
