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
    public partial class ReturnBook : Form
    {
        public ReturnBook(string txt)
        {
            InitializeComponent();
            textBox2.Text = txt;
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            //StuForm stu = new StuForm();
            //stu.Show();
            this.Close();
        }

        private void btn刷新_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmdStr1 = "select bnumber 书号,sName 学生用户名,borrowtime 借出时间 from 借阅信息表 where sName = '" + textBox2.Text + " '";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "test");
                dataGridView1.DataSource = myDataSet.Tables["test"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }
        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");
        private void btn归还_Click(object sender, EventArgs e)
        {
           // SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");
            try
            {
                conn.Open();
                string selecString1 = "delete from 借阅信息表  where bnumber = '" + textBox1.Text + " ' and sName = '" + textBox2.Text + " '";
                SqlCommand cmd1 = new SqlCommand(selecString1, conn);
                int stu = cmd1.ExecuteNonQuery();     //执行sql语句，返回受影响行数
                if (stu > 0)
                {
                    string selecString2 = "update 图书信息表 set bamount += 1 where bnumber = '" + textBox1.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(selecString2, conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("恭喜【归还成功】!","**提示**");
                }
                else MessageBox.Show("【归还失败】,请检查书号后重新尝试！", "**警告**", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }
    }
}
