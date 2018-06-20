namespace 书店销售管理系统.Interface
{
    partial class Login_Page
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            this.Login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminName_TextBox = new System.Windows.Forms.TextBox();
            this.AdminPwd_TextBox = new System.Windows.Forms.TextBox();
            this.setarg_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_btn.Location = new System.Drawing.Point(143, 226);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(158, 63);
            this.Login_btn.TabIndex = 0;
            this.Login_btn.Text = "登陆";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "管理员登陆";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码：";
            // 
            // AdminName_TextBox
            // 
            this.AdminName_TextBox.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AdminName_TextBox.Location = new System.Drawing.Point(200, 80);
            this.AdminName_TextBox.Name = "AdminName_TextBox";
            this.AdminName_TextBox.Size = new System.Drawing.Size(263, 57);
            this.AdminName_TextBox.TabIndex = 5;
            // 
            // AdminPwd_TextBox
            // 
            this.AdminPwd_TextBox.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AdminPwd_TextBox.Location = new System.Drawing.Point(200, 143);
            this.AdminPwd_TextBox.Name = "AdminPwd_TextBox";
            this.AdminPwd_TextBox.PasswordChar = '*';
            this.AdminPwd_TextBox.Size = new System.Drawing.Size(263, 57);
            this.AdminPwd_TextBox.TabIndex = 6;
            // 
            // setarg_btn
            // 
            this.setarg_btn.BackColor = System.Drawing.Color.White;
            this.setarg_btn.ForeColor = System.Drawing.Color.Black;
            this.setarg_btn.Location = new System.Drawing.Point(307, 258);
            this.setarg_btn.Name = "setarg_btn";
            this.setarg_btn.Size = new System.Drawing.Size(98, 31);
            this.setarg_btn.TabIndex = 7;
            this.setarg_btn.Text = "设置参数";
            this.setarg_btn.UseVisualStyleBackColor = false;
            this.setarg_btn.Click += new System.EventHandler(this.setarg_btn_Click);
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::书店销售管理系统.Properties.Resources.Login_bg;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.setarg_btn);
            this.Controls.Add(this.AdminPwd_TextBox);
            this.Controls.Add(this.AdminName_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;//使最大化窗口失效
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Page";
            this.Text = "管理员登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminName_TextBox;
        private System.Windows.Forms.TextBox AdminPwd_TextBox;
        private System.Windows.Forms.Button setarg_btn;
    }
}

