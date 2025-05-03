using BusinessLayer;
using BusinessLayer.chung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CollegeMS
{
    public partial class loginForm : Form
    {
        UserBL login = new UserBL();
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            Hocvien hv = new Hocvien();
            Giangvien gv = new Giangvien();
            string UserId, UserPass; 
            UserId = txtUsername.Text.Trim();
            UserPass = txtPassword.Text.Trim();
            UserAccount acc = new UserAccount(UserId, UserPass);
            bool b = true;
            try
            {
                b = login.LoginBL(acc);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (b)
            {
                SessionManager.Instance.UserId = UserId;
                switch (acc.UserRole)
                {
                    case "student":
                        hv.Show();
                        return;
                    case "lecturer":
                        gv.Show();
                        return;
                    case "admin":
                        this.DialogResult = DialogResult.OK;
                        return;
                }
            }
            else
            {
                string msg = "Username or Password is incorrect !";
                DialogResult result = MessageBox.Show(msg, "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    txtUsername.Focus();
                }
            }
        }
        private void closeBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; 
            }
            else
            {
                txtPassword.PasswordChar = '*'; 
            }
        }
    }
}
