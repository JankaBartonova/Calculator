using System;

namespace Calculator.Domain.Volume
{
    public class Block
    {
        public double Calculate(double a, double b, double c)
        {
            if ((a < 0) || (b < 0) || (c < 0))
            {
                throw new ArgumentException("The numbers must be positive");
            }

            if (double.IsNaN(a) || double.IsNaN(b) || double.IsNaN(c))
            {
                throw new ArgumentException("The input has to be numbers");
            }

            return a * b * c;
        }
    }
}
