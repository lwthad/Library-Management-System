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
    public partial class NewBook : Form
    {
        public NewBook()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");
        private void btn上架_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                MessageBox.Show("请您添写所有的【必填项】!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string selecString1 = "insert into 图书信息表 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selecString1, conn);
                    int stu = cmd.ExecuteNonQuery();     //执行sql语句，返回受影响行数
                    if (stu > 0) MessageBox.Show("图书成功架上!","**提示**");                        
                }
                catch (SqlException ex) { MessageBox.Show("图书架上失败，请修改书号后重试！", "**提示**", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { conn.Close(); }
            }
        }

        private void btn下架_Click(object sender, EventArgs e)
        {
            string selecString1 = "delete from 图书信息表 where bnumber = '" + textBox8.Text + "' ";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selecString1, conn);
                    int stu = cmd.ExecuteNonQuery();     //执行sql语句，返回受影响行数
                    if (stu > 0) 
                        MessageBox.Show("图书成功下架!", "**提示**");
                    else
                        MessageBox.Show("图书下架失败，请检查书号后重新尝试！", "**提示**", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
        }

        private void btn后退_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn查看_Click(object sender, EventArgs e)
        {
            string selecStr = "select * from 图书信息表 where bnumber like '%" + textBox8.Text + "%'";
            try
            {
                conn.Open();
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(selecStr, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "0");
                dataGridView1.DataSource = myDataSet.Tables["0"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

    }
}
