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
    public partial class LookBook : Form
    {
        public LookBook()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmdStr1 = "select bName 书名,bnumber 书号, bwriter 作者, bamount 现有数量,btype 类型,bplace 存放位置,bnote 备注 from 图书信息表 where bName like '%" + textBoxbName.Text + "%' and bwriter like '%" + textBoxWriter.Text + "%'";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "0");
                dataGridView1.DataSource = myDataSet.Tables["0"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if (textBoxWriter.Text == "admin")
            //{
            this.Close();
            /*ziAdminForm zi = new ziAdminForm();
            zi.Show();
            }
            else
            {
            this.Close();
            StuForm stu = new StuForm();
            stu.Show();
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmdStr1 = "select bName 书名,bnumber 书号, bwriter 作者, bamount 现有数量,btype 类型,bplace 存放位置,bnote 备注 from 图书信息表 where btype = '古典'";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "1");
                dataGridView1.DataSource = myDataSet.Tables["1"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmdStr1 = "select bName 书名,bnumber 书号, bwriter 作者, bamount 现有数量,btype 类型,bplace 存放位置,bnote 备注 from 图书信息表 where btype = '神话'";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "2");
                dataGridView1.DataSource = myDataSet.Tables["2"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmdStr1 = "select bName 书名,bnumber 书号, bwriter 作者, bamount 现有数量,btype 类型,bplace 存放位置,bnote 备注 from 图书信息表 where btype = '武侠'";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "3");
                dataGridView1.DataSource = myDataSet.Tables["3"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmdStr1 = "select bName 书名,bnumber 书号, bwriter 作者, bamount 现有数量,btype 类型,bplace 存放位置,bnote 备注 from 图书信息表 where btype = '言情'";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "4");
                dataGridView1.DataSource = myDataSet.Tables["4"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }
    }
}
