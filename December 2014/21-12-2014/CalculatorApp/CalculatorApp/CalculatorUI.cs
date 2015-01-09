using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            if (firstNumberTextBox.Text != string.Empty && secondNumberTextBox.Text != string.Empty)
                resultTextBox.Text =
                    aCalculator.Add(float.Parse(firstNumberTextBox.Text), float.Parse(secondNumberTextBox.Text))
                        .ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text != string.Empty && secondNumberTextBox.Text != string.Empty)
                resultTextBox.Text =
                    aCalculator.Subtract(float.Parse(firstNumberTextBox.Text), float.Parse(secondNumberTextBox.Text))
                        .ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text != string.Empty && secondNumberTextBox.Text != string.Empty)
                resultTextBox.Text =
                    aCalculator.Multiply(float.Parse(firstNumberTextBox.Text), float.Parse(secondNumberTextBox.Text))
                        .ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text != string.Empty && secondNumberTextBox.Text != string.Empty)
                resultTextBox.Text =
                    aCalculator.Divide(float.Parse(firstNumberTextBox.Text), float.Parse(secondNumberTextBox.Text))
                        .ToString();
        }
    }
}
