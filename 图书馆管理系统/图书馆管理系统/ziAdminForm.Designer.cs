namespace 图书馆管理系统
{
    partial class ziAdminForm
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
            this.btn查删改 = new System.Windows.Forms.Button();
            this.btn注册 = new System.Windows.Forms.Button();
            this.btn上下架 = new System.Windows.Forms.Button();
            this.btnLookbook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn查删改
            // 
            this.btn查删改.BackColor = System.Drawing.Color.Yellow;
            this.btn查删改.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn查删改.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn查删改.Location = new System.Drawing.Point(0, 108);
            this.btn查删改.Name = "btn查删改";
            this.btn查删改.Size = new System.Drawing.Size(353, 168);
            this.btn查删改.TabIndex = 2;
            this.btn查删改.Text = "查、删、改学生用户及借阅情况";
            this.btn查删改.UseVisualStyleBackColor = false;
            this.btn查删改.Click += new System.EventHandler(this.btn查删改_Click);
            // 
            // btn注册
            // 
            this.btn注册.BackColor = System.Drawing.Color.Yellow;
            this.btn注册.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn注册.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn注册.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn注册.Location = new System.Drawing.Point(0, 0);
            this.btn注册.Name = "btn注册";
            this.btn注册.Size = new System.Drawing.Size(543, 108);
            this.btn注册.TabIndex = 1;
            this.btn注册.Text = "注册学生用户";
            this.btn注册.UseVisualStyleBackColor = false;
            this.btn注册.Click += new System.EventHandler(this.btn注册_Click);
            // 
            // btn上下架
            // 
            this.btn上下架.BackColor = System.Drawing.Color.Yellow;
            this.btn上下架.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn上下架.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn上下架.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn上下架.Location = new System.Drawing.Point(353, 108);
            this.btn上下架.Name = "btn上下架";
            this.btn上下架.Size = new System.Drawing.Size(190, 254);
            this.btn上下架.TabIndex = 4;
            this.btn上下架.Text = "上下架图书";
            this.btn上下架.UseVisualStyleBackColor = false;
            this.btn上下架.Click += new System.EventHandler(this.btn上下架_Click);
            // 
            // btnLookbook
            // 
            this.btnLookbook.BackColor = System.Drawing.Color.Yellow;
            this.btnLookbook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLookbook.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLookbook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLookbook.Location = new System.Drawing.Point(0, 273);
            this.btnLookbook.Name = "btnLookbook";
            this.btnLookbook.Size = new System.Drawing.Size(353, 89);
            this.btnLookbook.TabIndex = 3;
            this.btnLookbook.Text = "查阅图书";
            this.btnLookbook.UseVisualStyleBackColor = false;
            this.btnLookbook.Click += new System.EventHandler(this.btnLookbook_Click);
            // 
            // ziAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(543, 362);
            this.Controls.Add(this.btnLookbook);
            this.Controls.Add(this.btn上下架);
            this.Controls.Add(this.btn注册);
            this.Controls.Add(this.btn查删改);
            this.Name = "ziAdminForm";
            this.Text = "二级管理员界面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn查删改;
        private System.Windows.Forms.Button btn注册;
        private System.Windows.Forms.Button btn上下架;
        private System.Windows.Forms.Button btnLookbook;
    }
}