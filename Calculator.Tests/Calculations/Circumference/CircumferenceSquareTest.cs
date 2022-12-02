using System;
using Xunit;
using Calculator.Domain.Calculations.Circumference;
using Calculator.Domain.Exceptions;

namespace Calculator.Tests.Calculations.Circumference
{
    public class CircumferenceSquareTest
    {
        [Theory]
        [InlineData(1, 4)]
        [InlineData(2, 8)]
        [InlineData(1.5, 6)]
        [InlineData(double.MaxValue, double.PositiveInfinity)]
        public void CircumferenceSquare_GivenArgs_ReturnsCalculatedValues(double a, double expected)
        {
            var square = new Square();

            double actual = square.Calculate(a);

            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(double.MinValue)]
        public void CircumferenceSquare_ArgAreLessThanZero_ReturnsException(double a)
        {
            var square = new Square();

            Assert.Throws<NegativeNumberException>(() => square.Calculate(a));
        }

        [Fact]
        public void CircumferenceSquare_ArgIsNotANumber_ReturnsArgumentException()
        {
            var square = new Square();

            Assert.Throws<NotANumberException>(() => square.Calculate(double.NaN));
        }
    }
}
