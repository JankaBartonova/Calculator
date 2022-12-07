using System;
using Calculator.Domain.Exceptions;

namespace Calculator.Domain.Calculations.Area
{
    public class Square : IMonoSideShape
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

            return a * a;
        }
    }
}
