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
        }
        private void load_StudInCourse()
        {
            if (string.IsNullOrEmpty(courseId)) return;
            dgvHocvien.DataSource = null;
            dgvHocvien.Rows.Clear();
            hocvien = new DataTable();
            hocvien = scBL.getStudInCourse(courseId);
            dgvHocvien.DataSource = hocvien;
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
                txtMark.Text = dgvHocvien.SelectedRows[0].Cells[7].Value.ToString(); 
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
