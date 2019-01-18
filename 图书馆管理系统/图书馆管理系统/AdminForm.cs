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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button进入二级_Click(object sender, EventArgs e)
        {
            ziAdminForm ziadmin = new ziAdminForm();
            ziadmin.Show();
            //this.Hide();
        }

        private void button注册管理_Click(object sender, EventArgs e)
        {
            NewZiadminForm nzimin = new NewZiadminForm();
            nzimin.Show();
        }

    }
}
