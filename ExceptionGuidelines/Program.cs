using System;
using static System.Console;

namespace ExceptionGuidelines
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter first number");
            int number1 = int.Parse(ReadLine());

            WriteLine("Enter second number");
            int number2 = int.Parse(ReadLine());

            WriteLine("Enter operation");
            string operation = ReadLine().ToUpperInvariant();


            var calculator = new Calculator();

            int result = calculator.Calculate(number1, number2, operation);
            DisplayResult(result);

            //try
            //{
            //    int result = calculator.Calculate(number1, number2, operation);
            //    DisplayResult(result);
            //}
            //catch
            //{
            //    WriteLine("Sorry, something went wrong.");
            //}

            //try
            //{
            //    int result = calculator.Calculate(number1, number2, operation);
            //    //int result = calculator.Calculate(number1, number2, null);
            //    DisplayResult(result);
            //}
            //catch (Exception ex)
            //{
            //    WriteLine($"Sorry, something went wrong. {ex}");
            //}

            //try
            //{
            //    //int result = calculator.Calculate(number1, number2, null);
            //    int result = calculator.Calculate(number1, number2, operation);
            //    DisplayResult(result);
            //}
            //catch(ArgumentNullException ex)
            //{
            //    // Log.Error(ex);
            //    WriteLine($"Operation was not provided. {ex}");
            //}
            //catch(ArgumentOutOfRangeException ex)
            //{  
            //    // Log.Error(ex);
            //    WriteLine($"Operation is not supported. {ex}");
            //}
            //catch (Exception ex)
            //{
            //    WriteLine($"Sorry, something went wrong. {ex}");
            //}

            //try
            //{
            //    //int result = calculator.Calculate(number1, number2, operation);
            //    int result = calculator.Calculate(number1, number2, null);
            //    DisplayResult(result);
            //}
            //catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            //{
            //    // Log.Error(ex);
            //    WriteLine($"Operation was not provided. {ex}");
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    // Log.Error(ex);
            //    WriteLine($"Operation is not supported. {ex}");
            //}
            //catch (Exception ex)
            //{
            //    WriteLine($"Sorry, something went wrong. {ex}");
            //}

            //try
            //{
            //    int result = calculator.Calculate(number1, number2, operation);
            //    DisplayResult(result);
            //}
            //catch (CalculationOperationNotSupportedException ex)
            //{
            //    // Log.Error(ex);
            //    WriteLine(ex);
            //}
            //catch (CalculationException ex)
            //{
            //    // Log.Error(ex);
            //    WriteLine(ex);
            //}
            //catch (Exception ex)
            //{
            //    WriteLine($"Sorry, something went wrong. {ex}");
            //}

            WriteLine("\nPress enter to exit.");
            ReadLine();
        }

        private static void DisplayResult(int result)
        {
            WriteLine($"Result is: {result}");
        }
    }
}
