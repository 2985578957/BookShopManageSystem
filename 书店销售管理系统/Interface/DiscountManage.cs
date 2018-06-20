using System;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class DiscountManage : Form
    {
        int level = 0;
        public DiscountManage()
        {
            InitializeComponent();
            dataGridView1.DataSource = Connector.ShowAllDiscounts().Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connector.ShowAllDiscounts().Tables[0].DefaultView;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (!CheckString.CheckUDouble(textBox1.Text) || !(Double.Parse(textBox1.Text) > 0 && (Double.Parse(textBox1.Text) <= 1)))
            {
                MessageBox.Show("请检查折扣是否为0-1的小数", "折扣填写错误");
            }
            else
                Connector.ChangeDiscount(level, textBox1.Text);
        }

        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {
            level = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            level = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            level = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            level = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            level = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            level = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            level = 6;
        }
    }
}
