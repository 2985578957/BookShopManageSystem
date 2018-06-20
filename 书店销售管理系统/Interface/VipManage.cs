using System;
using System.Data;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class VipManage : Form
    {
        int mode = 1;
        DataTable dt;
        public VipManage()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = Connector.SelectVipTTable().Tables[0].DefaultView;
            num_textbox.Text = Connector.GetNewVipNum();
            button1.Visible = false;
            button1.Enabled = false;
            num_textbox.Enabled = false;
            name_textbox.Enabled = true;
            pwd_textbox.Enabled = true;
            phone_textbox.Enabled = true;
            mail_textbox.Enabled = true;
            level_textbox.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            num_textbox.Text = "";
            name_textbox.Text = "";
            pwd_textbox.Text = "";
            phone_textbox.Text = "";
            mail_textbox.Text = "";
            level_textbox.Text = "";

            mode = 1;//添加
            this.dataGridView1.DataSource = Connector.SelectVipTTable().Tables[0].DefaultView;
            num_textbox.Text = Connector.GetNewVipNum();
            button1.Visible = false;
            button1.Enabled = false;
            num_textbox.Enabled = false;
            name_textbox.Enabled = true;
            pwd_textbox.Enabled = true;
            phone_textbox.Enabled = true;
            mail_textbox.Enabled = true;
            level_textbox.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            num_textbox.Text = "";
            name_textbox.Text = "";
            pwd_textbox.Text = "";
            phone_textbox.Text = "";
            mail_textbox.Text = "";
            level_textbox.Text = "";

            mode = 2;//升级
            dt=Connector.SelectVipTTable().Tables[0];
            this.dataGridView1.DataSource = dt.DefaultView;
            button1.Visible = true;
            button1.Enabled = true;
            num_textbox.Enabled = true;
            name_textbox.Enabled = false;
            pwd_textbox.Enabled = false;
            phone_textbox.Enabled = false;
            mail_textbox.Enabled = false;
            level_textbox.Enabled = false;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            num_textbox.Text = "";
            name_textbox.Text = "";
            pwd_textbox.Text = "";
            phone_textbox.Text = "";
            mail_textbox.Text = "";
            level_textbox.Text = "";

            mode = 3;//修改
            dt = Connector.SelectVipTTable().Tables[0];
            this.dataGridView1.DataSource = dt.DefaultView;
            button1.Visible = true;
            button1.Enabled = true;
            num_textbox.Enabled = true;
            name_textbox.Enabled = true;
            pwd_textbox.Enabled = true;
            phone_textbox.Enabled = true;
            mail_textbox.Enabled = true;
            level_textbox.Enabled = false;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            String pwd_sha1 = SecurityUnit.EncryptToSHA1(pwd_textbox.Text);
            if (mode == 1)
            {
                Connector.AddNewVip(num_textbox.Text, name_textbox.Text, pwd_sha1, phone_textbox.Text, mail_textbox.Text);
                num_textbox.Text = Connector.GetNewVipNum();
                this.dataGridView1.DataSource = Connector.SelectVipTTable().Tables[0].DefaultView;
                name_textbox.Text = "";
                pwd_textbox.Text = "";
                phone_textbox.Text = "";
                mail_textbox.Text = "";
            }
            else if (mode == 2)
            {
                if (!CheckString.CheckUInt(num_textbox.Text))
                    MessageBox.Show("编号填写错误", "编号错误");
                else
                {
                    Connector.UpgradeVipLevel(num_textbox.Text);
                    this.dataGridView1.DataSource = Connector.SelectVipTTable().Tables[0].DefaultView;
                    for (int i = 0; i < dt.Rows[0].ItemArray.Length; i++)
                    {
                        if (dt.Rows[i].ItemArray[0].ToString().Equals(num_textbox.Text))
                        {
                            name_textbox.Text = dt.Rows[i].ItemArray[1].ToString();
                            pwd_textbox.Text = dt.Rows[i].ItemArray[2].ToString();
                            phone_textbox.Text = dt.Rows[i].ItemArray[3].ToString();
                            mail_textbox.Text = dt.Rows[i].ItemArray[4].ToString();
                            level_textbox.Text = dt.Rows[i].ItemArray[5].ToString();
                            break;
                        }
                    }
                    num_textbox.Enabled = false;
                }
            }
            else if (mode == 3)
            {
                Connector.ChangeVipInfo(num_textbox.Text, name_textbox.Text, pwd_sha1, phone_textbox.Text, mail_textbox.Text);
                this.dataGridView1.DataSource = Connector.SelectVipTTable().Tables[0].DefaultView;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckString.CheckUInt(num_textbox.Text))
                MessageBox.Show("编号填写错误","编号错误");
            else
            {
                for (int i = 0; i < dt.Rows[0].ItemArray.Length; i++)
                {
                    if (dt.Rows[i].ItemArray[0].ToString().Equals(num_textbox.Text))
                    {
                        name_textbox.Text = dt.Rows[i].ItemArray[1].ToString();
                        pwd_textbox.Text = dt.Rows[i].ItemArray[2].ToString();
                        phone_textbox.Text = dt.Rows[i].ItemArray[3].ToString();
                        mail_textbox.Text = dt.Rows[i].ItemArray[4].ToString();
                        level_textbox.Text = dt.Rows[i].ItemArray[5].ToString();
                        break;
                    }
                }
                num_textbox.Enabled = false;
            }
        }
    }
}
