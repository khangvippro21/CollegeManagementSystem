using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Bao;
using BusinessLayer.chung;



namespace CollegeMS
{
    public partial class UCStuDKKH : UserControl
    {

        private DKKHBL dkkhbl = new DKKHBL();
        private DataTable selectedCoursesTable = new DataTable();
        public UCStuDKKH()
        {
            InitializeComponent();
            LoadCourses();
            InitializeDataGridView();
            InitializeSelectedCoursesGrid();
            LoadSelectedCourses();
        }

        private void dgvDKKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            // Thêm cột CheckBox
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Select",
                HeaderText = "Chọn"
            };
            dgvDKKHtrong.Columns.Add(checkBoxColumn);


            dgvDKKHtrong.ReadOnly = false;
            dgvDKKHtrong.Columns["Select"].ReadOnly = false;
            foreach (DataGridViewColumn col in dgvDKKHtrong.Columns)
            {
                if (col.Name != "Select")
                {
                    col.ReadOnly = true;
                }
                dgvDKKHtrong.AutoGenerateColumns = false;
                dgvDKKHtrong.AllowUserToAddRows = false;
            }
        }

        private void InitializeSelectedCoursesGrid()
        {
            selectedCoursesTable.Columns.Add("CId", typeof(string));
            selectedCoursesTable.Columns.Add("CourseName", typeof(string));
            selectedCoursesTable.Columns.Add("LecturerName", typeof(string));
            selectedCoursesTable.Columns.Add("StartDate", typeof(DateTime));
            selectedCoursesTable.Columns.Add("EndDate", typeof(DateTime));
            selectedCoursesTable.Columns.Add("CCredits", typeof(int));
            selectedCoursesTable.Columns.Add("FeePerCredit", typeof(decimal));
            selectedCoursesTable.Columns.Add("TotalFee", typeof(decimal));

            dgvDKKHselect.DataSource = selectedCoursesTable;
            dgvDKKHselect.AutoGenerateColumns = false;
            dgvDKKHselect.AllowUserToAddRows = false;
        }
        private void LoadCourses()
        {
            DataTable courses = dkkhbl.laydsmonhoc(SessionManager.Instance.UserId);
            if (courses.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu môn học");
                return;
            }
            dgvDKKHtrong.DataSource = courses;
            dgvDKKHtrong.Columns["CourseName"].HeaderText = "Tên Môn Học";
            dgvDKKHtrong.Columns["LecturerName"].HeaderText = "Tên Giảng Viên";
            dgvDKKHtrong.Columns["CId"].HeaderText = "Mã Môn Học";
            dgvDKKHtrong.Columns["TotalFee"].HeaderText = "Tổng Học Phí";
            dgvDKKHtrong.CurrentCellDirtyStateChanged += dgvDKKH_CurrentCellDirtyStateChanged;
        }
        private void dgvDKKH_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDKKHtrong.IsCurrentCellDirty)
            {
                dgvDKKHtrong.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void LoadSelectedCourses()
        {
            string studentId = SessionManager.Instance.UserId;
            DataTable dt = dkkhbl.laydsmonhocdadangky(studentId);
            if (!dgvDKKHselect.Columns.Contains("Select"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Select",
                    HeaderText = "Chọn"
                };
                dgvDKKHselect.Columns.Add(checkBoxColumn);

            }

            dgvDKKHselect.DataSource = dt;
            dgvDKKHselect.Columns["CourseName"].HeaderText = "Tên Môn Học";
            dgvDKKHselect.Columns["LecturerName"].HeaderText = "Tên Giảng Viên";
            dgvDKKHselect.Columns["CId"].HeaderText = "Mã Môn Học";
            dgvDKKHselect.Columns["TotalFee"].HeaderText = "Tổng Học Phí";
            dgvDKKHselect.CurrentCellDirtyStateChanged += dgvDKKH_CurrentCellDirtyStateChanged;
            dgvDKKHselect.ReadOnly = false;
            dgvDKKHselect.Columns["Select"].ReadOnly = false;
            foreach (DataGridViewColumn col in dgvDKKHselect.Columns)
            {
                if (col.Name != "Select")
                {
                    col.ReadOnly = true;
                }

            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDKKHtrong.Rows)
            {
                if (row.Cells["Select"].Value != null)
                {
                    row.Cells["Select"].Value = false;
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }

            selectedCoursesTable.Clear();
            dgvDKKHtrong.Refresh();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string studentId = SessionManager.Instance.UserId;
            bool hasRegisteredAny = false;

            foreach (DataGridViewRow row in dgvDKKHtrong.Rows)
            {
                if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    string courseId = row.Cells["CId"].Value.ToString();
                    string courseName = row.Cells["CourseName"].Value.ToString();
                    decimal fee = Convert.ToDecimal(row.Cells["TotalFee"].Value);

                    if (!dkkhbl.kiemtratrungmon(studentId, courseId))
                    {
                        int rowsAffected = dkkhbl.dangkimonhoc(studentId, courseId, fee);
                        if (rowsAffected > 0)
                        {
                            hasRegisteredAny = true;
                            MessageBox.Show($"Đăng ký môn {courseName} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Không thể đăng ký môn {courseName}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Môn {courseName} đã được đăng ký trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    row.Cells["Select"].Value = false;
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }

            if (hasRegisteredAny)
                LoadSelectedCourses();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string studentId = SessionManager.Instance.UserId;
            if (MessageBox.Show("Bạn có chắc muốn hủy đăng ký các môn đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                foreach (DataGridViewRow row in dgvDKKHselect.Rows)
                {
                    if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value))
                    {
                        string courseId = row.Cells["CId"].Value.ToString();
                        dkkhbl.huydangky(studentId, courseId);
                        MessageBox.Show("Hủy đăng ký thành công!");
                        LoadSelectedCourses();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hủy đăng ký môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCourses();
        }
    
    }
}

