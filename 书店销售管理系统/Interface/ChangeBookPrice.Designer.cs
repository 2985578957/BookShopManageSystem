namespace 书店销售管理系统.Interface
{
    partial class ChangeBookPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeBookPrice));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.submit_btn = new System.Windows.Forms.Button();
            this.fresh_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isbn_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Size = new System.Drawing.Size(1283, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("宋体", 15F);
            this.submit_btn.Location = new System.Drawing.Point(999, 483);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(296, 72);
            this.submit_btn.TabIndex = 1;
            this.submit_btn.Text = "提交";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // fresh_btn
            // 
            this.fresh_btn.Font = new System.Drawing.Font("宋体", 15F);
            this.fresh_btn.Location = new System.Drawing.Point(999, 401);
            this.fresh_btn.Name = "fresh_btn";
            this.fresh_btn.Size = new System.Drawing.Size(296, 76);
            this.fresh_btn.TabIndex = 2;
            this.fresh_btn.Text = "刷新";
            this.fresh_btn.UseVisualStyleBackColor = true;
            this.fresh_btn.Click += new System.EventHandler(this.fresh_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(275, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "图书号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(225, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "修改价格为：";
            // 
            // isbn_textbox
            // 
            this.isbn_textbox.Font = new System.Drawing.Font("宋体", 15F);
            this.isbn_textbox.Location = new System.Drawing.Point(382, 441);
            this.isbn_textbox.Name = "isbn_textbox";
            this.isbn_textbox.Size = new System.Drawing.Size(355, 36);
            this.isbn_textbox.TabIndex = 5;
            // 
            // price_textbox
            // 
            this.price_textbox.Font = new System.Drawing.Font("宋体", 15F);
            this.price_textbox.Location = new System.Drawing.Point(382, 483);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(312, 36);
            this.price_textbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(700, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "元";
            // 
            // ChangeBookPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.isbn_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fresh_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangeBookPrice";
            this.Text = "修改价格";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button fresh_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isbn_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.Label label3;
    }
}