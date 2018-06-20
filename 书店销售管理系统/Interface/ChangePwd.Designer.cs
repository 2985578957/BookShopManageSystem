namespace 书店销售管理系统.Interface
{
    partial class ChangePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePwd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldpwd_textbox = new System.Windows.Forms.TextBox();
            this.newpwd_textbox = new System.Windows.Forms.TextBox();
            this.confimnewpwd_textbox = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(70, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认新密码：";
            // 
            // oldpwd_textbox
            // 
            this.oldpwd_textbox.Font = new System.Drawing.Font("宋体", 15F);
            this.oldpwd_textbox.Location = new System.Drawing.Point(173, 32);
            this.oldpwd_textbox.Name = "oldpwd_textbox";
            this.oldpwd_textbox.PasswordChar = '*';
            this.oldpwd_textbox.Size = new System.Drawing.Size(216, 36);
            this.oldpwd_textbox.TabIndex = 3;
            // 
            // newpwd_textbox
            // 
            this.newpwd_textbox.Font = new System.Drawing.Font("宋体", 15F);
            this.newpwd_textbox.Location = new System.Drawing.Point(173, 100);
            this.newpwd_textbox.Name = "newpwd_textbox";
            this.newpwd_textbox.PasswordChar = '*';
            this.newpwd_textbox.Size = new System.Drawing.Size(216, 36);
            this.newpwd_textbox.TabIndex = 4;
            // 
            // confimnewpwd_textbox
            // 
            this.confimnewpwd_textbox.Font = new System.Drawing.Font("宋体", 15F);
            this.confimnewpwd_textbox.Location = new System.Drawing.Point(173, 166);
            this.confimnewpwd_textbox.Name = "confimnewpwd_textbox";
            this.confimnewpwd_textbox.PasswordChar = '*';
            this.confimnewpwd_textbox.Size = new System.Drawing.Size(216, 36);
            this.confimnewpwd_textbox.TabIndex = 5;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("宋体", 15F);
            this.submit_btn.Location = new System.Drawing.Point(155, 225);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(104, 43);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "提交";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(279, 225);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "显示密文";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 280);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.confimnewpwd_textbox);
            this.Controls.Add(this.newpwd_textbox);
            this.Controls.Add(this.oldpwd_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldpwd_textbox;
        private System.Windows.Forms.TextBox newpwd_textbox;
        private System.Windows.Forms.TextBox confimnewpwd_textbox;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}