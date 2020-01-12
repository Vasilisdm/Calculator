﻿using System;
namespace Calculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            string nonNullOperation = operation ?? throw new ArgumentNullException();

            if (nonNullOperation == "/")
            {
                return Divide(number1, number2);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported!");
            }
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
