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
    public partial class BorrowBook : Form
    {
        public BorrowBook()
        {
            InitializeComponent();
        }
        public BorrowBook(string txt)      //带一个参数的构造函数
            : this()
        {
            textBox2.Text = txt;
        }
        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");

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
                string cmdStr1 = "select bnumber 书号,sName 学生用户名,borrowtime 借出时间 from 借阅信息表 where sName = '" + textBox2.Text + "'";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "test");
                dataGridView1.DataSource = myDataSet.Tables["test"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void btn确认_Click(object sender, EventArgs e)
        {
            try
            {
            conn.Open();
            string Str0 = "select * from 图书信息表  where bamount = 0 and bnumber = '" + textBox1.Text + "'";       //预先判断所借书本是否有剩余
            SqlCommand cmd0 = new SqlCommand(Str0, conn);
            SqlDataReader dr1 = cmd0.ExecuteReader();
            if (dr1.Read())
            {
                MessageBox.Show("【借阅失败】,该书剩余数量为零！", "**提示**", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                conn.Close();
                conn.Open();
                string Str1 = "insert into 借阅信息表(bnumber,sName,borrowtime) values('" + textBox1.Text + "','" + textBox2.Text + "','" + DateTime.Now + "')";
                SqlCommand cmd = new SqlCommand(Str1, conn);
                int stu = cmd.ExecuteNonQuery();               //执行sql语句，返回受影响行数

                if (stu > 0)    //插入数据成功
                {
                    string Str2 = "update 图书信息表 set bamount -= 1 where bnumber = '" + textBox1.Text + "'";      //对图书数量进行修改
                    SqlCommand cmd1 = new SqlCommand(Str2, conn);
                    if (cmd1.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("恭喜【借阅成功】!","**提示**");
                    }
                    /*else
                    {
                        string selecStr = "delete from 借阅信息表  where bnumber = '" + textBox1.Text + " ' and sName = '" + textBox2.Text + " '";
                        SqlCommand cmd2 = new SqlCommand(selecStr, conn);
                        int stu2 = cmd2.ExecuteNonQuery();
                        if (stu2 > 0)
                            MessageBox.Show("借阅失败,该书剩余数量为零！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);             //还需要将上面插入借阅表的信息删除
                    }*/

                }
            }

            }
            catch (SqlException ex) 
            {     
                MessageBox.Show(ex.ToString()); 

            }
            finally 
            { 
                conn.Close();
            }
        }

    }
}
