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
    public partial class NewZiadminForm : Form
    {
        public NewZiadminForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");

        private void btn注册_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("请您填写用户名!", "**提***示**", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string selecString1 = "insert into 管理员信息表 values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selecString1, conn);
                    int stu = cmd.ExecuteNonQuery();       //执行sql语句，返回受影响行数
                    if (stu > 0) MessageBox.Show("注册管理员成功!","**恭*喜*您**");
                }
                catch //(SqlException ex) 
                { 
                    //MessageBox.Show(ex.ToString());
                    MessageBox.Show("该管理员已存在!","**提***示**");
                }
                finally { conn.Close(); }
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("请您填写用户名!", "**提***示**", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {              
                    string selecStr = "select * from 管理员信息表 where mName = '" + textBox1.Text + "'";
 
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selecStr, conn);
                    SqlDataReader dr1 = cmd.ExecuteReader();
                    if (dr1.Read())
                    {
                        conn.Close();
                        string selecStr1 = "update 管理员信息表 set mName = '" + textBox2.Text + "' where mName = '" + textBox1.Text + "' ";
                        string selecStr2 = "update 管理员信息表 set mPassword = '" + textBox3.Text + "' where mName = '" + textBox1.Text + "' ";
                        string selecStr3 = "update 管理员信息表 set mtel = '" + textBox4.Text + "' where mName = '" + textBox1.Text + "' ";
                        string selecStr4 = "update 管理员信息表 set mnote = '" + textBox5.Text + "' where mName = '" + textBox1.Text + "' ";
                        conn.Open();
                        if (textBox2.Text != "")
                        {
                            SqlCommand cmd1 = new SqlCommand(selecStr1, conn);
                            cmd1.ExecuteNonQuery();       //执行sql语句，返回受影响行数
                            textBox1.Text = textBox2.Text;
                        }
                        if (textBox3.Text != "")
                        {
                            SqlCommand cmd2 = new SqlCommand(selecStr2, conn);
                            cmd2.ExecuteNonQuery();
                        }
                        if (textBox4.Text != "")
                        {
                            SqlCommand cmd3 = new SqlCommand(selecStr3, conn);
                            cmd3.ExecuteNonQuery();
                        }
                        if (textBox5.Text != "")
                        {
                            SqlCommand cmd4 = new SqlCommand(selecStr4, conn);
                            cmd4.ExecuteNonQuery();
                        }
                        MessageBox.Show("修改成功!", "**提***示**");
                        textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
                    }
                    else
                        MessageBox.Show("修改失败，请检查用户名后重新尝试!", "**提***示**");

                }
                catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
            }
        }

        private void btn查看_Click(object sender, EventArgs e)
        {
            string selecStr1 = "select mName 用户名,mPassword 密码,mtel 电话,mnote 备注 from 管理员信息表 where mName like '%" + textBox1.Text + "%'";
                try
                {
                    conn.Open();
                    SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(selecStr1, conn);
                    DataSet myDataSet = new DataSet();
                    mySqlDataAdapter.Fill(myDataSet, "0");
                    dataGridView1.DataSource = myDataSet.Tables["0"];
                }
                catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("请您填写用户名!", "**提***示**", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("此操作不可逆，确定删除？", "**提示**", MessageBoxButtons.OKCancel);
                if (DialogResult != DialogResult.Cancel)
                {
                    string selecStr1 = "delete from 管理员信息表 where mName = '" + textBox1.Text + "'";
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(selecStr1, conn);
                        int stu = cmd.ExecuteNonQuery();       //执行sql语句，返回受影响行数
                        if (stu > 0) 
                            MessageBox.Show("删除操作成功!", "**恭*喜*您**");
                        else
                            MessageBox.Show("删除失败，该管理员不存在!", "**提***示**");

                    }
                    catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                    finally { conn.Close(); }
                }
            }
        }

    }
}
