using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);

            Console.WriteLine("Provide the first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Provide the second number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Provide the operation");
            string operation = Console.ReadLine().ToUpperInvariant();

            Calculator calculator = new Calculator();

            try
            {
                int result = calculator.Calculate(number1, number2, null);
                DisplayResult(result);
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                Console.WriteLine($"Operation was not provided: {ex}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"An argument was null: {ex}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Operator is not supported: {ex}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sorry, something went wrong, {ex}");
            }


            Console.WriteLine("\nPress enter to exit");
            Console.ReadLine();
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("There a cataclysmic error and the app was terminated!");
        }

        private static void DisplayResult(int result)
        {
            Console.WriteLine($"The result is: {result}");
        }
    }
}
