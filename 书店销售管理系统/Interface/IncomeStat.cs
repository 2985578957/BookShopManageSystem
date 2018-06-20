using System;
using System.Data;
using System.Windows.Forms;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class IncomeStat : Form
    {
        int mode = 1;
        DataSet ds;
        public IncomeStat()
        {
            InitializeComponent();
            ds = Connector.ShowIncomeStat(mode);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds = Connector.ShowIncomeStat(mode);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
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

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ds.Tables[0];
            int rowNumber = dataTable.Rows.Count;
            int columnNumber = dataTable.Columns.Count;

            if (rowNumber == 0)
            {
                MessageBox.Show("没有任何数据可以导入到Excel文件！");
            }

            //建立Excel对象 
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = true;//是否打开该Excel文件 
            for (int j = 0; j < columnNumber; j++)
            {
                excel.Cells[0 + 1, j + 1] = dataTable.Columns[j].ToString();
            }
            //填充数据 
            for (int c = 0; c < rowNumber; c++)
            {
                for (int j = 0; j < columnNumber; j++)
                {
                    excel.Cells[c + 1, j + 1] = dataTable.Rows[c].ItemArray[j];
                }
            }
        }
    }
}
