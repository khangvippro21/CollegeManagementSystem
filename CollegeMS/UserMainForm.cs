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
using BusinessLayer;

namespace CollegeMS
{
    public partial class UserMainForm : Form
    {


        private UserControlFee userControlHocphi;

        public UserMainForm()
        {
            InitializeComponent();
            pnContentStu.Dock = DockStyle.Fill;

          
        }
        private void UserMainForm_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;
            loginForm loginForm = new loginForm();
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled=true;
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
            UserControlStudent studentControl = new UserControlStudent();
            studentControl.Dock = DockStyle.Fill;
            pnContentStu.Controls.Add(studentControl);       
            pnContentStu.BringToFront();
        }

        private void btQLHP_Click(object sender, EventArgs e)
        {
            pnContentStu.Controls.Clear();
            userControlHocphi = new UserControlFee();
            pnContentStu.Controls.Add(userControlHocphi);
            pnContentStu.BringToFront();


        }

       
    }
}
