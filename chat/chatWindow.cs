using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace chat
{
    public partial class chatWindow : Form
    {
        public chatWindow()
        {
            InitializeComponent();
        }

        private System.Drawing.Image changePicZize(string path)
        {
            System.Drawing.Image imgToResize = Image.FromFile(user.mUser.currentSendingPic);
            //获取图片宽度
            int sourceWidth = imgToResize.Width;
            //获取图片高度
            int sourceHeight = imgToResize.Height;

            double nPercent = 0;
            double nPercentW = 0;
            double nPercentH = 0;
            //计算宽度的缩放比例
            nPercentW = (350.0 / (double)sourceWidth);
            //计算高度的缩放比例
            nPercentH = (350.0 / (double)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //期望的宽度
            int destWidth = (int)(sourceWidth * nPercent);
            //期望的高度
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //绘制图像
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return b;

        }

        private void send_Click(object sender, EventArgs e)
        {
            
            string time;
            if (user.mUser.currentSendingPic != "")
            {
                
                user.mUser.currentSending = localMessage.Text;
                time = DateTime.Now.ToString();
                user.mUser.messageLog.Add(time);

                viewChat.Text = viewChat.Text + "\r\nme " + time + "\r\n";


                Image pic = changePicZize(user.mUser.currentSendingPic);

                Clipboard.SetDataObject(pic, false);
                viewChat.ReadOnly = false;
                viewChat.Paste();
                viewChat.ReadOnly = true;

                user.mUser.currentSendingPic = "";
                return;

            }

            if (localMessage.Text == "")
            {
                return;
            }
            
            user.mUser.currentSending = localMessage.Text;
            time = DateTime.Now.ToString();
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
                 user.mUser.currentSendingPic = fileDialog.FileName;//返回文件的完整路径                
            }







        }
    }
    
}
