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
            chartHocphi.Titles.Clear();
            chartHocphi.Legends.Clear();

            chartHocphi.Legends.Add(new Legend("Legend"));

            Series series = new Series("Học phí")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = false,
                LegendText = "#VALX"
            };

            foreach (DataRow row in data.Rows)
            {
                string coursesname = row["CourseName"].ToString();
                double totalfee = Convert.ToDouble(row["TotalFee"]);
                DataPoint point = new DataPoint(0, totalfee)
                {
                    AxisLabel = "", // Không hiện tên trên miếng
                    Label = "",     // Không hiện label
                    LabelForeColor = Color.Transparent // ❗ Ẩn hẳn chữ bằng cách này
                };
                point.LegendText = coursesname; // Dùng cho legend
                series.Points.Add(point);
            }

            chartHocphi.Series.Add(series);
            chartHocphi.Titles.Add("Tổng học phí theo môn học");
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

        private void chartHocphi_Click(object sender, EventArgs e)
        {

        }
    }
}

