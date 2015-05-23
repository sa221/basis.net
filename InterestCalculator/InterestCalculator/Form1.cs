using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(amountTextBox.Text);
            double r = Convert.ToDouble(interestTextBox.Text);
            double i = r/100;
            double n = Convert.ToDouble(compoundTextBox.Text);
            double t = Convert.ToDouble(yearTextBox.Text);


            double a = p*(Math.Pow((1 + (i/n)),(n*t)));

            totalTextBox.Text = Math.Round(a, 2).ToString();

            amountTextBox.Clear();
            interestTextBox.Clear();
            compoundTextBox.Clear();
            yearTextBox.Clear();
        }
    }
}
