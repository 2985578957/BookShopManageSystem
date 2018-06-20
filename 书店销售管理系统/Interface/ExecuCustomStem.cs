using System;
using System.Windows.Forms;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class ExecuCustomStem : Form
    {
        public ExecuCustomStem()
        {
            InitializeComponent();
        }

        private void ececu_btn_Click(object sender, EventArgs e)
        {
            String stem = sql_textbox.Text;
            Connector.ExecuteStem(stem);
        }
    }
}
