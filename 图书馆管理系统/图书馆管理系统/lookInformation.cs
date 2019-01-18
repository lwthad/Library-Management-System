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
    public partial class lookInformation : Form
    {
        public lookInformation()
        {
            InitializeComponent();
        }

        public lookInformation(string txt)      //带一个参数的构造函数
            : this()
        {
            textBName.Text = txt;
        }
        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");

        private void lookInformation_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmdStr1 = "select sName 用户名,YuanXi 院系,JiBie 级别,ZhuanYe 专业班级,stel 电话,snote 备注 from 学生个人信息表 where sName = '" + textBName.Text + "'";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "look");
                dataGridView1.DataSource = myDataSet.Tables["look"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" ||textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("请填满所有必填项！", "**错误**", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox2.Text != textBox3.Text)
                MessageBox.Show("两次密码输入不一致！", "**错误**", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    conn.Open();
                    string selecString1 = "select * from 学生个人信息表 where sName='" + textBName.Text + "' and sPassword='" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(selecString1, conn);
                    SqlDataReader dr1 = cmd.ExecuteReader();       //select查询语句判断执行情况 需要用 ExecuteReader()  .Read() 来判断
                    
                    if (dr1.Read())
                    {
                        conn.Close(); 
                        conn.Open();
                        string selecStr1 = "update 学生个人信息表 set sPassword = '" + textBox2.Text + "'  where sName = '" + textBName.Text + "' ";
                        SqlCommand cmd1 = new SqlCommand(selecStr1, conn);
                        if (cmd1.ExecuteNonQuery() > 0)       //执行sql语句，返回受影响行数
                        {
                            conn.Close();
                            conn.Open();
                            if (textBox4.Text != "")
                            {
                                string selecStr2 = "update 学生个人信息表 set YuanXi = '" + textBox4.Text + "'  where sName = '" + textBName.Text + "' ";
                                SqlCommand cmd2 = new SqlCommand(selecStr2, conn);
                                cmd2.ExecuteNonQuery();
                            }
                            if (textBox5.Text != "")
                            {
                                string selecStr3 = "update 学生个人信息表 set JiBie = '" + textBox5.Text + "'  where sName = '" + textBName.Text + "' ";
                                SqlCommand cmd3 = new SqlCommand(selecStr3, conn);
                                cmd3.ExecuteNonQuery();
                            }
                            if (textBox6.Text != "")
                            {
                                string selecStr4 = "update 学生个人信息表 set ZhuanYe = '" + textBox6.Text + "'  where sName = '" + textBName.Text + "' ";
                                SqlCommand cmd4 = new SqlCommand(selecStr4, conn);
                                cmd4.ExecuteNonQuery();
                            }
                            if (textBox7.Text != "")
                            {
                                string selecStr5 = "update 学生个人信息表 set stel = '" + textBox7.Text + "'  where sName = '" + textBName.Text + "' ";
                                SqlCommand cmd5 = new SqlCommand(selecStr5, conn);
                                cmd5.ExecuteNonQuery();
                            }
                            if (textBox8.Text != "")
                            {
                                string selecStr6 = "update 学生个人信息表 set snote = '" + textBox8.Text + "'  where sName = '" + textBName.Text + "' ";
                                SqlCommand cmd6 = new SqlCommand(selecStr6, conn);
                                cmd6.ExecuteNonQuery();
                            }
                            MessageBox.Show("修改成功!", "**提示**");
                            this.Close();
                        }
                    }
                    else MessageBox.Show("密码输入错误，请重新输入！", "**提示**");
                }
                catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
