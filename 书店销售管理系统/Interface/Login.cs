using System;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            String name;
            String pwd_sha1;
            name = AdminName_TextBox.Text;
            pwd_sha1 = SecurityUnit.EncryptToSHA1(AdminPwd_TextBox.Text);
            if(Object.Equals(pwd_sha1, Connector.Get_Pwd(name)))
            {
                MessageBox.Show("登陆成功");
                LoginInfo.LoginName = name;
                LoginInfo.Power = Connector.GetPower(name);
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误");
            }
        }

        private void setarg_btn_Click(object sender, EventArgs e)
        {
            SetArgs newpage = new SetArgs();
            newpage.ShowDialog();
        }
    }
}
