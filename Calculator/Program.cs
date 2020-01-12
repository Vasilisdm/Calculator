using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide the first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Provide the second number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Provide the operation");
            string operation = Console.ReadLine().ToUpperInvariant();

            Calculator calculator = new Calculator();

            try
            {
                int result = calculator.Calculate(number1, number2, operation); 
                DisplayResult(result);
            }
            catch
            {
                Console.WriteLine("Sorry, something went wrong!");
            }


            Console.WriteLine("\nPress enter to exit");
            Console.ReadLine();
        }

        private static void DisplayResult(int result)
        {
            Console.WriteLine($"The result is: {result}");
        }
    }
}
