using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AgreeBtn_Click(object sender, EventArgs e)
        {
            if (AccountNameTxt.Text != "Admin")
                MessageBox.Show("Tên Đăng nhập Sai!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if(PasswordTxt.Text != "Admin")
                MessageBox.Show("Mật khẩu Sai!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                this.Hide();
                Form2 StudentInfo = new Form2();
                StudentInfo.Show();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
