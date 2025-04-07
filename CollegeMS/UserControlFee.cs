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
    public partial class UserControlFee: UserControl
    {
        private HocphiBL hocphiBL;

        public UserControlFee()
        {
            InitializeComponent();
            hocphiBL = new HocphiBL();
            LoadfeeData();
        }

        public void LoadfeeData()
        {
            try
            {
                List<HocphiDTO> tuitionList = hocphiBL.GetAllTuitionInfo();
                dataGridViewFee.DataSource = tuitionList;

                // Tùy chỉnh tiêu đề cột
                if (dataGridViewFee.Columns.Count > 0)
                {
                    dataGridViewFee.Columns["StudentName"].HeaderText = "Tên Học Viên";
                    dataGridViewFee.Columns["CourseName"].HeaderText = "Tên Khóa Học";
                    dataGridViewFee.Columns["Fee"].HeaderText = "Học Phí";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách học phí: " + ex.Message);
                
            }
        }

    }
}
