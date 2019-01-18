using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书馆管理系统
{
    public partial class NewStuForm : Form
    {
        public NewStuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("请您添写所有的【必填项】!", "**提***示**", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox2.Text != textBox3.Text)
                MessageBox.Show("密码前后输入不一致!", "**提***示**", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string selecString1 = "insert into 学生个人信息表 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selecString1, conn);
                    int stu = cmd.ExecuteNonQuery();     //执行sql语句，返回受影响行数
                    if (stu > 0) MessageBox.Show("【注册学生用户成功!】","*恭 喜 您*");
                }
                catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //ziAdminForm ziAd = new ziAdminForm();
            //ziAd.Show();
        }

    }
}
