using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer.Bao
{
   public class BaocaoBL
    {
        private BaocaoDTO baocao;
        private  BaocaoDAL baocaoDAL = new BaocaoDAL();
        
        public DataTable laydsmonhoc(string studentId)
        {
            try
            {
                return baocaoDAL.dsmonhocdadk(studentId);
            }
            catch (SqlException ex)
            {
                throw  ex;
            }
        }

        public string baocaosuco(string studentId, string courseId, string detail)
        {
            try
            {
                if (!baocaoDAL.kiemtramonhoc(studentId, courseId))
                {
                    throw new Exception("Bạn chỉ có thể báo cáo sự cố cho môn học đã đăng ký.");
                }

                return baocaoDAL.taobaocao(studentId, courseId, detail);
            }
            catch (SqlException ex)
            {
                throw  ex;
            }
        }

    }
}
