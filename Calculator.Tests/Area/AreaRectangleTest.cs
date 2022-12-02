﻿using System;
using Xunit;
using Calculator.Domain.Area;

namespace Calculator.Tests.Area
{
    public class AreaRectangleTest
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(1.5, 2.5, 3.75)]
        [InlineData(double.MaxValue, 1, double.MaxValue)]
        [InlineData(double.MaxValue, 2, double.PositiveInfinity)]
        [InlineData(double.MaxValue, -2, double.NegativeInfinity)]
        [InlineData(double.MinValue, 1, double.MinValue)]
        [InlineData(double.MinValue, 2, double.NegativeInfinity)]
        [InlineData(double.MinValue, -2, double.PositiveInfinity)]
        public void AreaRectangle_ArgsGiven_ReturnsCalculatedValue(double a, double b, double expected)
        {
            var rectangle = new Rectangle();

            double actual = rectangle.Calculate(a, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(1, -1)]
        public void AreaRectable_ArgIsLessThanZero_ReturnsException(double a, double b)
        {
            var rectangle = new Rectangle();

            Assert.Throws<ArgumentException>(() => rectangle.Calculate(a, b));
        }

        [Theory]
        [InlineData(double.NaN, 1)]
        [InlineData(1, double.NaN)]
        public void AreaRectangle_ArgIsNotANumber_ReturnsArgumentException(double a, double b)
        {
            var rectangle = new Rectangle();

            Assert.Throws<ArgumentException>(() => rectangle.Calculate(a, b));
        }
    }
}
