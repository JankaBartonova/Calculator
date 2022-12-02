using System;

namespace Calculator.Domain.Volume
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

            return a * a * a;
        }
    }
}
