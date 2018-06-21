using System.Data;
using System.Windows.Forms;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class GetBookInfo : Form
    {
        string str;
        DataSet ds;
        public GetBookInfo()
        {
            InitializeComponent();
            ds = Connector.SelectBookInfoTable(0, str);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void refresh_btn_Click(object sender, System.EventArgs e)
        {
            if (radioButton0.Checked)
            {
                ds = Connector.SelectBookInfoTable(0, str);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (radioButton1.Checked)
            {
                str = textBox1.Text.Trim();
                ds = Connector.SelectBookInfoTable(1, str);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (radioButton2.Checked)
            {
                str = textBox2.Text.Trim();
                ds = Connector.SelectBookInfoTable(2, str);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (radioButton3.Checked)
            {
                str = textBox3.Text.Trim();
                ds = Connector.SelectBookInfoTable(3, str);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (radioButton4.Checked)
            {
                str = textBox4.Text.Trim();
                ds = Connector.SelectBookInfoTable(4, str);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void radioButton0_CheckedChanged(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void export_button_Click(object sender, System.EventArgs e)
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
            for (int c = 1; c < rowNumber; c++)
            {
                for (int j = 0; j < columnNumber; j++)
                {
                    excel.Cells[c + 1, j + 1] = dataTable.Rows[c].ItemArray[j];
                }
            }
        }
    }
}
