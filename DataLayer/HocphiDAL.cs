using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data.SqlClient;
using System.Configuration;

namespace DataLayer
{
    public class HocphiDAL : DatabaseAccess
    {

        public List<HocphiDTO> GetAllTuitionInfo()
        {
            List<HocphiDTO> tuitionList = new List<HocphiDTO>();
            string sql = @"
                SELECT 
                    s.StName,
                    c.CName,
                    sc.Fee
                FROM Students s
                JOIN Students_Courses sc ON s.StId = sc.StId
                JOIN Courses c ON sc.CId = c.CId";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HocphiDTO hocphi = new HocphiDTO(
                        studentName: reader["StName"].ToString(),
                        courseName: reader["CName"].ToString(),
                        fee: Convert.ToDecimal(reader["Fee"])
                    );
                    tuitionList.Add(hocphi);
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách học phí: " + ex.Message);
            }
            finally
            {
                DisConnect();
            }

            return tuitionList;

        }
    }
}
