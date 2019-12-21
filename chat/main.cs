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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            m_treeView_Load();
            this.Text = "";
        }

        private void m_treeView_Load()
        {
            ////建立三个父节点
            //TreeNode f1 = treeView.Nodes.Add("姓名");

            ////建立姓名子节点
            //TreeNode NameS1 = new TreeNode("Hablee");

            ////将姓名子节点加到姓名父节点上去
            //f1.Nodes.Add(NameS1);

            //DataTable friendsData = new DataTable();
            //DataTable groupsData = new DataTable();
            
            TreeNode friends = new TreeNode();
            friends.Name = "friends";
            friends.Text = "好友";

            TreeNode groups = new TreeNode();
            groups.Name = "groups";
            groups.Text = "群组";

           
            string[] fridensDataset = { "friend1",
                                        "friend2"};

            string[] groupsDataset = { "group1",
                                       "group2"};

            foreach (string item in fridensDataset)
            {
                TreeNode tempFriend = new TreeNode();
                tempFriend.Text = item;
                //m_treeView.Nodes["friends"].Nodes.Add(tempFriend);
                friends.Nodes.Add(tempFriend);
            }

            foreach (string item in groupsDataset)
            {
                TreeNode tempGroup = new TreeNode();
                tempGroup.Text = item;
                groups.Nodes.Add(tempGroup);
            }
            m_treeView.Nodes.Add(friends);
            m_treeView.Nodes.Add(groups);

            //m_treeView.ExpandAll();
        }

        private void m_treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode currentNode = e.Node;
            Form chat = new chatWindow();
            chat.Show();
            chat.Text = currentNode.Text;
        }
    }
}
