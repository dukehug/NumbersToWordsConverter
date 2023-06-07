using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace MoneyConvertToCheck
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }


        //定义submit button , 并判断用户输入情况
        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            string name = textBoxName.Text;
            double amount;

            bool isAmountValid = double.TryParse(textBoxAmount.Text, out amount);

            DateTime date = dateTimePicker.Value;


            if (string.IsNullOrEmpty(name) || !isAmountValid || double.IsPositiveInfinity(amount))
            {
                MessageBox.Show(" The entered content does not conform to the format or is empty. ");


            }
            else
            {
                string amountInWords = ConvertAmountToWords(amount);
                string upperCaseName = name.ToUpper();

                Result form2 = new Result(amountInWords, upperCaseName, date, amount); // todo: amountInWords,
                form2.Show();
                this.Hide();

            }

            

        }


        //numbers to words converter method
        public string ConvertAmountToWords(double amount)
        {
            // 数字对应的英文表达
            string[] ones = { "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE" };
            string[] teens = { "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };
            string[] tens = { "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };
            string[] thousands = { "", "THOUSAND", "MILLION", "BILLION", "TRILLION" };

            string words = "";

            // 处理金额为零的特殊情况
            if (amount == 0)
            {
                words = "ZERO";
                return words;
            }

            // 将金额分为整数部分和小数部分
            long pesosAmount = (long)Math.Floor(amount);
            int centsAmount = (int)Math.Round((amount - pesosAmount) * 100);

            // 转换整数部分
            long tempAmount = pesosAmount;
            int group = 0;
            while (tempAmount > 0)
            {
                if (tempAmount % 1000 != 0)
                {
                    string groupWords = "";
                    int hundreds = (int)(tempAmount % 1000 / 100);
                    int tensAndOnes = (int)(tempAmount % 100);

                    if (hundreds > 0)
                    {
                        groupWords += ones[hundreds - 1] + " HUNDRED ";
                    }

                    if (tensAndOnes >= 10 && tensAndOnes <= 19)
                    {
                        groupWords += teens[tensAndOnes - 10];
                    }
                    else
                    {
                        int tensDigit = tensAndOnes / 10;
                        int onesDigit = tensAndOnes % 10;

                        if (tensDigit > 0)
                        {
                            groupWords += tens[tensDigit - 1] + " ";
                        }

                        if (onesDigit > 0)
                        {
                            groupWords += ones[onesDigit - 1] + " ";
                        }
                    }

                    if (group > 0)
                    {
                        groupWords += thousands[group] + " ";
                    }

                    words = groupWords + words;
                }

                tempAmount /= 1000;
                group++;
            }

            // 添加小数部分
            if (centsAmount > 0)
            {
                words += "AND " + centsAmount.ToString("00") + "/100";
            }

            // 添加货币单位
            words += " PESOS ONLY";

            return words;
        }


        //定义Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxAmount.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxName.Focus();
        }

        //定义程序退出
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        //使用showdialog 方法显示子窗口
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help helpform = new help();
            helpform.ShowDialog();
            

        }
    }
}
