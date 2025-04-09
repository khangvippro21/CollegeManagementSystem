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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CollegeMS
{
    public partial class accountUS : UserControl
    {
        public accountUS()
        {
            InitializeComponent();
        }

        private void accountUS_Load(object sender, EventArgs e)
        {
            UserBL a = new UserBL();
            DataTable dt = new DataTable();
            dt = a.viewUserTble();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, DataGridViewCellEventArgs e)
        {
            UserAccount a = new UserAccount();
            UserBL userBL = new UserBL();
            a.UserId = dataGridView1.Rows[e.RowIndex].ToString();
            userBL.deleteUser(a);
        }
        UserAccount acc = new UserAccount();
        private void button2_Click(object sender, EventArgs e)
        {
            //UserBL userBL = new UserBL();
            //userBL.deleteUser(acc);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
            //string nameid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //acc.UserId = nameid;            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserBL userBL = new UserBL();
            string UserId, UserPass;
            UserId = textBox1.Text.Trim();
            UserPass = textBox2.Text.Trim();
            UserAccount acc = new UserAccount(UserId, UserPass);
            if (userBL.insertUser(acc))
            {
                MessageBox.Show("Tao tai khoan thanh cong !!");
            }
            else
            {
                MessageBox.Show("Tai khoan da ton tai !!");
            }
            dataGridView1.DataSource = userBL.viewUserTble();
            
        }
    }
}
