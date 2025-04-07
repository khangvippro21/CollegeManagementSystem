using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TransferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace CollegeMS
{
    public partial class UserControlStudent : UserControl
    {
        private UserMainForm prform;
        private DataGridView dgvStudents;
        protected StudentBL studentbl;
        public UserControlStudent()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            studentbl = new StudentBL();
            LoadStudentData();
        }

        public UserControlStudent(UserMainForm parentForm)
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string name = txthoten.Text;
            string phone = txtsdt.Text;
            string email = txtEmail.Text;
            string gender = cbgioitinh.SelectedItem != null ? cbgioitinh.SelectedItem.ToString() : "";
            string address = txtDiachi.Text;
            DateTime birth = dtpStu.Value;
            string path = txtPic.Text;
            TransferObject.StudentDTO newStudent = new TransferObject.StudentDTO(
                "", name, phone, email, gender, address, path, birth);


            try
            {
             
                studentbl.InsertStudent(newStudent);
                MessageBox.Show("Thêm học viên thành công!");
                LoadStudentData();
                ClearInputFields();
                tabControlStu.SelectedTab = searchStu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm học viên: " + ex.Message);
            }
        }


        private void ClearInputFields()
        {
            txthoten.Clear();
            txtsdt.Clear();
            txtEmail.Clear();
            cbgioitinh.SelectedIndex = -1;
            txtDiachi.Clear();
            txtsearchStu.Clear();
            dtpStu.Value = DateTime.Now;
        }

     
    }
}

