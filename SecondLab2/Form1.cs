using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateHandeler(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            bool isFindExeption = false;

            foreach (var el in this.Controls)
            {
                if (el is TextBox)
                {
                    var textBox = el as TextBox;

                    if (!IsOnlyNumbers(textBox.Text))
                    {
                        isFindExeption = true;
                        textBox.BackColor = Color.Red;
                        ResultLabel.Text = "";
                    }
                    else
                    {
                        textBox.BackColor = Color.White;
                    }
                }
            }

            if (isFindExeption) return;

            double depositSize = double.Parse(DepositInput.Text);
            double percent = double.Parse(PercentInput.Text) / 100;

            var calc = new DepositCalculator(depositSize, percent);

            double depositLimit = double.Parse(DepLimitInput.Text);
            double incrementLimit = double.Parse(IncrementLimitInput.Text);

            var result = calc.Calculate(incrementLimit, depositLimit);

            ResultLabel.Text =
                $"Величина ежемесячного увеличения превысит {incrementLimit} руб через {result.a} месяцев \n" +
                $"Размер вклада превысит {depositLimit} руб через {result.b} месяцев";
        }

        private bool IsOnlyNumbers(String str)
        {
            if (String.IsNullOrEmpty(str)) return false;

            str = str.Replace(" ", "");
            for (int i=0; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
