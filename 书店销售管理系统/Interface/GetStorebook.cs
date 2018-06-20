using System;
using System.Windows.Forms;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class GetStorebook : Form
    {
        public GetStorebook()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Connector.SelectBookTable().Tables[0].DefaultView;
        }

        private void fresh_btn_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Connector.SelectBookTable().Tables[0].DefaultView;
        }
    }
}
