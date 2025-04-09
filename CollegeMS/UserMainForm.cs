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
                this.Enabled=true;
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
        private void UserMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btQLHV_Click(object sender, EventArgs e)
        {
            pnContentStu.Controls.Clear();
            UserControlStudents studentControl = new UserControlStudents();
            studentControl.Dock = DockStyle.Fill;
            pnContentStu.Controls.Add(studentControl);
            pnContentStu.BringToFront();
            pnContentStu.Show();
        }
        //Moi them vao
        private void btDashboard_Click(object sender, EventArgs e)
        {
            pnContentStu.Hide();
        }

        private void btQLHP_Click(object sender, EventArgs e)
        {
            pnContentStu.Controls.Clear();
            userControlHocphi = new UserControlFee();
            pnContentStu.Controls.Add(userControlHocphi);
            pnContentStu.BringToFront();
            //pnContentStu.Show();
        }
    }
}
