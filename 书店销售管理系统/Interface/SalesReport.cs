using System;
using System.Windows.Forms;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class SalesReport : Form
    {
        int mode = 1;
        public SalesReport()
        {
            InitializeComponent();
        }

        private void fresh_btn_Click(object sender, EventArgs e)
        {
            String starttime = "1970-1-1 00:00:00", endtime = "2030-12-31 23:59:59";
            DateTime dt = DateTime.Now;

            if (mode == 1)
            {//天
                starttime = String.Format("{0:d}", dt) + " 00:00:00";
                endtime = String.Format("{0:d}", dt) + " 23:59:59";
            }
            else if (mode == 2)
            {//月
                starttime = String.Format("{0:d}", dt.AddDays(1 - dt.Day)) + " 00:00:00";
                endtime = String.Format("{0:d}", dt.AddDays(1 - dt.Day).AddMonths(1).AddDays(-1)) + " 23:59:59";
            }
            else if (mode == 3)
            {//季度
                starttime = String.Format("{0:d}", dt.AddMonths(0 - (dt.Month - 1) % 3).AddDays(1 - dt.Day)) + " 00:00:00";
                endtime = String.Format("{0:d}", dt.AddMonths(0 - (dt.Month - 1) % 3).AddDays(1 - dt.Day).AddMonths(3).AddDays(-1)) + " 23:59:59";
            }
            this.dataGridView1.DataSource = Connector.ShowSalesReport(starttime, endtime).Tables[0].DefaultView;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            mode = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            mode = 0;
        }


    }
}
