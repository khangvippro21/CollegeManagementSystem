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
            
        }

        private void UserControlFee_Load(object sender, EventArgs e)
        {
            try
            {
                HocphiBL a = new HocphiBL();
                dataGridViewFee.DataSource = a.gethocphi();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách học phí: " + ex.Message);

            }
        }
    }
}

