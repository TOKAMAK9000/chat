namespace chat
{
    partial class registWindow
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
            this.regist = new System.Windows.Forms.Button();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.NewUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regist
            // 
            this.regist.Location = new System.Drawing.Point(245, 286);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(75, 23);
            this.regist.TabIndex = 9;
            this.regist.Text = "注册";
            this.regist.UseVisualStyleBackColor = true;
            this.regist.Click += new System.EventHandler(this.regist_Click);
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(180, 176);
            this.NewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(216, 21);
            this.NewPassword.TabIndex = 6;
            this.NewPassword.Text = "请输入密码";
            // 
            // NewUsername
            // 
            this.NewUsername.Location = new System.Drawing.Point(180, 120);
            this.NewUsername.Margin = new System.Windows.Forms.Padding(2);
            this.NewUsername.Name = "NewUsername";
            this.NewUsername.Size = new System.Drawing.Size(216, 21);
            this.NewUsername.TabIndex = 5;
            this.NewUsername.Text = "请输入用户名";
            this.NewUsername.Click += new System.EventHandler(this.NewUsername_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("黑体", 23F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(210, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "扣扣注册";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regist);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.NewUsername);
            this.Name = "registWindow";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regist;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox NewUsername;
        private System.Windows.Forms.Label label1;
    }
}