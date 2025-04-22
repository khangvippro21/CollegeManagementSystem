using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
using BusinessLayer;
using TransferObject;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollegeMS
{
    public partial class UserControlStudents : UserControl
    {


        private string selectedStudentId = "";

        private UserMainForm prform;
        private DataGridView dgvStudents;
        protected StudentBL studentbl;
        //sua cai nay
        public UserControlStudents()
        {
            InitializeComponent();
            dataGridViewStu.RowPostPaint += dataGridViewStu_RowPostPaint;
            this.Dock = DockStyle.Fill;
            studentbl = new StudentBL();
            LoadStudentData();
        }
        //sua cai nay
        public UserControlStudents(UserMainForm parentForm)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            studentbl = new StudentBL();
            LoadStudentData();
        }
        //sua cai nay
       public void LoadStudentData()
        {
            try
            {
                DataTable students = studentbl.getallstudent();
                dataGridViewStu.DataSource = students;
                dataGridViewStu.Columns["StPath"].Visible = false;
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

                    string imagePath = txtPic.Text;
                    try
                    {
                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        {
                            pictureBoxStu.Image = Image.FromFile(imagePath);
                            pictureBoxStu.SizeMode = PictureBoxSizeMode.StretchImage; // Tuỳ chỉnh hiển thị
                        }
                        else
                        {
                            pictureBoxStu.Image = null; // Clear ảnh nếu không tồn tại
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                        pictureBoxStu.Image = null;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
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
        

        //sua cai nay
        private void SearchStudents(string name)
        {
            try
            {
                DataTable students = studentbl.SearchStudent(name);
                dataGridViewStu.DataSource = students;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

       


        //tham khao cai nay
        private void UserControlStudents_Load(object sender, EventArgs e)
        {
            //dataGridViewStu.RowPostPaint += dataGridViewStu_RowPostPaint;

            try
            {
                StudentBL a = new StudentBL();
                dataGridViewStu.DataSource = a.getallstudent();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách student : " + ex.Message);

            }


        }

        private void btnsearchStu_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm học viên: " + ex.Message);
            }
        }

 
        private void dataGridViewStu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridViewStu.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                    dataGridViewStu.DefaultCellStyle.Font,
                    b,
                    e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txthoten.Clear();
            txtsdt.Clear();
            txtEmail.Clear();
            cbgioitinh.SelectedIndex = -1;
            txtDiachi.Clear();
            txtsearchStu.Clear();
            dtpStu.Value = DateTime.Now;
            txtPic.Clear();
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewStu.SelectedRows.Count > 0)
            {
                string id = dataGridViewStu.SelectedRows[0].Cells["StId"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa học viên này?", "Xác nhận", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        studentbl.DeleteStudent(id); // Gọi BL
                        dataGridViewStu.Rows.RemoveAt(dataGridViewStu.SelectedRows[0].Index); // Xóa UI
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void dataGridViewStu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewStu.Rows[e.RowIndex];

                selectedStudentId = row.Cells["StId"].Value.ToString();
                txthoten.Text = row.Cells["StName"].Value.ToString();
                txtsdt.Text = row.Cells["StPhone"].Value.ToString();
                txtEmail.Text = row.Cells["StEmail"].Value.ToString();
                cbgioitinh.Text = row.Cells["StGender"].Value.ToString();
                txtDiachi.Text = row.Cells["StAddress"].Value.ToString();
                txtPic.Text = row.Cells["StPath"].Value.ToString();
                dtpStu.Value = Convert.ToDateTime(row.Cells["StBirth"].Value);

                string imagePath = txtPic.Text;
                try
                {
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        pictureBoxStu.Image = Image.FromFile(imagePath);
                        pictureBoxStu.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBoxStu.Image = null; // Clear nếu ảnh không tồn tại
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                    pictureBoxStu.Image = null;
                }
            }
        }
        

        private void btSua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(selectedStudentId))
    {
                MessageBox.Show("Vui lòng chọn học viên cần sửa trước.");
                return;
            }

            
            string name = txthoten.Text;
            string phone = txtsdt.Text;
            string email = txtEmail.Text;
            string gender = cbgioitinh.SelectedItem != null ? cbgioitinh.SelectedItem.ToString() : "";
            string address = txtDiachi.Text;
            DateTime birth = dtpStu.Value;
            string path = txtPic.Text;

            
            StudentDTO student = new StudentDTO(
                selectedStudentId,
                name,
                phone,
                email,
                gender,
                address,
                path,
                birth
            );

            try
            {
                
                studentbl.UpdateStudent(student);
                MessageBox.Show("Cập nhật học viên thành công!");

              
                LoadStudentData();
                ClearInputFields();
                selectedStudentId = ""; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật học viên: " + ex.Message);
            }
        }

        private void cbgioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbgioitinh.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPic.Text = ofd.FileName;
                pictureBoxStu.Image = Image.FromFile(ofd.FileName);
                pictureBoxStu.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
