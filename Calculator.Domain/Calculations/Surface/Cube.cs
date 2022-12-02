using System;
using Calculator.Domain.Exceptions;

namespace Calculator.Domain.Calculations.Surface
{
    public class Cube
    {
        public double Calculate(double a)
        {
            if (a < 0)
            {
                throw new NegativeNumberException();
            }

            if (double.IsNaN(a))
            {
                throw new NotANumberException();
            }

            return 6 * a * a;
        }
    }
}
