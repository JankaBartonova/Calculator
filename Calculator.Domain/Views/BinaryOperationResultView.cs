using System;
using Calculator.Domain.Views.Interfaces;

namespace Calculator.Domain.Views
{
    public class BinaryOperationResultView : IBinaryOperationResultView
    {
        public void DisplayResult(double a, double b, string shape, string operation, double result)
        {
            Console.WriteLine($"Your {shape} has sides of " + "{0} and {1}", a, b);
            Console.WriteLine($"{operation} of your {shape} = " + "{0}", result);
        }
    }
}
