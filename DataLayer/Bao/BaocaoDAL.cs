using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;


namespace DataLayer
{
    public class BaocaoDAL:DatabaseAccess
    {
        public void taobaocao(BaocaoDTO baocaoDTO)
        {

            string sql = "INSERT INTO Problems (ProId,CourseId, StuId, Detail) " +
                 "VALUES (@ProId,@CourseId, @StuId, @Detail)";
            try
            {
                //Connect();

                SqlCommand cmd = new SqlCommand(sql);

                

                int rows = MyExecuteNonQuery(cmd);
                if (rows > 0)
                {
                    Console.WriteLine("Thêm học viên thành công.");
                }
                else
                {
                    Console.WriteLine("Không có học viên nào được thêm.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm học viên: " + ex.Message);
            }
            finally
            {
                DisConnect();
            }
        }




    }
}
