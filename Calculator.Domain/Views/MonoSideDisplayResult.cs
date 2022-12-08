using System;
using Calculator.Domain.Views.Interfaces;

namespace Calculator.Domain.Views
{
    public class MonoSideDisplayResult : IMonoSideDisplayResult
    {
        public void DisplayResult(double a, string shape, string operation, double result)
        {
            Console.WriteLine($"Your {shape} has a side/radius of " + "{0}", a);
            Console.WriteLine($"{operation} of your {shape} = " + "{0}", result);
        }
    }
}
