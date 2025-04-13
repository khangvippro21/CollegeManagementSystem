using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace CollegeMS
{
    public partial class UserMainForm : Form
    {
        private UserControlFee userControlHocphi;
        public UserMainForm()
        {
            InitializeComponent();
        }
        private void UserMainForm_Load(object sender, EventArgs e)
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
            dashboardUS1.Visible = true;
            userControlFee1.Visible = false;
            userControlStudents1.Visible = false;
            accountUS2.Visible = false;
            lbloaichucnang.Text = btDashboard.Text;
        }
        
        private void btQLHV_Click(object sender, EventArgs e)
        {
            dashboardUS1.Visible = false;
            userControlFee1.Visible = false;
            userControlStudents1.Visible = true;
            accountUS2.Visible = false;
            lbloaichucnang.Text = btQLHV.Text;
        }
        //Moi them vao
        private void btDashboard_Click(object sender, EventArgs e)
        {
            dashboardUS1.Visible = true;
            userControlFee1.Visible = false;
            userControlStudents1.Visible = false;
            accountUS2.Visible = false;
            lbloaichucnang.Text = btDashboard.Text;
        }

        private void btQLHP_Click(object sender, EventArgs e)
        {
            dashboardUS1.Visible = false;
            userControlFee1.Visible = true;
            userControlStudents1.Visible = false;
            accountUS2.Visible = false;
            lbloaichucnang.Text = btQLHP.Text;
        }
        private void btQLTK_Click(object sender, EventArgs e)
        {
            accountUS2.Visible = true;
            dashboardUS1.Visible = false;
            userControlFee1.Visible = false;
            userControlStudents1.Visible = false;
            lbloaichucnang.Text = btQLTK.Text;
        }
        private void UserMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
