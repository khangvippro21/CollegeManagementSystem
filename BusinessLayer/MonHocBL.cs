using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class MonHocBL
    {
        private MonHocDAL monHocDal;
        private DatabaseAccess access;
        public MonHocBL()
        {
            monHocDal = new MonHocDAL();
            access = new DatabaseAccess();
        }
        public DataTable MonHocTable()
        {
            return monHocDal.MonHocTable();
        }
        public DataTable SearchMH(string keyword)
        {
            return monHocDal.SearchMH(keyword);
        }
        public void deleteCourse(string CId)
        {
            monHocDal.DeleteMH(CId);
        }
        public void UpdateCourse(MonHocDTO monhoc)
        {
            monHocDal.UpdateCourse(monhoc);
        }
        public void insertCourse(MonHocDTO monhoc)
        {
            try
            {
                monHocDal.InsertMH(monhoc);
            }
            catch (SqlException e)
            {
                throw new Exception("Lỗi khi thêm môn học: " + e.Message);
            }
        }
    }
}
