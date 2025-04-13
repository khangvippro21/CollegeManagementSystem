using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeMS
{
    public partial class UCStuBcao: UserControl
    {
        public UCStuBcao()
        {
            InitializeComponent();
        }

        private void UCStuBcao_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbKhoahoc.DisplayMember = "CName";
            cbbKhoahoc.ValueMember = "CId";
            //cbbKhoahoc.DataSource = courseList; // List<CourseDTO>
        }
    }
}
