using BusinessLayer.Bao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeMS.Admin
{
    public partial class UserControlDanhGia : UserControl
    {
        private ReviewBL reviewbl = new ReviewBL();
        public UserControlDanhGia()
        {
            InitializeComponent();
            loadReview();
        }
        public void loadReview()
        {
            try
            {
                dgvDanhGia.DataSource = reviewbl.getReview();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
    }
}
