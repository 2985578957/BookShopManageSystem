using System;
using System.Windows.Forms;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class SetArgs : Form
    {
        public SetArgs()
        {
            InitializeComponent();
            Connector.MODE = 0;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            String name = name_textbox.Text;
            String user = user_textbox.Text;
            String pwd = pwd_textbox.Text;

            if (Object.Equals(name, "") || Object.Equals(user, "") || Object.Equals(pwd, ""))
            {
                MessageBox.Show("数据源、用户名、密码均不为空！！", "警告");
            }
            else
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("数据源："+name+"\n用户名："+user+"\n密码："+pwd+"\n确定?", "确认提交", messButton);
                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {
                    Connector.MODE = radioButton1.Checked?0:1;
                    if (Connector.TestConn(name, user, pwd))
                    {
                        Connector.SetArgs(name, user, pwd);
                        MessageBox.Show("连接成功");
                        this.Dispose();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("连接失败");
                        name_textbox.Text = "";
                        user_textbox.Text = "";
                        pwd_textbox.Text = "";
                    }
                }
                else//如果点击“取消”按钮
                {
                    name_textbox.Text = "";
                    user_textbox.Text = "";
                    pwd_textbox.Text = "";
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "ODBC数据源名称：";
            label4.Text = "默认值：BookShop2";
            Connector.MODE = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "数据库名称：";
            label4.Text = "默认值：BookShop";
            Connector.MODE = 1;
        }
    }
}
