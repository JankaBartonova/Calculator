using System;
using Calculator.Domain.Exceptions;

namespace Calculator.Domain.Calculations.Circumference
{
    public class Circle : IMonoSideShape
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

            double result = 2 * Math.PI * a;

            return Math.Round(result, 5);
        }
    }
}
