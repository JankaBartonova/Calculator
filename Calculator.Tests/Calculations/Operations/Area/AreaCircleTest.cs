using System;
using Calculator.Domain.Calculations.Operations.Area;
using Calculator.Domain.Exceptions;
using Xunit;

namespace Calculator.Tests.Calculations.Area
{
    public class AreaCircleTest
    {
        [Theory]
        [InlineData(1, 3.14159)]
        [InlineData(1.5, 7.06858)]
        [InlineData(double.MaxValue, double.PositiveInfinity)]
        public void AreaCircle_ArgGiven_ReturnsCalculatedValue(double a, double expected)
        {
            var circle = new Circle();

            double actual = circle.Calculate(a);

            // result rounded to 5 decimal digits
            Assert.Equal(expected, actual, 5);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(double.MinValue)]
        public void AreaCircle_ArgIsLessThanZero_ReturnsException(double a)
        {
            var circle = new Circle();

            Assert.Throws<NegativeNumberException>(() => circle.Calculate(a));
        }

        [Fact]
        public void AreaCircle_ArgIsNotANumber_ReturnsArgumentException()
        {
            var circle = new Circle();

            Assert.Throws<NotANumberException>(() => circle.Calculate(double.NaN));
        }
    }
}
