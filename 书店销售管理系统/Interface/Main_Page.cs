using System;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;

namespace 书店销售管理系统.Interface
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
            label2.Text += (LoginInfo.LoginName + ":" + LoginInfo.Power);
            if (LoginInfo.Power.Equals("销售员"))
            {
                执行SQL语句ToolStripMenuItem.Enabled = false;
                变更图书价格ToolStripMenuItem.Enabled = false;
                折扣管理ToolStripMenuItem.Enabled = false;
                进货ToolStripMenuItem.Enabled = false;
                补货ToolStripMenuItem.Enabled = false;
                会员管理ToolStripMenuItem1.Enabled = false;
                添加系统用户ToolStripMenuItem.Enabled = false;

                执行SQL语句ToolStripMenuItem.Visible = false;
                变更图书价格ToolStripMenuItem.Visible = false;
                折扣管理ToolStripMenuItem.Visible = false;
                进货ToolStripMenuItem.Visible = false;
                补货ToolStripMenuItem.Visible = false;
                会员管理ToolStripMenuItem1.Visible = false;
                添加系统用户ToolStripMenuItem.Visible = false;
            }
            else if (LoginInfo.Power.Equals("进货员"))
            {
                记账ToolStripMenuItem.Enabled = false;
                会员管理ToolStripMenuItem.Enabled = false;
                会员管理ToolStripMenuItem1.Enabled = false;
                折扣管理ToolStripMenuItem.Enabled = false;
                获取信息ToolStripMenuItem.Enabled = false;
                添加系统用户ToolStripMenuItem.Enabled = false;

                记账ToolStripMenuItem.Visible = false;
                会员管理ToolStripMenuItem.Visible = false;
                会员管理ToolStripMenuItem1.Visible = false;
                折扣管理ToolStripMenuItem.Visible = false;
                获取信息ToolStripMenuItem.Visible = false;
                添加系统用户ToolStripMenuItem.Visible = false;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 记账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellWindow newPage = new SellWindow();
            newPage.Show();
        }

        private void 进货ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportNewBooks newPage = new ImportNewBooks();
            newPage.Show();
        }

        private void 补货ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replenishment newPage = new Replenishment();
            newPage.Show();
        }

        private void 获取图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetBookInfo newPage = new GetBookInfo();
            newPage.Show();
        }

        private void 获取仓库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetStorebook newPage = new GetStorebook();
            newPage.Show();
        }

        private void 查看销售列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSellList newPage = new GetSellList();
            newPage.Show();
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePwd newPage = new ChangePwd();
            newPage.ShowDialog();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 执行SQL语句ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuCustomStem newpage = new ExecuCustomStem();
            newpage.Show();
        } 
        private void 会员管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VipManage newpage = new VipManage();
            newpage.Show();
        }

        private void 获取会员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetVipInfoTable newpage = new GetVipInfoTable();
            newpage.Show();
        }
       

        private void 折扣管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscountManage newpage = new DiscountManage();
            newpage.Show();
        }


        private void 收入统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeStat newpage = new IncomeStat();
            newpage.Show();
        }

        private void 畅销书名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BestSellingBooks newpage = new BestSellingBooks();
            newpage.Show();
        }

        private void 变更图书价格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBookPrice newpage = new ChangeBookPrice();
            newpage.Show();
        }

        private void 查看所有用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllSysUser newpage = new ShowAllSysUser();
            newpage.Show();
        }

        private void 添加系统用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSysUser newpage = new AddSysUser();
            newpage.Show();
        }

        private void 发送优惠信息邮件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendDiscountEmails newpage = new SendDiscountEmails();
            newpage.Show();
        }
    }
}
