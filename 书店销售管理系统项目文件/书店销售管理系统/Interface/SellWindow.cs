using System;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class SellWindow : Form
    {
        public SellWindow()
        {
            InitializeComponent();
        }

        private void SubmitSell(object sender, EventArgs e)
        {
            if (!CheckString.CheckISBN(isbn_textbox.Text.Trim()))
                MessageBox.Show("请检查ISBN填写是否正确", "ISBN格式错误");
            else if (!CheckString.CheckUInt(num_textbox.Text.Trim()) || int.Parse(num_textbox.Text.Trim()) == 0)
                MessageBox.Show("请检查数量填写是否正确", "数量错误");
            else
            {
                money_textbox.Text = (double.Parse(Connector.GetPrice(isbn_textbox.Text.Trim())) * int.Parse(num_textbox.Text.Trim())).ToString();

                String ISBN = isbn_textbox.Text.Trim();
                int num = int.Parse(num_textbox.Text.Trim());
                String TranMode = mode_textbox.Text.Trim();
                String Remarks = remarks_textbox.Text.Trim();

                

                Int64 VipNum;
                String time;
                double money=Double.Parse(money_textbox.Text.Trim());
                bool flag = true;

                if (Object.Equals(vipnum_textbox.Text.Trim(), ""))
                {
                    vipnum_textbox.Text = "0";
                    VipNum = 0;
                }
                else
                {
                    if (!CheckString.CheckUInt(vipnum_textbox.Text.Trim()))
                    {
                        MessageBox.Show("会员编号填写错误", "会员编号错误");
                        VipNum = 0;
                        flag = false;
                    }
                    else
                        VipNum = Int64.Parse(vipnum_textbox.Text.Trim());
                }

                if (Object.Equals(time_textbox.Text.Trim(), ""))
                {
                    time_textbox.Text = string.Format("{0:G}", DateTime.Now);
                    time = string.Format("{0:G}", System.DateTime.Now);
                }
                else
                {
                    if (!CheckString.CheckDate(time_textbox.Text.Trim()))
                    {
                        MessageBox.Show("交易时间填写错误", "时间格式错误");
                        flag = false;
                        time = string.Format("{0:G}", System.DateTime.Now);
                    }
                    else
                        time = time_textbox.Text.Trim();
                }

                if (flag)
                {
                    trannum_textbox.Text = SecurityUnit.EncryptToMD5(VipNum + ISBN + time + TranMode);
                    String TranNum = trannum_textbox.Text.Trim();

                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show("确定?", "确认订单", messButton);
                    if (dr == DialogResult.OK)//如果点击“确定”按钮
                    {
                        if (Connector.InquireBookNumbers(ISBN) >= num)
                        {
                            Connector.AddToSellList(VipNum, ISBN, time, num, money, TranMode, TranNum, Remarks);
                            Connector.Replenishment(2, ISBN, -1 * num);

                            money_textbox.Text = "";
                            isbn_textbox.Text = "";
                            num_textbox.Text = "";
                            mode_textbox.Text = "";
                            remarks_textbox.Text = "";
                            trannum_textbox.Text = "";
                            time_textbox.Text = "";
                            vipnum_textbox.Text = "";

                            if (money > 50 && VipNum == 0) 
                            {
                                MessageBoxButtons messButton2 = MessageBoxButtons.OKCancel;
                                DialogResult dr2 = MessageBox.Show("添加会员吗?", "添加会员", messButton2);
                                if (dr2 == DialogResult.OK)//如果点击“确定”按钮
                                {
                                    VipManage newpage = new VipManage();
                                    newpage.Show();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("存货不足！");
                        }
                    }
                    else//如果点击“取消”按钮
                    {
                        vipnum_textbox.Text
                            = isbn_textbox.Text
                            = time_textbox.Text
                            = num_textbox.Text
                            = money_textbox.Text
                            = mode_textbox.Text
                            = remarks_textbox.Text
                            = trannum_textbox.Text = "";
                    }
                }
            }
        }

        private void nowtime_btn_Click(object sender, EventArgs e)
        {
            time_textbox.Text = string.Format("{0:G}", DateTime.Now);
        }

        private void getprice_btn_Click(object sender, EventArgs e)
        {
            money_textbox.Text = (double.Parse(Connector.GetPrice(isbn_textbox.Text)) * int.Parse(num_textbox.Text)).ToString();
        }
    }
}
