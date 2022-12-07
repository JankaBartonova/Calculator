using System;
using Calculator.Domain.Exceptions;

namespace Calculator.Domain.Calculations.Area
{
    public class Rectangle : IDoubleSideShape
    {
        public double Calculate(double a, double b)
        {
            if ((a < 0) || (b < 0))
            {
                throw new NegativeNumbersException();
            }

            if (double.IsNaN(a) || double.IsNaN(b))
            {
                throw new NotANumbersException();
            }

            return a * b;
        }
    }
}
