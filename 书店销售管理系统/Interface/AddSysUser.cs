using System;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class AddSysUser : Form
    {
        public AddSysUser()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Connector.ShowAllSysUsers().Tables[0].DefaultView;
        }

        private void fresh_button_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Connector.ShowAllSysUsers().Tables[0].DefaultView;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (CheckString.ChechPower(power_textBox.Text))
                Connector.AddNewSysUser(name_textBox.Text, SecurityUnit.EncryptToSHA1(pwd_textBox.Text), power_textBox.Text);
            else
                MessageBox.Show("权限仅限 管理员/进货员/销售员", "权限输入错误");
        }
    }
}
