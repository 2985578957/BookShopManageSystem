namespace 书店销售管理系统.Interface
{
    partial class SetArgs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetArgs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.user_textbox = new System.Windows.Forms.TextBox();
            this.pwd_textbox = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(60, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ODBC数据源名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F);
            this.label2.Location = new System.Drawing.Point(30, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "SQL Server用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F);
            this.label3.Location = new System.Drawing.Point(210, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("宋体", 18F);
            this.name_textbox.Location = new System.Drawing.Point(300, 64);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(282, 42);
            this.name_textbox.TabIndex = 3;
            // 
            // user_textbox
            // 
            this.user_textbox.Font = new System.Drawing.Font("宋体", 18F);
            this.user_textbox.Location = new System.Drawing.Point(300, 135);
            this.user_textbox.Name = "user_textbox";
            this.user_textbox.Size = new System.Drawing.Size(282, 42);
            this.user_textbox.TabIndex = 4;
            // 
            // pwd_textbox
            // 
            this.pwd_textbox.Font = new System.Drawing.Font("宋体", 18F);
            this.pwd_textbox.Location = new System.Drawing.Point(300, 197);
            this.pwd_textbox.Name = "pwd_textbox";
            this.pwd_textbox.Size = new System.Drawing.Size(282, 42);
            this.pwd_textbox.TabIndex = 5;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("宋体", 15F);
            this.submit_btn.Location = new System.Drawing.Point(174, 276);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(272, 54);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "提交";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "默认值：BookShop2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "默认值：sa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "默认值：（sa的密码）";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(187, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 19);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ODBC";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(376, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "ADO";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SetArgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 342);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.pwd_textbox);
            this.Controls.Add(this.user_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetArgs";
            this.Text = "设置参数";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox user_textbox;
        private System.Windows.Forms.TextBox pwd_textbox;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}