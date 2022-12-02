using System;

namespace Calculator.Domain.Surface
{
    public class Block
    {
        public double Calculate(double a, double b, double c)
        {
            return 2 * ((a * b) + (b * c) + (c * a));
        }
    }
}
