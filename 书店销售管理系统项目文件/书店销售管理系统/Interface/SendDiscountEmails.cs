using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using 书店销售管理系统.Assembly;
using 书店销售管理系统.DBConnector;

namespace 书店销售管理系统.Interface
{
    public partial class SendDiscountEmails : Form
    {
        public SendDiscountEmails()
        {
            InitializeComponent();
            AddCC();
        }

        MailMessage msg = new MailMessage();

        private void attach_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            String path = ofd.FileName;
            Attachment attach = new Attachment(path);
            msg.Attachments.Add(attach);
            attach_listbox.Items.Add(path);
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            string host = server_textbox.Text.Trim();
            string userName = name_textbox.Text.Trim();
            string password = pwd_textbox.Text.Trim();

            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式    
            client.Host = host;//邮件服务器
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(userName, password);//用户名、密码
            client.EnableSsl = useSSL_checkbox.Checked;

            //////////////////////////////////////
            string strfrom = userName;
            string strto = receiver_textbox.Text.Trim();


            string subject = title_textbox.Text;//邮件的主题             
            string body = msg_textbox.Text;//发送的邮件正文  


            msg.From = new MailAddress(strfrom, showname_textbox.Text);
            msg.To.Add(strto);

            msg.Subject = subject;//邮件标题   
            msg.Body = body;//邮件内容   
            msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码   
            msg.IsBodyHtml = false;//是否是HTML邮件   
            msg.Priority = MailPriority.High;//邮件优先级   
            try
            {
                client.Send(msg);
                MessageBox.Show("发送成功", "发送成功");
                
                attach_listbox.Items.Clear();
                addcc_listbox.Items.Clear();

                msg = new MailMessage();
                AddCC();
            }
            catch (SmtpException ex)
            {
                if (ex.Message.Equals(""))
                    MessageBox.Show("被识别为垃圾邮件", "发送邮件出错");
                else
                    Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "发送邮件出错");
            }
        }

        private void AddCC()
        {
            DataSet ds = Connector.GetAllEmails();
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                String address =ds.Tables[0].Rows[i].ItemArray[0].ToString();
                if (CheckString.ChechEmail(address))
                {
                    msg.CC.Add(address);
                    addcc_listbox.Items.Add(address);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                name_textbox.ReadOnly=true;
                receiver_textbox.ReadOnly = true;
                pwd_textbox.ReadOnly = true;
                server_textbox.ReadOnly = true;
                useSSL_checkbox.Enabled = false;
            }
            else
            {
                name_textbox.ReadOnly = false;
                receiver_textbox.ReadOnly = false;
                pwd_textbox.ReadOnly = false;
                server_textbox.ReadOnly = false;
                useSSL_checkbox.Enabled = true;
            }

        }
    }
}