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
    public partial class ziAdminForm : Form
    {
        public ziAdminForm()
        {
            InitializeComponent();
        }

        private void btn注册_Click(object sender, EventArgs e)
        {
            NewStuForm stu = new NewStuForm();
            stu.Show();
            //this.Hide();
        }

        private void btnLookbook_Click(object sender, EventArgs e)
        {
            LookBook LB = new LookBook();
            LB.Show();
            //this.Hide();
        }

        private void btn上下架_Click(object sender, EventArgs e)
        {
            NewBook ab = new NewBook();
            ab.Show();
            //this.Hide();
        }

        private void btn查删改_Click(object sender, EventArgs e)
        {
            LAstu la = new LAstu();
            la.Show();
            //this.Hide();
        }

    }
}
