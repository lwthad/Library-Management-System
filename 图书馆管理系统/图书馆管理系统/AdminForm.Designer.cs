namespace 图书馆管理系统
{
    partial class AdminForm
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
            this.button进入二级 = new System.Windows.Forms.Button();
            this.btn注册管理 = new System.Windows.Forms.Button();
            this.btn待开发 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button进入二级
            // 
            this.button进入二级.BackColor = System.Drawing.SystemColors.Highlight;
            this.button进入二级.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button进入二级.Location = new System.Drawing.Point(39, 97);
            this.button进入二级.Name = "button进入二级";
            this.button进入二级.Size = new System.Drawing.Size(158, 172);
            this.button进入二级.TabIndex = 1;
            this.button进入二级.Text = "进入二级管理界面";
            this.button进入二级.UseVisualStyleBackColor = false;
            this.button进入二级.Click += new System.EventHandler(this.button进入二级_Click);
            // 
            // btn注册管理
            // 
            this.btn注册管理.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn注册管理.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn注册管理.Location = new System.Drawing.Point(203, 97);
            this.btn注册管理.Name = "btn注册管理";
            this.btn注册管理.Size = new System.Drawing.Size(179, 99);
            this.btn注册管理.TabIndex = 2;
            this.btn注册管理.Text = "注册修改管理员";
            this.btn注册管理.UseVisualStyleBackColor = false;
            this.btn注册管理.Click += new System.EventHandler(this.button注册管理_Click);
            // 
            // btn待开发
            // 
            this.btn待开发.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn待开发.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn待开发.Location = new System.Drawing.Point(203, 213);
            this.btn待开发.Name = "btn待开发";
            this.btn待开发.Size = new System.Drawing.Size(179, 56);
            this.btn待开发.TabIndex = 3;
            this.btn待开发.Text = "待开发";
            this.btn待开发.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(198, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "秘钥:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(101, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 38);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "admin";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(259, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 38);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "123456";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 293);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn待开发);
            this.Controls.Add(this.btn注册管理);
            this.Controls.Add(this.button进入二级);
            this.Name = "AdminForm";
            this.Text = "超级管理员操作界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button进入二级;
        private System.Windows.Forms.Button btn注册管理;
        private System.Windows.Forms.Button btn待开发;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}