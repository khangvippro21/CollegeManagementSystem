using BusinessLayer;
using BusinessLayer.Khang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TransferObject;


namespace CollegeMS
{
    public partial class dashboardUS : UserControl
    {
        public dashboardUS()
        {
            InitializeComponent();
        }

        private void dashboardUS_Load(object sender, EventArgs e)
        {
            //Chart
            AttendanceBL a = new AttendanceBL();
            DataTable dt = a.getData();
            foreach (DataRow row in dt.Rows)
            {
                string courseName = row["CId"].ToString();
                int studentCount = Convert.ToInt32(row["StudentCount"]);
                chart1.Series["attendance"].Points.AddXY(courseName, studentCount);
            }

            //Label
            StudentTble_BL st = new StudentTble_BL();
            LeTble_BL le = new LeTble_BL();
            CoTble_BL co = new CoTble_BL();
            RvTble_BL rv = new RvTble_BL();

            lbNumhv.Text = st.NumofStd().ToString();
            lbNumgv.Text = le.NumofLe().ToString();
            lbNumKh.Text = co.NumofCourse().ToString();  
            lbNumRv.Text = rv.NumofRview().ToString();
        }
    }
}
