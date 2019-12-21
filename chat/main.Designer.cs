namespace chat
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accountContent = new System.Windows.Forms.Label();
            this.nameContent = new System.Windows.Forms.Label();
            this.personalInfo = new System.Windows.Forms.Button();
            this.m_treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "--------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "账号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "昵称：";
            // 
            // accountContent
            // 
            this.accountContent.AutoSize = true;
            this.accountContent.Location = new System.Drawing.Point(115, 23);
            this.accountContent.Name = "accountContent";
            this.accountContent.Size = new System.Drawing.Size(17, 12);
            this.accountContent.TabIndex = 3;
            this.accountContent.Text = "  ";
            // 
            // nameContent
            // 
            this.nameContent.AutoSize = true;
            this.nameContent.Location = new System.Drawing.Point(115, 56);
            this.nameContent.Name = "nameContent";
            this.nameContent.Size = new System.Drawing.Size(17, 12);
            this.nameContent.TabIndex = 4;
            this.nameContent.Text = "  ";
            // 
            // personalInfo
            // 
            this.personalInfo.Location = new System.Drawing.Point(92, 99);
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(102, 23);
            this.personalInfo.TabIndex = 5;
            this.personalInfo.Text = "查看个人信息";
            this.personalInfo.UseVisualStyleBackColor = true;
            // 
            // m_treeView
            // 
            this.m_treeView.Location = new System.Drawing.Point(23, 169);
            this.m_treeView.Name = "m_treeView";
            this.m_treeView.Size = new System.Drawing.Size(231, 347);
            this.m_treeView.TabIndex = 6;
            this.m_treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.m_treeView_NodeMouseDoubleClick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.ControlBox = false;
            this.Controls.Add(this.m_treeView);
            this.Controls.Add(this.personalInfo);
            this.Controls.Add(this.nameContent);
            this.Controls.Add(this.accountContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "temp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label accountContent;
        private System.Windows.Forms.Label nameContent;
        private System.Windows.Forms.Button personalInfo;
        private System.Windows.Forms.TreeView m_treeView;
    }
}

