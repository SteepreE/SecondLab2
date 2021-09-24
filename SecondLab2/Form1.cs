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

        private void ResultButton_Click(object sender, EventArgs e)
        {
            double depositSize = int.Parse(DepositInput.Text);
            double percent = double.Parse(PercentInput.Text) / 100;

            DepositCalculator calc = new DepositCalculator(depositSize, percent);

            double depositLimit = int.Parse(DepLimitInput.Text);
            double incrementLimit = int.Parse(IncrementLimitInput.Text);

            var result = calc.Calculate(incrementLimit, depositLimit);

            MessageBox.Show(
                $"Величина ежемесячного увеличения превысит {incrementLimit} руб через {result.a} месяцев \n" +
                $"Размер вклада превысит {depositLimit} руб через {result.b} месяцев"
                );
        }
    }
}
