using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeMS
{
    public partial class loadingForm : Form
    {
        public loadingForm()
        {
            InitializeComponent();
        }

        private void loadingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UserMainForm a = new UserMainForm();
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 20;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                a.Show();
            }
        }
    }
}
