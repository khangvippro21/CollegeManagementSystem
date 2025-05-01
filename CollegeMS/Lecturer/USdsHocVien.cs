using BusinessLayer.chung;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
using BusinessLayer.Khang;

namespace CollegeMS.Lecturer
{
    public partial class USdsHocVien : UserControl
    {
        private LecturersCoursesBL lcBL;
        private StudentsCoursesBL scBL;
        private string userid;
        private DataTable monhoc; 
        private DataTable hocvien;
        private string courseId;
        public USdsHocVien()
        {
            InitializeComponent();
            scBL = new StudentsCoursesBL();
            lcBL = new LecturersCoursesBL();
        }

        private void USdsHocVien_Load(object sender, EventArgs e)
        {
            load_Courses();
        }

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

        private void dgvMonhoc_SelectionChanged(object sender, EventArgs e)
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
    }
}
