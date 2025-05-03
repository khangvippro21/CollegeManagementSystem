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
using BusinessLayer;
using BusinessLayer.Bao;

namespace CollegeMS
{
    public partial class UserControlXemSuCo : UserControl
    {
        private BaocaoBL baobl=new BaocaoBL();
        DataTable dt = new DataTable();


        public UserControlXemSuCo()
        {
            InitializeComponent();
            loadbaocao();
        }

        public void loadbaocao()
        {
            try
            {
                dgvBaoCaoSuCo.DataSource = baobl.getallBaoCao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
}
    }
}
