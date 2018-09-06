using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGuidelines
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            //if (operation is null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}

            //throw new ArgumentNullException(nameof(number1));

            if (operation == "/")
            {
                return Divide(number1, number2);
            }
            else
            {
                Console.WriteLine("Unknown operation.");
                return 0;

                //throw new ArgumentOutOfRangeException(nameof(operation),
                //    "The mathematical operator is not supported.");
            }

            //if (operation == "/")
            //{
            //    try
            //    {
            //        return Divide(number1, number2);
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        // Log.Error(ex);
            //        //throw ex;
            //        throw;
            //    }
            //}
            //else
            //{
            //    //Console.WriteLine("Unknown operation.");
            //    //return 0;

            //    throw new ArgumentOutOfRangeException(nameof(operation),
            //        "The mathematical operator is not supported.");
            //}

            //if (operation == "/")
            //{
            //    try
            //    {
            //        return Divide(number1, number2);
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        // Log.Error(ex);
            //        //throw new ArithmeticException();
            //        throw new ArithmeticException("An error occured during calculation.", ex);
            //    }
            //}
            //else
            //{
            //    //Console.WriteLine("Unknown operation.");
            //    //return 0;

            //    throw new ArgumentOutOfRangeException(nameof(operation),
            //        "The mathematical operator is not supported.");
            //}


            //if (operation == "/")
            //{
            //    try
            //    {
            //        return Divide(number1, number2);
            //    }
            //    //catch (DivideByZeroException ex)
            //    //{
            //    //    // Log.Error(ex);
            //    //    throw new ArithmeticException("An error occured during calculation.", ex);
            //    //}
            //    catch (ArithmeticException ex)
            //    {
            //        // Log.Error(ex);
            //        //throw new CalculationException(ex);
            //        throw new CalculationException("An error occured during division", ex);
            //    }
            //}
            //else
            //{
            //    //throw new CalculationOperationNotSupportedException();
            //    throw new CalculationOperationNotSupportedException(operation);
            //}
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
