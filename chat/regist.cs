using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace chat
{
    public partial class registWindow : Form
    {
        public registWindow()
        {
            InitializeComponent();
        }



        private void regist_Click(object sender, EventArgs e)
        {
            user newUser = new user();
            newUser.userName = NewUsername.Text;
            newUser.password = NewPassword.Text;



            registInfo reg = new registInfo();
            reg.userName = NewUsername.Text;
            reg.password = NewPassword.Text;
            string postRegistMessage = JsonConvert.SerializeObject(reg);
            string getRes;

            m_socket registSocket = new m_socket();
            getRes=registSocket.message(postRegistMessage);
            MessageBox.Show(getRes);

            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox textBox = (TextBox)ctr;
                    textBox.Text = "";
                }
            }
            if (newUser.userName == "请输入用户名" || newUser.password == "请输入密码" || newUser.userName == "" || newUser.password == "")
            {
                MessageBox.Show("请输入注册信息！");
                NewUsername.Text = "请输入用户名";
                NewPassword.Text = "请输入密码";
                return;
            }
        }

        private void NewUsername_MouseClick(object sender, MouseEventArgs e)
        {
            NewUsername.Text = "";
        }

        private void NewPassword_MouseClick(object sender, MouseEventArgs e)
        {
            NewPassword.Text = "";
        }
    }
}
