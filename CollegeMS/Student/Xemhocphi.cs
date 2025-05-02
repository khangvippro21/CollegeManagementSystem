using BusinessLayer;
using BusinessLayer.Bao;
using BusinessLayer.chung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeMS.Student
{
    public partial class Xemhocphi : UserControl
    {
        private DKKHBL dkkhbl = new DKKHBL();
        private DataTable dshocphi = new DataTable();
        private  HocphiBL hocphiBL = new HocphiBL();
        public Xemhocphi()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadDsHocphi();
            
        }

        private void InitializeDataGridView()
        {
            dshocphi.Columns.Add("CId", typeof(string));
            dshocphi.Columns.Add("CourseName", typeof(string));
            dshocphi.Columns.Add("LecturerName", typeof(string));
            dshocphi.Columns.Add("StartDate", typeof(DateTime));
            dshocphi.Columns.Add("EndDate", typeof(DateTime));
            dshocphi.Columns.Add("CCredits", typeof(int));
            dshocphi.Columns.Add("FeePerCredit", typeof(decimal));
            dshocphi.Columns.Add("TotalFee", typeof(decimal));

            dgvdshocphi.DataSource = dshocphi;
            dgvdshocphi.AutoGenerateColumns = false;
            dgvdshocphi.AllowUserToAddRows = false;
        }

        private void LoadDsHocphi()
        {
            string studentId = SessionManager.Instance.UserId;
            DataTable dt = dkkhbl.laydsmonhocdadangky(studentId);
            dgvdshocphi.DataSource = dt;
            dgvdshocphi.Columns["CourseName"].HeaderText = "Tên Môn Học";
            dgvdshocphi.Columns["LecturerName"].HeaderText = "Tên Giảng Viên";
            dgvdshocphi.Columns["CId"].HeaderText = "Mã Môn Học";
            dgvdshocphi.Columns["TotalFee"].HeaderText = "Tổng Học Phí";
            dgvdshocphi.Columns["StartDate"].HeaderText = "Ngày bắt đầu";
            dgvdshocphi.Columns["EndDate"].HeaderText = "Ngày kết thúc";
            dgvdshocphi.Columns["CCredits"].HeaderText = "Số tín chỉ";
            dgvdshocphi.Columns["FeePerCredit"].HeaderText = "Số tiền mỗi tín";
            if (string.IsNullOrEmpty(studentId))
            {
                txttongph.Text = "0";
                return;
            }

            decimal totalFee = hocphiBL.tonghpsinhvien(studentId);
            txttongph.Text = totalFee.ToString();
        }

        
    }
}
