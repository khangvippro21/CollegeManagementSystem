using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeMS
{
    public partial class lecturerForm: Form
    {
        private Timer timer;
        public lecturerForm()
        {
            InitializeComponent();
            LoadDateTime();
        }
        private void LoadDateTime()
        {
            lbDatetime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm", new CultureInfo("vi-VN"));
            timer = new Timer();
            timer.Interval = 60000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbDatetime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm", new CultureInfo("vi-VN"));
        }

        private void Giangvien_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndkkh_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btdanhgia_Click(object sender, EventArgs e)
        {

        }
    }
}
