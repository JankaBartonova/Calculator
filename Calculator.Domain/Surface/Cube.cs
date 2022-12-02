using System;

namespace Calculator.Domain.Surface
{
    public class Cube
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

            return 6 * a * a;
        }
    }
}
