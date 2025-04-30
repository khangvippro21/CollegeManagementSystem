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

        
        public bool dangkimonhoc(string studentId, string courseId, decimal fee)
        {
            if (dal.kiemtratrungmon(studentId, courseId))
            {
                return false; 
            }

            return dal.Dangkimonhoc(studentId, courseId, fee);
        }

       
        public DataTable laydsmonhoc()
        {
            return dal.laydsmonhoc();
        }

    }
}
