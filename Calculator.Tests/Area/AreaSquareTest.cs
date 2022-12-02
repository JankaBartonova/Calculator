using System;
using Xunit;
using Calculator.Domain.Area;

namespace Calculator.Tests.Area
{
    public class AreaSquareTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(1.5, 2.25)]
        [InlineData(double.MaxValue, double.PositiveInfinity)]
        [InlineData(double.MinValue, double.PositiveInfinity)]
        public void AreaSquare_ArgGiven_ReturnsCalculatedValue(double a, double expected)
        {
            var square = new Square();

            double actual = square.Calculate(a);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AreaSquare_ArgIsLessThanZero_ReturnsException()
        {
            var square = new Square();

            Assert.Throws<ArgumentException>(() => square.Calculate(-1));
        }

        [Fact]
        public void AreaSquare_ArgIsNotANumber_ReturnsArgumentException()
        {
            var square = new Square();

            Assert.Throws<ArgumentException>(() => square.Calculate(double.NaN));
        }
    }
}
