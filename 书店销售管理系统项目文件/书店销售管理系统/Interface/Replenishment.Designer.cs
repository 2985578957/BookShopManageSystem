namespace 书店销售管理系统.Interface
{
    partial class Replenishment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replenishment));
            this.label1 = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.zengjia_radiobutton = new System.Windows.Forms.RadioButton();
            this.zengjiadao_radiobutton = new System.Windows.Forms.RadioButton();
            this.zengjia_textbox = new System.Windows.Forms.TextBox();
            this.zengjiadao_textbox = new System.Windows.Forms.TextBox();
            this.isbn_textbox = new System.Windows.Forms.TextBox();
            this.book_dataGridView = new System.Windows.Forms.DataGridView();
            this.select_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.book_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书号：";
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("宋体", 15F);
            this.submit_btn.Location = new System.Drawing.Point(95, 285);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(164, 54);
            this.submit_btn.TabIndex = 2;
            this.submit_btn.Text = "提交";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // zengjia_radiobutton
            // 
            this.zengjia_radiobutton.AutoSize = true;
            this.zengjia_radiobutton.Checked = true;
            this.zengjia_radiobutton.Font = new System.Drawing.Font("宋体", 15F);
            this.zengjia_radiobutton.Location = new System.Drawing.Point(2, 55);
            this.zengjia_radiobutton.Name = "zengjia_radiobutton";
            this.zengjia_radiobutton.Size = new System.Drawing.Size(134, 29);
            this.zengjia_radiobutton.TabIndex = 4;
            this.zengjia_radiobutton.TabStop = true;
            this.zengjia_radiobutton.Text = " 增 加：";
            this.zengjia_radiobutton.UseVisualStyleBackColor = true;
            this.zengjia_radiobutton.CheckedChanged += new System.EventHandler(this.zengjia_radiobutton_CheckedChanged);
            // 
            // zengjiadao_radiobutton
            // 
            this.zengjiadao_radiobutton.AutoSize = true;
            this.zengjiadao_radiobutton.Font = new System.Drawing.Font("宋体", 15F);
            this.zengjiadao_radiobutton.Location = new System.Drawing.Point(3, 97);
            this.zengjiadao_radiobutton.Name = "zengjiadao_radiobutton";
            this.zengjiadao_radiobutton.Size = new System.Drawing.Size(133, 29);
            this.zengjiadao_radiobutton.TabIndex = 5;
            this.zengjiadao_radiobutton.Text = "修改为：";
            this.zengjiadao_radiobutton.UseVisualStyleBackColor = true;
            this.zengjiadao_radiobutton.CheckedChanged += new System.EventHandler(this.zengjiadao_radiobutton_CheckedChanged);
            // 
            // zengjia_textbox
            // 
            this.zengjia_textbox.Location = new System.Drawing.Point(186, 176);
            this.zengjia_textbox.Name = "zengjia_textbox";
            this.zengjia_textbox.Size = new System.Drawing.Size(100, 25);
            this.zengjia_textbox.TabIndex = 6;
            // 
            // zengjiadao_textbox
            // 
            this.zengjiadao_textbox.Enabled = false;
            this.zengjiadao_textbox.Location = new System.Drawing.Point(184, 221);
            this.zengjiadao_textbox.Name = "zengjiadao_textbox";
            this.zengjiadao_textbox.Size = new System.Drawing.Size(100, 25);
            this.zengjiadao_textbox.TabIndex = 7;
            // 
            // isbn_textbox
            // 
            this.isbn_textbox.Location = new System.Drawing.Point(184, 127);
            this.isbn_textbox.Name = "isbn_textbox";
            this.isbn_textbox.Size = new System.Drawing.Size(100, 25);
            this.isbn_textbox.TabIndex = 8;
            // 
            // book_dataGridView
            // 
            this.book_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_dataGridView.Location = new System.Drawing.Point(313, 12);
            this.book_dataGridView.Name = "book_dataGridView";
            this.book_dataGridView.ReadOnly = true;
            this.book_dataGridView.RowTemplate.Height = 27;
            this.book_dataGridView.Size = new System.Drawing.Size(676, 364);
            this.book_dataGridView.TabIndex = 9;
            // 
            // select_btn
            // 
            this.select_btn.Font = new System.Drawing.Font("宋体", 15F);
            this.select_btn.Location = new System.Drawing.Point(595, 382);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(134, 56);
            this.select_btn.TabIndex = 10;
            this.select_btn.Text = "查看";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.zengjia_radiobutton);
            this.panel1.Controls.Add(this.zengjiadao_radiobutton);
            this.panel1.Location = new System.Drawing.Point(32, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 129);
            this.panel1.TabIndex = 11;
            // 
            // Replenishment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.book_dataGridView);
            this.Controls.Add(this.isbn_textbox);
            this.Controls.Add(this.zengjiadao_textbox);
            this.Controls.Add(this.zengjia_textbox);
            this.Controls.Add(this.submit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Replenishment";
            this.Text = "补货/修改库存";
            ((System.ComponentModel.ISupportInitialize)(this.book_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.RadioButton zengjia_radiobutton;
        private System.Windows.Forms.RadioButton zengjiadao_radiobutton;
        private System.Windows.Forms.TextBox zengjia_textbox;
        private System.Windows.Forms.TextBox zengjiadao_textbox;
        private System.Windows.Forms.TextBox isbn_textbox;
        private System.Windows.Forms.DataGridView book_dataGridView;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Panel panel1;
    }
}