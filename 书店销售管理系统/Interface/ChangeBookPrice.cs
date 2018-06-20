using System;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class ChangeBookPrice : Form
    {
        public ChangeBookPrice()
        {
            InitializeComponent();
            dataGridView1.DataSource = Connector.SelectBookInfoTable(0,"").Tables[0].DefaultView;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (CheckString.CheckISBN(isbn_textbox.Text) && CheckString.CheckUDouble(price_textbox.Text))
            {
                Connector.ChangePrice(isbn_textbox.Text, price_textbox.Text);
                dataGridView1.DataSource = Connector.SelectBookInfoTable(0, "").Tables[0].DefaultView;
            }
            else if (!CheckString.CheckISBN(isbn_textbox.Text))
                MessageBox.Show("请检查ISBN填写是否正确", "ISBN格式错误");
            else if (!CheckString.CheckUDouble(price_textbox.Text))
                MessageBox.Show("请检查价格填写是否正确","价格错误");
        }

        private void fresh_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connector.SelectBookInfoTable(0, "").Tables[0].DefaultView;
        }

    }
}
