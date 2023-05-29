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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //终止程序
            Application.Exit();
        }
        
        //模态对话框下的关于我们
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.TopLevel = true;//顶级窗口才能是模态的 否则会抛出异常 System.InvalidOperationException:“非顶级窗体不能显示为模式对话框。在调用 showDialog 之前应从所有父窗体中移除该窗体。”
            //aboutUs.MdiParent = this;
            aboutUs.ShowDialog();
        }

        //打开添加收支项目
        private void addIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddIncome addIncome = new AddIncome();
            addIncome.MdiParent = this;
            addIncome.Show();
        }

        //用户管理?
        private void userManToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserMan addUserMan = new UserMan();
            addUserMan.MdiParent = this;
            addUserMan.Show();
        }

        //添加收支和之前的添加收支项目有啥区别 就当没区别吧
        private void 添加收支ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddIncome addIncome = new AddIncome();
            addIncome.MdiParent = this;
            addIncome.Show();
        }

        private void 统计查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query query = new Query();//统计查询
            query.MdiParent = this;
            query.Show();
        }
    }
}
