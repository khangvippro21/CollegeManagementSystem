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
            LoadChart2();
            
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
            chartHocphi.Titles.Add("Tỉ lệ học phí từng môn học");
          
            
        }

        private void LoadChart2()
        {
            HocphiBL hocphiBbl = new HocphiBL();
            DataTable data = hocphiBbl.GetFeeDataByCourse(); 

         
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

          
            chart1.Legends.Add(new Legend("Legend")
            {
                Title = "Các môn học",
                Docking = Docking.Bottom, 
                Alignment = StringAlignment.Center 
            });

           
            Series series = new Series("Tổng Học Phí")
            {
                ChartType = SeriesChartType.Column, 
                IsValueShownAsLabel = true, 
                Color = Color.Blue 
            };

            foreach (DataRow row in data.Rows)
            {
                string courseName = row["CourseName"].ToString(); 
                double totalFee = Convert.ToDouble(row["TotalFee"]); 

                series.Points.AddXY(courseName, totalFee); 
            }

           
            chart1.Series.Add(series);

            
            chart1.Titles.Add(new Title("Tổng học phí theo môn học")
            {
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.DarkBlue
            });

            
            chart1.ChartAreas[0].AxisX.Title = "Môn học";
            chart1.ChartAreas[0].AxisY.Title = "Tổng học phí (VNĐ)";
            chart1.ChartAreas[0].AxisX.Interval = 1; 
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; 
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

