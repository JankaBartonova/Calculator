using System;

namespace Calculator.Domain.Circumference
{
    public class Rectangle
    {
        public double Calculate(double a, double b)
        {
            if ((a < 0) || (b < 0))
            {
                throw new ArgumentException("The numbers must be positive");
            }

            if (double.IsNaN(a) || double.IsNaN(b))
            {
                throw new ArgumentException("The input has to be numbers");
            }

            return 2 * (a + b);
        }
    }
}
