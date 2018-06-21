using System;
using System.Windows.Forms;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class VipSumBuy : Form
    {
        public VipSumBuy()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Connector.SelectVipSumBuy(textBox1.Text.Trim()).Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Connector.SelectVipSumBuy(textBox1.Text.Trim()).Tables[0].DefaultView;
        }
    }
}
