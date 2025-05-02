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

namespace CollegeMS
{
    public partial class UserControlQLMH : UserControl
    {
        MonHocBL monhocbl = new MonHocBL();
        DataTable dt = new DataTable();
        public UserControlQLMH()
        {
            InitializeComponent();
        }
        private void LoadMH()
        {
            try
            {
                dgvMH.DataSource = monhocbl.MonHocTable();
                if (dgvMH.Columns.Count > 0)
                {
                    dgvMH.Columns["CId"].HeaderText = "Mã Môn Học";
                    dgvMH.Columns["CName"].HeaderText = "Tên Môn Học";
                    dgvMH.Columns["CDescription"].HeaderText = "Mô Tả Môn Học";
                    dgvMH.Columns["CCredits"].HeaderText = "Số Tín Chỉ";
                    dgvMH.Columns["StartDate"].HeaderText = "Ngày Bắt Đầu";
                    dgvMH.Columns["EndDate"].HeaderText = "Ngày Kết Thúc";
                    dgvMH.Columns["FeePerCredit"].HeaderText = "Học Phí Từng Tín Chỉ";
                    dgvMH.Columns["Fee"].HeaderText = "Học Phí Môn Học";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void UserControlQLMH_Load(object sender, EventArgs e)
        {
            LoadMH();
        }
        private void SearchMH(string name)
        {
            try
            {
                dt = monhocbl.SearchMH(name);
                dgvMH.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btTimMH_Click_1(object sender, EventArgs e)
        {
            string txtsearch = tbTimMH.Text;
            if (String.IsNullOrEmpty(txtsearch))
            {
                LoadMH();
            }
            else
            {
                SearchMH(txtsearch);
            }
        }

        private void btXoaMH_Click_1(object sender, EventArgs e)
        {
            if (dgvMH.SelectedRows.Count > 0)
            {
                string id = dgvMH.SelectedRows[0].Cells["CId"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        monhocbl.deleteCourse(id);
                        dgvMH.Rows.RemoveAt(dgvMH.SelectedRows[0].Index);
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

        private void btHuyMH_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void btThemMH_Click_1(object sender, EventArgs e)
        {

            string id = tbMaMH.Text;
            string name = tbTenMH.Text;
            string desc = tbMoTaMH.Text;
            int credits = int.Parse(tbSoTinChi.Text);
            DateTime start = dtpNgayBatDau.Value;
            DateTime end = dtpNgayKetThuc.Value;
            int feePerCredit = int.Parse(tbPerCredit.Text);
            int fee = feePerCredit * credits;
            MonHocDTO monhoc = new MonHocDTO(id, name, desc, credits, start, end, fee, feePerCredit);

            try
            {
                monhocbl.insertCourse(monhoc);
                MessageBox.Show("Thêm môn học thành công!");
                LoadMH();
                clearInput();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm môn học: " + ex.Message);
            }
        }
        public void clearInput()
        {
            tbMaMH.Clear();
            tbTenMH.Clear();
            tbSoTinChi.Clear();
            tbTimMH.Clear();
            tbMoTaMH.Clear();
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;
            tbPerCredit.Clear();
        }


        private void btSuaMH_Click_1(object sender, EventArgs e)
        {
            MonHocDTO course1 = new MonHocDTO();
            course1.CId = tbMaMH.Text;
            course1.CName = tbTenMH.Text;
            course1.CDescription = tbMoTaMH.Text;
            course1.CCredits = int.Parse(tbSoTinChi.Text);
            course1.StartDate = dtpNgayBatDau.Value;
            course1.EndDate = dtpNgayKetThuc.Value;
            course1.FeePerCredit = int.Parse(tbPerCredit.Text);
            course1.Fee = course1.FeePerCredit * course1.CCredits;
            try
            {
                monhocbl.UpdateCourse(course1);
                MessageBox.Show("Sửa môn học thành công!");
                LoadMH();
                clearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa môn học: " + ex.Message);
            }
        }


        private void dgvMH_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMH.Rows[e.RowIndex];
                tbMaMH.Text = row.Cells[0].Value.ToString();
                tbTenMH.Text = row.Cells[1].Value.ToString();
                tbMoTaMH.Text = row.Cells[2].Value.ToString();
                tbSoTinChi.Text = row.Cells[3].Value.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells[4].Value);
                dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells[5].Value);
                tbPerCredit.Text = row.Cells[6].Value.ToString();
            }
        }


    }
}
