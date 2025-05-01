using BusinessLayer.chung;
using BusinessLayer.Khang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeMS.Lecturer
{
    public partial class USMarkUpdate : UserControl
    {
        public USMarkUpdate()
        {
            InitializeComponent();
            scBL = new StudentsCoursesBL();
            lcBL = new LecturersCoursesBL();
        }
        private LecturersCoursesBL lcBL;
        private StudentsCoursesBL scBL;
        private string userid;
        private DataTable monhoc;
        private DataTable hocvien;
        private string courseId;

        

        private void load_Courses()
        {
            dgvMonhoc.DataSource = null;
            dgvMonhoc.Rows.Clear();
            userid = SessionManager.Instance.UserId;
            monhoc = new DataTable();
            monhoc = lcBL.getData(userid);
            dgvMonhoc.DataSource = monhoc;

            if (dgvMonhoc.Columns.Count > 0)
            {
                dgvMonhoc.Columns["Cid"].HeaderText = "Mã Môn";
                dgvMonhoc.Columns["CName"].HeaderText = "Tên Môn Học";
                dgvMonhoc.Columns["CDescription"].HeaderText = "Mô Tả";
                dgvMonhoc.Columns["CCredits"].HeaderText = "Số Tín Chỉ";
                dgvMonhoc.Columns["StartDate"].HeaderText = "Ngày Bắt Đầu";
                dgvMonhoc.Columns["EndDate"].HeaderText = "Ngày Kết Thúc";
            }
        }
        private void load_StudInCourse()
        {
            if (string.IsNullOrEmpty(courseId)) return;
            dgvHocvien.DataSource = null;
            dgvHocvien.Rows.Clear();
            hocvien = new DataTable();
            hocvien = scBL.getStudInCourse(courseId);
            dgvHocvien.DataSource = hocvien;
            if (dgvHocvien.Columns.Count > 0)
            {
                dgvHocvien.Columns["StId"].HeaderText = "Mã sinh viên";
                dgvHocvien.Columns["StName"].HeaderText = "Tên sinh viên";
                dgvHocvien.Columns["StGender"].HeaderText = "Giới tính";
                dgvHocvien.Columns["StEmail"].HeaderText = "Email";
                dgvHocvien.Columns["StBirth"].HeaderText = "Ngày sinh";
                dgvHocvien.Columns["StPhone"].HeaderText = "Số điện thoại";
                dgvHocvien.Columns["Mark"].HeaderText = "Điểm";
            }
            dgvHocvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvMonhoc_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvMonhoc.SelectedRows.Count > 0)
            {
                courseId = dgvMonhoc.SelectedRows[0].Cells[0].Value.ToString();
                load_StudInCourse();
            }
            else
            {
                courseId = "";
                dgvHocvien.DataSource = null;
            }
        }

        private void USMarkUpdate_Load(object sender, EventArgs e)
        {
            load_Courses();
        }

        private void dgvHocvien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocvien.SelectedRows.Count > 0)
            {
                txtStdId.Text = dgvHocvien.SelectedRows[0].Cells[0].Value.ToString();
                txtHoten.Text = dgvHocvien.SelectedRows[0].Cells[1].Value.ToString();
                txtMark.Text = dgvHocvien.SelectedRows[0].Cells[6].Value.ToString(); 
            }
            else
            {
                txtHoten.Text = "";
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            int number = scBL.nhapDiemHocVien(txtStdId.Text, decimal.Parse(txtMark.Text));
            if (number > 0)
            {
                MessageBox.Show("Thành công! ");
                load_StudInCourse();
            }
        }
    }
}
