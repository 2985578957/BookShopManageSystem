namespace 书店销售管理系统.Interface
{
    partial class ExecuCustomStem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecuCustomStem));
            this.sql_textbox = new System.Windows.Forms.TextBox();
            this.result_lable = new System.Windows.Forms.Label();
            this.ececu_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sql_textbox
            // 
            this.sql_textbox.Font = new System.Drawing.Font("宋体", 10F);
            this.sql_textbox.Location = new System.Drawing.Point(12, 12);
            this.sql_textbox.Multiline = true;
            this.sql_textbox.Name = "sql_textbox";
            this.sql_textbox.Size = new System.Drawing.Size(776, 180);
            this.sql_textbox.TabIndex = 0;
            // 
            // result_lable
            // 
            this.result_lable.AutoSize = true;
            this.result_lable.Location = new System.Drawing.Point(15, 245);
            this.result_lable.Name = "result_lable";
            this.result_lable.Size = new System.Drawing.Size(52, 15);
            this.result_lable.TabIndex = 1;
            this.result_lable.Text = "结果：";
            // 
            // ececu_btn
            // 
            this.ececu_btn.Font = new System.Drawing.Font("宋体", 15F);
            this.ececu_btn.Location = new System.Drawing.Point(333, 198);
            this.ececu_btn.Name = "ececu_btn";
            this.ececu_btn.Size = new System.Drawing.Size(82, 44);
            this.ececu_btn.TabIndex = 2;
            this.ececu_btn.Text = "执行";
            this.ececu_btn.UseVisualStyleBackColor = true;
            this.ececu_btn.Click += new System.EventHandler(this.ececu_btn_Click);
            // 
            // ExecuCustomStem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ececu_btn);
            this.Controls.Add(this.result_lable);
            this.Controls.Add(this.sql_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExecuCustomStem";
            this.Text = "执行自定义SQL语句";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sql_textbox;
        private System.Windows.Forms.Label result_lable;
        private System.Windows.Forms.Button ececu_btn;
    }
}