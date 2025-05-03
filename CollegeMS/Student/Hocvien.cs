using CollegeMS.Student;
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
    public partial class Hocvien: Form
    {
        private Timer timer;
        public Hocvien()
        {
            InitializeComponent();
            LoadDateTime();
        }

        private void LoadDateTime()
        {
            label1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm", new CultureInfo("vi-VN"));
            timer = new Timer();
            timer.Interval = 60000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm", new CultureInfo("vi-VN"));
        }

        
        private void Hocvien_FormClosing(object sender, FormClosingEventArgs e) 
        {
            Application.Exit();
        }

        private void btndkkh_Click(object sender, EventArgs e)
        {
            UCStuDKKH dkkhControl = new UCStuDKKH();
            pncontentStu.Controls.Clear();
            pncontentStu.Controls.Add(dkkhControl);
            dkkhControl.Dock = DockStyle.Fill;
            MoveSidePanel(btndkkh);

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Enabled = false;
            loginForm loginForm = new loginForm();
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void btBaocaosuco_Click(object sender, EventArgs e)
        {
            UCStuBcao baocao = new UCStuBcao();
            pncontentStu.Controls.Clear();
            pncontentStu.Controls.Add(baocao);
            baocao.Dock = DockStyle.Fill;
            MoveSidePanel(btBaocaosuco);

        }

        private void bthocphi_Click(object sender, EventArgs e)
        {
            Xemhocphi xemhocphi = new Xemhocphi();
            pncontentStu.Controls.Clear();
            pncontentStu.Controls.Add(xemhocphi);
            xemhocphi.Dock = DockStyle.Fill;
            MoveSidePanel(bthocphi);

        }
        private void MoveSidePanel(Control button)
        {
            SlidePanel.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 113);
        }
    }
}
