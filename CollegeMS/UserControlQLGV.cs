using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusinessLayer;
using TransferObject;

namespace CollegeMS
{
    public partial class UserControlQLGV : UserControl
    {
        GiangVienBL giangvienbl = new GiangVienBL();
        DataTable dt = new DataTable();
        string selectedId = "";
        public UserControlQLGV()
        {
            InitializeComponent();

        }
        private void SearchLecturers(string name)
        {
            try
            {
                dt = giangvienbl.SearchLecturer(name);
                dgvGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
        private void LoadGV()
        {
            try
            {
                dgvGV.DataSource = giangvienbl.getallgv();
                dgvGV.Columns["LePath"].Visible = false;
                if (dgvGV.Columns.Count > 0)
                {
                    dgvGV.Columns["LeId"].HeaderText = "Mã Giảng Viên";
                    dgvGV.Columns["LeName"].HeaderText = "Tên Giảng Viên";
                    dgvGV.Columns["LePhone"].HeaderText = "Số Điện Thoại";
                    dgvGV.Columns["LeEmail"].HeaderText = "Email";
                    dgvGV.Columns["LeGender"].HeaderText = "Giới Tính";
                    dgvGV.Columns["LeAddress"].HeaderText = "Địa Chỉ";
                    dgvGV.Columns["Lepath"].HeaderText = "Đường Dẫn";
                    dgvGV.Columns["LeBirth"].HeaderText = "Ngày Sinh";
                }
                string img = tbHinhAnh.Text;
                string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string fullPath = Path.Combine(projectRoot, "AnhThe", "GiaoVien", img);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void UserControlQLGV_Load(object sender, EventArgs e)
        {
            LoadGV();
        }

        private void btTimGV_Click(object sender, EventArgs e)
        {
            string txtsearch = tbTimGV.Text;
            if (String.IsNullOrEmpty(txtsearch))
            {
                LoadGV();
            }
            else
            {
                SearchLecturers(txtsearch);
            }
        }

        private void btSuaGV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần sửa trước.");
                return;
            }
            string name = tbTenGV.Text;
            string phone = tbSDTGV.Text;
            string email = tbEmailGV.Text;
            string gender = cbGioiTinhGV.SelectedItem != null ? cbGioiTinhGV.SelectedItem.ToString() : "";
            string address = tbDiaChiGV.Text;
            DateTime birth = dtpNgaySinhGV.Value;
            string path = tbHinhAnh.Text;


            GiangVien gv = new GiangVien(
                selectedId,
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

                giangvienbl.UpdateLecturer(gv);
                MessageBox.Show("Cập nhật giảng viên thành công!");
                LoadGV();
                ClearInputFields();
                selectedId = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật giảng viên: " + ex.Message);
            }

        }

        private void btThemGV_Click(object sender, EventArgs e)
        {
            string name = tbTenGV.Text;
            string phone = tbSDTGV.Text;
            string email = tbEmailGV.Text;
            string gender = cbGioiTinhGV.SelectedItem != null ? cbGioiTinhGV.SelectedItem.ToString() : "";
            string address = tbDiaChiGV.Text;
            DateTime birth = dtpNgaySinhGV.Value;
            string path = tbHinhAnh.Text;
            TransferObject.GiangVien newGiangVien = new TransferObject.GiangVien(
                "", name, phone, email, gender, address, path, birth);

            try
            {

                giangvienbl.InsertLecturer(newGiangVien);
                MessageBox.Show("Thêm giảng viên thành công!");
                LoadGV();
                ClearInputFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm giảng viên: " + ex.Message);
            }
        }
        private void ClearInputFields()
        {
            tbTenGV.Clear();
            tbSDTGV.Clear();
            tbEmailGV.Clear();
            cbGioiTinhGV.SelectedIndex = -1;
            tbDiaChiGV.Clear();
            tbTimGV.Clear();
            tbHinhAnh.Clear();
            dtpNgaySinhGV.Value = DateTime.Today;
        }

        private void btXoaGV_Click_1(object sender, EventArgs e)
        {
            if (dgvGV.SelectedRows.Count > 0)
            {
                string id = dgvGV.SelectedRows[0].Cells["LeId"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa giảng viên này?", "Xác nhận", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        giangvienbl.deleteLecturer(id);
                        dgvGV.Rows.RemoveAt(dgvGV.SelectedRows[0].Index);
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


        private void btHuy_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void dgvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGV.Rows[e.RowIndex];
                selectedId = row.Cells[0].Value.ToString();
                tbTenGV.Text = row.Cells[1].Value.ToString();
                tbSDTGV.Text = row.Cells[2].Value.ToString();
                tbEmailGV.Text = row.Cells[3].Value.ToString();
                cbGioiTinhGV.Text = row.Cells[4].Value.ToString();
                tbDiaChiGV.Text = row.Cells[5].Value.ToString();
                tbHinhAnh.Text = row.Cells[6].Value.ToString();
                dtpNgaySinhGV.Value = Convert.ToDateTime(row.Cells[7].Value.ToString());
                string fileName = tbHinhAnh.Text;
                string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string fullPath = Path.Combine(projectRoot, "AnhThe", "GiaoVien", fileName);
                try
                {
                    if (!string.IsNullOrEmpty(fileName) && File.Exists(fullPath))
                    {
                        pictureBoxGV.Image = Image.FromFile(fullPath);
                        pictureBoxGV.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pictureBoxGV.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                    pictureBoxGV.Image = null;
                }
            }
        }

        private void btChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string originalFileName = Path.GetFileName(ofd.FileName);
                string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string destFolder = Path.Combine(projectRoot, "AnhThe", "GiaoVien");
                if (!Directory.Exists(destFolder))
                    Directory.CreateDirectory(destFolder);
                string destFilePath = Path.Combine(destFolder, originalFileName);
                try
                {
                    File.Copy(ofd.FileName, destFilePath, true);
                    tbHinhAnh.Text = originalFileName; 
                    pictureBoxGV.Image = Image.FromFile(destFilePath);
                    pictureBoxGV.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sao chép ảnh: " + ex.Message);
                }

            }
        }
    }
} 
