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
    public class GiangVienBL
    {
        private getGiangVien giangVienDal;
        private UserAccess userAccess;

        public GiangVienBL()
        {
            giangVienDal = new getGiangVien();
            userAccess = new UserAccess();
        }
        public DataTable getallgv()
        {
            return giangVienDal.lecTable();
        }
        public DataTable SearchLecturer(string keyword)
        {
            return giangVienDal.SearchLecturer(keyword);
        }
       
     
        public string GenerateNewLecturerId()
        {
            string newLecturerId = userAccess.GenerateNewUserId("L");
            Console.WriteLine($"Generated new LecturerId: {newLecturerId}");
            return newLecturerId;
        }


        public void InsertLecturer(GiangVien giangVien)
        {
            if (giangVien == null) throw new ArgumentNullException(nameof(giangVien));
            if (string.IsNullOrEmpty(giangVien.LeName)) throw new ArgumentException("Tên học viên không được để trống.", nameof(giangVien.LeName));
            if (string.IsNullOrEmpty(giangVien.LePhone)) throw new ArgumentException("Số điện thoại không được để trống.", nameof(giangVien.LePhone));

            giangVien.LeId = GenerateNewLecturerId();

            try
            {
                userAccess.CreateUser(giangVien.LeId, "123", "lecturer");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo tài khoản cho giảng viên: " + ex.Message);
            }

            try
            {
                giangVienDal.InsertLecturer(giangVien);
            }
            catch (Exception ex)
            {
                throw new Exception("Tạo tài khoản thành công, nhưng lỗi khi thêm giảng viên vào bảng Lecturers: " + ex.Message);
            }
        }

        public void deleteLecturer(string LeId)
        {
           giangVienDal.DeleteLecturer(LeId);
        }

        public bool UpdateLecturer(GiangVien giangVien)
        {
           return giangVienDal.UpdateLecturer(giangVien);
        }
    }
}
