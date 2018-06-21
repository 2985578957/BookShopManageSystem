using System;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class ImportNewBooks : Form
    {
        public ImportNewBooks()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (CheckString.CheckISBN(isbn_textbox.Text.Trim()) && CheckString.CheckUDouble(money_textbox.Text.Trim()) && double.Parse(money_textbox.Text.Trim()) >0)
            {
                String ISBN = isbn_textbox.Text.Trim();
                String bookname = bookname_textbox.Text.Trim();
                String authorname = author_textbox.Text.Trim();
                String publishname = publish_textbok.Text.Trim();
                String classificationname = classification_textbox.Text.Trim();
                double money = double.Parse(money_textbox.Text.Trim());
                String remarks = remarks_textbox.Text.Trim();

                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定?", "确认", messButton);
                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {
                    Connector.AddNewBooks(ISBN, bookname, authorname, publishname, classificationname, money, remarks);
                }
                else//如果点击“取消”按钮
                {
                    isbn_textbox.Text
                        = bookname_textbox.Text
                        = author_textbox.Text
                        = publish_textbok.Text
                        = money_textbox.Text
                        = classification_textbox.Text
                        = remarks_textbox.Text = "";
                }
            }
            else if (!CheckString.CheckISBN(isbn_textbox.Text.Trim()))
                MessageBox.Show("请检查ISBN填写是否正确", "ISBN格式错误");
            else if(!CheckString.CheckUDouble(money_textbox.Text.Trim()) || double.Parse(money_textbox.Text.Trim()) ==0)
                MessageBox.Show("请检查价格填写是否正确", "价格填写错误");
        }
    }
}
