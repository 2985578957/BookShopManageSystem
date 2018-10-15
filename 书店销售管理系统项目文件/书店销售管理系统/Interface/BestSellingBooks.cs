using System;
using System.Windows.Forms;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class BestSellingBooks : Form
    {
        public BestSellingBooks()
        {
            InitializeComponent();
            textBox1.Text = GetSellList();
        }

        public String GetSellList()
        {
            String starttime, endtime;
            DateTime dt = DateTime.Now;
            String str="";

            starttime = String.Format("{0:d}", dt) + " 00:00:00";
            endtime = String.Format("{0:d}", dt) + " 23:59:59";
            str+=("当天最高销量(书号，书名，销量):\r\n"+Connector.FindBestSellingBook(starttime, endtime)+ "\r\n");
            str += "\r\n\r\n";
            starttime = String.Format("{0:d}", dt.AddDays(1 - dt.Day)) + " 00:00:00";
            endtime = String.Format("{0:d}", dt.AddDays(1 - dt.Day).AddMonths(1).AddDays(-1)) + " 23:59:59";
            str += ("本月最高销量(书号，书名，销量):\r\n" + Connector.FindBestSellingBook(starttime, endtime) + "\r\n");
            str += "\r\n\r\n";
            starttime = String.Format("{0:d}", dt.AddMonths(0 - (dt.Month - 1) % 3).AddDays(1 - dt.Day)) + " 00:00:00";
            endtime = String.Format("{0:d}", dt.AddMonths(0 - (dt.Month - 1) % 3).AddDays(1 - dt.Day).AddMonths(3).AddDays(-1)) + " 23:59:59";
            str += ("本季度最高销量(书号，书名，销量):\r\n" + Connector.FindBestSellingBook(starttime, endtime) + "\r\n");
            return str;
        }
    }
}
