using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //登录按钮
        private void login_btn_Click(object sender, EventArgs e)
        {
            //先不管直接跳
            //MainForm mainForm = new MainForm();
           // this.Close();
            //Program.mainForm.Show();
            Program.isSuccess = true;
            this.Close();
        }

        //取消按钮
        private void cancel_txt_Click(object sender, EventArgs e)
        {
            username_txt.Text = string.Empty;
            password_txt.Text = string.Empty;
        }
    }
}
