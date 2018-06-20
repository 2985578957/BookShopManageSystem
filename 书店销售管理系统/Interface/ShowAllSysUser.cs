using System;
using System.Windows.Forms;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class ShowAllSysUser : Form
    {
        public ShowAllSysUser()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Connector.ShowAllSysUsers().Tables[0].DefaultView;
        }

        private void fresh_button_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Connector.ShowAllSysUsers().Tables[0].DefaultView;
        }
    }

  
}
