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
using System.Windows.Forms.DataVisualization.Charting;

namespace CollegeMS
{
    public partial class UserControlFee: UserControl
    {
        private HocphiBL hocphiBL;

        public UserControlFee()
        {
            InitializeComponent();
            LoadChart();
            
        }

        private void LoadChart()
        {
            HocphiBL hocphiBbl = new HocphiBL();
            DataTable data = hocphiBbl.GetFeeDataByCourse();
        
            chartHocphi.Series.Clear();
            Series series = new Series("Học phí")
            {
                ChartType = SeriesChartType.Bar
            };

          
            foreach (DataRow row in data.Rows)
            {
                string coursesname = row["CourseName"].ToString();
                double totalfee = Convert.ToDouble(row["TotalFee"]);
                series.Points.AddXY(coursesname, totalfee);
            }

            chartHocphi.Series.Add(series);
            chartHocphi.Titles.Add("Tổng học phí theo môn học");
            chartHocphi.ChartAreas[0].AxisX.Title = "Môn học";
            chartHocphi.ChartAreas[0].AxisY.Title = "Tổng học phí (VNĐ)";
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

