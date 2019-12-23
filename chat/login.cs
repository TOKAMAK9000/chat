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
    public partial class loginWindow : Form
    {
        
        public loginWindow()
        {
            InitializeComponent();
            
        }


        private void regist_Click(object sender, EventArgs e)
        {
            Form regist = new registWindow();
            regist.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Visible = false;
            Form main = new main();
            main.Visible = true;
        }
    }
}
