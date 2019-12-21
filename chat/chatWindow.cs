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
    public partial class chatWindow : Form
    {
        public chatWindow()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (localMessage.Text == "")
            {
                return;
            }
            string time;
            user.mUser.currentSending = localMessage.Text;
            time = DateTime.Now.ToLongTimeString().ToString();
            user.mUser.messageLog.Add(time);

            viewChat.Text = viewChat.Text + "\r\nme " + time + "\r\n";
            viewChat.Text = viewChat.Text + user.mUser.currentSending + "\r\n";
            localMessage.Text = "";
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "(*.jpg)|*.jpg|(*.png)|*.png"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;//返回文件的完整路径                
            }
        }
    }
}
