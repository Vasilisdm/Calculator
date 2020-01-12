using System;
namespace Calculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            string nonNullOperation = operation ?? throw new ArgumentNullException();

            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2); 
                }
                catch (DivideByZeroException ex)
                {
                    throw new ArithmeticException("An error occured during calculation.", ex);
                }
            }
            else
            {
                throw new CalculationOperationNotSupportedException(operation);
            }
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
