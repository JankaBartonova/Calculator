using System;

namespace Calculator.Domain.Circumference
{
    public class Square
    {
        public double Calculate(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("The number must be positive");
            }

            if (double.IsNaN(a))
            {
                throw new ArgumentException("The input must be a number");
            }

            return 4 * a;
        }
    }
}
