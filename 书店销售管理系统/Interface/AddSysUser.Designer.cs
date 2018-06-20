namespace 书店销售管理系统.Interface
{
    partial class AddSysUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSysUser));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.pwd_textBox = new System.Windows.Forms.TextBox();
            this.power_textBox = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.fresh_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(776, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(110, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(111, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(110, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "权限：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(552, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "（管理员/进货员/销售员）";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("宋体", 15F);
            this.name_textBox.Location = new System.Drawing.Point(204, 237);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(342, 36);
            this.name_textBox.TabIndex = 5;
            // 
            // pwd_textBox
            // 
            this.pwd_textBox.Font = new System.Drawing.Font("宋体", 15F);
            this.pwd_textBox.Location = new System.Drawing.Point(204, 286);
            this.pwd_textBox.Name = "pwd_textBox";
            this.pwd_textBox.PasswordChar = '*';
            this.pwd_textBox.Size = new System.Drawing.Size(342, 36);
            this.pwd_textBox.TabIndex = 6;
            // 
            // power_textBox
            // 
            this.power_textBox.Font = new System.Drawing.Font("宋体", 15F);
            this.power_textBox.Location = new System.Drawing.Point(203, 334);
            this.power_textBox.Name = "power_textBox";
            this.power_textBox.Size = new System.Drawing.Size(343, 36);
            this.power_textBox.TabIndex = 7;
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("宋体", 15F);
            this.submit_button.Location = new System.Drawing.Point(197, 388);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(156, 50);
            this.submit_button.TabIndex = 8;
            this.submit_button.Text = "提交";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // fresh_button
            // 
            this.fresh_button.Font = new System.Drawing.Font("宋体", 15F);
            this.fresh_button.Location = new System.Drawing.Point(388, 388);
            this.fresh_button.Name = "fresh_button";
            this.fresh_button.Size = new System.Drawing.Size(156, 50);
            this.fresh_button.TabIndex = 9;
            this.fresh_button.Text = "刷新";
            this.fresh_button.UseVisualStyleBackColor = true;
            this.fresh_button.Click += new System.EventHandler(this.fresh_button_Click);
            // 
            // AddSysUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fresh_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.power_textBox);
            this.Controls.Add(this.pwd_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddSysUser";
            this.Text = "添加系统用户";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox pwd_textBox;
        private System.Windows.Forms.TextBox power_textBox;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button fresh_button;
    }
}