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
        private StudentDTO student;
        public UserControlStudents()
        {
            InitializeComponent();
            dataGridViewStu.RowPostPaint += dataGridViewStu_RowPostPaint;
            this.Dock = DockStyle.Fill;
            studentbl = new StudentBL();
            LoadStudentData();
        }
        public void LoadStudentData()
        {
            try
            {
                DataTable students = studentbl.getallstudent();
                dataGridViewStu.DataSource = students;
                dataGridViewStu.Columns["Stpath"].Visible = false;
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
                    string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                    string fullPath = Path.Combine(projectRoot, "AnhThe", "HocVien", imagePath);
                    try
                    {
                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        {
                            pictureBoxStu.Image = Image.FromFile(imagePath);
                            pictureBoxStu.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else
                        {
                            pictureBoxStu.Image = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                        pictureBoxStu.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Loi khi tai du lieu !");
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

                int result = studentbl.InsertStudent(newStudent);
                if (result > 0)
                    MessageBox.Show("Thêm học viên thành công!");
                else
                    MessageBox.Show("Không thêm được học viên.");
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
                       int kq= studentbl.DeleteStudent(id);
                        if (kq > 0)
                            MessageBox.Show("Xóa học viên thành công!");
                        else
                            MessageBox.Show("Không tìm thấy học viên để xóa.");

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

                string fileName = txtPic.Text;
                string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string fullPath = Path.Combine(projectRoot, "AnhThe", "HocVien", fileName);

                try
                {
                    if (!string.IsNullOrEmpty(fileName) && File.Exists(fullPath))
                    {
                        pictureBoxStu.Image = Image.FromFile(fullPath);
                        pictureBoxStu.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBoxStu.Image = null;
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
            if (string.IsNullOrEmpty(selectedStudentId))
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
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (o.ShowDialog() == DialogResult.OK)
            {
                string img = Path.GetFileName(o.FileName);
                string folder = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string file = Path.Combine(folder, "AnhThe", "HocVien");
                if (!Directory.Exists(file))
                    Directory.CreateDirectory(folder);
                string destFilePath = Path.Combine(file, img);
                try
                {
                    File.Copy(o.FileName, destFilePath, true);
                    txtPic.Text = img;
                    pictureBoxStu.Image = Image.FromFile(destFilePath);
                    pictureBoxStu.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sao chép ảnh: " + ex.Message);
                }
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
    }
}

