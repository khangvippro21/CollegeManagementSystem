using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;
using DataLayer;
using QRCoder;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

namespace BusinessLayer
{
    public class StudentBL
    {
        private DataLayer.StudentDAL studentdal;
        private DataLayer.UserAccess userAccess;
        private StudentDTO studentDTO;
        public StudentBL()
        {
            studentdal = new DataLayer.StudentDAL();
            userAccess = new DataLayer.UserAccess();
        }
        
        public DataTable getallstudent()
        {
            return studentdal.getallstd();
        }

       
        public DataTable SearchStudent(string keyword)
        {
            return studentdal.SearchStudent(keyword);

        }

        public string GenerateNewStudentId()
        {
            string newStudentId = userAccess.GenerateNewUserId("S");
            Console.WriteLine($"Generated new StudentId: {newStudentId}");
            return newStudentId;
        }


        public int InsertStudent( StudentDTO student)
        {
            if (student == null) throw new ArgumentNullException(nameof(student));
            if (string.IsNullOrEmpty(student.StName)) throw new ArgumentException("Tên học viên không được để trống.", nameof(student.StName));
            if (string.IsNullOrEmpty(student.StPhone)) throw new ArgumentException("Số điện thoại không được để trống.", nameof(student.StPhone));

            student.StId = GenerateNewStudentId();
            student.StQRCodePath = QRGenerate(student.StId);

            try
            {
                userAccess.CreateUser(student.StId, "123", "student");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo tài khoản cho học viên: " + ex.Message);
            }

            try
            {
                return studentdal.InsertStudent(student);
            }
            catch (Exception ex)
            {
                throw new Exception("Tạo tài khoản thành công, nhưng lỗi khi thêm học viên vào bảng Students: " + ex.Message);
            }
        }

        public int UpdateStudent(StudentDTO student)
        {
            return studentdal.UpdateStudent(student);
        }

        public int DeleteStudent(string studentId)
        {
            return studentdal.DeleteStudent(studentId); 
        }
        private string QRGenerate(string StId)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(StId, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            Bitmap qrImage = code.GetGraphic(5);
            string qrId = $"{StId}.png";
            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string destFolder = Path.Combine(projectRoot, "QRCode", "SinhVien");
            string destFilePath = Path.Combine(destFolder, qrId);
            qrImage.Save(destFilePath, ImageFormat.Png);
            return destFilePath;
        }
    }
}
