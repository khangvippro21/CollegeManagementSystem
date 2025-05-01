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
        public UCStuDKKH()
        {
            InitializeComponent();
            LoadCourses();
            InitializeDataGridView();
            dgvDKKH.CellValueChanged += dgvDKKH_CellValueChanged;
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
            dgvDKKH.Columns.Add(checkBoxColumn);


            dgvDKKH.ReadOnly = false;
            dgvDKKH.Columns["Select"].ReadOnly = false;
            foreach (DataGridViewColumn col in dgvDKKH.Columns)
            {
                if (col.Name != "Select")
                {
                    col.ReadOnly = true;
                }
                dgvDKKH.AutoGenerateColumns = false;
                dgvDKKH.AllowUserToAddRows= false;
            }
        }

        private void LoadCourses()
        {
            DataTable courses = dkkhbl.laydsmonhoc();

            // Kiểm tra dữ liệu
            if (courses.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu môn học");
                return;
            }

            dgvDKKH.DataSource = courses;
            dgvDKKH.Columns["CourseName"].HeaderText = "Tên Môn Học";
            dgvDKKH.Columns["LecturerName"].HeaderText = "Tên Giảng Viên";
            dgvDKKH.Columns["CId"].HeaderText = "Mã Môn Học";
            dgvDKKH.Columns["TotalFee"].HeaderText = "Tổng Học Phí";
            dgvDKKH.CurrentCellDirtyStateChanged += dgvDKKH_CurrentCellDirtyStateChanged;
            dgvDKKH.CellValueChanged += dgvDKKH_CellValueChanged;
        }
        private void dgvDKKH_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDKKH.IsCurrentCellDirty)
            {
                dgvDKKH.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvDKKH_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvDKKH.Columns["Select"].Index && e.RowIndex >= 0)
            {

                bool isChecked = Convert.ToBoolean(dgvDKKH.Rows[e.RowIndex].Cells["Select"].Value);
                dgvDKKH.Rows[e.RowIndex].DefaultCellStyle.BackColor = isChecked ? Color.Turquoise : Color.White;
            }
            
        }


        private void btnDki_Click(object sender, EventArgs e)
        {

            {
                string studentId = SessionManager.Instance.UserId;
                bool registeredAny = false;

                try
                {
                    foreach (DataGridViewRow row in dgvDKKH.Rows)
                    {
                        if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value))
                        {
                            string courseId = row.Cells["CId"].Value.ToString();
                            decimal fee = Convert.ToDecimal(row.Cells["TotalFee"].Value);
                            bool success = dkkhbl.dangkimonhoc(studentId, courseId, fee);

                            if (!success)
                                MessageBox.Show($"Môn {row.Cells["CourseName"].Value} đã được đăng ký trước đó.");
                            else
                                registeredAny = true;
                        }
                    }

                    if (registeredAny)
                        MessageBox.Show("Đăng ký hoàn tất!");
                    else
                        MessageBox.Show("Không có môn nào được đăng ký.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng ký môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDKKH.Rows)
            {
                if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    row.Cells["Select"].Value = false;
                }
                row.Cells["Select"].Value = false;
                row.DefaultCellStyle.BackColor = Color.White;
                dgvDKKH.Refresh();
            }
        }
    }
}

