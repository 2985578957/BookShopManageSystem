namespace 书店销售管理系统.Interface
{
    partial class SendDiscountEmails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendDiscountEmails));
            this.label9 = new System.Windows.Forms.Label();
            this.addcc_listbox = new System.Windows.Forms.ListBox();
            this.receiver_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showname_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.attach_button = new System.Windows.Forms.Button();
            this.attach_listbox = new System.Windows.Forms.ListBox();
            this.send_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.useSSL_checkbox = new System.Windows.Forms.CheckBox();
            this.server_textbox = new System.Windows.Forms.TextBox();
            this.pwd_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.msg_textbox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(700, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "抄送列表";
            // 
            // addcc_listbox
            // 
            this.addcc_listbox.FormattingEnabled = true;
            this.addcc_listbox.ItemHeight = 15;
            this.addcc_listbox.Location = new System.Drawing.Point(668, 145);
            this.addcc_listbox.Name = "addcc_listbox";
            this.addcc_listbox.Size = new System.Drawing.Size(120, 259);
            this.addcc_listbox.TabIndex = 41;
            // 
            // receiver_textbox
            // 
            this.receiver_textbox.Location = new System.Drawing.Point(70, 55);
            this.receiver_textbox.Name = "receiver_textbox";
            this.receiver_textbox.ReadOnly = true;
            this.receiver_textbox.Size = new System.Drawing.Size(366, 25);
            this.receiver_textbox.TabIndex = 40;
            this.receiver_textbox.Text = "1998jiangpengcheng@163.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "收件人：";
            // 
            // showname_textbox
            // 
            this.showname_textbox.Location = new System.Drawing.Point(336, 86);
            this.showname_textbox.Name = "showname_textbox";
            this.showname_textbox.Size = new System.Drawing.Size(100, 25);
            this.showname_textbox.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "署名：";
            // 
            // title_textbox
            // 
            this.title_textbox.Location = new System.Drawing.Point(91, 86);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(185, 25);
            this.title_textbox.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "邮件标题：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "附件\r\n列表";
            // 
            // attach_button
            // 
            this.attach_button.Location = new System.Drawing.Point(668, 410);
            this.attach_button.Name = "attach_button";
            this.attach_button.Size = new System.Drawing.Size(120, 64);
            this.attach_button.TabIndex = 33;
            this.attach_button.Text = "添加附件";
            this.attach_button.UseVisualStyleBackColor = true;
            this.attach_button.Click += new System.EventHandler(this.attach_button_Click);
            // 
            // attach_listbox
            // 
            this.attach_listbox.FormattingEnabled = true;
            this.attach_listbox.ItemHeight = 15;
            this.attach_listbox.Location = new System.Drawing.Point(52, 410);
            this.attach_listbox.Name = "attach_listbox";
            this.attach_listbox.Size = new System.Drawing.Size(610, 64);
            this.attach_listbox.TabIndex = 32;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(12, 485);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(776, 46);
            this.send_button.TabIndex = 31;
            this.send_button.Text = "发送";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "SMTP服务器：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "授权码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "邮箱：";
            // 
            // useSSL_checkbox
            // 
            this.useSSL_checkbox.AutoSize = true;
            this.useSSL_checkbox.Checked = true;
            this.useSSL_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useSSL_checkbox.Enabled = false;
            this.useSSL_checkbox.Location = new System.Drawing.Point(703, 57);
            this.useSSL_checkbox.Name = "useSSL_checkbox";
            this.useSSL_checkbox.Size = new System.Drawing.Size(85, 19);
            this.useSSL_checkbox.TabIndex = 27;
            this.useSSL_checkbox.Text = "Use SSL";
            this.useSSL_checkbox.UseVisualStyleBackColor = true;
            // 
            // server_textbox
            // 
            this.server_textbox.Location = new System.Drawing.Point(551, 55);
            this.server_textbox.Name = "server_textbox";
            this.server_textbox.ReadOnly = true;
            this.server_textbox.Size = new System.Drawing.Size(146, 25);
            this.server_textbox.TabIndex = 26;
            this.server_textbox.Text = "smtp.163.com";
            // 
            // pwd_textbox
            // 
            this.pwd_textbox.Location = new System.Drawing.Point(577, 17);
            this.pwd_textbox.Name = "pwd_textbox";
            this.pwd_textbox.PasswordChar = '*';
            this.pwd_textbox.ReadOnly = true;
            this.pwd_textbox.Size = new System.Drawing.Size(211, 25);
            this.pwd_textbox.TabIndex = 25;
            this.pwd_textbox.Text = "1998jpch";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(70, 17);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.ReadOnly = true;
            this.name_textbox.Size = new System.Drawing.Size(428, 25);
            this.name_textbox.TabIndex = 24;
            this.name_textbox.Text = "1998jiangpengcheng@163.com";
            // 
            // msg_textbox
            // 
            this.msg_textbox.Location = new System.Drawing.Point(12, 116);
            this.msg_textbox.Multiline = true;
            this.msg_textbox.Name = "msg_textbox";
            this.msg_textbox.Size = new System.Drawing.Size(650, 288);
            this.msg_textbox.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 15F);
            this.checkBox1.Location = new System.Drawing.Point(519, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 29);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "锁定配置";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SendDiscountEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addcc_listbox);
            this.Controls.Add(this.receiver_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.showname_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.attach_button);
            this.Controls.Add(this.attach_listbox);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.useSSL_checkbox);
            this.Controls.Add(this.server_textbox);
            this.Controls.Add(this.pwd_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.msg_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SendDiscountEmails";
            this.Text = "发送优惠信息邮件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox addcc_listbox;
        private System.Windows.Forms.TextBox receiver_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox showname_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button attach_button;
        private System.Windows.Forms.ListBox attach_listbox;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox useSSL_checkbox;
        private System.Windows.Forms.TextBox server_textbox;
        private System.Windows.Forms.TextBox pwd_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox msg_textbox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}