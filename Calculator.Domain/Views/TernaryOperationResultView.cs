using System;
using Calculator.Domain.Views.Interfaces;

namespace Calculator.Domain.Views
{
    public class TernaryOperationResultView : ITernaryOperationResultView
    {
        public void DisplayResult(double a, double b, double c, string shape, string operation, double result)
        {
            Console.WriteLine($"Your {shape} has sides of " + "{0}, {1} and {2}", a, b, c);
            Console.WriteLine($"{operation} of your {shape} = " + "{0}", result);
        }
    }
}
