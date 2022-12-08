﻿using System;
using Calculator.Domain.Exceptions;

namespace Calculator.Domain.Calculations.Area
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

            double result = Math.PI * Math.Pow(a, 2);

            return Math.Round(result, 5);
        }
    }
}
