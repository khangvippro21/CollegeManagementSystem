using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CollegeMS
{
    public partial class accountUS : UserControl
    {
        public accountUS()
        {
            InitializeComponent();
        }
        public void dataload()
        {
            UserBL a = new UserBL();
            DataTable dt = new DataTable();
            dt = a.viewUserTble();
            dataGridView1.DataSource = dt;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;
            }
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void accountUS_Load(object sender, EventArgs e)
        {
            dataload();
        }

        UserAccount acc = new UserAccount();
        private void button2_Click(object sender, EventArgs e)
        {
            UserAccount a = new UserAccount();
            UserBL userBL = new UserBL();
            a.UserId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show(
                "Do you want to delete user " + a.UserId,
                "Warning! ",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                userBL.deleteUser(a);
                MessageBox.Show("Deleted !!!");
            }
            dataload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill input !!! ");
            }
            else
            {
                UserBL userBL = new UserBL();
                string UserId, UserPass;
                UserId = textBox1.Text.Trim();
                UserPass = textBox2.Text.Trim();
                UserAccount acc = new UserAccount(UserId, UserPass);
                if (userBL.insertUser(acc))
                {
                    MessageBox.Show("User created successfully !!!");
                }
                else
                {
                    MessageBox.Show("User already exists !!!");
                }
                dataload();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserBL userBL = new UserBL();
            string UserId, UserPass;
            UserId = txtUsername2.Text.Trim();
            if (txtNewPass.Text == "" || txtNewpass2.Text == "")
            {
                MessageBox.Show("Please fill all inputs !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNewPass.Text == txtNewpass2.Text)
            {
                UserPass = txtNewpass2.Text.Trim();
                UserAccount acc = new UserAccount(UserId, UserPass);
                if (userBL.changePass(acc))
                {
                    MessageBox.Show("Password changed successfully !!!");
                }
                dataload();
            }
            else
            {
                MessageBox.Show("Passwords do not match !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewpass2.Focus();
                return;
            }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtUsername2.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
            }
            else
            {
                txtUsername2.Text = "";
            }
        }
    }
}
