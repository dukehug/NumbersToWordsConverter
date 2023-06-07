using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyConvertToCheck
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        //关闭当前子窗口
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        //定义 url link1的内容
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.adamson.edu.ph");

        }
        //定义 url link2的内容
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.itiohub.com");
        }
    }
}
