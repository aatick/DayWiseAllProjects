using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }
        Calculator aCalculator=new Calculator();
        private void addButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text =
                aCalculator.Add(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text))
                    .ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text =
                aCalculator.Subtract(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text))
                    .ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text =
                aCalculator.Multiply(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text))
                    .ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text =
                aCalculator.Divide(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text))
                    .ToString();
        }
    }
}
