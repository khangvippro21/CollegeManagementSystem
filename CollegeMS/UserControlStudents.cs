using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;

namespace CollegeMS
{
    public partial class UserControlStudents: UserControl
    {
        private UserMainForm prform;
        private DataGridView dgvStudents;
        protected StudentBL studentbl;

        public UserControlStudents()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            studentbl = new StudentBL();
            LoadStudentData();
        }

        public UserControlStudents(UserMainForm parentForm)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            studentbl = new StudentBL();
            LoadStudentData();
        }

        public void LoadStudentData()
        {
            try
            {
                List<TransferObject.StudentDTO> students = studentbl.GetAllStudents();
                dataGridViewStu.DataSource = students;
                if (dataGridViewStu.Columns.Count > 0)
                {
                    dataGridViewStu.Columns["StId"].HeaderText = "Mã Học Viên";
                    dataGridViewStu.Columns["StName"].HeaderText = "Tên Học Viên";
                    dataGridViewStu.Columns["StPhone"].HeaderText = "Số Điện Thoại";
                    dataGridViewStu.Columns["StEmail"].HeaderText = "Email";
                    dataGridViewStu.Columns["StGender"].HeaderText = "Giới Tính";
                    dataGridViewStu.Columns["StAddress"].HeaderText = "Địa Chỉ";
                    dataGridViewStu.Columns["Stpath"].HeaderText = "Đường Dẫn";
                    dataGridViewStu.Columns["StBirth"].HeaderText = "Ngày Sinh";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnsearchStu_Click(object sender, EventArgs e)
        {

            string txtsearch = txtsearchStu.Text;
            if (String.IsNullOrEmpty(txtsearch))
            {
                LoadStudentData();
            }
            else
            {
                SearchStudents(txtsearch);
            }
        }


        private void SearchStudents(string name)
        {
            try
            {
                List<StudentDTO> students = studentbl.SearchStudent(name);
                dataGridViewStu.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
