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
    public partial class Result : Form
    {

        //当窗口启动时，接收form1 的数据
        public Result(string amountInWords, string upupperCaseName, DateTime date, double amount)
        {
            InitializeComponent();

            labelReciveAmount.Text = amountInWords;
            labelReciveName.Text = "** " + upupperCaseName + " **";
            labelReciveDate.Text = date.ToString();
            labelReciveDecimal.Text = amount.ToString("N");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //定义strip menu的事件
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutform = new about();
            aboutform.ShowDialog();
           
        }
    }
}
