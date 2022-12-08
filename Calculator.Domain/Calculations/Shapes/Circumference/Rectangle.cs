﻿using Calculator.Domain.Exceptions;

namespace Calculator.Domain.Calculations.Shapes.Circumference
{
    public class Rectangle : IDoubleSideShape
    {
        public double Calculate(double a, double b)
        {
            if ((a < 0) || (b < 0))
            {
                throw new NegativeNumbersException();
            }

            if (double.IsNaN(a) || double.IsNaN(b))
            {
                throw new NotANumbersException();
            }

            return 2 * (a + b);
        }
    }
}