using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Bao;
using BusinessLayer.chung;

namespace CollegeMS
{
    public partial class UCStuBcao : UserControl
    {

        private BaocaoBL baocaoBL = new BaocaoBL();
        private ReviewBL reviewBL = new ReviewBL();
        string leId;
        public UCStuBcao()
        {
            InitializeComponent();
        }

        private void UCStuBcao_Load(object sender, EventArgs e)
        {
            LoadRegisteredCourses();
        }

        private void LoadRegisteredCourses()
        {
            try
            {
                string studentId = SessionManager.Instance.UserId;


                DataTable dt = baocaoBL.laydsmonhoc(studentId);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Bạn chưa đăng ký môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbKhoahoc.Enabled = false;
                    cbbKhoahoc.Enabled = false;
                    return;
                }

                cbbKhoahoc.DataSource = dt;
                cbbKhoahoc.DisplayMember = "CourseName";
                cbbKhoahoc.ValueMember = "CId";
                cbbKhoahoc.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Lỗi khi tải danh sách môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string studentId = SessionManager.Instance.UserId;
            if (cbbKhoahoc.SelectedValue == null)
            {
                MessageBox.Show("Chọn một môn học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string courseId = cbbKhoahoc.SelectedValue.ToString();
            string detail = rtbreport.Text.Trim();
            if (string.IsNullOrEmpty(detail))
            {
                MessageBox.Show("Nhập mô tả sự cố.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string problemId = baocaoBL.baocaosuco(studentId, courseId, detail);
            if (!string.IsNullOrEmpty(problemId))
            {
                MessageBox.Show("Gửi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbreport.Clear();
                cbbKhoahoc.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Không thể gửi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbbKhoahoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbKhoahoc.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                if (cbbKhoahoc.SelectedValue == null)
                {
                    ClearLecturerInfo();
                    return;
                }

                string courseId = cbbKhoahoc.SelectedValue.ToString();
                DataTable dt = reviewBL.laythontingv(courseId);
                if (dt.Rows.Count == 0)
                {
                    ClearLecturerInfo();
                    return;
                }

                DataRow row = dt.Rows[0];
                leId = row["LeId"].ToString();
                txttengv.Text = row["LeName"].ToString();
                txtmailgv.Text = row["LeEmail"].ToString();
                txtsdtgv.Text = row["LePhone"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin giảng viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearLecturerInfo();
            }
        }

        private void ClearLecturerInfo()
        {
            txttengv.Text = string.Empty;
            txtmailgv.Text = string.Empty;
            txtsdtgv.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string studentId = SessionManager.Instance.UserId;
            string courseId = cbbKhoahoc.SelectedValue.ToString();
            string comment = rtbreview.Text.Trim();
            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Nhập nội dung đánh giá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = reviewBL.laythontingv(courseId);
            if (dt.Rows.Count == 0)
            {
                ClearLecturerInfo();
                return;
            }

            string lecturerId = dt.Rows[0]["LeId"].ToString();
            int reviewId = reviewBL.guidahgia(studentId, lecturerId, courseId, comment);
            if (reviewId > 0)
            {
                MessageBox.Show("Đánh giá giảng viên đã được gửi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbreview.Clear();
                cbbKhoahoc.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("hello!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

