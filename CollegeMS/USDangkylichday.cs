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
using System.Data.SqlClient;
using BusinessLayer;
using BusinessLayer.Khang;
using System.Diagnostics;
using BusinessLayer.chung;
using BusinessLayer.Bao;

namespace CollegeMS
{
    public partial class USDangkylichday : UserControl
    {
        private LecturersCoursesBL lcBL;
        private LecturersCourses lc;
        private DataTable monHoc;
        private DataTable monHocTrong;
        string UserId;
        public USDangkylichday()
        {
            InitializeComponent();
            lcBL = new LecturersCoursesBL();
        }
        private bool HasColumn(DataGridView grid, string columnName)
        {
            foreach (DataGridViewColumn column in grid.Columns)
            {
                if (column.Name == columnName)
                    return true;
            }
            return false;
        }
        private void load_Data_AllCourses()
        {
            dgvMonhocTrong.DataSource = null;
            dgvMonhocTrong.Rows.Clear();
            monHocTrong = new DataTable();
            monHocTrong = lcBL.getData_AllCourses();
            dgvMonhocTrong.DataSource = monHocTrong;

            if (!HasColumn(dgvMonhocTrong, "Select"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Select",
                    HeaderText = "Chọn"
                };
                dgvMonhocTrong.Columns.Add(checkBoxColumn);
            }
            dgvMonhocTrong.ReadOnly = false;
            foreach (DataGridViewColumn col in dgvMonhocTrong.Columns)
            {
                if (col.Name != "Select")
                {
                    col.ReadOnly = true;
                }
                dgvMonhocTrong.AutoGenerateColumns = false;
                dgvMonhocTrong.AllowUserToAddRows = false;
            }
        }

        private void load_Data()
        {
            dgvMonhoc.DataSource = null;
            dgvMonhoc.Rows.Clear();
            UserId = SessionManager.Instance.UserId;
            monHoc = new DataTable();
            monHoc = lcBL.getData(UserId);
            dgvMonhoc.DataSource = monHoc;

            if (!HasColumn(dgvMonhoc, "Select"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Select",
                    HeaderText = "Chọn"
                };
                dgvMonhoc.Columns.Add(checkBoxColumn);
            }

            dgvMonhoc.ReadOnly = false;
            foreach (DataGridViewColumn col in dgvMonhoc.Columns)
            {
                if (col.Name != "Select")
                {
                    col.ReadOnly = true;
                }
                dgvMonhoc.AutoGenerateColumns = false;
                dgvMonhoc.AllowUserToAddRows = false;
            }
        }

        private void USDangkylichday_Load(object sender, EventArgs e)
        {
            getdata();
        }
        private void getdata()
        {
            load_Data_AllCourses();
            load_Data();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            UserId = SessionManager.Instance.UserId;
            foreach (DataGridViewRow row in dgvMonhocTrong.Rows)
            {
                if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    if (string.IsNullOrEmpty(row.Cells["LecturerName"].Value?.ToString()))
                    {
                        string courseId = row.Cells["CId"].Value.ToString();
                        int numOfRows = lcBL.enrollLecturerToCourse(new LecturersCourses(UserId, courseId));
                        if (numOfRows > 0)
                        {
                            MessageBox.Show("Dang ky lich day thanh cong !");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Môn {row.Cells["CName"].Value} đã được đăng ký trước đó.");
                        row.Cells["Select"].Value = false;
                    }
                }
            }
            getdata();
        }

        private void btCancel_1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMonhocTrong.Rows)
            {
                if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    row.Cells["Select"].Value = false;
                }
                row.Cells["Select"].Value = false;
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btCancel_2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMonhoc.Rows)
            {
                if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    row.Cells["Select"].Value = false;
                }
                row.Cells["Select"].Value = false;
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMonhoc.Rows)
            {
                if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    string courseId = row.Cells["CId"].Value.ToString();
                    int numOfRows = lcBL.removeLecFromCourse(courseId);
                    if (numOfRows > 0)
                    {
                        MessageBox.Show("Đã hủy đăng ký khóa học thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            getdata();
        }
    }
}
