using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        private float firstNumber;
        private float secondNumber;
        private float result;
        public float Add(float number1, float number2)
        {
            result = number1 + number2;
            return result;
        }

        public float Subtract(float subtractor, float subtractingValue)
        {
            result = subtractor - subtractingValue;
            return result;
        }

        public float Multiply(float number1, float number2)
        {
            result = number1 * number2;
            return result;
        }

        public float Divide(float dividend, float divisor)
        {
            return dividend / divisor;
        }

        public int Remainder(float dividend, float divisor)
        {
            return Convert.ToInt32(dividend%divisor);
        }
    }
}
