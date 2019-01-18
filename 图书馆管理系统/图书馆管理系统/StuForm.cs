using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 图书馆管理系统
{
    public partial class StuForm : Form
    {
        public StuForm()
        {
            InitializeComponent();
        }
        public StuForm(string txt)      //构造函数
            : this()
        {
            textBoxName.Text = txt;
        }

        private void StuForm_Load(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("f");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lookInformation look = new lookInformation( textBoxName.Text );
            look.Show();
            //this.Hide();
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            LookBook LB = new LookBook();
            LB.Show();
            //this.Hide();
        }

        private void btnbrro_Click(object sender, EventArgs e)
        {
            BorrowBook borbook = new BorrowBook(textBoxName.Text);
            borbook.Show();
           // this.Hide();
        }

        private void btnretu_Click(object sender, EventArgs e)
        {
            ReturnBook rebook = new ReturnBook(textBoxName.Text);
            rebook.Show();
            //this.Hide();
        }

    }
}
