using DataLayer;
using DataLayer.Bao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Bao
{
    public class ReviewBL
    {
        private ReviewDAL reviewDAL = new ReviewDAL();
        private BaocaoDAL baocaoDAL = new BaocaoDAL();
        public DataTable getReview()
        {
            return reviewDAL.getReview();
        }
        public DataTable laythontingv(string courseId)
        {
            try
            {
                return reviewDAL.laythongtingv(courseId);
            }
            catch (Exception ex)
            {
                throw new Exception(@"Lỗi khi lấy thông tin giảng viên: {ex.Message}", ex);
            }
        }

        public int guidahgia(string studentId, string lecturerId, string courseId, string comment)
        {
            try
            {
                
                if (!baocaoDAL.kiemtramonhoc(studentId, courseId))
                {
                    throw new Exception("Bạn chỉ có thể đánh giá giảng viên của môn học đã đăng ký!");
                }

                return reviewDAL.guidanhgia(studentId, lecturerId, courseId, comment);
            }
            catch (Exception ex)
            {
                throw new Exception(@"Lỗi khi gửi đánh giá: {ex.Message}", ex);
            }
        }

    }
}
