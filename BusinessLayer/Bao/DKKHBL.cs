using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TransferObject;


namespace BusinessLayer.Bao
{
    public class DKKHBL
    {
        private DKKHDAL dal = new DKKHDAL();


        public int dangkimonhoc(string studentId, string courseId, decimal fee)
        {

            try
            {
                return dal.Dangkimonhoc(studentId, courseId, fee);
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }
        public bool kiemtratrungmon(string studentId, string courseId)
        {


            return dal.kiemtratrungmon(studentId, courseId);

        }

        public DataTable laydsmonhoc(string studentId)
        {
            try
            {
                return dal.laydsmonhoc(studentId);
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }
        public DataTable laydsmonhocdadangky(string studentId)
        {
            try
            {
                return dal.layMonHocDaDangKy(studentId);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int huydangky(string studentId, string courseId)
        {
            try
            {
                return dal.HuyDangKyMonHoc(studentId, courseId);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
