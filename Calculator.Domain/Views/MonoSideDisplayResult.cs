using System;

namespace Calculator.Domain.Views
{
    public class MonoSideDisplayResult : IDisplayResult
    {
        private readonly double _a;
        private readonly string _shape;
        private readonly string _operation;
        private readonly double _result;

        public MonoSideDisplayResult (double a, string shape, string operation, double result)
        {
            _a = a;
            _shape = shape;
            _operation = operation;
            _result = result;
        }

        public void DisplayResult()
        {
            Console.WriteLine($"Your {_shape} has a side = " + "{0}", _a);
            Console.WriteLine($"{_operation} of your {_shape} = " + "{0}", _result);
        }

    }
}
