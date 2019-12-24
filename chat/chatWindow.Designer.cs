namespace chat
{
    partial class chatWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.chatLog = new System.Windows.Forms.Label();
            this.localMessage = new System.Windows.Forms.TextBox();
            this.selectFile = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.viewChat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "----";
            // 
            // chatLog
            // 
            this.chatLog.AutoSize = true;
            this.chatLog.Location = new System.Drawing.Point(555, 9);
            this.chatLog.Name = "chatLog";
            this.chatLog.Size = new System.Drawing.Size(137, 12);
            this.chatLog.TabIndex = 1;
            this.chatLog.Text = "这里会用来显示消息记录";
            // 
            // localMessage
            // 
            this.localMessage.Location = new System.Drawing.Point(28, 354);
            this.localMessage.Multiline = true;
            this.localMessage.Name = "localMessage";
            this.localMessage.Size = new System.Drawing.Size(498, 100);
            this.localMessage.TabIndex = 2;
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(28, 460);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(75, 23);
            this.selectFile.TabIndex = 3;
            this.selectFile.Text = "选择文件";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(451, 460);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 4;
            this.send.Text = "发送";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // viewChat
            // 
            this.viewChat.Location = new System.Drawing.Point(28, 12);
            this.viewChat.Name = "viewChat";
            this.viewChat.ReadOnly = true;
            this.viewChat.Size = new System.Drawing.Size(499, 319);
            this.viewChat.TabIndex = 5;
            this.viewChat.Text = "";
            // 
            // chatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 491);
            this.Controls.Add(this.viewChat);
            this.Controls.Add(this.send);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.localMessage);
            this.Controls.Add(this.chatLog);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "chatWindow";
            this.Text = "chatWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chatLog;
        private System.Windows.Forms.TextBox localMessage;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.RichTextBox viewChat;
    }
}