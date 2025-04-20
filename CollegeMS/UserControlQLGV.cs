using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        string selectedId="";
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

        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = dgvGV.SelectedRows[0].Cells[0].Value.ToString();
                tbTenGV.Text = dgvGV.SelectedRows[0].Cells[1].Value.ToString();
                tbSDTGV.Text = dgvGV.SelectedRows[0].Cells[2].Value.ToString();
                tbEmailGV.Text = dgvGV.SelectedRows[0].Cells[3].Value.ToString();
                cbGioiTinhGV.Text = dgvGV.SelectedRows[0].Cells[4].Value.ToString();
                tbDiaChiGV.Text = dgvGV.SelectedRows[0].Cells[5].Value.ToString();
                tbHinhAnh.Text = dgvGV.SelectedRows[0].Cells[6].Value.ToString();
                dtpNgaySinhGV.Value = Convert.ToDateTime(dgvGV.SelectedRows[0].Cells[7].Value.ToString());
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
