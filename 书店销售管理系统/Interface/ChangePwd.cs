using System;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class ChangePwd : Form
    {
        public ChangePwd()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (!Object.Equals(newpwd_textbox.Text, confimnewpwd_textbox.Text)){
                MessageBox.Show("原密码与新密码不符","修改密码失败");
            }
            else {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定?", "确认", messButton);
                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {
                    String oldpwd_sha1 = SecurityUnit.EncryptToSHA1(oldpwd_textbox.Text);
                    String newpwd_sha1 = SecurityUnit.EncryptToSHA1(newpwd_textbox.Text);
                    Connector.ChangeAdminPwd(oldpwd_sha1, newpwd_sha1);
                    this.Dispose();
                    this.Close();
                }
                else//如果点击“取消”按钮
                {
                    this.newpwd_textbox.Text = this.oldpwd_textbox.Text = this.confimnewpwd_textbox.Text = "";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                oldpwd_textbox.PasswordChar = '\0';
                newpwd_textbox.PasswordChar = '\0';
                confimnewpwd_textbox.PasswordChar = '\0';
            }
            else
            {
                oldpwd_textbox.PasswordChar = '*';
                newpwd_textbox.PasswordChar = '*';
                confimnewpwd_textbox.PasswordChar = '*';
            }
        }
    }
}
