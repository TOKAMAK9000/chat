using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat
{
    public partial class registWindow : Form
    {
        public registWindow()
        {
            InitializeComponent();
        }

   
        private void NewUsername_Click(object sender, EventArgs e)
        {
            NewUsername.Text = "";
        }
        private void NewPassword_Click(object sender, EventArgs e)
        {
            NewPassword.Text = "";
        }

        private void regist_Click(object sender, EventArgs e)
        {
            user newUser = new user();
            newUser.userName = NewUsername.Text;
            newUser.password = NewPassword.Text;

            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox textBox = (TextBox)ctr;
                    textBox.Text = "";
                }
            }
            if (newUser.userName == "请输入用户名" || newUser.password == "请输入密码" ||  newUser.userName == "" || newUser.password == "" )
            {
                MessageBox.Show("请输入注册信息！");
                NewUsername.Text = "请输入用户名";
                NewPassword.Text = "请输入密码";
                return;
            }
        }
    }
}
