namespace 图书馆管理系统
{
    partial class StuForm
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
            this.btnLook = new System.Windows.Forms.Button();
            this.btnbrro = new System.Windows.Forms.Button();
            this.btnretu = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labTime = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLook
            // 
            this.btnLook.BackColor = System.Drawing.Color.Yellow;
            this.btnLook.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLook.ForeColor = System.Drawing.Color.Black;
            this.btnLook.Location = new System.Drawing.Point(203, 62);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(266, 68);
            this.btnLook.TabIndex = 0;
            this.btnLook.Text = "查阅图书";
            this.btnLook.UseVisualStyleBackColor = false;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // btnbrro
            // 
            this.btnbrro.BackColor = System.Drawing.Color.Yellow;
            this.btnbrro.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnbrro.ForeColor = System.Drawing.Color.Black;
            this.btnbrro.Location = new System.Drawing.Point(203, 136);
            this.btnbrro.Name = "btnbrro";
            this.btnbrro.Size = new System.Drawing.Size(266, 68);
            this.btnbrro.TabIndex = 1;
            this.btnbrro.Text = "借阅图书";
            this.btnbrro.UseVisualStyleBackColor = false;
            this.btnbrro.Click += new System.EventHandler(this.btnbrro_Click);
            // 
            // btnretu
            // 
            this.btnretu.BackColor = System.Drawing.Color.Yellow;
            this.btnretu.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnretu.ForeColor = System.Drawing.Color.Black;
            this.btnretu.Location = new System.Drawing.Point(203, 210);
            this.btnretu.Name = "btnretu";
            this.btnretu.Size = new System.Drawing.Size(266, 68);
            this.btnretu.TabIndex = 2;
            this.btnretu.Text = "归还图书";
            this.btnretu.UseVisualStyleBackColor = false;
            this.btnretu.Click += new System.EventHandler(this.btnretu_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(12, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 216);
            this.button4.TabIndex = 3;
            this.button4.Text = "查看个人信息";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labTime
            // 
            this.labTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTime.ForeColor = System.Drawing.Color.Black;
            this.labTime.Location = new System.Drawing.Point(277, 9);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(230, 37);
            this.labTime.TabIndex = 5;
            this.labTime.Text = "TimeShow";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.textBoxName.Location = new System.Drawing.Point(87, 5);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(97, 44);
            this.textBoxName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "用户名:";
            // 
            // StuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(535, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnretu);
            this.Controls.Add(this.btnbrro);
            this.Controls.Add(this.btnLook);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "StuForm";
            this.Text = "学生使用界面";
            this.Load += new System.EventHandler(this.StuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnbrro;
        private System.Windows.Forms.Button btnretu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
    }
}