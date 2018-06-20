using System;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class Replenishment : Form
    {
        public Replenishment()
        {
            InitializeComponent();
            this.book_dataGridView.DataSource = Connector.SelectBookTable().Tables[0].DefaultView;
        }

        private void zengjia_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            zengjia_textbox.Enabled = true;
            zengjiadao_textbox.Enabled = false;
            zengjiadao_textbox.Text = "";
        }

        private void zengjiadao_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            zengjiadao_textbox.Enabled = true;
            zengjia_textbox.Enabled = false;
            zengjia_textbox.Text = "";
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            this.book_dataGridView.DataSource = Connector.SelectBookTable().Tables[0].DefaultView;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (zengjiadao_textbox.Enabled == true)
            {
                if (!CheckString.CheckUInt(zengjiadao_textbox.Text))
                    MessageBox.Show("请检查修改数量是否填写正确", "数量填写错误");
                else
                    Connector.Replenishment(1, isbn_textbox.Text, int.Parse(zengjiadao_textbox.Text));
            }
            else
            {
                if (!CheckString.CheckUInt(zengjia_textbox.Text))
                    MessageBox.Show("请检查增加数量是否填写正确", "数量填写错误");
                else
                    Connector.Replenishment(2, isbn_textbox.Text, int.Parse(zengjia_textbox.Text));
            }
        }
    }
}
