using System;
using Calculator.Domain.Exceptions;

namespace Calculator.Domain.Calculations.Circumference
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

            return 4 * a;
        }
    }
}
